using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BObject
{
    public class repports
    {   public int code_patient { get; set; }
        public int numero_repport { get; set; }
        public DateTime date_examen { get; set; }
        public String raison { get; set; }
        public String Nom_radiologue { get; set; }
        public String Nom_medecin_pres { get; set; }
        public String composition { get; set; }
        public String echogenicity { get; set; }
        public String shape { get; set; }
        public String margin { get; set; }
        public String echo_foci { get; set; }
        public int? score { get; set; }
    }
    
}
