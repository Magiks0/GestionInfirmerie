using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Eleve
    {
        private int id;
        private string lastname;
        private string firstname;
        private DateTime birthdate;
        private int phone;
        private int classNumber;
        private int parentsPhone;
        private bool extraTime;
        private string comment;

        // Constructeur sans l'id
        public Eleve(string lastname, string firstname, DateTime birthdate, int phone, int classNumber, int parentsPhone, bool extraTime, string comment)
        {
            this.Lastname = lastname;
            this.Firstname = firstname;
            this.Birthdate = birthdate;
            this.Phone = phone;
            this.ClassNumber = classNumber;
            this.ParentsPhone = parentsPhone;
            this.ExtraTime = extraTime;
            this.Comment = comment;
        }

        public int Id { get => id; set => id = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public int Phone { get => phone; set => phone = value; }
        public int ClassNumber { get => classNumber; set => classNumber = value; }
        public int ParentsPhone { get => parentsPhone; set => parentsPhone = value; }
        public bool ExtraTime { get => extraTime; set => extraTime = value; }
        public string Comment { get => comment; set => comment = value; }
    }
}
