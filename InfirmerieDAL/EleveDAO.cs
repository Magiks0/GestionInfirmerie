using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieDAL
{
    class EleveDAO
    {
        static EleveDAO unEleveDAO;

        // Accesseur en lecture, renvoie une instance
        public static EleveDAO GetunUtilisateurDAO()
        {
            if (unEleveDAO == null)
            {
                unEleveDAO = new EleveDAO();
            }
            return unEleveDAO;
        }
    }
}
