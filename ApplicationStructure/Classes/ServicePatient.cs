using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;

namespace ApplicationStructure.Classes
{
    public class ServicePatient
    {

        public List<Patient> pat;

        public ServicePatient()
        {
            pat = new List<Patient>();
        }

        Random r = new Random();
        public void GeneratePatient()
        {
            GenOrganiz go = new GenOrganiz();
            for (int i = 0; i < 20; i++)
            {
                Generator g = new Generator();
                Patient p = new Patient();
                p.FullName = g.GenerateDefault((Gender)r.Next(0, 2));
                p.IIN = r.Next(100000000, 900000000).ToString();
                p.MedOrganization = go.med[r.Next(0, go.med.Count)];
            }
        }

        public Patient SearchPatient(string name)
        {
            foreach (Patient item in pat)
            {
                if(item.FullName.Contains(name))
                    return item;
            }

            return null;
        }


    }
}
