using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiUygulaması
{
    public class Directory
    {
        private string name;
        private string surname;
        private string number;

        public Directory(string name = "null", string surname = "null", string number = "null")
        {
            this.name = name;
            this.surname = surname;
            this.number = number;
        }

        public string Name
        {
            get
            {
                if (name == null || name == "")
                    return "null";
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                if (surname == null || surname == "")
                    return "null";
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public string Number
        {
            get
            {
                if (number == null || number == "")
                    return "null";
                return number;
            }
            set
            {
                number = value;
            }
        }
    }
}
