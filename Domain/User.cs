using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User: Entity<int>
    {
        public string Password { get; set; }
        public string Email { get; set; }
        
    }
}
