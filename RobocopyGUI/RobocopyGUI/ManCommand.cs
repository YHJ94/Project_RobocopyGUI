using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RobocopyGUI
{
    class MainCommand : Command
    {
        private StringBuilder mCom;

        public MainCommand(string line)
        {
            mCom = new StringBuilder();
            mCom.Append(line);
        }

        public override StringBuilder BuildCommand()
        {
            return mCom;
        }
    }
}
