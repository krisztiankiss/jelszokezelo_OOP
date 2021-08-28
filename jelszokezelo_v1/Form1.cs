using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace jelszokezelo_v1
{
    public partial class Form1 : Form
    {
            
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {        
        }

        // Admin felhasználó autentikációja
        private void bt_bejelentkezes_Click(object sender, EventArgs e)
        {
            bool siker = true;
             
            if (tb_felhasznalonev.Text.Equals("admin") && tb_jelszo.Text.Equals("admin")) { siker = true; }

            if(siker)
            {
                MessageBox.Show("Sikeres belépés", "Üzenet");
                new adatkezelo().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nem jó felhasználónevet vagy jelszót adtál meg! \n Próbáld újra", "Hiba");
                tb_felhasznalonev.Text = "";
                tb_jelszo.Text = "";
            }
            
           
        }

        // Jelszó megjelenítő
        private void ch_jelszomeg_CheckedChanged(object sender, EventArgs e)
        {
            if(ch_jelszomeg.Checked)
            {
                tb_jelszo.PasswordChar = '\0';
            }
            else
            {
                tb_jelszo.PasswordChar = '•';
            }
        }

        // Enter lenyomásra tovább lépés és bejelentkezés
        private void tb_felhasznalonev_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                tb_jelszo.Focus();
            }
        }

        private void tb_jelszo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                bt_bejelentkezes.PerformClick();
            }
        }
    }
}
