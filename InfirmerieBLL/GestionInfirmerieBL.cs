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
            return InfirmerieDAO.Authentification(unUtilisateur);
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

        public static List<Eleve> ToutLesEleves()
        {
            return EleveDAO.GetEleves();
        }

        public int AjouterEleve(Eleve unEleve)
        {
            return EleveDAO.InsertEleve(unEleve);
        }

        public static int UpdateEleve(Eleve unEleve)
        {
            return EleveDAO.UpdateEleve(unEleve);
        }

        public int SupprimerEleve(Eleve unEleve)
        {
            return EleveDAO.DeleteEleve(unEleve);
        }

        #endregion

        #region Gestion Medicaments

        public static List<Eleve> ToutLesMedicaments()
        {
            return MedicamentDAO.GetEleves();
        }
        
        public int AjouterMedicament(Medicament unMedicament)
        {
            return MedicamentDAO.InsertEleve(unMedicament);
        }

        public static int UpdateMedicament(Medicament unMedicament)
        {
            return MedicamentDAO.UpdateEleve(unMedicament);
        }

        public int SupprimerMedicament(Medicament unMedicament)
        {
            return MedicamentDAO.DeleteEleve(unMedicament);
        }

        #endregion
    }
}