//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OTIS_POC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Financials_by_Brand
    {
        public string Brand { get; set; }
        public string Brand_description { get; set; }
        public string Parent_Brand { get; set; }
        public Nullable<bool> Key_Brand { get; set; }
        public Nullable<bool> Contract_Brand { get; set; }
        public Nullable<double> Bottle_size { get; set; }
        public Nullable<double> Bott___9L_case { get; set; }
        public Nullable<double> NSV___9L_case { get; set; }
        public Nullable<double> GP___9L_case { get; set; }
        public Nullable<double> Target_RPB { get; set; }
        public Nullable<double> Overachieve_RPB { get; set; }
        public Nullable<double> Gold_RPB { get; set; }
        public Nullable<double> Silver_RPB { get; set; }
        public Nullable<double> Bronze_RPB { get; set; }
        public Nullable<double> Gold_TM { get; set; }
        public Nullable<double> Silver_TM { get; set; }
        public Nullable<double> Bronze_TM { get; set; }
        public Nullable<double> Gold_BB_min { get; set; }
        public Nullable<double> Silver_BB_min { get; set; }
        public Nullable<double> Bronze_BB_min { get; set; }
        public string BrandAlt { get; set; }
        public string Prodnumber { get; set; }
        public Nullable<int> PackingSpec { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> SizeRatio { get; set; }
        public Nullable<decimal> COGs { get; set; }
        public Nullable<decimal> FG_Cost { get; set; }
        public Nullable<bool> OrderForm { get; set; }
        public Nullable<decimal> NaturalCases { get; set; }
    }
}
