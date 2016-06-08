using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogAnalyser
{
    public class CallLogCriteria
    {
        public string FromMobileNumber { get; set; }
        public string ToMobileNumber { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public string TowerId { get; set; }
        public string IMEINumber { get; set; }

        public CallLogCriteria()
        {
            this.FromMobileNumber = null;
            this.ToMobileNumber = null;
            this.FromDate = null;
            this.ToDate = null;
            this.FromTime = null;
            this.ToTime = null;
            this.TowerId = null;
            this.IMEINumber = null;
        }
    }
}
