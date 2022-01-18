using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain.Response
{
    public class UserUpdateResponse
    {
        public bool Success { get; set; }
        public string User {  get; set; }
    }
}
