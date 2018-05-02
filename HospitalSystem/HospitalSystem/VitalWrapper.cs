using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem
{
    class VitalWrapper : VitalsIF
    {
        public VitalsIF lastVital;
        public VitalWrapper myWrapped;
        //holds the most recently added vital

        public VitalWrapper(VitalWrapper oldWrapped, VitalWrapper newVital)
        {
            // VitalWrapper temp = new HospitalSystem.VitalWrapper();
            oldWrapped.lastVital = newVital;
            oldWrapped.myWrapped = oldWrapped;

        }
        public VitalWrapper()
        {
        }
    }
}
