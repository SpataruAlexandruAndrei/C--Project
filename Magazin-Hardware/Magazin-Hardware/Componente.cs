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
        private int id;
        private string denumire;
        private string detalii;
        private float pret;
        private int cantitate;
        //private int cantitateComandata;

        public Componente()
        {
            Id = 0;
            Denumire = "N/A";
            Detalii = "N/A";
            Pret = 0;
            Cantitate = 0;
        }

        public Componente(int id, string denumire, string detalii, float pret, int cantitate)
        {
            this.Id = id;
            this.denumire = denumire;
            this.detalii = detalii;
            this.pret = pret;
            this.cantitate = cantitate;
        }

        //public Componente(string denumire, float pret, int cantitateComandata)
        //{
        //    this.denumire = denumire;
        //    this.pret = pret;
        //    this.CantitateComandata = cantitateComandata;
        //}

        public string Denumire { get => denumire; set => denumire = value; }
        public string Detalii { get => detalii; set => detalii = value; }
        public float Pret { get => pret; set => pret = value; }
        public int Cantitate { get => cantitate; set => cantitate = value; }
        public int Id { get => id; set => id = value; }
        ///public int CantitateComandata { get => cantitateComandata; set => cantitateComandata = value; }

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
