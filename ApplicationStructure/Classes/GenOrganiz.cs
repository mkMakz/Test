using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationStructure.Classes
{
    public enum Clinics { Cl1, Cl2, Cl3, Cl4, Cl5, Cl6 }
    public class GenOrganiz
    {
        Random r = new Random();
        public List<MedicalOrganization> med;

        public GenOrganiz()
        {
            med = new List<MedicalOrganization>();
        }

        public void GenerateOrganization()
        {

            for (int i = 0; i < 10; i++)
            {

                MedicalOrganization m = new MedicalOrganization();
                m.OrgName = ((Clinics)r.Next(0, 6)).ToString();
                m.Adress = "Street N";
                m.Phone = r.Next(1000000, 2000000).ToString();

                med.Add(m);

            }

        }


    }
}
