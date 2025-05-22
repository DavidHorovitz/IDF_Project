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
        public void AddTNewTeroris(string enterTerrorist)
        {
            //Terrorist a = new Terrorist(enterTerrorist);
            //a = a.ToString;
            terroristsDictionary.Add("name: ", enterTerrorist);
        }
    }
}
