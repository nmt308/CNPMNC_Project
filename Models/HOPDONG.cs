//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNPMNC_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOPDONG
    {
        public int MAHD { get; set; }
        public string THOIHANHD { get; set; }
        public Nullable<int> MANV { get; set; }
        public string TENHD { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
