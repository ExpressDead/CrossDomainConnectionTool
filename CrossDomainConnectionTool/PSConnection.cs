using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace PSTest
{
    class PSConnection
    {
        
        public void buildConnection(string domain, string user, string path)
        {
             //create a string with domain, username, and application file path
            string baseCall = "runas /netonly /user:";
            
            var callBuilder = string.Format(baseCall + "{0}\\{1} '{2}'",
                domain, 
                user, 
                path
                );

            //append the filepath/user info as an argument to Process.Start that calls powershell
            
             Process.Start("powershell.exe", callBuilder);
            
        }
    }
}
