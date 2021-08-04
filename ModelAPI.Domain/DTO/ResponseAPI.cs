using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelAPI.Domain.DTO
{
    public class ResponseAPI
    {
        /// <summary>
        /// Information message returned by the service
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        ///Object returned by service
        /// </summary>
        public object Object { get; set; }
    }
}
