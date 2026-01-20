using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Job_Management_System_Kamao.Model;

namespace Online_Job_Management_System_Kamao.Controller
{
    public class EmailSenderController
    {
        public string GenerateOtp()
        {
            EmailSender emailSender = new EmailSender();
            return emailSender.GenerateOtp();
        }
        public void SendOtpToEmail(string email, string otp)
        {
            EmailSender emailSender = new EmailSender();
            emailSender.SendOtpToEmail(email, otp);
        }
        public void SendIdPasswordToEmail(string email, string userid, string password)
        {
            EmailSender emailSender = new EmailSender();
            emailSender.SendIdPasswordToEmail(email, userid, password);
        }
    }
}
