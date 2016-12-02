using System.Web.Mvc;
using KhachSan.Models;

namespace KhachSan.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            var model = new ContactModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                string smtpUserName = "viet220994@gmail.com";
                string smtpPassword = "royqmnnxqsokykka";
                string smtpHost = "smtp.gmail.com";
                int smtpPort = 25;

                string emailTo = "viet220994@gmail.com"; // Khi có liên hệ sẽ gửi về thư của mình
                string subject = model.Subject;
                string body = string.Format("Bạn vừa nhận được liên hệ từ: <b>{0}</b><br/>Email: {1}<br/>Nội dung: </br>{2}",
                    model.UserName, model.Email, model.Message);

                MailService service = new MailService();

                bool kq = service.Send(smtpUserName, smtpPassword, smtpHost, smtpPort,
                    emailTo, subject, body);

                if (kq) ModelState.AddModelError("", "Cảm ơn bạn đã liên hệ với chúng tôi.");
                else ModelState.AddModelError("", "Gửi tin nhắn thất bại, vui lòng thử lại.");
            }
            return View(model);
        }
    }
}