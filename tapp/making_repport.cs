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
//using Microsoft.Office.Interop;
using BLogic;
using BObject;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace tapp
{
    public partial class making_repport : MetroForm
    { public Operation op = new Operation();
        string check1 = "";
        string echogenecity = "";
        string shape = "";
        string margin = "";
        string foci = "";
        int score = 0;
        int x;
        public repports rs = new repports();
        public patients p = new patients();
        public DataTable dt = new DataTable();
        public DataTable d = new DataTable();
        public making_repport()
        {
            InitializeComponent();
        }
        public making_repport(repports r,int x1)
        {
            InitializeComponent();
            rs.code_patient = r.code_patient;
            rs.date_examen = r.date_examen;
            rs.numero_repport = r.numero_repport;
            p.code = rs.code_patient;
            x = x1;
            dt=op.selectPatientspecifique(p);
          //  MessageBox.Show(p.code.ToString());
        }
        private void making_repport_Load(object sender, EventArgs e)
        {
            if (x == 1) {
                button3.Show();
                button5.Hide();
            }else if (x == 2)
            {
                button5.Show();
                button3.Hide();
            }
            // MessageBox.Show(rs.numero_repport.ToString());
            compo_groupe.Hide();
            echogenicity_groupe.Hide();
            shape_groupe.Hide();
            margin_groupe.Hide();
            echo_groupe.Hide();
            richTextBox1.Text ="";
            d=op.selectRepportpecifique(rs);
            if (d.Rows[0][5].ToString() != "" || d.Rows[0][6].ToString() != ""|| d.Rows[0][7].ToString() != "" || d.Rows[0][8].ToString() != "" || d.Rows[0][9].ToString() != "")
            {
                rs.composition = d.Rows[0][5].ToString();
                rs.echogenicity = d.Rows[0][6].ToString();
                rs.shape= d.Rows[0][7].ToString();
                rs.margin = d.Rows[0][8].ToString();
                rs.echo_foci = d.Rows[0][9].ToString();
               
                if (d.Rows[0][5].ToString().TrimEnd() == compo_cystic_ch.Text.ToString().TrimEnd())
                {
                    compo_cystic_ch.Checked=true;
                   
                }
                else if (d.Rows[0][5].ToString().TrimEnd() == compo_spon_chh.Text.ToString().TrimEnd())
                {
                    compo_spon_chh.Checked = true;
                  
                }
                else if (d.Rows[0][5].ToString().TrimEnd() == compo_mixed_ch.Text.ToString().TrimEnd())
                {
                    compo_mixed_ch.Checked = true;
                   
                }
                else if (d.Rows[0][5].ToString().TrimEnd() == compo_mixed_ch.Text.ToString().TrimEnd())
                {
                    compo_mixed_ch.Checked = true;
                   
                }



                if (d.Rows[0][8].ToString().TrimEnd() == margin_smooth_ch.Text.TrimEnd())
                {
                    margin_smooth_ch.Checked = true;

                }
                else if (d.Rows[0][8].ToString().TrimEnd() == margin_defned_ch.Text.ToString().TrimEnd())
                {
                    margin_defned_ch.Checked = true;

                }
                else if (d.Rows[0][8].ToString().TrimEnd() == margin_extra_ch.Text.ToString().TrimEnd())
                {
                    margin_extra_ch.Checked = true;

                }
                else if (d.Rows[0][8].ToString().TrimEnd() == margin_lobu_ch.Text.ToString().TrimEnd())
                {
                    margin_lobu_ch.Checked = true;

                }



                if (d.Rows[0][6].ToString().TrimEnd() == echo_ane_ch.Text.TrimEnd())
                {
                    echo_ane_ch.Checked = true;

                }
                else if (d.Rows[0][6].ToString().TrimEnd() == echo_hypo_ch.Text.ToString().TrimEnd())
                {
                    echo_hypo_ch.Checked = true;

                }
                else if (d.Rows[0][6].ToString().TrimEnd() == echo_very_hypo_ch.Text.ToString().TrimEnd())
                {
                    echo_very_hypo_ch.Checked = true;

                }

                if (d.Rows[0][7].ToString().TrimEnd() == shape_tall_ch.Text.TrimEnd())
                {
                    shape_tall_ch.Checked = true;

                }
                else if (d.Rows[0][7].ToString().TrimEnd() == shape_wider_ch.Text.ToString().TrimEnd())
                {
                    shape_wider_ch.Checked = true;

                }

                if (d.Rows[0][9].ToString().TrimEnd() == foci_macro_ch.Text.TrimEnd())
                {
                    foci_macro_ch.Checked = true;

                }
                else if (d.Rows[0][9].ToString().TrimEnd() == foci_none_ch.Text.ToString().TrimEnd())
                {
                    foci_none_ch.Checked = true;

                }
                else if (d.Rows[0][9].ToString().TrimEnd() == foci_peripheral_ch.Text.ToString().TrimEnd())
                {
                    foci_peripheral_ch.Checked = true;

                }
                else if (d.Rows[0][9].ToString().TrimEnd() == foci_punc_ch.Text.ToString().TrimEnd())
                {
                    foci_punc_ch.Checked = true;

                }


                richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + d.Rows[0][2] + "\n " + " prenom:" + d.Rows[0][3] + "\n " + " age:" + d.Rows[0][4] + "\n " + " adresse:" + d.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + "\n  composition:" + rs.composition + " " + "\n  margin:" + rs.margin + "" + "\n  echogenecity foci:" + rs.echo_foci+ "" + "\n  echogenecity:" + rs.echogenicity + " " + "\n  shape:" + rs.shape;

            }

        }

        private void composition_btn_Click(object sender, EventArgs e)
        {
            compo_groupe.Show();
            echogenicity_groupe.Hide();
            shape_groupe.Hide();
            margin_groupe.Hide();
            echo_groupe.Hide();
        }

        private void echogenicity_btn_Click(object sender, EventArgs e)
        {

            compo_groupe.Hide();
            echogenicity_groupe.Show();
            shape_groupe.Hide();
            margin_groupe.Hide();
            echo_groupe.Hide();
        }

        private void margin_btn_Click(object sender, EventArgs e)
        {

            compo_groupe.Hide();
            echogenicity_groupe.Hide();
            shape_groupe.Hide();
            margin_groupe.Show();
            echo_groupe.Hide();
        }

        private void foci_btn_Click(object sender, EventArgs e)
        {
            compo_groupe.Hide();
            echogenicity_groupe.Hide();
            shape_groupe.Hide();
            margin_groupe.Hide();
            echo_groupe.Show();
        }

        private void shape_btn_Click(object sender, EventArgs e)
        {
            compo_groupe.Hide();
            echogenicity_groupe.Hide();
            shape_groupe.Show();
            margin_groupe.Hide();
            echo_groupe.Hide();

        }

        private void compo_cystic_ch_CheckedChanged_1(object sender, EventArgs e)
        {

            if (compo_cystic_ch.Checked)
            {

                check1 = "-the composition :" + compo_cystic_ch.Text + "\n";
                rs.composition = compo_cystic_ch.Text;
                score += 0;
            }
            else
            {
                check1 = "";

            }
            score_lbl.Text = score.ToString();
            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;
        }

        private void compo_spon_chh_CheckedChanged_1(object sender, EventArgs e)
        {
            if (compo_spon_chh.Checked)
            {

                check1 = "-the composition :"+ compo_spon_chh.Text + "\n";
                rs.composition = compo_spon_chh.Text;
                score += 0; 
            }
            else
            {
                check1 = "";

            }
            score_lbl.Text = score.ToString();
            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;
        }

        private void compo_mixed_ch_CheckedChanged_1(object sender, EventArgs e)
        {
            if (compo_mixed_ch.Checked)
            {

                check1 = "-the composition is :" + compo_mixed_ch.Text+"\n";
                rs.composition = compo_mixed_ch.Text;
                score += 1;
            }
            else
            {
                check1 = "";
                score -= 1;
            }
            score_lbl.Text = score.ToString();
            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;
        }

        private void compo_solid_ch_CheckedChanged_1(object sender, EventArgs e)
        {

            if (compo_solid_ch.Checked)
            {

                check1 = "-the composition is :" + compo_solid_ch.Text + "\n";
                rs.composition = compo_solid_ch.Text;
                score += 2;
            }
            else
            {
                check1 = "";
                score -= 2;
            }
            score_lbl.Text = score.ToString();
            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;
        }

        private void margin_smooth_ch_CheckedChanged_1(object sender, EventArgs e)
        {

            if (margin_smooth_ch.Checked)
            {

                margin = "-the margin is :" + margin_smooth_ch.Text.TrimEnd() + "\n";
                rs.margin = margin_smooth_ch.Text;
                score += 0;
            }
            else
            {
                margin = "";

            }
            score_lbl.Text = score.ToString();
            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;
        }

        private void margin_defned_ch_CheckedChanged_1(object sender, EventArgs e)
        {

            if (margin_defned_ch.Checked)
            {

                margin = "-the margin  :" +  margin_defned_ch.Text + "\n";
                rs.margin = margin_defned_ch.Text;
                score += 0;
            }
            else
            {
                margin = "";
               
            }
            score_lbl.Text = score.ToString();
            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;
        }

        private void margin_lobu_ch_CheckedChanged_1(object sender, EventArgs e)
        {

            if (margin_lobu_ch.Checked)
            {

                margin = "-the margin :" + margin_lobu_ch.Text + "\n";
                rs.margin = margin_lobu_ch.Text;
                score += 2;
            }
            else
            {
                margin = "";
                score -= 2;
            }
            score_lbl.Text = score.ToString();
            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;
        }

        private void margin_extra_ch_CheckedChanged_1(object sender, EventArgs e)
        {
            if (margin_extra_ch.Checked)
            {

                margin = "-the margin :" + margin_extra_ch.Text + "\n";
                rs.margin = margin_extra_ch.Text;
                score += 3;
            }
            else
            {
                margin = "";
                score -= 3;
            }
            score_lbl.Text = score.ToString();
            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;
        }

        private void shape_wider_ch_CheckedChanged(object sender, EventArgs e)
        {
            if (shape_wider_ch.Checked)
            {

                shape ="-the shape :" + shape_wider_ch.Text + "\n";
                rs.shape = shape_wider_ch.Text;
                score += 0;
            }
            else
            {
                shape = "";

            }
            score_lbl.Text = score.ToString();
            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;
        }

        private void shape_tall_ch_CheckedChanged(object sender, EventArgs e)
        {
            if (shape_tall_ch.Checked)
            {

                shape = "-the shape : " + shape_tall_ch.Text + "\n";
                rs.shape = shape_tall_ch.Text;
                score += 3;
            }
            else
            {
                shape = "";
                score -= 3;
            }
            score_lbl.Text = score.ToString();
            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;
        }

        private void foci_none_ch_CheckedChanged(object sender, EventArgs e)
        {

            if (foci_none_ch.Checked)
            {

                shape = "-the echogeic foci " + foci_none_ch.Text + "\n";
                rs.echo_foci = foci_none_ch.Text;
            }
            else
            {
                shape = "";

            }
            score_lbl.Text = score.ToString();
            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;
        }

        private void foci_macro_ch_CheckedChanged(object sender, EventArgs e)
        {

            if (foci_macro_ch.Checked)
            {

                foci = "-the echogeic foci :" + foci_macro_ch.Text + "\n";
                rs.echo_foci = foci_macro_ch.Text;
                score += 1;
            }
            else
            {
                foci = "";
                score -= 3;
            }
            score_lbl.Text = score.ToString();
            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;
        }

        private void foci_peripheral_ch_CheckedChanged(object sender, EventArgs e)
        {

            if (foci_peripheral_ch.Checked)
            {

                foci = "-the echogeic foci :" + foci_peripheral_ch.Text + "\n";
                rs.echo_foci = foci_peripheral_ch.Text;
                score += 2;
            }
            else
            {
                foci = "";
                score -= 2;
            }
            score_lbl.Text = score.ToString();
            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;
        }

        private void foci_punc_ch_CheckedChanged(object sender, EventArgs e)
        {

            if (foci_punc_ch.Checked)
            {

                foci = "-the echogeic foci :" + foci_punc_ch.Text + "\n";
                rs.echo_foci = foci_punc_ch.Text;
                score += 3;
            }
            else
            {
                foci = "";
                score-= 3;
            }
            score_lbl.Text = score.ToString();
            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;
        }

        private void echo_ane_ch_CheckedChanged(object sender, EventArgs e)
        {

            if (echo_ane_ch.Checked)
            {

                echogenecity = "-the echogenicity : " + echo_ane_ch.Text + "\n";
                rs.echogenicity = echo_ane_ch.Text;

            }
            else
            {
                echogenecity = "";

            }

            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;
        }

        private void echo_hyp_ch_CheckedChanged(object sender, EventArgs e)
        {

            if (echo_hyp_ch.Checked)
            {

                echogenecity = "-the echogenicity : " + echo_hyp_ch.Text + "\n";
                rs.echogenicity = echo_hyp_ch.Text;
                score += 1;
            }
            else
            {
                echogenecity = "";
                score -= 1;
            }
            score_lbl.Text = score.ToString();
            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;
        }

        private void echo_hypo_ch_CheckedChanged(object sender, EventArgs e)
        {

            if (echo_hypo_ch.Checked)
            {

                echogenecity = "-the echogenicity :  " + echo_hypo_ch.Text + "\n";
                rs.echogenicity = echo_hypo_ch.Text;
                score += 2;
            }
            else
            {
                echogenecity = "";
                score -= 2;
            }
            score_lbl.Text = score.ToString();
            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;

        }

        private void echo_very_hypo_ch_CheckedChanged(object sender, EventArgs e)
        {

            if (echo_very_hypo_ch.Checked)
            {

                echogenecity = "-the echogenicity : " + echo_very_hypo_ch.Text + "\n";
                rs.echogenicity = echo_very_hypo_ch.Text;
                // MessageBox.Show(rs.echogenicity);
                score += 3;
            }
            else
            {
                echogenecity = "";
                score -= 3;
            }
            score_lbl.Text = score.ToString();
            richTextBox1.Text = "\n \t \t \t RAPPORT MEDICAL \n\n Dossier N° :" + rs.code_patient + "\n  nom:" + dt.Rows[0][2] + "\n " + " prenom:" + dt.Rows[0][3] + "\n " + " age:" + dt.Rows[0][4] + "\n " + " adresse:" + dt.Rows[0][6] + "\n " + " date d'examen :" + rs.date_examen + "\n\n  " + " resultat du test: \n " + check1 + " " + margin + "" + foci + "" + echogenecity + " " + shape;
        }
        //save button
        private void button5_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(rs.numero_repport.ToString());
           // MessageBox.Show(rs.echogenicity.ToString());
            int resultat=op.insertrepport(rs);
            if (resultat > 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "ok", "repport is saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            System.Drawing.Font new1, old1;
            old1 = richTextBox1.SelectionFont;
            if (old1.Bold)
                new1 = new System.Drawing.Font(old1, old1.Style & ~FontStyle.Bold);
            else
                new1 = new System.Drawing.Font(old1, old1.Style | FontStyle.Bold);

            richTextBox1.SelectionFont = new1;
            richTextBox1.Focus();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            System.Drawing.Font new1, old1;
            old1 = richTextBox1.SelectionFont;
            if (old1.Italic)
                new1 = new System.Drawing.Font(old1, old1.Style & ~FontStyle.Italic);
            else
                new1 = new System.Drawing.Font(old1, old1.Style | FontStyle.Italic);

            richTextBox1.SelectionFont = new1;

            richTextBox1.Focus();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

            System.Drawing.Font new1, old1;
            old1 = richTextBox1.SelectionFont;
            if (old1.Underline)
                new1 = new System.Drawing.Font(old1, old1.Style & ~FontStyle.Underline);
            else
                new1 = new System.Drawing.Font(old1, old1.Style | FontStyle.Underline);

            richTextBox1.SelectionFont = new1;
            richTextBox1.Focus();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            // Check if it is Left aligned
            if (richTextBox1.RightToLeft == RightToLeft.No)
                richTextBox1.RightToLeft = RightToLeft.Yes; // If so, turn it to Right Aligned
            else
                richTextBox1.RightToLeft = RightToLeft.No;  // If Right aligned, turn it to Left aligned
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extention for the file.
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                richTextBox1.SaveFile(saveFile1.FileName);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            DialogResult messageResult = MessageBox.Show("Save this file into PDF?", "PDF File", MessageBoxButtons.OKCancel);

            if (messageResult == DialogResult.Cancel)
            {
                MessageBox.Show("Operation Canceled By User", "PDF File");
            }
            else
            {
                sfd.Title = "Save As PDF";
                sfd.Filter = "(*.pdf)|*.pdf";
                sfd.InitialDirectory = @"C:\";


                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (richTextBox1.Text != "")
                    {
                        iTextSharp.text.Document doc = new iTextSharp.text.Document();
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(richTextBox1.Text));
                        doc.Close();
                        richTextBox1.Text = "";
                        MessageBox.Show("PDF Saved Succesfully", "PDF File");

                    }
                    else
                    {
                        MessageBox.Show("Please Enter Your Text", "PDF File",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }

                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
               
                
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "do you really want to delete the repport?", "delete patient", MessageBoxButtons.YesNoCancel,
                  MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    op.deleteprepport(rs);
                }
                
                repport repo = new repport();
                dt = op.selectRepport();
                if (dt.Rows.Count > 0)
                {

                    repo.metroGrid1.DataSource = dt;
                }
                this.Hide();
                repo.Show();
                

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int resultat=op.Updaterepportpart2(rs);
            if (resultat > 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "ok", "repport is saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            patient pf = new patient();
            pf.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            repport rf = new repport();
            rf.Show();
            this.Hide();
        }
    }
}
