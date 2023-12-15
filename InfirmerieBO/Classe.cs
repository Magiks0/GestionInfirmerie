using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Classe
    {
        private int id;
        private string name;


        public Classe(string nom)
        {
            this.name = nom;
        }

        public Classe(int id)
        {
            this.id = id;
        }
        public Classe(int id, string nom)
        {
            this.id = id;
            this.name = nom;
        }


        public int GetId()
        {
            return this.id;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public void SetName(string nom)
        {
            this.name = nom;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
