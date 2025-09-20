using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBS
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool _identity;
        public bool Identity
        {
            set
            {
                if (value == true)
                {
                    _identity = value;
                }
            }
            get
            {
                return _identity;
            }
        }

        public Guid id { get; set; }
        public Client(string Name, string Email, bool Identity,Guid id)
        {
            this.Name = Name;
            this.Email = Email;
            this.Identity = Identity;
            this.id = id;
        }
    }
}
