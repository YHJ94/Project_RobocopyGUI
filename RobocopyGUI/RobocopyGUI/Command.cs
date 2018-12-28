using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobocopyGUI
{
    public abstract class Command
    {
        public abstract StringBuilder BuildCommand();
    }
}
