//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryMvcProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLBOOK
    {
        public int BOOKID { get; set; }
        public string NAME { get; set; }
        public string PAGE { get; set; }
        public string AUTHOR { get; set; }
        public Nullable<int> CATEGORY { get; set; }
    
        public virtual TBLCATEGORY TBLCATEGORY { get; set; }
    }
}
