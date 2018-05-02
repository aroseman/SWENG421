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
            if (String.Equals(type, "patient")
                {
                return new patient();
            }
            else if (String.Equals(type, "doctor"))
            {
                return new doctor();
            }
            else if (String.Equals(type, nurse))
            {
                return new nurse();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
