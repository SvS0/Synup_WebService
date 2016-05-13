//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace synup_webService
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public partial class TaskHistory
    {
        public string id_employee { get; set; }
        public string id_task { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> finishDate { get; set; }
        public string comment { get; set; }
        public byte isFinished { get; set; }
        public int id { get; set; }
    
        [JsonIgnore]
        public virtual Employee Employee { get; set; }
        [JsonIgnore]
        public virtual Task Task { get; set; }
    }
}
