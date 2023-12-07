using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Medicament
    {
        private int id;
        private string nom;

        // Constructeur avec id
        public Medicament(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        // Constructeur sans id
        public Medicament(string nom)
        {
            this.nom = nom;
        }

        public int GetId()
        {
            return this.id;
        }
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }

        public override string ToString()
        {
            return nom;
        }
    }
}
