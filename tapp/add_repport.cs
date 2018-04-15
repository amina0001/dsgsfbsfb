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
    public partial class add_repport : MetroForm
    {
        public patients p = new patients();
        public repports r = new repports();
        public DataTable dt = new DataTable();
        public Operation op = new Operation();
        public add_repport()
        {
            InitializeComponent();
        }

        private void add_repport_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (code_txtt.Text == "" )
            {
                errorProvider1.SetError(code_txtt, "erroor");
              



            }
            else
            {
                errorProvider1.SetError(code_txtt, "");
                
                p.code =Int32.Parse(code_txtt.Text);
                dt=op.SelectSimilairProduct(p);
                if (dt.Rows.Count > 0)
                {
                    r.code_patient = Int32.Parse(code_txtt.Text);
                    r.date_examen = Convert.ToDateTime(date_ex_txt.Value);
                    if (nom_radio_txt.Text != "")
                    {
                        r.Nom_radiologue = nom_radio_txt.Text;
                    }
                    if (nom_med.Text != "")
                    {
                        r.Nom_medecin_pres = nom_med.Text;
                    }
                    op.insertrepport(r);
                    dt=op.selectLastRepport();
                     r.numero_repport  =Int32.Parse(dt.Rows[0][0].ToString());
                    //  MessageBox.Show(r.numero_repport.ToString());
                    int x = 2;
                    making_repport mr = new making_repport(r,x);
                    mr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(this, "there is no patient with this reference  ....!!!!!","warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void code_txtt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void nom_med_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void nom_radio_txt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void date_ex_txt_onValueChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
