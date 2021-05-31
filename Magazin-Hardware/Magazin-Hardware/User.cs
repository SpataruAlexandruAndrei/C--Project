using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin_Hardware
{
    public partial class User : ICloneable, IComparable
    {
        private string nume;
        private string prenume;
        private string username;
        private string nrTel;
        private string email;
        private string pass;
        private string confPass;
        private int id;
        public static int contor = 0;

        public User()
        {
            Nume = "N/A";
            Prenume = "N/A";
            Username = "N/A";
            NrTel = "N/A";
            Email = "N/A";
            Pass = "N/A";
            ConfPass = "N/A";
            id = contor++;
        }

        public User(string nume, string prenume, string username, string nrTel, string email, string pass, string confPass)
        {
            this.Nume = nume;
            this.Prenume = prenume;
            this.Username = username;
            this.NrTel = nrTel;
            this.Email = email;
            this.Pass = pass;
            this.ConfPass = confPass;
            id = contor++;
        }

        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public string Username { get => username; set => username = value; }
        public string NrTel { get => nrTel; set => nrTel = value; }
        public string Email { get => email; set => email = value; }
        public string Pass { get => pass; set => pass = value; }
        public string ConfPass { get => confPass; set => confPass = value; }

        public User getUser()
        {
            return new User(nume, prenume, username, nrTel, email, pass, confPass);
        }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Object obj)
        {
            User u = (User)obj;
            return String.Compare(this.username, u.username);
        }

        public override string ToString()
        {
            return "Nume: " + nume + "\nPrenume: " + prenume + "\nUsername: " + username + "\nEmail: " + email + "\nNumar telefon: " + nrTel;
        }
    }
}
