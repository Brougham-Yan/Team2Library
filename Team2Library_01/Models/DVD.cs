//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Team2Library_01.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DVD
    {
        public int DvdID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int Length { get; set; }
        public string Director_FName { get; set; }
        public string Director_LName { get; set; }
        public string Studio { get; set; }
        public Nullable<int> Genre { get; set; }
        public int Language { get; set; }
        public Nullable<float> Rating { get; set; }
        public string Synopsis { get; set; }
        public int Shelf { get; set; }
    }
}
