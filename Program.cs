using Online_Job_Management_System_Kamao.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;  
using System.Windows.Forms;   

namespace Online_Job_Management_System_Kamao
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       public  static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }  
    }  
}  
