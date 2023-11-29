using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Visite
    {
        #region Déclaration des attributs privé
        private int id;
        private Eleve idEleve;
        private DateTime dateVisite;
        private DateTime heureDebutVisite;
        private DateTime heureFinVisite;
        private string motifVisite;
        private string commentaireVisite;
        private bool renvoiDomicile;
        private bool hospitalisation;
        private bool parentsPrevenus;
        private Medicament idMedicament;
        private string quantiteMedicament;

        #endregion

        #region Constructeurs
        //Constructeur Visite avec ID
        public Visite(int id, Eleve idEleve, DateTime dateVisite, DateTime heureDebutVisite, DateTime heureFinVisite, string motifVisite, string commentaireVisite, bool renvoiDomicile, bool hospitalisation, bool parentsPrevenus, Medicament idMedicament, string quantiteMedicament)
        {
            this.id = id;
            this.idEleve = idEleve;
            this.DateVisite = dateVisite;
            this.heureDebutVisite = heureDebutVisite;
            this.heureFinVisite = heureFinVisite;
            this.motifVisite = motifVisite;
            this.commentaireVisite = commentaireVisite;
            this.renvoiDomicile = renvoiDomicile;
            this.hospitalisation = hospitalisation;
            this.parentsPrevenus = parentsPrevenus;
            this.idMedicament = idMedicament;
            this.quantiteMedicament = quantiteMedicament;
        }

        //Constructeur Visite sans ID
        public Visite(Eleve idEleve, DateTime heureDebutVisite, DateTime dateVisite, DateTime heureFinVisite, string motifVisite, string commentaireVisite, bool renvoiDomicile, bool hospitalisation, bool parentsPrevenus, Medicament idMedicament, string quantiteMedicament)
        {
            this.idEleve = idEleve;
            this.DateVisite = dateVisite;
            this.heureDebutVisite = heureDebutVisite;
            this.heureFinVisite = heureFinVisite;
            this.motifVisite = motifVisite;
            this.commentaireVisite = commentaireVisite;
            this.renvoiDomicile = renvoiDomicile;
            this.hospitalisation = hospitalisation;
            this.parentsPrevenus = parentsPrevenus;
            this.idMedicament = idMedicament;
            this.quantiteMedicament = quantiteMedicament;
        }
        #endregion

        #region Getters/Setters
        public int Id { get => id; set => id = value; }
        public Eleve IdEleve { get => IdEleve; set => IdEleve = value; }
        public DateTime HeureDebutVisite { get => heureDebutVisite; set => heureDebutVisite = value; }
        public DateTime HeureFinVisite { get => heureFinVisite; set => heureFinVisite = value; }
        public string MotifVisite { get => motifVisite; set => motifVisite = value; }
        public string CommentaireVisite { get => commentaireVisite; set => commentaireVisite = value; }
        public bool RenvoiDomicile { get => renvoiDomicile; set => renvoiDomicile = value; }
        public bool Hospitalisation { get => hospitalisation; set => hospitalisation = value; }
        public bool ParentsPrevenus { get => parentsPrevenus; set => parentsPrevenus = value; }
        public Medicament IdMedicament { get => idMedicament; set => idMedicament = value; }
        public string QuantiteMedicament { get => quantiteMedicament; set => quantiteMedicament = value; }
        public DateTime DateVisite { get => dateVisite; set => dateVisite = value; }
        #endregion
    }
}
