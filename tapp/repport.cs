using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using BLogic;
using BObject;
namespace tapp
{
    public partial class repport : MetroForm
    {
        public patients p = new patients();
        public DataTable dt = new DataTable();
        public Operation op = new Operation();
        public repports r=new repports();
        public Form1 f;
        public patient pat;
        public update_form up;
        public repport()
        {
            InitializeComponent();
        }
        public repport(Form1 f1)
        {
            InitializeComponent();
            f = f1;
        }
     

        //public repport(patient p1)
        //{
        //    InitializeComponent();

        //         pat = p1;
        //}

        private void repport_Load(object sender, EventArgs e)
        {
            metroGrid1.AutoGenerateColumns = true;

            dt = op.selectRepport();
            metroGrid1.DataSource = dt;
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            add_repport ar = new add_repport();
            ar.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if (metroGrid1.SelectedRows.Count > 0)
            {

                int selectedIndex = metroGrid1.SelectedRows[0].Index;
                int numero = int.Parse(metroGrid1[0, selectedIndex].Value.ToString());
               
                r.numero_repport = numero;
                dt = op.selectRepportpecifique(r);
                code_lbl.Text =  dt.Rows[0]["code_patient"].ToString();
                date_lbll.Text = dt.Rows[0]["date_ex"].ToString();
                if (dt.Rows[0]["Nom_radio"].ToString() != "")
                {
                   // MessageBox.Show(dt.Rows[0][5].ToString());
                    //DateTime date = Convert.ToDateTime(dt.Rows[0][5].ToString());
                   nom_radio_lbll.Text= dt.Rows[0]["nom_radio"].ToString();
                }
                if (dt.Rows[0]["Nom_pres"].ToString() != "")
                {
                    // MessageBox.Show(dt.Rows[0][5].ToString());
                    //DateTime date = Convert.ToDateTime(dt.Rows[0][5].ToString());
                    nom_médecin_pres.Text = dt.Rows[0]["Nom_pres"].ToString();
                }
                if (dt.Rows[0]["raison"].ToString() != "")
                {

                    raison_lbll.Text = dt.Rows[0]["raison"].ToString();
                }
                if (dt.Rows[0]["composition"].ToString() != "")
                {

                    composition_lbll.Text = dt.Rows[0]["composition"].ToString();
                }
                if (dt.Rows[0]["echogenecity"].ToString() != "")
                {
                   
                    nom_médecin_pres.Text = dt.Rows[0]["echogenecity"].ToString(); ;
                }

                if (dt.Rows[0]["shape"].ToString() != "")
                {

                    
                    shape_lbll.Text = dt.Rows[0]["shape"].ToString();

                }
                if (dt.Rows[0]["margin"].ToString() != "")
                {


                    margin_lbll.Text = dt.Rows[0]["margin"].ToString();

                }
                if (dt.Rows[0]["echo_foci"].ToString() != "")
                {


                    shape_lbll.Text = dt.Rows[0]["echo_foci"].ToString();

                }
                if (dt.Rows[0]["score"].ToString() != "")
                {


                    score_lbll.Text = dt.Rows[0]["score"].ToString();

                }
            }
        }
        //delete action
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {

                int selectedIndex = metroGrid1.SelectedRows[0].Index;
                int numero = int.Parse(metroGrid1[0, selectedIndex].Value.ToString());
                r.numero_repport= numero;
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "do you really want to delete the repport?", "delete patient", MessageBoxButtons.YesNoCancel,
                  MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    op.deleteprepport(r);
                }
                dt = op.selectRepport();
                if (dt.Rows.Count > 0)
                {
                    metroGrid1.DataSource = dt;
                }

            }
        }

        private void search_txt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void search_txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                dt = op.selectRepport();
                if (!code_ch.Checked && !numero_ch.Checked && !date_ch.Checked)
                {
                    DataView DV = new DataView(dt);
                    DV.RowFilter = string.Format("id + code_patient  = {0}", search_txt.Text);
                    metroGrid1.DataSource = DV;
                }
                else if (!code_ch.Checked && numero_ch.Checked && !date_ch.Checked)
                {  
                    DataView DV = new DataView(dt);
                    DV.RowFilter = string.Format("Id = {0}", search_txt.Text);

                    metroGrid1.DataSource = DV;
                }
                else if (!code_ch.Checked && !numero_ch.Checked && date_ch.Checked)
                {

                    DataView DV = new DataView(dt);
                    DV.RowFilter = string.Format(Convert.ToDateTime(date_ex).ToShortDateString(),"LIKE '%{0}%'", DateTime.Parse(search_txt.Text).ToShortDateString());
                    metroGrid1.DataSource = DV;
                }
                else if (code_ch.Checked && !numero_ch.Checked && !date_ch.Checked)
                {
                    DataView DV = new DataView(dt);
                    DV.RowFilter = string.Format("code_patient = {0}", search_txt.Text);
                    metroGrid1.DataSource = DV;
                }

            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void picker_onValueChanged(object sender, EventArgs e)
        {
            search_txt.Text = picker.Value.ToShortDateString();
        }

        private void bunifuSeparator12_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            update_report up = new update_report(this);
            up.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            patient p = new patient();
            p.Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }
    }
}
