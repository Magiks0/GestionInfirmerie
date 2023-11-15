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

        public int GetId()
        {
            return this.id;
        }

        public string GetName()
        {
            return this.name;
        }

    }
}
