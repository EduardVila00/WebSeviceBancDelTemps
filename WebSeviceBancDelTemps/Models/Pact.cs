//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace WebSeviceBancDelTemps.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Pact
    {
        public int Id_Pact { get; set; }
        public string date_created { get; set; }
        public string date_finished { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public int Posts_Id_Post { get; set; }
        public int Id_Author { get; set; }
        public int Id_NoAuthor { get; set; }
        public int hours { get; set; }
        [JsonIgnore]
        public virtual Post Post { get; set; }
    }
}
