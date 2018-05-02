using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem
{
    class HospitalPersonFactory : HospitalPersonFactoryIF
    {
        //I know this does not compile. Hospital person would just be a proper person from the hospital
        public HospitalPerson Enroll(string type)
        {
            try
            {
                HospitalPerson newHospotalPerson = Activator.CreateInstance(null, "HospitalSystem." + type);
                return newHospotalPerson;
            }
            catch (System.Exception exc1)
            {
                Console.WriteLine("Exception: {0}", exc1.ToString());
            }
        }


    }
}
