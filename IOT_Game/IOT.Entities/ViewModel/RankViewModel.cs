using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Entities.ViewModel
{
    [DataContract]
    public class RankViewModel
    {
        [DataMember]
        public int RankingID { get; set; }
        [DataMember]
        public Nullable<int> UserID { get; set; }
        [DataMember]
        public Nullable<int> PrizeId { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public int PrizeTotal { get; set; }
    }
} 
