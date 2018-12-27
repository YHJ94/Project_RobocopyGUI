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
            ComOption test = new ComOption();

            test.AddSwitch("/E");
            test.AddSwitch("/DCOPY:T");

            MessageBox.Show(test.GetOption());

            test.removeSwitch("/E");

            MessageBox.Show(test.GetOption());
        }
    }
}
