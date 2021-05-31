using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin_Hardware
{
    [Serializable]
    public partial class Componente: ICloneable, IComparable
    {
        private string denumire;
        private string detalii;
        private double pret;
        private int cantitate;

        public Componente()
        {

            Denumire = "N/A";
            Detalii = "N/A";
            Pret = 0;
            Cantitate = 0;
        }

        public Componente(string denumire, string detalii, float pret, int cantitate)
        {
            this.denumire = denumire;
            this.detalii = detalii;
            this.pret = pret;
            this.cantitate = cantitate;
        }

        public string Denumire { get => denumire; set => denumire = value; }
        public string Detalii { get => detalii; set => detalii = value; }
        public double Pret { get => pret; set => pret = value; }
        public int Cantitate { get => cantitate; set => cantitate = value; }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Object obj)
        {
            Componente u = (Componente)obj;
            return this.pret.CompareTo(u.pret);
        }

        public override string ToString()
        {
            return "Denumire: " + denumire + "Detalii: " + detalii + "Pret: " + pret + "Cantitate: " + cantitate;
        }
    }
}
