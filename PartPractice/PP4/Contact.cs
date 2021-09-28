using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP4
{
    public class Contact
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public Contact()
        {
            Firstname = "";
            Lastname = "";
            Email = "";
        }

        public Contact(string data)
        {
            var files = data;
            Firstname = files[2];
            Lastname = files[3];
            Email = files[4];
        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
            
        }
    }
}
