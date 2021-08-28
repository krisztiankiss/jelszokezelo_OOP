using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace jelszokezelo_v1
{
    //Ez a jó
    public partial class adatkezelo : Form
    {
        public List<felhasznalok> felhasznalokList = new List<felhasznalok>(); //a felhasználók lista 
        public int index = 0; // egy elem jelenlegi helye
        FileStream fajl;
        public List<string> beosztasok = new List<string>();

        string titkosjelszo = "kismacska"; // titkosító jelszó
        public adatkezelo()
        {
            InitializeComponent();
        }

        // Fájl vizsgálata, létrehozása vagy beolvasása, nevek és jelszavak, email címek és beosztás tárolása
        private void adatkezelo_Load(object sender, EventArgs e)
        {
            if (!File.Exists("felhasznalok.json"))
            {
                fajl = new FileStream("felhasznalok.json", FileMode.Create);
            }
            else
            {
                fajl = new FileStream("felhasznalok.json", FileMode.Open);
            }

            StreamReader beolvas = new StreamReader(fajl);
           
            string egysor = beolvas.ReadLine();

            while (egysor != null)
            { 
                felhasznalok fh = JsonConvert.DeserializeObject<felhasznalok>(egysor);
                felhasznalokList.Add(fh);
                egysor = beolvas.ReadLine(); 
            }
            beolvas.Close();

            ListboxFeltoltes(felhasznalokList);

            //beosztások beolvasása és tárolása vagy a fájl létrehozása

            if (!File.Exists("beosztasok.txt"))
            {
                fajl = new FileStream("beosztasok.txt", FileMode.Create);
            }
            else
            {
                fajl = new FileStream("beosztasok.txt", FileMode.Open);
            }

            StreamReader beosztas_olvas = new StreamReader(fajl);
            egysor = beosztas_olvas.ReadLine();
            
            while(egysor!=null)
            {
                beosztasok.Add(egysor);
                egysor = beosztas_olvas.ReadLine();
            }
            beosztas_olvas.Close();

            ComboboxFeltoltes(beosztasok);

            //A felhsaználó létrehozás gomb letiltása, az üres értérkek bevitele ellen
            btn_letrehozas.Enabled = false;
            //A visszafejtett jelszót megjelenítő label "elrejtése"
            lb_pass_en.Visible = false;        
        }

        //A jelszó megjeleítése
        private void lb_felhasznalo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_felhasznalojelszo.Text = "";
            for (int i = 0; i < felhasznalokList.Count; i++)
            {
                if (lb_felhasznalo.SelectedItem.Equals(felhasznalokList[i].Nev))
                {
                    tb_felhasznalojelszo.Text += felhasznalokList[i].Jelszo;
                }
            }
        }

        // Felhasználó létrehozás, jelszó titkosítás és tárolás
        private void btn_letrehozas_Click(object sender, EventArgs e)
        {
                string titkositott_jel = titkositas.Encrypt(tb_ujfelhasznalojelszo.Text, titkosjelszo);
                string felhasznalonev = tb_ujfelhasznalonev.Text.Trim();
                string jelszo = titkositott_jel;
                string email = tb_ujfelhasznaloemail.Text.Trim();
                string beosztas = cb_ujfelhasznalobeosztas.Text.Trim();

            felhasznalok ujfelhasznalo = new felhasznalok(felhasznalonev,
                jelszo, email, beosztas);

            felhasznalokList.Add(ujfelhasznalo);

            FileIras(felhasznalokList);

            lb_felhasznalo.Items.Add(ujfelhasznalo.Nev);

            FileIras(felhasznalokList);

            if(!beosztasok.Contains(beosztas))
            { 
                beosztasok.Add(beosztas); 
            }

            FileStream fajl = new FileStream("beosztasok.txt", FileMode.Create);
            StreamWriter iro = new StreamWriter(fajl);

            for (int i = 0; i < beosztasok.Count; i++)
            {
                iro.WriteLine(beosztasok[i]);
            }
            iro.Close();

            ComboboxFeltoltes(beosztasok);

                tb_ujfelhasznalonev.Text = "";
                tb_ujfelhasznalojelszo.Text = "";  
                tb_ujfelhasznaloemail.Text = "";
                cb_ujfelhasznalobeosztas.Text = "";
        }

        // Keresés a listában
        private void bt_kereses_Click(object sender, EventArgs e)
        {
            index = 0;
            for (int i = 0; i < felhasznalokList.Count; i++)
            {
                if(tb_keres.Text.Equals(felhasznalokList[i].Nev))
                {
                    //tb_1.Text += felhasznalonevek[i];
                    lb_felhasznalo.SelectedIndex = i-1;
                    index = i;
                }
            }
        }

        // Már meglévő felhasználó jelszavának felülítása, titkosítása éstárolása
        private void btn_ujjelszo_Click(object sender, EventArgs e)
        {

            if (lb_felhasznalo.SelectedItems.Count==0) 
            {
                MessageBox.Show("Jelölj ki egy felhasználót!", "Hiba");
                tb_ujjelszo.Text = "";
                tb_ujjelszo2.Text = "";               
            }
            else if (tb_ujjelszo.Text.Equals(tb_ujjelszo2.Text))
            {
                //jelszó felülírás
                string titkositott_jel = titkositas.Encrypt(tb_ujjelszo.Text, titkosjelszo);
                felhasznalokList[index].Jelszo = titkositott_jel;
                //megerősítő üzenet
                MessageBox.Show("Az új jelszó mentése megtörtént", "Üzenet");
                tb_ujjelszo.Text = "";
                tb_ujjelszo2.Text = "";

                //fájlba tárolás
                FileIras(felhasznalokList);
                ListboxFeltoltes(felhasznalokList);
            }
            else
            {               
                tb_ujjelszo2.Text = "";
                tb_ujjelszo2.Focus();
                MessageBox.Show("A megadott jelszavak nem egyeznek!", "Hiba");
            }
        }

        // Keresés könnyítés sok felhasználó esetén, kezdőbetű szűréssel.
        private void kereso(object sender, EventArgs e)
        {
            lb_felhasznalo.Items.Clear();

            //foreach(string str in felhasznalokList)
            for (int i = 0; i < felhasznalokList.Count; i++)
            {
                if (felhasznalokList[i].Nev.StartsWith(tb_keres.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    lb_felhasznalo.Items.Add(felhasznalokList[i].Nev);
                }
            }
        }

        // Kilépés gomb
        private void label8_Click(object sender, EventArgs e)
        {
            //megerősítés kérése
            DialogResult dontes;
            dontes = MessageBox.Show("Biztos ki szeretnél lépni?","Üzenet.", MessageBoxButtons.YesNo);

            if (dontes == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        // A felhasználó létrehozása gomb engedélyezése,
        // ha minimum 2 karakter van mind a 4 adat mezőben 
        private void letrehozas_enged(object sender, EventArgs e)
        {
            string emailcim = tb_ujfelhasznaloemail.Text;
            if(tb_ujfelhasznalonev.Text.Length>1 && tb_ujfelhasznalojelszo.Text.Length>1&&cb_ujfelhasznalobeosztas.Text.Length>1&& Helyesemail(emailcim).Equals(true))
            {
                btn_letrehozas.Enabled = true;
            }
            else
            {
                btn_letrehozas.Enabled = false;
            }
        }

        // A visszafejtett jelszó megjelenítése, és elrejtése
        private void pw_mutat(object sender, EventArgs e)
        {
            lb_pass_en.Visible = true;
            lb_pass_en.Text = "A titkosítatlan jelszó: " + titkositas.Decrypt(tb_felhasznalojelszo.Text, titkosjelszo);
            
        }
        private void pw_elrejt(object sender, EventArgs e)
        {
            lb_pass_en.Visible = false;
        }

        // Kijelölt felhasználó törlése, megerősítés kérése
        private void bt_felhasznalotorles_Click(object sender, EventArgs e)
        {
            if (lb_felhasznalo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nincs kijeleölt felhasználó!", "Hiba");
            }
            else
            {
                DialogResult torles;
                torles = MessageBox.Show("Biztos törölni szeretnéd a kijelölt felhasználót?", "Üzenet.", MessageBoxButtons.YesNo);

                if (torles == DialogResult.Yes)
                {
                    string kijelölt_nev = lb_felhasznalo.SelectedItem.ToString();

                    for (int i = 0; i < felhasznalokList.Count; i++)
                    {
                        if (felhasznalokList[i].Nev.Equals(kijelölt_nev))
                        {
                            felhasznalokList.RemoveAt(i);
                        }
                    }
                }

                File.Delete("felhasznalok.json");
                FileIras(felhasznalokList);
                ListboxFeltoltes(felhasznalokList);
            }
            }


        // Listbox feltöltése
        void ListboxFeltoltes (List<felhasznalok> felhasznalokList)
        {
            lb_felhasznalo.Items.Clear();
            for (int i = 0; i < felhasznalokList.Count; i++)
            {
                lb_felhasznalo.Items.Add(felhasznalokList[i].Nev);
            }
        }

        // Combobox feltöltés
        void ComboboxFeltoltes(List<string> beosztasok)
        {
            cb_ujbeosztas.Items.Clear();
            cb_ujfelhasznalobeosztas.Items.Clear();
            for (int i = 0; i < beosztasok.Count; i++)
            {
                if (!cb_ujbeosztas.Items.Contains(beosztasok[i]))
                {
                    cb_ujbeosztas.Items.Add(beosztasok[i]);
                    cb_ujfelhasznalobeosztas.Items.Add(beosztasok[i]);
                }
            }
        }


        //A fájlba írás kiszervezése
        void FileIras(List<felhasznalok> lista)
        {
            FileStream fajl = new FileStream("felhasznalok.json", FileMode.Create);
            StreamWriter iro = new StreamWriter(fajl);

            for (int i = 0; i < lista.Count; i++)
            {
                string json = JsonConvert.SerializeObject(lista[i]);
                iro.WriteLine(json);
            }

            iro.Close();
        }

        //Az e-mail cím helyességének ellenőrzése
        public static bool Helyesemail(string e_mail)
        {
            bool helyes = false;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(e_mail);
            if (match.Success)
            {
                helyes = true;
            }
            return helyes;
        }

        //Új email cím felvétele már meglévő felhasználóhoz
        private void btn_ujemailvagybeo_Click(object sender, EventArgs e)
        {
            if (lb_felhasznalo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Jelölj ki egy felhasználót!", "Hiba");
                tb_ujemail.Text = "";
                cb_ujbeosztas.Text = "";
            }

            if(tb_ujemail.Text.Equals(""))
            {
                string ujemail = tb_ujemail.Text;
                felhasznalokList[index].Email = ujemail;

                MessageBox.Show("Nem írtál be E-mail címet!", "Hiba");
            }
            else if(Helyesemail(tb_ujemail.Text).Equals(false))
            {
                MessageBox.Show("A megadott E-mail cím nem helyes!", "Hiba");
            }
            else
            {
                string ujemail = tb_ujemail.Text;
                felhasznalokList[index].Email = ujemail;

                MessageBox.Show("Az új E-mail cím mentése megtörtént!", "Üzenet");

                tb_ujemail.Text = "";
                FileIras(felhasznalokList);
                ListboxFeltoltes(felhasznalokList);
            }

            
            
        }

        // Új beosztás felvétele már meglévő felhasználóhoz
        private void btn_ujbeosztás_Click(object sender, EventArgs e)
        {
            //List<string> ujbeosztasok = new List<string>();
            if (lb_felhasznalo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Jelölj ki egy felhasználót!", "Hiba");
                cb_ujbeosztas.Text = "";
            }

            string kijeleölt_beosztas = cb_ujbeosztas.Text.Trim();
            if (!beosztasok.Contains(kijeleölt_beosztas) 
                 && cb_ujbeosztas.Text.Trim() != "") 
            { 
                beosztasok.Add(kijeleölt_beosztas); 
            }
            else
            {
                MessageBox.Show("Írd be a beosztást", "Hiba");
            }


            if(kijeleölt_beosztas.Equals(felhasznalokList[index].Beosztas))
            {
                MessageBox.Show("Ugyanazt a beosztást nem adhatod meg mégegyszer!", "Hiba");
            }
            else
            {
                felhasznalokList[index].Beosztas = kijeleölt_beosztas;
                MessageBox.Show("Az új beosztás mentése megtörtént!", "Üzenet");
            }

            FileIras(felhasznalokList);
            ListboxFeltoltes(felhasznalokList);
            cb_ujbeosztas.Text = "";            

            FileStream fajl = new FileStream("beosztasok.txt", FileMode.Create);
            StreamWriter iro = new StreamWriter(fajl);

            for (int i = 0; i < beosztasok.Count; i++)
            {              
                iro.WriteLine(beosztasok[i]);
            }
            iro.Close();
            ComboboxFeltoltes(beosztasok);
        }
    }
    }
