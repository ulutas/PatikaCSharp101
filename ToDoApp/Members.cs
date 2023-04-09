using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class Member
    {

        private Dictionary<int, string> teamMembers;

        public Dictionary<int, string> TeamMembers { get => teamMembers; set => teamMembers = value; }

        public Member()
        {
            teamMembers = new Dictionary<int, string>();
        }


    }
}
