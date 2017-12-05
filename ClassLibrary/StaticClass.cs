using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class StaticClass
    {
        public static string StaticMetod(Person person)
        {
            StringBuilder str = new StringBuilder();
            str.Append(person.Id);
            str.Append(person.FirstName);
            str.Append(person.LastName);
            str.Append(person.Age);
            string strFinally = str.ToString();
            return strFinally;
        }
    }
}
