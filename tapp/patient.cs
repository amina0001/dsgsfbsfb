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
    public partial class patient : MetroForm
    {
        public patients p = new patients();
        public DataTable dt = new DataTable();
        public Operation op = new Operation();
        public Form1 f;
        
        public patient()
        {
            InitializeComponent();
           
        }
        public patient(Form1 f1)
        {
            InitializeComponent();
            f = f1;
        }

        private void patient_Load(object sender, EventArgs e)
        {
            // panel5.BringToFront();
            metroGrid1.AutoGenerateColumns = true;

            dt = op.selectPatients();
            metroGrid1.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

          
            if (metroGrid1.SelectedRows.Count > 0)
            {
              
                int selectedIndex = metroGrid1.SelectedRows[0].Index;
                int code = int.Parse(metroGrid1[0, selectedIndex].Value.ToString());
                String nom = metroGrid1[1, selectedIndex].Value.ToString();
                String prenom = metroGrid1[2, selectedIndex].Value.ToString();
                String age = metroGrid1[3, selectedIndex].Value.ToString();
                p.code = code;
                dt=op.selectPatientspecifique(p);
                code_lbl.Text = code.ToString();
                prenom_lbl.Text = prenom;
                nom_lbl.Text = nom;
                if (age != "")
                {
                    age_lbl.Text = age;
                }
                p.code = code;
                dt = op.selectPatientspecifique(p);
                if(dt.Rows[0][5].ToString()!= "")
                {
                   // MessageBox.Show(dt.Rows[0][5].ToString());
                    DateTime date = Convert.ToDateTime(dt.Rows[0][5].ToString());
                    date_lbl.Text = date.ToString();
                }
                if (dt.Rows[0][6].ToString() != "")
                {
                    String adresse = dt.Rows[0][6].ToString();
                    adresse_lbl.Text = adresse;
                }
                if (dt.Rows[0][7].ToString() != "")
                {
                    String gouver = dt.Rows[0][7].ToString();
                    gouver_lbl.Text = gouver;
                }

                if (dt.Rows[0][7].ToString() != "")
                {

                    String telephone = dt.Rows[0][8].ToString();
                    tele_lbl.Text = telephone;

                }

            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Add_Form add = new Add_Form(this);
            add.Show();

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              
                dt = op.selectPatients();
                if (!code_ch.Checked && !nom_ch.Checked && !prenom_ch.Checked)
                {


                    DataView DV = new DataView(dt);
                    DV.RowFilter = string.Format("code + prenom +nom Like '%{0}%'", search_txt.Text);

                    metroGrid1.DataSource = DV;
                }
                else if (!code_ch.Checked && nom_ch.Checked && !prenom_ch.Checked)
                {
                    DataView DV = new DataView(dt);
                    DV.RowFilter = string.Format("nom Like '%{0}%'", search_txt.Text);

                    metroGrid1.DataSource = DV;
                }
                else if (!code_ch.Checked && !nom_ch.Checked && prenom_ch.Checked)
                {
                    DataView DV = new DataView(dt);
                    DV.RowFilter = string.Format("prenom Like '%{0}%'", search_txt.Text);

                    metroGrid1.DataSource = DV;
                }
                else if (code_ch.Checked && !nom_ch.Checked && !prenom_ch.Checked)
                {
                    DataView DV = new DataView(dt);
                    DV.RowFilter = string.Format("code = {0}", search_txt.Text);

                    metroGrid1.DataSource = DV;
                }

            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {

                int selectedIndex = metroGrid1.SelectedRows[0].Index;
                int code = int.Parse(metroGrid1[0, selectedIndex].Value.ToString());
                p.code = code;
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "do you really want to delete the patient?", "delete patient", MessageBoxButtons.YesNoCancel,
                  MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    op.deletepatient(p);
                }
                dt = op.selectPatients();
                if (dt.Rows.Count > 0)
                {
                    metroGrid1.DataSource = dt;
                }

            }
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            f = new Form1();
            f.Show();
            this.Hide();
           
        
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            update_form up = new update_form(this);
            up.Show();
           

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            repport re = new repport();
            re.Show();
            this.Hide();
        }
    }
}
