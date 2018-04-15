namespace tapp
{
    partial class add_repport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_repport));
            this.nom_radio_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nom_med = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.date_ex_txt = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.code_txtt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nom_radio_txt
            // 
            this.nom_radio_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom_radio_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nom_radio_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nom_radio_txt.HintForeColor = System.Drawing.Color.Empty;
            this.nom_radio_txt.HintText = "";
            this.nom_radio_txt.isPassword = false;
            this.nom_radio_txt.LineFocusedColor = System.Drawing.Color.Teal;
            this.nom_radio_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.nom_radio_txt.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.nom_radio_txt.LineThickness = 3;
            this.nom_radio_txt.Location = new System.Drawing.Point(221, 188);
            this.nom_radio_txt.Margin = new System.Windows.Forms.Padding(4);
            this.nom_radio_txt.Name = "nom_radio_txt";
            this.nom_radio_txt.Size = new System.Drawing.Size(379, 33);
            this.nom_radio_txt.TabIndex = 3;
            this.nom_radio_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nom_radio_txt.OnValueChanged += new System.EventHandler(this.nom_radio_txt_OnValueChanged);
            // 
            // nom_med
            // 
            this.nom_med.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom_med.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nom_med.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nom_med.HintForeColor = System.Drawing.Color.Empty;
            this.nom_med.HintText = "";
            this.nom_med.isPassword = false;
            this.nom_med.LineFocusedColor = System.Drawing.Color.Teal;
            this.nom_med.LineIdleColor = System.Drawing.Color.Gray;
            this.nom_med.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.nom_med.LineThickness = 3;
            this.nom_med.Location = new System.Drawing.Point(221, 258);
            this.nom_med.Margin = new System.Windows.Forms.Padding(4);
            this.nom_med.Name = "nom_med";
            this.nom_med.Size = new System.Drawing.Size(379, 33);
            this.nom_med.TabIndex = 4;
            this.nom_med.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nom_med.OnValueChanged += new System.EventHandler(this.nom_med_OnValueChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(25, 132);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(101, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Date Examen:";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(23, 215);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(121, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Nom radiologue:";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(23, 272);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(191, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Nom medecin prescripteur:";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(25, 72);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(99, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Code Patient:";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Teal;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Teal;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Suivant";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(221, 365);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 22;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // date_ex_txt
            // 
            this.date_ex_txt.BackColor = System.Drawing.Color.Teal;
            this.date_ex_txt.BorderRadius = 0;
            this.date_ex_txt.ForeColor = System.Drawing.Color.White;
            this.date_ex_txt.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_ex_txt.FormatCustom = null;
            this.date_ex_txt.Location = new System.Drawing.Point(232, 132);
            this.date_ex_txt.Name = "date_ex_txt";
            this.date_ex_txt.Size = new System.Drawing.Size(379, 36);
            this.date_ex_txt.TabIndex = 26;
            this.date_ex_txt.Value = new System.DateTime(2017, 12, 6, 11, 47, 31, 614);
            this.date_ex_txt.onValueChanged += new System.EventHandler(this.date_ex_txt_onValueChanged);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Annuler";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.Location = new System.Drawing.Point(419, 365);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton22.TabIndex = 27;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // code_txtt
            // 
            this.code_txtt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.code_txtt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.code_txtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.code_txtt.HintForeColor = System.Drawing.Color.Empty;
            this.code_txtt.HintText = "";
            this.code_txtt.isPassword = false;
            this.code_txtt.LineFocusedColor = System.Drawing.Color.Teal;
            this.code_txtt.LineIdleColor = System.Drawing.Color.Gray;
            this.code_txtt.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.code_txtt.LineThickness = 3;
            this.code_txtt.Location = new System.Drawing.Point(221, 46);
            this.code_txtt.Margin = new System.Windows.Forms.Padding(4);
            this.code_txtt.Name = "code_txtt";
            this.code_txtt.Size = new System.Drawing.Size(379, 33);
            this.code_txtt.TabIndex = 12;
            this.code_txtt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.code_txtt.OnValueChanged += new System.EventHandler(this.code_txtt_OnValueChanged);
            // 
            // add_repport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 444);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.date_ex_txt);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.code_txtt);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.nom_med);
            this.Controls.Add(this.nom_radio_txt);
            this.Name = "add_repport";
            this.Load += new System.EventHandler(this.add_repport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox nom_radio_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nom_med;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuDatepicker date_ex_txt;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox code_txtt;
    }
}