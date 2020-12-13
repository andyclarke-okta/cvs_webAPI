using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI_allDemo_core31.Models
{
    public class IdProofResponse
    {
        public bool IsApproved { get; set; }
    }

    public class IdProofRequest
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string customId { get; set; }
    }

}
