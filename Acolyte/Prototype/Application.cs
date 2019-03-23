using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Diagnostics;

namespace Prototype
{
    class Application : Entities.Application
    {
       public Application(Process process)
        {
            this.Name = process.ProcessName.ToString();
        }

        public string returnName()
        {
            return Name;
        }
    }
}
