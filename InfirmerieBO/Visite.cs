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
        private Eleve eleve;
        private DateTime dateVisite;
        private TimeSpan heureDebutVisite;
        private TimeSpan heureFinVisite;
        private string motifVisite;
        private string commentaireVisite;
        private bool renvoiDomicile;
        private bool hospitalisation;
        private bool parentsPrevenus;

        #endregion

        #region Constructeurs
        //Constructeur Visite avec ID
        public Visite(int id, Eleve unEleve, DateTime dateVisite, TimeSpan heureDebutVisite, TimeSpan heureFinVisite, string motifVisite, string commentaireVisite, bool renvoiDomicile, bool hospitalisation, bool parentsPrevenus, Medicament unMedicament, string quantiteMedicament)
        {
            this.id = id;
            this.eleve = unEleve;
            this.DateVisite = dateVisite;
            this.heureDebutVisite = heureDebutVisite;
            this.heureFinVisite = heureFinVisite;
            this.motifVisite = motifVisite;
            this.commentaireVisite = commentaireVisite;
            this.renvoiDomicile = renvoiDomicile;
            this.hospitalisation = hospitalisation;
            this.parentsPrevenus = parentsPrevenus;
            this.Medicament = unMedicament;
            this.QuantiteMedicament = quantiteMedicament;
        }

        //Constructeur Visite sans ID
        public Visite(Eleve unEleve, TimeSpan heureDebutVisite, DateTime dateVisite, TimeSpan heureFinVisite, string motifVisite, string commentaireVisite, bool renvoiDomicile, bool hospitalisation, bool parentsPrevenus, Medicament unMedicament, string quantiteMedicament)
        {
            this.eleve = unEleve;
            this.DateVisite = dateVisite;
            this.heureDebutVisite = heureDebutVisite;
            this.heureFinVisite = heureFinVisite;
            this.motifVisite = motifVisite;
            this.commentaireVisite = commentaireVisite;
            this.renvoiDomicile = renvoiDomicile;
            this.hospitalisation = hospitalisation;
            this.parentsPrevenus = parentsPrevenus;
            this.Medicament = unMedicament;
            this.QuantiteMedicament = quantiteMedicament;
        }
        #endregion

        #region Getters/Setters
        public int Id { get => id; set => id = value; }
        public Eleve Eleve { get => eleve; set => eleve = value; }
        public TimeSpan HeureDebutVisite { get => heureDebutVisite; set => heureDebutVisite = value; }
        public TimeSpan HeureFinVisite { get => heureFinVisite; set => heureFinVisite = value; }
        public string MotifVisite { get => motifVisite; set => motifVisite = value; }
        public string CommentaireVisite { get => commentaireVisite; set => commentaireVisite = value; }
        public bool RenvoiDomicile { get => renvoiDomicile; set => renvoiDomicile = value; }
        public bool Hospitalisation { get => hospitalisation; set => hospitalisation = value; }
        public bool ParentsPrevenus { get => parentsPrevenus; set => parentsPrevenus = value; }
        public Medicament Medicament { get; set; }
        public string QuantiteMedicament { get; set; }
        public DateTime DateVisite { get => dateVisite; set => dateVisite = value; }
        #endregion
    }
}
