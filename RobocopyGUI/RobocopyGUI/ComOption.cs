using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RobocopyGUI
{
    class ComOption
    {
        private StringBuilder optCom;
        private ComOption comOpt;

        public ComOption()
        {
            optCom = new StringBuilder();
        }

        public void AddOption(ComOption addComOpt)
        {
            comOpt = addComOpt;
        }

        public void AddSwitch(string _switch)
        {
            optCom.AppendFormat(" {0}", _switch);
        }

        public void removeSwitch(string _switch)
        {
            optCom.Replace(_switch, "");
        }

        public string GetOption()
        {
            return optCom.ToString();
        }
    }
}
