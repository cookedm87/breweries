//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace breweries.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    
    public partial class Style
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Style()
        {
            this.beers = new HashSet<beer>();
        }
    
        public int Id { get; set; }
        public int CountryId { get; set; }
        [Required]
        [Remote("doesStyleExist", "StylesController", HttpMethod = "POST", ErrorMessage = "This style already exists")]
        public string Style1 { get; set; }
        public string Colour { get; set; }
        [Range(0, 50)]
        public Nullable<decimal> lowABV { get; set; }
        [Range(0,50)]
        public Nullable<decimal> highABV { get; set; }
        public string styleWiki { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<beer> beers { get; set; }
        public virtual Country Country { get; set; }
    }
}
