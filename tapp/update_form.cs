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
using BObject;
using BLogic;

namespace tapp
{
    public partial class update_form : MetroForm
    {
        public patient pf;
        public Form1 f;
        public int codes=0;
        public patients p = new patients();
        public DataTable dt = new DataTable();
        public Operation op = new Operation();
        public update_form(patient p1)
        {
            InitializeComponent();
            pf = p1;
        }
        public update_form(Form1 f1,int code)
        {
            InitializeComponent();
            f = f1;
             codes=code;
    }
        private void update_form_Load(object sender, EventArgs e)
        {
            if (codes != 0)
            {
                int code = codes;
                p.code = code;
                dt = op.selectPatientspecifique(p);
                code_txt.Text = dt.Rows[0][1].ToString();
                nom_txt.Text = dt.Rows[0][2].ToString();
                prenom_txt.Text = dt.Rows[0][3].ToString();
                age_txt.Text = dt.Rows[0][4].ToString();
                date_txt.Text = dt.Rows[0][5].ToString();
                adresse_txt.Text = dt.Rows[0][6].ToString();
                gouvernerat_txt.Text = dt.Rows[0][7].ToString();
                tele_txt.Text = dt.Rows[0][8].ToString();
            }else
            if (pf.metroGrid1.SelectedRows.Count > 0)
            {

                int selectedIndex = pf.metroGrid1.SelectedRows[0].Index;
                int code = int.Parse(pf.metroGrid1[0, selectedIndex].Value.ToString());
                p.code = code;
                dt = op.selectPatientspecifique(p);
                code_txt.Text = dt.Rows[0][1].ToString();
                nom_txt.Text = dt.Rows[0][2].ToString();
                prenom_txt.Text = dt.Rows[0][3].ToString();
                age_txt.Text = dt.Rows[0][4].ToString();
                date_txt.Text = dt.Rows[0][5].ToString();
                adresse_txt.Text = dt.Rows[0][6].ToString();
                gouvernerat_txt.Text = dt.Rows[0][7].ToString();
                tele_txt.Text = dt.Rows[0][8].ToString();


                //dt = op.selectPatients();
                //if (dt.Rows.Count > 0)
                //{
                //    pf.metroGrid1.DataSource = dt;
                //}

            }
            
        }

        private void update_btnn_Click(object sender, EventArgs e)
        {
            int codef;
            if (codes != 0)
            {
                codef = codes;
            }
            else
            {

                int selectedIndex = pf.metroGrid1.SelectedRows[0].Index;
                codef = int.Parse(pf.metroGrid1[0, selectedIndex].Value.ToString());
            }

            p.code=Int32.Parse(code_txt.Text.ToString());
            p.prenom = prenom_txt.Text;
            p.nom = nom_txt.Text;
            if (age_txt.Text != "")
            {
                p.age = Int32.Parse(age_txt.Text.ToString());
            }
            //  MessageBox.Show(date_txt.Value.ToString());
            if (date_txt.Value != null)
            {
                p.date_n = DateTime.Parse(date_txt.Value.ToString());
              

            }
            if (adresse_txt.Text != "")
            {
                p.adresse = adresse_txt.Text.ToString();
            }
            if (gouvernerat_txt.Text != "")
            {
                p.gouvernerat = gouvernerat_txt.Text.ToString();
            }
            if (tele_txt.Text != "")
            {
                p.telephone = tele_txt.Text.ToString();
            }

            int rows = op.UpdatePatients(p,codef);
            if (rows > 0)
            {
              //  MetroFramework.MetroMessageBox.Show(this, "ok", "patient is updated ....!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            if (codes == 0)
            {
                pf.Show();
                dt = op.selectPatients();
                if (dt.Rows.Count > 0)
                {
                    pf.metroGrid1.DataSource = dt;
                }
            }
            else
            {
                int code = codes;
                p.code = code;
                dt = op.selectPatientspecifique(p);
                code_txt.Text = dt.Rows[0][1].ToString().TrimEnd();
                nom_txt.Text = dt.Rows[0][2].ToString().TrimEnd();
                prenom_txt.Text = dt.Rows[0][3].ToString().TrimEnd();
                age_txt.Text = dt.Rows[0][4].ToString().TrimEnd();
                date_txt.Text = dt.Rows[0][5].ToString().TrimEnd();
                adresse_txt.Text = dt.Rows[0][6].ToString().TrimEnd();
                gouvernerat_txt.Text = dt.Rows[0][7].ToString().TrimEnd();
                tele_txt.Text = dt.Rows[0][8].ToString();
               
            }
           
        }

        private void Cancel_btnn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tele_txt_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void age_txt_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void age_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tele_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void code_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
