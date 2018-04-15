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
    public partial class Add_Form : MetroForm
    {
        public patients p = new patients();
        public DataTable dt = new DataTable();
        public Operation op = new Operation();
        public patient pf;
        public Add_Form()
        {
            InitializeComponent();
        }
        public Add_Form(patient f)
        {
            InitializeComponent();
            pf = f;
        }

        private void Add_Form_Load(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {  
          
        }

        private void add_btnn_Click(object sender, EventArgs e)
        { if(code_txt.Text !="" && prenom_txt.Text !="" && nom_txt.Text != "")
            {


                errorProvider1.SetError(code_txt, "");

                errorProvider1.SetError(prenom_txt, "");
                errorProvider1.SetError(nom_txt, "");

                p.code = Int32.Parse(code_txt.Text);
            p.prenom = prenom_txt.Text;
            p.nom = nom_txt.Text;
            dt = op.SelectSimilairProduct(p);
          
             if (dt.Rows.Count > 0)
            {
                errorProvider1.SetError(code_txt, "erroor");
                MetroFramework.MetroMessageBox.Show(this, "ok", "this reference is already used try again....!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else { 
           
                if (age_txt.Text != "")
                {
                    p.age = Int32.Parse(age_txt.Text.ToString());
                }
              //  MessageBox.Show(date_txt.Value.ToString());
                if (date_txt.Value != null)
                {
                    p.date_n = DateTime.Parse(date_txt.Value.ToString());
             


                }
                if (adresse_txt.Text !="")
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
                int rows = op.insertPatients(p);
                if (rows > 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "ok", "patient is saved ....!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                dt = op.selectPatients();
                if (dt.Rows.Count > 0)
                {
                    pf.metroGrid1.DataSource = dt;
                }
            }
            }
            else
            {
                errorProvider1.SetError(code_txt, "erroor");
                errorProvider1.SetError(prenom_txt, "erroor");
                errorProvider1.SetError(nom_txt, "erroor");

            }
        }

        private void Cancel_btnn_Click(object sender, EventArgs e)
        {
            this.Close();
                
                
         }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
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

        private void code_txt_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void code_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
