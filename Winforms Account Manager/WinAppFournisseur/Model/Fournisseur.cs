using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fournisseur
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }      
        public string City { get; private set; }
        public string Postal { get; private set; }

        public string MailAddress { get; private set; }
        public bool InCommand { get; private set; }
        public DateTime? CreationDate { get; private set; }
        public DateTime? ModificationDate { get; private set; }



    }
}
