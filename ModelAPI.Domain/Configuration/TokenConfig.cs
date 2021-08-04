using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelAPI.Domain.Configuration
{
    public class TokenConfig
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }

    }
}
