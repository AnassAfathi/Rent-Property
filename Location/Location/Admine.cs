//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Location
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admine
    {
        public string Email_a { get; set; }
        public string Nom_a { get; set; }
        public string Tel_a { get; set; }
    
        public virtual Usere Usere { get; set; }
    }
}