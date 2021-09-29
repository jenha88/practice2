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
        public string Image { get; set; }

        public Contact()
        {
            Firstname = "";
            Lastname = "";
            Email = "";
            Image = "";
        }

        public Contact(string data)
        {
            var files = data.Split('|');
            Firstname = files[1];
            Lastname = files[2];
            Email = files[3];
            Image = files[4];

        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
            
        }
    }
}
