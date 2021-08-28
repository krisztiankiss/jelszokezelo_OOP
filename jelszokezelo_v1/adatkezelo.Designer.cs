
namespace jelszokezelo_v1
{
    partial class adatkezelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adatkezelo));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_felhasznalojelszo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_letrehozas = new System.Windows.Forms.Button();
            this.lb_felhasznalo = new System.Windows.Forms.ListBox();
            this.tb_ujjelszo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ujjelszo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ujfelhasznalonev = new System.Windows.Forms.TextBox();
            this.tb_ujfelhasznalojelszo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_keres = new System.Windows.Forms.TextBox();
            this.bt_kereses = new System.Windows.Forms.Button();
            this.tb_ujjelszo2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_pass_en = new System.Windows.Forms.Label();
            this.bt_felhasznalotorles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_ujfelhasznalobeosztas = new System.Windows.Forms.ComboBox();
            this.tb_ujfelhasznaloemail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ujemail = new System.Windows.Forms.Button();
            this.cb_ujbeosztas = new System.Windows.Forms.ComboBox();
            this.btn_ujbeosztás = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_ujemail = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(60, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Felhasználók";
            // 
            // tb_felhasznalojelszo
            // 
            this.tb_felhasznalojelszo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_felhasznalojelszo.Location = new System.Drawing.Point(19, 47);
            this.tb_felhasznalojelszo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_felhasznalojelszo.Name = "tb_felhasznalojelszo";
            this.tb_felhasznalojelszo.Size = new System.Drawing.Size(444, 25);
            this.tb_felhasznalojelszo.TabIndex = 2;
            this.tb_felhasznalojelszo.MouseLeave += new System.EventHandler(this.pw_elrejt);
            this.tb_felhasznalojelszo.MouseHover += new System.EventHandler(this.pw_mutat);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "A kiválasztott felhasználó jelenlegi  jelszava:";
            // 
            // btn_letrehozas
            // 
            this.btn_letrehozas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_letrehozas.Location = new System.Drawing.Point(24, 172);
            this.btn_letrehozas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_letrehozas.Name = "btn_letrehozas";
            this.btn_letrehozas.Size = new System.Drawing.Size(439, 34);
            this.btn_letrehozas.TabIndex = 4;
            this.btn_letrehozas.Text = "Felhasználó létrehozása";
            this.btn_letrehozas.UseVisualStyleBackColor = true;
            this.btn_letrehozas.Click += new System.EventHandler(this.btn_letrehozas_Click);
            // 
            // lb_felhasznalo
            // 
            this.lb_felhasznalo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_felhasznalo.FormattingEnabled = true;
            this.lb_felhasznalo.ItemHeight = 17;
            this.lb_felhasznalo.Location = new System.Drawing.Point(3, 28);
            this.lb_felhasznalo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_felhasznalo.Name = "lb_felhasznalo";
            this.lb_felhasznalo.Size = new System.Drawing.Size(223, 344);
            this.lb_felhasznalo.TabIndex = 5;
            this.lb_felhasznalo.SelectedIndexChanged += new System.EventHandler(this.lb_felhasznalo_SelectedIndexChanged);
            // 
            // tb_ujjelszo
            // 
            this.tb_ujjelszo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_ujjelszo.Location = new System.Drawing.Point(19, 37);
            this.tb_ujjelszo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ujjelszo.Name = "tb_ujjelszo";
            this.tb_ujjelszo.PasswordChar = '•';
            this.tb_ujjelszo.Size = new System.Drawing.Size(212, 25);
            this.tb_ujjelszo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Új jelszó:";
            // 
            // btn_ujjelszo
            // 
            this.btn_ujjelszo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ujjelszo.Location = new System.Drawing.Point(19, 131);
            this.btn_ujjelszo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ujjelszo.Name = "btn_ujjelszo";
            this.btn_ujjelszo.Size = new System.Drawing.Size(212, 33);
            this.btn_ujjelszo.TabIndex = 9;
            this.btn_ujjelszo.Text = "Új jelszó rögzítése";
            this.btn_ujjelszo.UseVisualStyleBackColor = true;
            this.btn_ujjelszo.Click += new System.EventHandler(this.btn_ujjelszo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(115, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Egy új felhasználó adatai:";
            // 
            // tb_ujfelhasznalonev
            // 
            this.tb_ujfelhasznalonev.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_ujfelhasznalonev.Location = new System.Drawing.Point(24, 70);
            this.tb_ujfelhasznalonev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ujfelhasznalonev.Name = "tb_ujfelhasznalonev";
            this.tb_ujfelhasznalonev.Size = new System.Drawing.Size(207, 25);
            this.tb_ujfelhasznalonev.TabIndex = 11;
            this.tb_ujfelhasznalonev.TextChanged += new System.EventHandler(this.letrehozas_enged);
            // 
            // tb_ujfelhasznalojelszo
            // 
            this.tb_ujfelhasznalojelszo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_ujfelhasznalojelszo.Location = new System.Drawing.Point(256, 71);
            this.tb_ujfelhasznalojelszo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ujfelhasznalojelszo.Name = "tb_ujfelhasznalojelszo";
            this.tb_ujfelhasznalojelszo.Size = new System.Drawing.Size(207, 25);
            this.tb_ujfelhasznalojelszo.TabIndex = 12;
            this.tb_ujfelhasznalojelszo.TextChanged += new System.EventHandler(this.letrehozas_enged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(20, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Felhasználónév:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(252, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Jelszó:";
            // 
            // tb_keres
            // 
            this.tb_keres.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_keres.Location = new System.Drawing.Point(3, 400);
            this.tb_keres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_keres.Name = "tb_keres";
            this.tb_keres.Size = new System.Drawing.Size(224, 25);
            this.tb_keres.TabIndex = 15;
            this.tb_keres.TextChanged += new System.EventHandler(this.kereso);
            // 
            // bt_kereses
            // 
            this.bt_kereses.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_kereses.Location = new System.Drawing.Point(3, 442);
            this.bt_kereses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_kereses.Name = "bt_kereses";
            this.bt_kereses.Size = new System.Drawing.Size(224, 34);
            this.bt_kereses.TabIndex = 16;
            this.bt_kereses.Text = "Keresés";
            this.bt_kereses.UseVisualStyleBackColor = true;
            this.bt_kereses.Click += new System.EventHandler(this.bt_kereses_Click);
            // 
            // tb_ujjelszo2
            // 
            this.tb_ujjelszo2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_ujjelszo2.Location = new System.Drawing.Point(19, 89);
            this.tb_ujjelszo2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ujjelszo2.Name = "tb_ujjelszo2";
            this.tb_ujjelszo2.PasswordChar = '•';
            this.tb_ujjelszo2.Size = new System.Drawing.Size(212, 25);
            this.tb_ujjelszo2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(13, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Új jelszó mégegyszer:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(653, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kilépés ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lb_pass_en
            // 
            this.lb_pass_en.AutoSize = true;
            this.lb_pass_en.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_pass_en.Location = new System.Drawing.Point(13, 91);
            this.lb_pass_en.Name = "lb_pass_en";
            this.lb_pass_en.Size = new System.Drawing.Size(182, 20);
            this.lb_pass_en.TabIndex = 21;
            this.lb_pass_en.Text = "A kódolatlan jelszo helye";
            this.lb_pass_en.Visible = false;
            // 
            // bt_felhasznalotorles
            // 
            this.bt_felhasznalotorles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_felhasznalotorles.Location = new System.Drawing.Point(3, 7);
            this.bt_felhasznalotorles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_felhasznalotorles.Name = "bt_felhasznalotorles";
            this.bt_felhasznalotorles.Size = new System.Drawing.Size(224, 50);
            this.bt_felhasznalotorles.TabIndex = 22;
            this.bt_felhasznalotorles.Text = "Kijelölt felhasználó törlése.";
            this.bt_felhasznalotorles.UseVisualStyleBackColor = true;
            this.bt_felhasznalotorles.Click += new System.EventHandler(this.bt_felhasznalotorles_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cb_ujfelhasznalobeosztas);
            this.panel1.Controls.Add(this.tb_ujfelhasznaloemail);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tb_ujfelhasznalonev);
            this.panel1.Controls.Add(this.tb_ujfelhasznalojelszo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_letrehozas);
            this.panel1.Location = new System.Drawing.Point(267, 342);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 226);
            this.panel1.TabIndex = 23;
            // 
            // cb_ujfelhasznalobeosztas
            // 
            this.cb_ujfelhasznalobeosztas.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_ujfelhasznalobeosztas.FormattingEnabled = true;
            this.cb_ujfelhasznalobeosztas.Location = new System.Drawing.Point(24, 128);
            this.cb_ujfelhasznalobeosztas.Name = "cb_ujfelhasznalobeosztas";
            this.cb_ujfelhasznalobeosztas.Size = new System.Drawing.Size(207, 25);
            this.cb_ujfelhasznalobeosztas.TabIndex = 25;
            // 
            // tb_ujfelhasznaloemail
            // 
            this.tb_ujfelhasznaloemail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_ujfelhasznaloemail.Location = new System.Drawing.Point(256, 130);
            this.tb_ujfelhasznaloemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ujfelhasznaloemail.Name = "tb_ujfelhasznaloemail";
            this.tb_ujfelhasznaloemail.Size = new System.Drawing.Size(207, 25);
            this.tb_ujfelhasznaloemail.TabIndex = 17;
            this.tb_ujfelhasznaloemail.TextChanged += new System.EventHandler(this.letrehozas_enged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(20, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Beosztás:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(252, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "E-mail:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_ujemail);
            this.panel2.Controls.Add(this.cb_ujbeosztas);
            this.panel2.Controls.Add(this.btn_ujbeosztás);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tb_ujemail);
            this.panel2.Controls.Add(this.btn_ujjelszo);
            this.panel2.Controls.Add(this.tb_ujjelszo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tb_ujjelszo2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(267, 154);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 184);
            this.panel2.TabIndex = 24;
            // 
            // btn_ujemail
            // 
            this.btn_ujemail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ujemail.Location = new System.Drawing.Point(256, 123);
            this.btn_ujemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ujemail.Name = "btn_ujemail";
            this.btn_ujemail.Size = new System.Drawing.Size(83, 49);
            this.btn_ujemail.TabIndex = 25;
            this.btn_ujemail.Text = "Új E-mail rögzítése";
            this.btn_ujemail.UseVisualStyleBackColor = true;
            this.btn_ujemail.Click += new System.EventHandler(this.btn_ujemailvagybeo_Click);
            // 
            // cb_ujbeosztas
            // 
            this.cb_ujbeosztas.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_ujbeosztas.FormattingEnabled = true;
            this.cb_ujbeosztas.Location = new System.Drawing.Point(256, 90);
            this.cb_ujbeosztas.Name = "cb_ujbeosztas";
            this.cb_ujbeosztas.Size = new System.Drawing.Size(207, 25);
            this.cb_ujbeosztas.TabIndex = 24;
            // 
            // btn_ujbeosztás
            // 
            this.btn_ujbeosztás.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ujbeosztás.Location = new System.Drawing.Point(368, 123);
            this.btn_ujbeosztás.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ujbeosztás.Name = "btn_ujbeosztás";
            this.btn_ujbeosztás.Size = new System.Drawing.Size(95, 49);
            this.btn_ujbeosztás.TabIndex = 28;
            this.btn_ujbeosztás.Text = "Új beosztás rögzítése";
            this.btn_ujbeosztás.UseVisualStyleBackColor = true;
            this.btn_ujbeosztás.Click += new System.EventHandler(this.btn_ujbeosztás_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(252, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "Új beosztás:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(252, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Új e-mail:";
            // 
            // tb_ujemail
            // 
            this.tb_ujemail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_ujemail.Location = new System.Drawing.Point(256, 37);
            this.tb_ujemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ujemail.Name = "tb_ujemail";
            this.tb_ujemail.Size = new System.Drawing.Size(205, 25);
            this.tb_ujemail.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tb_felhasznalojelszo);
            this.panel3.Controls.Add(this.lb_pass_en);
            this.panel3.Location = new System.Drawing.Point(267, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 126);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lb_felhasznalo);
            this.panel4.Controls.Add(this.tb_keres);
            this.panel4.Controls.Add(this.bt_kereses);
            this.panel4.Location = new System.Drawing.Point(12, 22);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 496);
            this.panel4.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.bt_felhasznalotorles);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(12, 572);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(745, 67);
            this.panel5.TabIndex = 27;
            // 
            // adatkezelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 650);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "adatkezelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adatkezelo";
            this.Load += new System.EventHandler(this.adatkezelo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_felhasznalojelszo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_letrehozas;
        private System.Windows.Forms.ListBox lb_felhasznalo;
        private System.Windows.Forms.TextBox tb_ujjelszo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ujjelszo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ujfelhasznalonev;
        private System.Windows.Forms.TextBox tb_ujfelhasznalojelszo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_keres;
        private System.Windows.Forms.Button bt_kereses;
        private System.Windows.Forms.TextBox tb_ujjelszo2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_pass_en;
        private System.Windows.Forms.Button bt_felhasznalotorles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tb_ujfelhasznaloemail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_ujbeosztas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_ujemail;
        private System.Windows.Forms.Button btn_ujemail;
        private System.Windows.Forms.Button btn_ujbeosztás;
        private System.Windows.Forms.ComboBox cb_ujfelhasznalobeosztas;
    }
}