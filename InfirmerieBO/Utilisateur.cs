using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Utilisateur
    {
        private int Id_Utilisateur;
        private string Nom_Utilisateur;
        private string Mdp_Utilisateur;

        public Utilisateur(int id_Utilisateur, string nom_Utilisateur, string mdp_Utilisateur)
        {
            Id_Utilisateur1 = id_Utilisateur;
            Nom_Utilisateur1 = nom_Utilisateur;
            Mdp_Utilisateur1 = mdp_Utilisateur;
        }

        public int Id_Utilisateur1 { get => Id_Utilisateur; set => Id_Utilisateur = value; }
        public string Nom_Utilisateur1 { get => Nom_Utilisateur; set => Nom_Utilisateur = value; }
        public string Mdp_Utilisateur1 { get => Mdp_Utilisateur; set => Mdp_Utilisateur = value; }
    }
}
