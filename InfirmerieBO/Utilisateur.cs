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

        // Constructeur de la classe Utilisateur
        public Utilisateur(string nom_Utilisateur, string mdp_Utilisateur)
        {
            Nom_Utilisateur = nom_Utilisateur;
            Mdp_Utilisateur = mdp_Utilisateur;
        }

        // Getter + Setter
        public int idUtilisateur { get => Id_Utilisateur; set => Id_Utilisateur = value; }
        public string nomUtilisateur { get => Nom_Utilisateur; set => Nom_Utilisateur = value; }
        public string mdpUtilisateur { get => Mdp_Utilisateur; set => Mdp_Utilisateur = value; }
    }
}
