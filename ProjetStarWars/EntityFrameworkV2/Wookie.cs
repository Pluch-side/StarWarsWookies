//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkV2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wookie
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public Nullable<System.DateTime> DateN { get; set; }
        public Nullable<bool> Sexe { get; set; }
        public Nullable<int> PlaneteID { get; set; }
    
        public virtual Planete Planete { get; set; }
    }
}