//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class custloginfo
    {
        public int logid { get; set; }
        public string custemail { get; set; }
        public string custname { get; set; }
        public string logstatus { get; set; }
        public Nullable<int> userid { get; set; }
        public string descroption { get; set; }
    
        public virtual userinfo userinfo { get; set; }
    }
}
