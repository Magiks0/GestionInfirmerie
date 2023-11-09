using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfirmerieBO;
using InfirmerieDAL;

namespace InfirmerieBLL
{
    public class GestionInfirmerieBL
    {
        public static bool AuthentifierUtilisateur(string login, string mdp)
        {
            return InfirmerieDAO.Authentification(login, mdp);
        }
    }
}