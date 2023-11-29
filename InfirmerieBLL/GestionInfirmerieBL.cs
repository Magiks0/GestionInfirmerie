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

        public static int AjouterEleve(Eleve unEleve)
        {
            return EleveDAO.InsertEleve(unEleve);
        }

        public static int UpdateEleve(Eleve unEleve)
        {
            return EleveDAO.UpdateEleve(unEleve);
        }

        public static int SupprimerEleve(Eleve unEleve)
        {
            return EleveDAO.DeleteEleve(unEleve);
        }

        #endregion

        #region Gestion Medicaments

        public static List<Medicament> ToutLesMedicaments()
        {
            return MedicamentDAO.GetMedicaments();
        }
        
        public static int AjouterMedicament(Medicament unMedicament)
        {
            return MedicamentDAO.InsertMedicament(unMedicament);
        }

        public static int UpdateMedicament(Medicament unMedicament)
        {
            return MedicamentDAO.UpdateMedicament(unMedicament);
        }

        public static int SupprimerMedicament(Medicament unMedicament)
        {
            return MedicamentDAO.DeleteMedicament(unMedicament);
        }

        #endregion

        #region Gestion Visites

        public static List<Visite> ToutesLesVisites()
        {
            return VisiteDAO.GetVisites();
        }

        public static int Ajouterament(Visite unVisite)
        {
            return VisiteDAO.InsertVisite(unVisite);
        }

        public static int UpdateVisite(Visite unVisite)
        {
            return VisiteDAO.UpdateVisite(unVisite);
        }

        public static int SupprimerVisite(Visite unVisite)
        {
            return VisiteDAO.DeleteVisite(unVisite);
        }

        #endregion
    }
} 