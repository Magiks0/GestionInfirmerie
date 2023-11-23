using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfirmerieBO;
using System.Data.SqlClient;


namespace InfirmerieDAL
{
    class ClasseDAO
    {
        static ClasseDAO classeDAO;
        public static ClasseDAO GetClasseDAO()
        {
            if (classeDAO == null)
            {
                classeDAO = new ClasseDAO();
            }
            return classeDAO;
        }

        public static List<Classe> GetClasses()
        {
            int id;
            string name;
            Classe uneClasse;

            SqlConnection maConnexion = DbConnection.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Eleves
            List<Classe> lesClasses = new List<Classe>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            // select pour avoir toute les informations d'Eleve ainsi que le nom de sa classe (pour la création d'objet classe)
            cmd.CommandText = "SELECT * FROM Classe";

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = Int32.Parse(monReader["id_classe"].ToString());
                name = monReader["nom_eleve"].ToString();
                uneClasse = new Classe(id, name);
                lesClasses.Add(uneClasse);
            }

            maConnexion.Close();

            return lesClasses;

        }
    }
}
