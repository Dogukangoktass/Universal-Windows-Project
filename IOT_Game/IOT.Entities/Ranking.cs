//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IOT.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Ranking
    {
        [DataMember]
        public int RankingID { get; set; }
        [DataMember]
        public Nullable<int> UserID { get; set; }
        [DataMember]
        public Nullable<int> PrizeId { get; set; }
    }
}
