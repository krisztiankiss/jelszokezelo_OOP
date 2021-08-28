using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Linq;

namespace jelszokezelo_v1
{
    class titkositas
    {
        // This constant is used to determine the keysize of the encryption algorithm in bits.
        // Ez a konstans a titkosítási algoritmus kulcsméretének meghatározására szolgál bitben kifejezve.

        // We divide this by 8 within the code below to get the equivalent number of bytes.
        // Az alábbi kódban ezt elosztjuk 8-cal, hogy megkapjuk az egyenértékű bájtok számát.

        private const int Keysize = 256;

        // This constant determines the number of iterations for the password bytes generation function.
        // Ez a konstans határozza meg a jelszó bájtgeneráló funkció iterációinak számát.
        private const int DerivationIterations = 1000;

        public static string Encrypt(string plainText, string passPhrase)
        {
            // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
            // so that the same Salt and IV values can be used when decrypting.

            // A salt és az IV minden alkalommal véletlenszerűen generálódik, de a titkosított rejtjelezett szöveghez előzetesen hozzá van rendelve.
            // így a visszafejtéskor ugyanazokat a salt-és IV - értékeket lehet használni. 

            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                //A végső bájtokat a véletlenszerű  salt bájtok, a véletlenszerű iv-bájtok és a titkosítási bájtok összekapcsolásaként hozza létre.
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        public static string Decrypt(string cipherText, string passPhrase)
        {
            // Get the complete stream of bytes that represent:
            // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]

            // A teljes bájtfolyam kinyerése, amely képviseli:
            // [32 bájt Salt] + [32 bájt IV] + [n bájt CipherText].

            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
            // A saltbájtok kinyerése az első 32 bájt kivonásával a megadott cipherText bájtokból.
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
            // Az IV bájtok kinyerése a következő 32 bájt kivonásával a megadott cipherText bájtokból
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
            //A tényleges titkosított szöveg bájtjainak kinyerése az első 64 bájt eltávolításával a cipherText karakterláncból.
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits // A 32 bájt 256 bitet ad.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                // Fill the array with cryptographically secure random bytes.
                // Feltöltjük tömböt kriptográfiailag biztonságos véletlen bájtokkal.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
    }
}
