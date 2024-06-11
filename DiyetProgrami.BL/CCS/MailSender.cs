using DiyetProgrami.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.BL.CCS
{
    public class MailSender : IMailSender
    {
        public async Task<string> SendEmailAsync(UserViewModel userViewModel,string psw)
        {
            try
            {
                // Bu benim uygulama için açtığım mail. Onay kodu bu mail üzerinden çıkıcak.
                var smtpServer = "smtp-mail.outlook.com";
                var smtpPort = 587;
                var fromMail = "fitlifetracker@outlook.com";
                var password = "Test123456789!";

                // Bu kısım onay kodunu alıcak olan, uygulamaya kayıt olan user, kullanıcının mailiyle ilgili kısım
                var toMail = userViewModel.Email;
                string verificationCode = GenerateVerificationCode();
                userViewModel.VerificationCode = verificationCode;
                var subject = "Email Verification";
                var body = $"Your verification code is: {verificationCode}";

                // SMTP istemcisi oluşturulur ve mail bu kısımdan sonra istenilen şekilde gönderilir.
                var client = new SmtpClient(smtpServer, smtpPort)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential(fromMail, password)
                };

                var message = new MailMessage(fromMail, toMail, subject, body);
                await client.SendMailAsync(message);
                return verificationCode;
            }
            catch (Exception ex)
            {
                return string.Empty;
                //throw new Exception($"Failed to send email. Error: {ex.Message}");
            }
        }

        private static string GenerateVerificationCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }
    }
}
