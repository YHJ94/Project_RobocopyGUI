using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RobocopyGUI
{
    class ComOption : Command
    {
        private StringBuilder comStr;
        private Command comOpt;

        public ComOption()
        {
            comStr = new StringBuilder();
        }

        public void AddOption(Command ComOpt)
        {
            this.comOpt = ComOpt;
        }

        public void AddSwitch(string _switch)
        {
            comStr.AppendFormat(" {0}", _switch);
        }

        public void removeSwitch(string _switch)
        {
            comStr.Replace(_switch, "");
        }

        public override StringBuilder BuildCommand()
        {
            StringBuilder sb = comOpt.BuildCommand();
            sb.Append(comStr);
            return sb;
        }
    }
}
