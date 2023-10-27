using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {


        // public string FirstName; //field örneği

        // private string _firstName;

        // public string FirstName // FirstName çağırıldığında başına Mr. Gelmesini sağlayan kod.
        // {
        //     get { return "Mr." + _firstName; }
        //     set { _firstName = value; }
        // }

        public int Id { get; set; }
        public string FirstName { get; set; } //property örneği
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
