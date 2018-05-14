using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationStructure.Classes
{
    public class Patient
    {
        public string FullName { get; set; }

        public string IIN { get; set; }

        public MedicalOrganization MedOrganization { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Name {FullName} IIN {IIN} MedOrg {MedOrganization}");
        }

    }
}
