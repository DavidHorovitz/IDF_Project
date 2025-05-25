using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IDF_Project
{
    internal class Hamas
    {
        Terrorist Terrorist;
        string YearOfEstablishment = "1987";
        string HeadOfOrganization = "Yahya Sanwar";

        public Dictionary <string,string> terroristsDictionary = new Dictionary <string,string> ();

        public Hamas(string a, string b)
        {
            a = YearOfEstablishment;
            b = HeadOfOrganization;
            Console.WriteLine($"Year Of Establishment: {YearOfEstablishment}\n "+
            $"Head Of Organization; {HeadOfOrganization}");
        }
        public void AddTNewTeroris()
        {
            for (int i = 1; i < 11; i++)
            {
                terroristsDictionary.Add("name" + i, "mehabel num " + i);
            }

            foreach (var value in terroristsDictionary.Values)
            {
                Console.WriteLine(value);
            }
        }

    }
}
