//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookLibrary.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string WebSite { get; set; }
        public int CategoryId { get; set; }
        public string Discription { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
