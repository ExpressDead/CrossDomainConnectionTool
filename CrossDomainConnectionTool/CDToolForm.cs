using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSTest;
using System.IO;

namespace CrossDomainConnectionTool
{
    public partial class CDToolForm : Form
    {
        

        public CDToolForm()
        {
            InitializeComponent();
        }


        private void connectBtn_Click(object sender, EventArgs e)
        {
            string dom = domainTxt.Text;
            string user = userTxt.Text;
            string path; 
            //Check which version of SSMS the user want
            if (versionComboBox.Text.Equals("2012"))
            {
                path = Directory.Exists(@"C:/Program Files (x86)") ? @"C:\Program Files (x86)\Microsoft SQL Server\110\Tools\Binn\ManagementStudio\Ssms.exe" : @"C:\Program Files\Microsoft SQL Server\110\Tools\Binn\ManagementStudio\Ssms.exe";
            }else{
                    //if the user is after VS2008, make sure we are creating the correct file path based on the system bit size assuming default installtion of SQL Server
                    path = Directory.Exists(@"C:\Program Files (x86)") ? @"C:\Program Files (x86)\Microsoft SQL Server\100\Tools\Binn\VSShell\Common7\IDE\Ssms.exe" : @"C:\Program Files\Microsoft SQL Server\100\Tools\Binn\VSShell\Common7\IDE\Ssms.exe";
                }
                PSConnection ps = new PSConnection();
            ps.buildConnection(dom, user, path);
        }

       

    }
}
