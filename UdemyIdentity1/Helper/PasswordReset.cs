using System.Net.Mail;

namespace UdemyIdentity.Helper
{
    public class PasswordReset
    {
        public static void PasswordResetSendEmail(string link)

        {
            MailMessage mail = new MailMessage();

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";

            mail.From = new MailAddress("emrecanyasar08@gmail.com");
            mail.To.Add("emrecansocial@outlook.com");
            mail.Subject = $"www.bıdıbı.com::Şifre sıfırlama";

            mail.Body = "<h2>Şifrenizi yenilemek için lütfen aşağıdaki linke tıklayınız.</h2><hr/>";
            mail.Body += $"<a href='{link}'>şifre yenileme linki</a>";
            mail.IsBodyHtml = true;
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential("emrecanyasar08@gmail.com", "gmessvsxikbtrcon");

            smtpClient.Send(mail);

            //MailMessage mail = new MailMessage();
            //mail.To.Add("emrecansocial@outlook.com");
            ////mail.To.Add("Another Email ID where you wanna send same email");
            //mail.From = new MailAddress("emrecanyasar1@outlook.com");
            //mail.Subject = "Inquiry";


            //mail.Body = "<h2>Şifrenizi yenilemek için lütfen aşağıdaki linke tıklayınız.</h2><hr/>";
            //mail.Body += $"<a href='{link}'>şifre yenileme linki</a>";
            ////gmessvsxikbtrcon

            //mail.IsBodyHtml = true;
            //SmtpClient smtp = new SmtpClient();
            //smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
            //smtp.Credentials = new System.Net.NetworkCredential
            //     ("emrecanyasar1@outlook.com", "qnyy3c3c");
            ////Or your Smtp Email ID and Password
            //smtp.EnableSsl = true;
            //smtp.Send(mail);
        }
    }
}
