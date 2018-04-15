namespace tapp
{
    partial class update_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_form));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_txt = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Cancel_btnn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.update_btnn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tele_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gouvernerat_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.adresse_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.age_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nom_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.prenom_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.code_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(30, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 25);
            this.label6.TabIndex = 79;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(30, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 78;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(30, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 25);
            this.label4.TabIndex = 77;
            this.label4.Text = "*";
            // 
            // date_txt
            // 
            this.date_txt.BackColor = System.Drawing.Color.SeaGreen;
            this.date_txt.BorderRadius = 0;
            this.date_txt.ForeColor = System.Drawing.Color.White;
            this.date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_txt.FormatCustom = null;
            this.date_txt.Location = new System.Drawing.Point(229, 259);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(379, 36);
            this.date_txt.TabIndex = 76;
            this.date_txt.Value = new System.DateTime(2017, 12, 7, 0, 11, 11, 368);
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
            this.Cancel_btnn.Location = new System.Drawing.Point(462, 449);
            this.Cancel_btnn.Margin = new System.Windows.Forms.Padding(5);
            this.Cancel_btnn.Name = "Cancel_btnn";
            this.Cancel_btnn.Size = new System.Drawing.Size(151, 41);
            this.Cancel_btnn.TabIndex = 75;
            this.Cancel_btnn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancel_btnn.Click += new System.EventHandler(this.Cancel_btnn_Click);
            // 
            // update_btnn
            // 
            this.update_btnn.ActiveBorderThickness = 1;
            this.update_btnn.ActiveCornerRadius = 20;
            this.update_btnn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.update_btnn.ActiveForecolor = System.Drawing.Color.White;
            this.update_btnn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.update_btnn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.update_btnn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update_btnn.BackgroundImage")));
            this.update_btnn.ButtonText = "mise a jour";
            this.update_btnn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btnn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btnn.ForeColor = System.Drawing.Color.SeaGreen;
            this.update_btnn.IdleBorderThickness = 1;
            this.update_btnn.IdleCornerRadius = 20;
            this.update_btnn.IdleFillColor = System.Drawing.Color.White;
            this.update_btnn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.update_btnn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.update_btnn.Location = new System.Drawing.Point(301, 449);
            this.update_btnn.Margin = new System.Windows.Forms.Padding(5);
            this.update_btnn.Name = "update_btnn";
            this.update_btnn.Size = new System.Drawing.Size(151, 41);
            this.update_btnn.TabIndex = 74;
            this.update_btnn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update_btnn.Click += new System.EventHandler(this.update_btnn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(46, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 73;
            this.label3.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(46, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 72;
            this.label2.Text = "Prenom:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(51, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 71;
            this.label1.Text = "Nom:";
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
            this.tele_txt.Location = new System.Drawing.Point(229, 407);
            this.tele_txt.Margin = new System.Windows.Forms.Padding(4);
            this.tele_txt.Name = "tele_txt";
            this.tele_txt.Size = new System.Drawing.Size(379, 33);
            this.tele_txt.TabIndex = 70;
            this.tele_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tele_txt.OnValueChanged += new System.EventHandler(this.tele_txt_OnValueChanged);
            this.tele_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tele_txt_KeyPress);
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
            this.gouvernerat_txt.Location = new System.Drawing.Point(229, 350);
            this.gouvernerat_txt.Margin = new System.Windows.Forms.Padding(4);
            this.gouvernerat_txt.Name = "gouvernerat_txt";
            this.gouvernerat_txt.Size = new System.Drawing.Size(379, 33);
            this.gouvernerat_txt.TabIndex = 69;
            this.gouvernerat_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.adresse_txt.Location = new System.Drawing.Point(229, 298);
            this.adresse_txt.Margin = new System.Windows.Forms.Padding(4);
            this.adresse_txt.Name = "adresse_txt";
            this.adresse_txt.Size = new System.Drawing.Size(379, 33);
            this.adresse_txt.TabIndex = 68;
            this.adresse_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(46, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 24);
            this.label11.TabIndex = 67;
            this.label11.Text = "Telephone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(46, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 24);
            this.label10.TabIndex = 66;
            this.label10.Text = "date de naisance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(46, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 24);
            this.label9.TabIndex = 65;
            this.label9.Text = "Gouvernerat:";
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
            this.age_txt.Location = new System.Drawing.Point(229, 184);
            this.age_txt.Margin = new System.Windows.Forms.Padding(4);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(379, 33);
            this.age_txt.TabIndex = 62;
            this.age_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.age_txt.OnValueChanged += new System.EventHandler(this.age_txt_OnValueChanged);
            this.age_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_txt_KeyPress);
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
            this.nom_txt.Location = new System.Drawing.Point(229, 133);
            this.nom_txt.Margin = new System.Windows.Forms.Padding(4);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.Size = new System.Drawing.Size(379, 33);
            this.nom_txt.TabIndex = 61;
            this.nom_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.prenom_txt.Location = new System.Drawing.Point(229, 78);
            this.prenom_txt.Margin = new System.Windows.Forms.Padding(4);
            this.prenom_txt.Name = "prenom_txt";
            this.prenom_txt.Size = new System.Drawing.Size(379, 33);
            this.prenom_txt.TabIndex = 60;
            this.prenom_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.code_txt.Location = new System.Drawing.Point(229, 16);
            this.code_txt.Margin = new System.Windows.Forms.Padding(4);
            this.code_txt.Name = "code_txt";
            this.code_txt.Size = new System.Drawing.Size(379, 33);
            this.code_txt.TabIndex = 59;
            this.code_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.code_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.code_txt_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(46, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 24);
            this.label8.TabIndex = 64;
            this.label8.Text = "Age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(46, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 63;
            this.label7.Text = "adresse:";
            // 
            // update_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 507);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_txt);
            this.Controls.Add(this.Cancel_btnn);
            this.Controls.Add(this.update_btnn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tele_txt);
            this.Controls.Add(this.gouvernerat_txt);
            this.Controls.Add(this.adresse_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.age_txt);
            this.Controls.Add(this.nom_txt);
            this.Controls.Add(this.prenom_txt);
            this.Controls.Add(this.code_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "update_form";
            this.Load += new System.EventHandler(this.update_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker date_txt;
        private Bunifu.Framework.UI.BunifuThinButton2 Cancel_btnn;
        private Bunifu.Framework.UI.BunifuThinButton2 update_btnn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tele_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox gouvernerat_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adresse_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox age_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nom_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prenom_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox code_txt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}