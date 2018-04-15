namespace tapp
{
    partial class Add_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Form));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.code_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.prenom_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nom_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.age_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adresse_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gouvernerat_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tele_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_btnn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Cancel_btnn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.date_txt = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // code_txt
            // 
            this.code_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.code_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.code_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.code_txt.HintForeColor = System.Drawing.Color.Empty;
            this.code_txt.HintText = "";
            this.code_txt.isPassword = false;
            this.code_txt.LineFocusedColor = System.Drawing.Color.Blue;
            this.code_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.code_txt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.code_txt.LineThickness = 3;
            this.code_txt.Location = new System.Drawing.Point(231, 111);
            this.code_txt.Margin = new System.Windows.Forms.Padding(4);
            this.code_txt.Name = "code_txt";
            this.code_txt.Size = new System.Drawing.Size(379, 33);
            this.code_txt.TabIndex = 35;
            this.code_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.code_txt.OnValueChanged += new System.EventHandler(this.code_txt_OnValueChanged);
            this.code_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.code_txt_KeyPress);
            // 
            // prenom_txt
            // 
            this.prenom_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prenom_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prenom_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prenom_txt.HintForeColor = System.Drawing.Color.Empty;
            this.prenom_txt.HintText = "";
            this.prenom_txt.isPassword = false;
            this.prenom_txt.LineFocusedColor = System.Drawing.Color.Blue;
            this.prenom_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.prenom_txt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.prenom_txt.LineThickness = 3;
            this.prenom_txt.Location = new System.Drawing.Point(231, 173);
            this.prenom_txt.Margin = new System.Windows.Forms.Padding(4);
            this.prenom_txt.Name = "prenom_txt";
            this.prenom_txt.Size = new System.Drawing.Size(379, 33);
            this.prenom_txt.TabIndex = 36;
            this.prenom_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nom_txt
            // 
            this.nom_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nom_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nom_txt.HintForeColor = System.Drawing.Color.Empty;
            this.nom_txt.HintText = "";
            this.nom_txt.isPassword = false;
            this.nom_txt.LineFocusedColor = System.Drawing.Color.Blue;
            this.nom_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.nom_txt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nom_txt.LineThickness = 3;
            this.nom_txt.Location = new System.Drawing.Point(231, 228);
            this.nom_txt.Margin = new System.Windows.Forms.Padding(4);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.Size = new System.Drawing.Size(379, 33);
            this.nom_txt.TabIndex = 37;
            this.nom_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // age_txt
            // 
            this.age_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.age_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.age_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.age_txt.HintForeColor = System.Drawing.Color.Empty;
            this.age_txt.HintText = "";
            this.age_txt.isPassword = false;
            this.age_txt.LineFocusedColor = System.Drawing.Color.Blue;
            this.age_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.age_txt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.age_txt.LineThickness = 3;
            this.age_txt.Location = new System.Drawing.Point(231, 279);
            this.age_txt.Margin = new System.Windows.Forms.Padding(4);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(379, 33);
            this.age_txt.TabIndex = 38;
            this.age_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.age_txt.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            this.age_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_txt_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(48, 511);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 24);
            this.label11.TabIndex = 46;
            this.label11.Text = "Telephone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(48, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 24);
            this.label10.TabIndex = 45;
            this.label10.Text = "date de naisance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(48, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 24);
            this.label9.TabIndex = 44;
            this.label9.Text = "Gouvernerat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(48, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 24);
            this.label8.TabIndex = 43;
            this.label8.Text = "Age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(48, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "adresse:";
            // 
            // adresse_txt
            // 
            this.adresse_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adresse_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.adresse_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adresse_txt.HintForeColor = System.Drawing.Color.Empty;
            this.adresse_txt.HintText = "";
            this.adresse_txt.isPassword = false;
            this.adresse_txt.LineFocusedColor = System.Drawing.Color.Blue;
            this.adresse_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.adresse_txt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.adresse_txt.LineThickness = 3;
            this.adresse_txt.Location = new System.Drawing.Point(231, 393);
            this.adresse_txt.Margin = new System.Windows.Forms.Padding(4);
            this.adresse_txt.Name = "adresse_txt";
            this.adresse_txt.Size = new System.Drawing.Size(379, 33);
            this.adresse_txt.TabIndex = 47;
            this.adresse_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gouvernerat_txt
            // 
            this.gouvernerat_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gouvernerat_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gouvernerat_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gouvernerat_txt.HintForeColor = System.Drawing.Color.Empty;
            this.gouvernerat_txt.HintText = "";
            this.gouvernerat_txt.isPassword = false;
            this.gouvernerat_txt.LineFocusedColor = System.Drawing.Color.Blue;
            this.gouvernerat_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.gouvernerat_txt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.gouvernerat_txt.LineThickness = 3;
            this.gouvernerat_txt.Location = new System.Drawing.Point(231, 445);
            this.gouvernerat_txt.Margin = new System.Windows.Forms.Padding(4);
            this.gouvernerat_txt.Name = "gouvernerat_txt";
            this.gouvernerat_txt.Size = new System.Drawing.Size(379, 33);
            this.gouvernerat_txt.TabIndex = 48;
            this.gouvernerat_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tele_txt
            // 
            this.tele_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tele_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tele_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tele_txt.HintForeColor = System.Drawing.Color.Empty;
            this.tele_txt.HintText = "";
            this.tele_txt.isPassword = false;
            this.tele_txt.LineFocusedColor = System.Drawing.Color.Blue;
            this.tele_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.tele_txt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tele_txt.LineThickness = 3;
            this.tele_txt.Location = new System.Drawing.Point(231, 502);
            this.tele_txt.Margin = new System.Windows.Forms.Padding(4);
            this.tele_txt.Name = "tele_txt";
            this.tele_txt.Size = new System.Drawing.Size(379, 33);
            this.tele_txt.TabIndex = 49;
            this.tele_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tele_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tele_txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(53, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(48, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "Prenom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(48, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 52;
            this.label3.Text = "Code:";
            // 
            // add_btnn
            // 
            this.add_btnn.ActiveBorderThickness = 1;
            this.add_btnn.ActiveCornerRadius = 20;
            this.add_btnn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.add_btnn.ActiveForecolor = System.Drawing.Color.White;
            this.add_btnn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.add_btnn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.add_btnn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_btnn.BackgroundImage")));
            this.add_btnn.ButtonText = "Ajouter";
            this.add_btnn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btnn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btnn.ForeColor = System.Drawing.Color.SeaGreen;
            this.add_btnn.IdleBorderThickness = 1;
            this.add_btnn.IdleCornerRadius = 20;
            this.add_btnn.IdleFillColor = System.Drawing.Color.White;
            this.add_btnn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.add_btnn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.add_btnn.Location = new System.Drawing.Point(303, 544);
            this.add_btnn.Margin = new System.Windows.Forms.Padding(5);
            this.add_btnn.Name = "add_btnn";
            this.add_btnn.Size = new System.Drawing.Size(151, 41);
            this.add_btnn.TabIndex = 53;
            this.add_btnn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add_btnn.Click += new System.EventHandler(this.add_btnn_Click);
            // 
            // Cancel_btnn
            // 
            this.Cancel_btnn.ActiveBorderThickness = 1;
            this.Cancel_btnn.ActiveCornerRadius = 20;
            this.Cancel_btnn.ActiveFillColor = System.Drawing.Color.Red;
            this.Cancel_btnn.ActiveForecolor = System.Drawing.Color.White;
            this.Cancel_btnn.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.Cancel_btnn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Cancel_btnn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancel_btnn.BackgroundImage")));
            this.Cancel_btnn.ButtonText = "Annuler";
            this.Cancel_btnn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_btnn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btnn.ForeColor = System.Drawing.Color.Red;
            this.Cancel_btnn.IdleBorderThickness = 1;
            this.Cancel_btnn.IdleCornerRadius = 20;
            this.Cancel_btnn.IdleFillColor = System.Drawing.Color.White;
            this.Cancel_btnn.IdleForecolor = System.Drawing.Color.DarkRed;
            this.Cancel_btnn.IdleLineColor = System.Drawing.Color.DarkRed;
            this.Cancel_btnn.Location = new System.Drawing.Point(464, 544);
            this.Cancel_btnn.Margin = new System.Windows.Forms.Padding(5);
            this.Cancel_btnn.Name = "Cancel_btnn";
            this.Cancel_btnn.Size = new System.Drawing.Size(151, 41);
            this.Cancel_btnn.TabIndex = 54;
            this.Cancel_btnn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancel_btnn.Click += new System.EventHandler(this.Cancel_btnn_Click);
            // 
            // date_txt
            // 
            this.date_txt.BackColor = System.Drawing.Color.SeaGreen;
            this.date_txt.BorderRadius = 0;
            this.date_txt.ForeColor = System.Drawing.Color.White;
            this.date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_txt.FormatCustom = null;
            this.date_txt.Location = new System.Drawing.Point(231, 354);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(379, 36);
            this.date_txt.TabIndex = 55;
            this.date_txt.Value = new System.DateTime(2017, 12, 7, 0, 11, 11, 368);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(32, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(32, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 57;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(32, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 25);
            this.label6.TabIndex = 58;
            this.label6.Text = "*";
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 599);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_txt);
            this.Controls.Add(this.Cancel_btnn);
            this.Controls.Add(this.add_btnn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tele_txt);
            this.Controls.Add(this.gouvernerat_txt);
            this.Controls.Add(this.adresse_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.age_txt);
            this.Controls.Add(this.nom_txt);
            this.Controls.Add(this.prenom_txt);
            this.Controls.Add(this.code_txt);
            this.Name = "Add_Form";
            this.Load += new System.EventHandler(this.Add_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nom_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prenom_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox code_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox age_txt;
        private Bunifu.Framework.UI.BunifuThinButton2 Cancel_btnn;
        private Bunifu.Framework.UI.BunifuThinButton2 add_btnn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tele_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox gouvernerat_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adresse_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDatepicker date_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}