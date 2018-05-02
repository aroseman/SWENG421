using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem
{
    interface HospitalPersonFactoryIF
    {
        //Change the return type here so it fits with the structure better.
        HospitalPersonFactoryIF Enroll(string mystring);
    }
}
