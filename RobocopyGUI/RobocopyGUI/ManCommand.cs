using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RobocopyGUI
{
    class ManCommand
    {
        private StringBuilder mCom;
        private ComOption opt;

        public ManCommand()
        {
            mCom = new StringBuilder();
        }

        public StringBuilder MCom
        {
            get
            {
                return mCom;
            }
        }

    }
}
