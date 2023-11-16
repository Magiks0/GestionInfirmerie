using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfirmerieBO;
using InfirmerieDAL;
using System.Configuration;

namespace InfirmerieBLL
{
    public class GestionInfirmerieBL
    {
        private static GestionInfirmerieBL uneGestionInfirmerie;

        #region Authentification
        // retourne la méthode d'authentification
        public static bool AuthentifierInfirmerie(Utilisateur unUtilisateur)
        {
            return InfirmerieDAO.Authentification(unUtilisateur.nomUtilisateur, unUtilisateur.mdpUtilisateur);
        }

        // retourne une instande de GestionInfirmerieBL
        public static GestionInfirmerieBL GetGestionInfirmeries()
        {
            if (uneGestionInfirmerie == null)
            {
                uneGestionInfirmerie = new GestionInfirmerieBL();
            }
            return uneGestionInfirmerie;
        }
        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            DbConnection.GetConnexionBD().SetchaineConnexion(chaine);
        }

        #endregion
        #region Gestion Eleve

        #endregion
    }
}