using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobocopyGUI
{
    public partial class PathDirection : UserControl
    {
        public PathDirection()
        {
            InitializeComponent();
        }

        private void srcBrowse_button_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            srcPath_textBox.Text = folderBrowserDialog1.SelectedPath.ToString();
        }

        private void dstBrowse_button_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            dstPath_textBox.Text = folderBrowserDialog1.SelectedPath.ToString();
        }

        private void run_button_Click(object sender, EventArgs e)
        {
            MainCommand robocopy = new MainCommand("robocopy ");
            ComOption copyOption = new ComOption();
            ComOption excOption = new ComOption();
            ComOption logOption = new ComOption();

            copyOption.AddSwitch("/E /DCOPY:T /MIR");
            excOption.AddSwitch("/XF : F: ");
            logOption.AddSwitch("/NFL /DTS ");

            copyOption.AddOption(robocopy);
            excOption.AddOption(copyOption);
            logOption.AddOption(excOption);

            MessageBox.Show(logOption.BuildCommand().ToString());

        }
    }
}
