using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BObject;
using System.Data;
using System.Data.SqlServerCe;
using DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace BLogic
{
    public class Operation
    {
        public DBconnection db = new DBconnection();
        public patients p = new patients();

        public DataTable SelectSimilairProduct(patients p)
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT code  FROM Patient where code='" + p.code + "' ";
            return db.ExeReader(cmd);
        }
        public int insertPatients(patients p)
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "INSERT INTO Patient(code, nom, prenom,age,date_N,adresse,gouvernerat,telephone) VALUES('" + p.code + "', '" + p.nom + "', '" + p.prenom + "',@age,@date_N,@adresse,@gouvernerat,@telephone)";

            cmd.Parameters.Clear();

            if (p.age != null)
            {
                cmd.Parameters.AddWithValue("@age", p.age);
            }
               
            else
            {
                cmd.Parameters.AddWithValue("@age", DBNull.Value);
            }
            if (p.date_n != null)
            {
                cmd.Parameters.AddWithValue("@date_N", p.date_n);
            }
           

            else
            {
                cmd.Parameters.AddWithValue("@date_N", DBNull.Value);
            
                    MessageBox.Show("hhhhhhhhh");

                
            }
            if (p.adresse != null)
            {
                cmd.Parameters.AddWithValue("@adresse", p.adresse);
            }

            else
            {
                cmd.Parameters.AddWithValue("@adresse", DBNull.Value);
            }
            if (p.gouvernerat != null)
            {
                cmd.Parameters.AddWithValue("@gouvernerat", p.gouvernerat);
            }

            else
            {
                cmd.Parameters.AddWithValue("@gouvernerat", DBNull.Value);
            }
            if (p.telephone != null)
            {
                cmd.Parameters.AddWithValue("@telephone", p.telephone);
            }

            else
            {
                cmd.Parameters.AddWithValue("@telephone", DBNull.Value);
            }



            int rows = db.ExeNonQuery(cmd);
            return rows;
        }
        public int UpdatePatients(patients p ,int codef)
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "Update Patient set Code= '" + p.code + "' , nom=@nom, prenom=@prenom,age=@age,date_N=@date_N,adresse=@adresse,gouvernerat=@gouvernerat,telephone=@telephone WHERE Code='" +codef + "'";

            cmd.Parameters.Clear();

            
            if (p.nom != null)
            {
                cmd.Parameters.AddWithValue("@nom", p.nom);
            }

            else
            {
                cmd.Parameters.AddWithValue("@nom", DBNull.Value);
            }
            if (p.prenom != null)
            {
                cmd.Parameters.AddWithValue("@prenom", p.prenom);
            }

            else
            {
                cmd.Parameters.AddWithValue("@prenom", DBNull.Value);
            }
            if (p.age != null)
            {
                cmd.Parameters.AddWithValue("@age", p.age);
            }

            else
            {
                cmd.Parameters.AddWithValue("@age", DBNull.Value);
            }
            if (p.date_n != null)
            {
                cmd.Parameters.AddWithValue("@date_N", p.date_n);
            }


            else
            {
                cmd.Parameters.AddWithValue("@date_N", DBNull.Value);

              

            }
            if (p.adresse != null)
            {
                cmd.Parameters.AddWithValue("@adresse", p.adresse);
            }

            else
            {
                cmd.Parameters.AddWithValue("@adresse", DBNull.Value);
            }
            if (p.gouvernerat != null)
            {
                cmd.Parameters.AddWithValue("@gouvernerat", p.gouvernerat);
            }

            else
            {
                cmd.Parameters.AddWithValue("@gouvernerat", DBNull.Value);
            }
            if (p.telephone != null)
            {
                cmd.Parameters.AddWithValue("@telephone", p.telephone);
            }

            else
            {
                cmd.Parameters.AddWithValue("@telephone", DBNull.Value);
            }



            int rows = db.ExeNonQuery(cmd);
            return rows;
        }
        public int Updaterepportpart1(repports r)
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "Update repport set code_patient= '" + r.code_patient + "' , date_ex=@date_ex, Nom_radio=@Nom_radio,Nom_pres=@Nom_pres WHERE code_patient='" + r.code_patient + "'";

            cmd.Parameters.Clear();


            if ( r.date_examen != null)
            {
                cmd.Parameters.AddWithValue("@date_ex", r.date_examen);
            }

            else
            {
                cmd.Parameters.AddWithValue("@date_ex", DBNull.Value);
            }
            if (r.Nom_medecin_pres != null)
            {
                cmd.Parameters.AddWithValue("@Nom_pres", r.Nom_medecin_pres);
            }

            else
            {
                cmd.Parameters.AddWithValue("@Nom_pres", DBNull.Value);
            }
            if (r.Nom_radiologue != null)
            {
                cmd.Parameters.AddWithValue("@Nom_radio", r.Nom_radiologue);
            }

            else
            {
                cmd.Parameters.AddWithValue("@Nom_radio", DBNull.Value);
            }
           


            int rows = db.ExeNonQuery(cmd);
            return rows;
        }
        public int Updaterepportpart2(repports r)
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "Update repport set composition=@composition, echogenecity=@echogenecity ,shape=@shape,margin=@margin,echo_foci=@echo_foci,score=@score WHERE code_patient='" + r.code_patient + "'";

            cmd.Parameters.Clear();


            if (r.composition != null)
            {
                cmd.Parameters.AddWithValue("@composition", r.composition);
            }

            else
            {
                cmd.Parameters.AddWithValue("@composition", DBNull.Value);
            }
            if (r.echogenicity != null)
            {
                cmd.Parameters.AddWithValue("@echogenecity", r.echogenicity);
            }

            else
            {
                cmd.Parameters.AddWithValue("@echogenecity", DBNull.Value);
            }
            if (r.shape != null)
            {
                cmd.Parameters.AddWithValue("@shape", r.shape);
            }

            else
            {
                cmd.Parameters.AddWithValue("@shape", DBNull.Value);
            }
            if (r.margin != null)
            {
                cmd.Parameters.AddWithValue("@margin", r.margin);
            }

            else
            {
                cmd.Parameters.AddWithValue("@margin", DBNull.Value);
            }

            if (r.echo_foci != null)
            {
                cmd.Parameters.AddWithValue("@echo_foci", r.echo_foci);
            }

            else
            {
                cmd.Parameters.AddWithValue("@echo_foci", DBNull.Value);
            }
            if (r.score != null)
            {
                cmd.Parameters.AddWithValue("@score", r.score);
            }

            else
            {
                cmd.Parameters.AddWithValue("@score", DBNull.Value);
            }





            int rows = db.ExeNonQuery(cmd);
            return rows;
        }
        public DataTable selectPatients()
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT code,nom,prenom,age FROM Patient ORDER BY code desc";

            return db.ExeReader(cmd);
        }
        public DataTable selectRepport()
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT Id,code_patient,date_ex FROM repport ORDER BY id desc";

            return db.ExeReader(cmd);
        }
        public DataTable selectPatientspecifique(patients p)
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT * FROM Patient WHERE code='"+p.code+"'";

            return db.ExeReader(cmd);
        }
        public void deletepatient(patients p)
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "DELETE FROM Patient WHERE  Code ='" + p.code + "';";
            db.ExeNonQuery(cmd);
        }
        public DataTable selectLastRepport()
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT TOP 1 Id FROM repport ORDER BY Id desc";

            return db.ExeReader(cmd);
        }
        public int insertrepport(repports r)
        {

            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "INSERT INTO repport(code_patient,date_ex, Nom_radio,Nom_pres,composition,echogenecity,shape,margin,echo_foci,score) VALUES('" + r.code_patient + "', '" + r.date_examen + "',@Nom_radio,@Nom_pres,@composition,@echogenecity,@shape,@margin,@echo_foci,@score)";

            cmd.Parameters.Clear();

            //if (r.raison != null)
            //{
            //    cmd.Parameters.AddWithValue("@raison", r.raison);
            //}

            //else
            //{
            //    cmd.Parameters.AddWithValue("@raison", DBNull.Value);
            //}
            if (r.Nom_radiologue != null)
            {
                cmd.Parameters.AddWithValue("@Nom_radio", r.Nom_radiologue);
            }


            else
            {
                cmd.Parameters.AddWithValue("@Nom_radio", DBNull.Value);

               


            }
            if (r.Nom_medecin_pres != null)
            {
                cmd.Parameters.AddWithValue("@Nom_pres", r.Nom_medecin_pres);
            }

            else
            {
                cmd.Parameters.AddWithValue("@Nom_pres", DBNull.Value);
            }

            if (r.composition != null)
            {
                cmd.Parameters.AddWithValue("@composition", r.composition);
            }

            else
            {
                cmd.Parameters.AddWithValue("@composition", DBNull.Value);
            }

            if (r.echogenicity != null)
            {
                cmd.Parameters.AddWithValue("@echogenecity", r.echogenicity);
            }

            else
            {
                cmd.Parameters.AddWithValue("@echogenecity", DBNull.Value);
            }

            if (r.shape != null)
            {
                cmd.Parameters.AddWithValue("@shape", r.shape);
            }

            else
            {
                cmd.Parameters.AddWithValue("@shape", DBNull.Value);
            }

            if (r.margin != null)
            {
                cmd.Parameters.AddWithValue("@margin", r.margin);
            }

            else
            {
                cmd.Parameters.AddWithValue("@margin", DBNull.Value);
            }

            if (r.echo_foci != null)
            {
                cmd.Parameters.AddWithValue("@echo_foci", r.echo_foci);
            }

            else
            {
                cmd.Parameters.AddWithValue("@echo_foci", DBNull.Value);
            }
            if (r.score != null)
            {
                cmd.Parameters.AddWithValue("@score", r.score);
            }

            else
            {
                cmd.Parameters.AddWithValue("@score", DBNull.Value);
            }
            int rows = db.ExeNonQuery(cmd);
            return rows;
        }
        public DataTable selectRepportpecifique(repports r)
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT *  FROM repport where Id='" + r.numero_repport + "' ";
            return db.ExeReader(cmd);
        }
        public void deleteprepport(repports r)
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "DELETE FROM repport WHERE  Id ='" + r.numero_repport + "';";
            db.ExeNonQuery(cmd);
        }
        public DataTable nb_patient_today()
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT  count(code_patient)FROM repport  ";
            return db.ExeReader(cmd);
        }
        public DataTable stat_chart()
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT  SUM(code_patient) AS patient, CONVERT(nvarchar(10),date_ex,120) AS dates From repport Group BY  CONVERT(nvarchar(10),date_ex,120)";
            return db.ExeReader(cmd);
        }
        public DataTable patient_empty_fields()
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT  code,nom,prenom  From Patient WHERE age IS Null OR date_N IS Null OR adresse IS Null OR gouvernerat IS Null OR telephone IS Null";
            return db.ExeReader(cmd);
        }
        public DataTable count_patients()
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT COUNT(code)  From Patient";
            return db.ExeReader(cmd);
        }
    }
}
