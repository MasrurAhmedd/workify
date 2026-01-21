using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Job_Management_System_Kamao.Model
{
    public class EmailSender
    {
        public string GenerateOtp()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
            //Returns Random number
        }

        public void SendOtpToEmail(string email, string otp)
        {
            try
            {
                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.Credentials = new System.Net.NetworkCredential("rafit2828@gmail.com", "zdqu rkwv uioz jfef");
                    smtpClient.EnableSsl = true;

                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress("rafit2828@gmail.com"),
                        Subject = "Your OTP Code",
                        Body = $"Your OTP code is: {otp}"
                    };
                    mail.To.Add(email);

                    smtpClient.Send(mail);
                    Console.WriteLine("OTP sent to your email successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send OTP. Error" + ex);
            }
        }
        public void SendIdPasswordToEmail(string email, string userid, string password)
        {
            try
            {
                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.Credentials = new System.Net.NetworkCredential("rafit2828@gmail.com", "zdqu rkwv uioz jfef");
                    smtpClient.EnableSsl = true;

                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress("rafit2828@gmail.com"),
                        Subject = "Your userId and Password ",
                        Body = $"Your User Id is: {userid}  and Password is: {password} .Please do not share with anyone "
                    };
                    mail.To.Add(email);

                    smtpClient.Send(mail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send UserId and Password. Error: {ex.Message}");
            }
        }
    }
}
