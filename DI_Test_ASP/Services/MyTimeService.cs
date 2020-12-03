using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_Test_ASP.Services
{
    public class MyTimeService
    {
        public string Time { get; }

        public MyTimeService()
        {
            Time = System.DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
