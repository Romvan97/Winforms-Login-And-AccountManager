using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employe
    {

        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Confirmation { get; private set; }    

        public Employe(string pLogin, string pPassword, string pConfirmation)
        {

            Login = pLogin;
            Password = pPassword;
            Confirmation = pConfirmation;


        }

        public Employe(string pLine)
        {

            string[] vs = pLine.Split(';');
            this.Login = vs[0];
            this.Password = vs[1];
            this.Confirmation = vs[2];
         
        }

    }
}
