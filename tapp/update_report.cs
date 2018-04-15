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
    public partial class update_report : MetroForm
    {
        public repport r;
        public Form1 f;
        public int codes = 0;
        public repports rp = new repports();
        public DataTable dt = new DataTable();
        public DataTable dtable = new DataTable();
        public DataTable d = new DataTable();
        public Operation op = new Operation();
        public update_report()
        {
            InitializeComponent();
        }
        public update_report(repport r1)
        {
            InitializeComponent();
            r = r1;
        }
        private void update_report_Load(object sender, EventArgs e)
        {

            if (r.metroGrid1.SelectedRows.Count > 0)
            {

                int selectedIndex = r.metroGrid1.SelectedRows[0].Index;
                int code = int.Parse(r.metroGrid1[0, selectedIndex].Value.ToString());
                rp.numero_repport = code;
                MessageBox.Show(code.ToString());
                dt = op.selectRepportpecifique(rp);

                code_txtt.Text = dt.Rows[0][11].ToString();
                date_ex_txt.Text = dt.Rows[0][1].ToString();
                nom_radio_txt.Text = dt.Rows[0][3].ToString();
                nom_med.Text = dt.Rows[0][4].ToString();





            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            bool found=true;
            dtable = op.count_patients();
            d = op.selectPatients();
            int max = Int32.Parse(dtable.Rows[0][0].ToString());
            for (int i = 0; i < max; i++)
            {
               // MessageBox.Show(code_txtt.Text.ToString());
               // MessageBox.Show(d.Rows[i][1].ToString());
                if (d.Rows[i][0].ToString() == code_txtt.Text.ToString())
                {
                    found = true;
                   
                    i = max;
                }
                else
                {
                    found = false;
                }
            }
                if (found == true)
                {
                    int selectedIndex = r.metroGrid1.SelectedRows[0].Index;
                    int code = int.Parse(r.metroGrid1[0, selectedIndex].Value.ToString());
                    rp.numero_repport = code;

                    rp.code_patient = Int32.Parse(code_txtt.Text.ToString());
                    rp.date_examen = DateTime.Parse(date_ex_txt.Text.ToString());
                    rp.Nom_medecin_pres = nom_med.Text.ToString();
                    rp.Nom_radiologue = nom_radio_txt.Text.ToString();
                    op.Updaterepportpart1(rp);
                    int x = 1;
                    making_repport mr = new making_repport(rp,x);
                    mr.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("sorry there is no patient with this number add it fist");
                }
                 

            dt = op.selectRepport();
                if (dt.Rows.Count > 0)
                {
                    r.metroGrid1.DataSource = dt;
                }

            
        }
    }
}
