using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Account
    {
        public string link, user, pass;
        public Account(string _link, string _user, string _pass)
        {
            link = _link;
            user = _user;
            pass = _pass;
        }
    }
}
