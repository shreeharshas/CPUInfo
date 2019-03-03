using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace CPU_Profile_Display
{
    public class CPUReader
    {
        public object GetCPUInfo(CPUProps requiredProp) {

            var searcher = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (var item in searcher.Get())
            {
                return item[requiredProp.ToString()];
            }

            //uint currentsp, Maxsp;
            //using (ManagementObject Mo = new ManagementObject("Win32_Processor.DeviceID='CPU0'"))
            //    {
            //        currentsp = (uint)(Mo["CurrentClockSpeed"]);
            //        Maxsp = (uint)(Mo["MaxClockSpeed"]);
            //    }

            return null;
        }
    }
}
