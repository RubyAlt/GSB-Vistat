using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_06
{
    internal class EtapeNormee
    {
        public int num;
        public string libelle;
        public string norme;
        public DateTime dateNorme;

        public EtapeNormee(int num_, string libelle_, string norme_, DateTime dateNorme_)
        {
            this.num = num_;
            this.libelle = libelle_;
            this.norme = norme_;
            this.dateNorme = dateNorme_;
        }
    }
}
