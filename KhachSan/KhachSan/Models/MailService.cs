using System.Net;
using System.Net.Mail;
using System.Text;

namespace KhachSan.Models
{
    /// <summary>
    /// Email Service
    /// Class gửi mail
    /// </summary>
    public class MailService
    {
        ///<summary>
        /// Hàm thực thi gửi mail trong MVC
        /// </summary>
        /// <param name="smtpUserName">kienctn15@gmail.com</param>
        /// <param name="smtpPassword">optimus143</param>
        /// <param name="smtpHost">smtp.gmail.com</param>
        /// <param name="smtpPort">25</param>
        /// <param name="toEmail">Mail người nhận</param>
        /// <param name="topic">chủ đề</param>
        /// <param name="content">nội dung</param>
        /// <returns>True - Thành công/False - Thât bại</returns>
        public bool Send(string smtpUserName, string smtpPassword, string smtpHost, int smtpPort,
            string toEmail, string subject, string body)
        {
            try
            {
                using (var smtpClient = new SmtpClient())
                {
                    smtpClient.EnableSsl = true;
                    smtpClient.Host = smtpHost;
                    smtpClient.Port = smtpPort;
                    smtpClient.UseDefaultCredentials = true;
                    smtpClient.Credentials = new NetworkCredential(smtpUserName, smtpPassword);
                    var msg = new MailMessage
                    {
                        IsBodyHtml = true,
                        BodyEncoding = Encoding.UTF8,
                        From = new MailAddress(smtpUserName),
                        Subject = subject,
                        Body = body,
                        Priority = MailPriority.Normal,
                    };

                    msg.To.Add(toEmail);

                    smtpClient.Send(msg);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}