//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE3_osu_Github
{
    using System;
    using System.Collections.Generic;
    
    public partial class fichefrais
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fichefrais()
        {
            this.LigneFraisForfait = new HashSet<LigneFraisForfait>();
            this.LigneFraisHorsForfait = new HashSet<LigneFraisHorsForfait>();
        }
    
        public string idVisiteur { get; set; }
        public string mois { get; set; }
        public Nullable<int> nbJustificatifs { get; set; }
        public Nullable<decimal> montantValide { get; set; }
        public Nullable<System.DateTime> dateModif { get; set; }
        public string idEtat { get; set; }
    
        public virtual Etat Etat { get; set; }
        public virtual Visiteur Visiteur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LigneFraisForfait> LigneFraisForfait { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LigneFraisHorsForfait> LigneFraisHorsForfait { get; set; }
    }
}
