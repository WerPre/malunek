namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.suwak = new System.Windows.Forms.TrackBar();
            this.btnWyczy = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnLinia = new System.Windows.Forms.Button();
            this.btnBlok = new System.Windows.Forms.Button();
            this.btnObrecz = new System.Windows.Forms.Button();
            this.btnGumka = new System.Windows.Forms.Button();
            this.btnPedzel = new System.Windows.Forms.Button();
            this.btnFarba = new System.Windows.Forms.Button();
            this.btnKolor = new System.Windows.Forms.Button();
            this.obraz = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suwak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obraz)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.suwak);
            this.panel1.Controls.Add(this.btnWyczy);
            this.panel1.Controls.Add(this.btnZapisz);
            this.panel1.Controls.Add(this.btnLinia);
            this.panel1.Controls.Add(this.btnBlok);
            this.panel1.Controls.Add(this.btnObrecz);
            this.panel1.Controls.Add(this.btnGumka);
            this.panel1.Controls.Add(this.btnPedzel);
            this.panel1.Controls.Add(this.btnFarba);
            this.panel1.Controls.Add(this.btnKolor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 79);
            this.panel1.TabIndex = 0;
            // 
            // suwak
            // 
            this.suwak.Location = new System.Drawing.Point(752, 3);
            this.suwak.Maximum = 100;
            this.suwak.Minimum = 2;
            this.suwak.Name = "suwak";
            this.suwak.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.suwak.Size = new System.Drawing.Size(45, 73);
            this.suwak.TabIndex = 9;
            this.suwak.Value = 10;
            this.suwak.Scroll += new System.EventHandler(this.suwak_scroll);
            // 
            // btnWyczy
            // 
            this.btnWyczy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWyczy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWyczy.Location = new System.Drawing.Point(640, 40);
            this.btnWyczy.Name = "btnWyczy";
            this.btnWyczy.Size = new System.Drawing.Size(106, 33);
            this.btnWyczy.TabIndex = 8;
            this.btnWyczy.Text = "&Wyczyść";
            this.btnWyczy.UseVisualStyleBackColor = false;
            this.btnWyczy.Click += new System.EventHandler(this.btnWyczy_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnZapisz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZapisz.Location = new System.Drawing.Point(640, 3);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(106, 33);
            this.btnZapisz.TabIndex = 7;
            this.btnZapisz.Text = "&Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = false;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnLinia
            // 
            this.btnLinia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLinia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinia.Image = global::WinFormsApp1.Properties.Resources.ruler;
            this.btnLinia.Location = new System.Drawing.Point(552, 3);
            this.btnLinia.Name = "btnLinia";
            this.btnLinia.Size = new System.Drawing.Size(82, 73);
            this.btnLinia.TabIndex = 6;
            this.btnLinia.UseVisualStyleBackColor = false;
            this.btnLinia.Click += new System.EventHandler(this.btnLinia_Click);
            // 
            // btnBlok
            // 
            this.btnBlok.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBlok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlok.Image = global::WinFormsApp1.Properties.Resources.square;
            this.btnBlok.Location = new System.Drawing.Point(462, 3);
            this.btnBlok.Name = "btnBlok";
            this.btnBlok.Size = new System.Drawing.Size(84, 73);
            this.btnBlok.TabIndex = 5;
            this.btnBlok.UseVisualStyleBackColor = false;
            this.btnBlok.Click += new System.EventHandler(this.btnBlok_Click);
            // 
            // btnObrecz
            // 
            this.btnObrecz.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnObrecz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrecz.Image = global::WinFormsApp1.Properties.Resources.circumference;
            this.btnObrecz.Location = new System.Drawing.Point(372, 3);
            this.btnObrecz.Name = "btnObrecz";
            this.btnObrecz.Size = new System.Drawing.Size(84, 73);
            this.btnObrecz.TabIndex = 4;
            this.btnObrecz.UseVisualStyleBackColor = false;
            this.btnObrecz.Click += new System.EventHandler(this.btnObrecz_Click);
            // 
            // btnGumka
            // 
            this.btnGumka.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGumka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGumka.Image = global::WinFormsApp1.Properties.Resources.eraser__1_;
            this.btnGumka.Location = new System.Drawing.Point(282, 3);
            this.btnGumka.Name = "btnGumka";
            this.btnGumka.Size = new System.Drawing.Size(84, 73);
            this.btnGumka.TabIndex = 3;
            this.btnGumka.UseVisualStyleBackColor = false;
            this.btnGumka.Click += new System.EventHandler(this.btnGumka_Click);
            // 
            // btnPedzel
            // 
            this.btnPedzel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPedzel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedzel.Image = global::WinFormsApp1.Properties.Resources.painting__1_;
            this.btnPedzel.Location = new System.Drawing.Point(102, 3);
            this.btnPedzel.Name = "btnPedzel";
            this.btnPedzel.Size = new System.Drawing.Size(84, 73);
            this.btnPedzel.TabIndex = 2;
            this.btnPedzel.UseVisualStyleBackColor = false;
            this.btnPedzel.Click += new System.EventHandler(this.btnPedzel_Click);
            // 
            // btnFarba
            // 
            this.btnFarba.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFarba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFarba.Image = global::WinFormsApp1.Properties.Resources.bucket;
            this.btnFarba.Location = new System.Drawing.Point(192, 3);
            this.btnFarba.Name = "btnFarba";
            this.btnFarba.Size = new System.Drawing.Size(84, 73);
            this.btnFarba.TabIndex = 1;
            this.btnFarba.UseVisualStyleBackColor = false;
            this.btnFarba.Click += new System.EventHandler(this.btnFarba_Click);
            // 
            // btnKolor
            // 
            this.btnKolor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKolor.Image = global::WinFormsApp1.Properties.Resources.color_wheel;
            this.btnKolor.Location = new System.Drawing.Point(12, 3);
            this.btnKolor.Name = "btnKolor";
            this.btnKolor.Size = new System.Drawing.Size(84, 73);
            this.btnKolor.TabIndex = 0;
            this.btnKolor.UseVisualStyleBackColor = false;
            this.btnKolor.Click += new System.EventHandler(this.btnKolor_Click);
            // 
            // obraz
            // 
            this.obraz.BackColor = System.Drawing.Color.White;
            this.obraz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.obraz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.obraz.Location = new System.Drawing.Point(0, 79);
            this.obraz.Name = "obraz";
            this.obraz.Size = new System.Drawing.Size(800, 371);
            this.obraz.TabIndex = 1;
            this.obraz.TabStop = false;
            this.obraz.Click += new System.EventHandler(this.obraz_Click);
            this.obraz.Paint += new System.Windows.Forms.PaintEventHandler(this.obraz_Paint);
            this.obraz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.obraz_MouseClick);
            this.obraz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.obraz_MouseDown);
            this.obraz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.obraz_MouseMove);
            this.obraz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.obraz_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.obraz);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Form1";
            this.Text = "Malunek";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suwak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obraz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnKolor;
        private Button btnWyczy;
        private Button btnZapisz;
        private Button btnLinia;
        private Button btnBlok;
        private Button btnObrecz;
        private Button btnGumka;
        private Button btnPedzel;
        private Button btnFarba;
        private PictureBox obraz;
        private TrackBar suwak;
    }
}