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
    public partial class Form1 : MetroForm
    {
        public Operation op = new Operation();
        public DataTable dt = new DataTable();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notif.Hide();
            
           
            //panel9.BringToFront();
          //  panel5.BringToFront();
            //panel6.BringToFront();
           // panel7.BringToFront();
           // panel11.BringToFront();
           panel13.BringToFront();
           // panel4.BringToFront();
         //   panel8.BringToFront();
           // panel12.BringToFront();
            panel10.BringToFront();
            if (this.WindowState == FormWindowState.Maximized)
            {
               // panel11.Width=400;
                //panel8.Width =410;
               // chart1.Width = 500;
            }
            dt=op.nb_patient_today();
            if (dt.Rows.Count > 0)
            {
            //    nb_patient_lbl.Text = dt.Rows[0][0].ToString();
            }
            else
            {
              //  nb_patient_lbl.Text = "0";
            }

            ///////////////////////////////////////////chart

            int delta = DayOfWeek.Monday - DateTime.Today.DayOfWeek;
            if (delta > 0)
            {
                delta -= 7;

            }
            DateTime mondays = DateTime.Today.AddDays(delta);

            int days = Int32.Parse((DateTime.Today - mondays).TotalDays.ToString());
            dt = op.stat_chart();
            DataView dvasc = new DataView(dt);
            dvasc.Sort = "dates DESC";
            DataTable dtasc = dvasc.ToTable();
            //MessageBox.Show(dtasc.Rows[0][0].ToString());
            /// MessageBox.Show(dtasc.Rows[0][1].ToString());
            // MessageBox.Show(days.ToString());
            chart2.DataSource = dtasc.AsEnumerable().Take(days);
            chart2.Series["stat"].XValueMember = "dates";
            chart2.Series["stat"].YValueMembers = "patient";
            //////////////////////////////
            dt=op.patient_empty_fields();
            notif.Show();
            if (dt.Rows[0][0].ToString()!="")
            {
                name.Text = dt.Rows[0][1].ToString();
                name.Show();
                first_emty_patient.Show();
                delete.Show();
            }
            else
            {
                name.Hide();
                first_emty_patient.Hide();
                delete.Hide();
            }
            if (dt.Rows[1][0].ToString() != "")
            {
                name2.Text = dt.Rows[1][1].ToString();
                name2.Show();
                second_emty_patient.Show();
                delete1.Show();
            }
            else
            {
                name2.Hide();
                second_emty_patient.Hide();
                delete1.Hide();
            }
            if (dt.Rows[2][0].ToString() != "")
            {
                name3.Text = dt.Rows[2][1].ToString();
                name3.Show();
                third_emty_patient.Show();
                delete2.Show();
            }
            else
            {
                name3.Hide();
                third_emty_patient.Hide();
                delete3.Hide();
            }
            if (dt.Rows[3][0].ToString() != "")
            {
                name4.Text = dt.Rows[3][1].ToString();
                name4.Show();
                fourth_emty_patient.Show();
                delete3.Show();
            }
            else
            {
                name4.Hide();
                fourth_emty_patient.Hide();
                delete3.Hide();
            }
        }
       
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            patient p = new patient();
            p.Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            repport r = new repport(this);
            r.Show();     
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator3_Load(object sender, EventArgs e)
        {

        }

        private void first_emty_patient_Click_1(object sender, EventArgs e)
        {
            int code;
            dt = op.patient_empty_fields();
            code = Int32.Parse(dt.Rows[0][0].ToString());
            update_form up = new update_form(this,code);
            up.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            name.Hide();
            first_emty_patient.Hide();
            delete.Hide();
        }

        private void delete1_Click(object sender, EventArgs e)
        {
            name2.Hide();
            second_emty_patient.Hide();
            delete1.Hide();
        }

        private void delete2_Click(object sender, EventArgs e)
        {

            name3.Hide();
           third_emty_patient.Hide();
            delete2.Hide();
        }

        private void delete3_Click(object sender, EventArgs e)
        {

            name4.Hide();
            fourth_emty_patient.Hide();
            delete3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void second_emty_patient_Click(object sender, EventArgs e)
        {

            int code;
            dt = op.patient_empty_fields();
            code = Int32.Parse(dt.Rows[1][0].ToString());
            update_form up = new update_form(this, code);
            up.Show();
        }

        private void third_emty_patient_Click(object sender, EventArgs e)
        {

            int code;
            dt = op.patient_empty_fields();
            code = Int32.Parse(dt.Rows[2][0].ToString());
            update_form up = new update_form(this, code);
            up.Show();
        }

        private void fourth_emty_patient_Click(object sender, EventArgs e)
        {

            int code;
            dt = op.patient_empty_fields();
            code = Int32.Parse(dt.Rows[3][0].ToString());
            update_form up = new update_form(this, code);
            up.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }
    }
}
