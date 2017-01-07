namespace GB_Editor
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.CBlvl = new System.Windows.Forms.ComboBox();
            this.labelniv = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 15);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(71, 33);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open ROM";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOADED ROM : ";
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Bulbizarre",
            "Herbizarre",
            "Salameche",
            "Reptincel",
            "Carapuce",
            "Carabaffe",
            "Chenipan",
            "Chrysacier",
            "Aspicot",
            "Coconfort",
            "Roucoul",
            "Roucoups",
            "Rattata",
            "Piafabec",
            "Abo",
            "Pikachu",
            "Sabelette",
            "NidoranF",
            "Nidorina",
            "NidoranM",
            "Nidorino",
            "Melofee",
            "Goupix",
            "Rondoudou",
            "Nosferapti",
            "Mystherbe",
            "Ortide",
            "Paras",
            "Mimitos",
            "Taupiqueur",
            "Miaouss",
            "Psykokwak",
            "Ferosinge",
            "Caninos",
            "Ptitard",
            "Tetarte",
            "Abra",
            "Kadabra",
            "Machoc",
            "Machopeur",
            "Chetiflor",
            "Boustiflor",
            "Tentacool",
            "Racaillou",
            "Gravalanche",
            "Ponyta",
            "Ramoloss",
            "Magneti",
            "Doduo",
            "Otaria",
            "Tadmorv",
            "Kokiyas",
            "Fantominus",
            "Spectrum",
            "Soporifik",
            "Krabby",
            "Voltorbe",
            "Noeunoeuf",
            "Osselait",
            "Smogo",
            "Rhinocorne",
            "Hypotrempe",
            "Poissirene",
            "Stari",
            "Magicarpe",
            "Evoli",
            "Amonita",
            "Kabuto",
            "Minidraco",
            "Draco"});
            this.cb1.Location = new System.Drawing.Point(12, 89);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(118, 21);
            this.cb1.TabIndex = 2;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(18, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Methode d\'évolution : ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(146, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 33);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CBlvl
            // 
            this.CBlvl.FormattingEnabled = true;
            this.CBlvl.Items.AddRange(new object[] {
            "Niveau",
            "Pierre",
            "Echange"});
            this.CBlvl.Location = new System.Drawing.Point(176, 125);
            this.CBlvl.Name = "CBlvl";
            this.CBlvl.Size = new System.Drawing.Size(117, 21);
            this.CBlvl.TabIndex = 6;
            this.CBlvl.SelectedIndexChanged += new System.EventHandler(this.CBlvl_SelectedIndexChanged);
            // 
            // labelniv
            // 
            this.labelniv.AutoSize = true;
            this.labelniv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelniv.Location = new System.Drawing.Point(18, 155);
            this.labelniv.Name = "labelniv";
            this.labelniv.Size = new System.Drawing.Size(104, 13);
            this.labelniv.TabIndex = 7;
            this.labelniv.Text = "Niveau d\'evolution : ";
            this.labelniv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(188, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 68);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(305, 184);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelniv);
            this.Controls.Add(this.CBlvl);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GB Evolution Editor By MadDog84";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox CBlvl;
        private System.Windows.Forms.Label labelniv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

