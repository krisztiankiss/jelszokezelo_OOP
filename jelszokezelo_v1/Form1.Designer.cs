
namespace jelszokezelo_v1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_felhasznalonev = new System.Windows.Forms.TextBox();
            this.tb_jelszo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ch_jelszomeg = new System.Windows.Forms.CheckBox();
            this.bt_bejelentkezes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(97, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév";
            // 
            // tb_felhasznalonev
            // 
            this.tb_felhasznalonev.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_felhasznalonev.Location = new System.Drawing.Point(101, 151);
            this.tb_felhasznalonev.Name = "tb_felhasznalonev";
            this.tb_felhasznalonev.Size = new System.Drawing.Size(295, 30);
            this.tb_felhasznalonev.TabIndex = 1;
            this.tb_felhasznalonev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_felhasznalonev_KeyDown);
            // 
            // tb_jelszo
            // 
            this.tb_jelszo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_jelszo.Location = new System.Drawing.Point(101, 217);
            this.tb_jelszo.Name = "tb_jelszo";
            this.tb_jelszo.PasswordChar = '•';
            this.tb_jelszo.Size = new System.Drawing.Size(295, 30);
            this.tb_jelszo.TabIndex = 2;
            this.tb_jelszo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_jelszo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(97, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jelszó";
            // 
            // ch_jelszomeg
            // 
            this.ch_jelszomeg.AutoSize = true;
            this.ch_jelszomeg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ch_jelszomeg.Location = new System.Drawing.Point(319, 278);
            this.ch_jelszomeg.Name = "ch_jelszomeg";
            this.ch_jelszomeg.Size = new System.Drawing.Size(174, 24);
            this.ch_jelszomeg.TabIndex = 4;
            this.ch_jelszomeg.Text = "Jelszó megjelenítése";
            this.ch_jelszomeg.UseVisualStyleBackColor = true;
            this.ch_jelszomeg.CheckedChanged += new System.EventHandler(this.ch_jelszomeg_CheckedChanged);
            // 
            // bt_bejelentkezes
            // 
            this.bt_bejelentkezes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_bejelentkezes.Location = new System.Drawing.Point(55, 318);
            this.bt_bejelentkezes.Name = "bt_bejelentkezes";
            this.bt_bejelentkezes.Size = new System.Drawing.Size(409, 37);
            this.bt_bejelentkezes.TabIndex = 5;
            this.bt_bejelentkezes.Text = "Bejelentkezés";
            this.bt_bejelentkezes.UseVisualStyleBackColor = true;
            this.bt_bejelentkezes.Click += new System.EventHandler(this.bt_bejelentkezes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(164, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bejelentkezés";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_bejelentkezes);
            this.Controls.Add(this.ch_jelszomeg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_jelszo);
            this.Controls.Add(this.tb_felhasznalonev);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_felhasznalonev;
        private System.Windows.Forms.TextBox tb_jelszo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ch_jelszomeg;
        private System.Windows.Forms.Button bt_bejelentkezes;
        private System.Windows.Forms.Label label3;
    }
}

