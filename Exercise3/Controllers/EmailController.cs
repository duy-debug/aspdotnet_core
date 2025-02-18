    using Exercise3.Models;
    using MailKit.Net.Smtp;
    using MimeKit;
    using Microsoft.AspNetCore.Mvc;
    using Exercise3.Models;
    using System.Net.Mail;

    namespace Exercise3.Controllers
    {
        public class EmailController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public IActionResult SendEmail(EmailModel model)
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        var message = new MimeMessage();
                        message.From.Add(new MailboxAddress("Người gửi", model.FromEmail));
                        message.To.Add(new MailboxAddress("Người nhận", model.ToEmail));
                        message.Subject = model.Subject;

                        message.Body = new TextPart("plain")
                        {
                            Text = model.Body
                        };

                        using (var client = new MailKit.Net.Smtp.SmtpClient())
                        {
                            client.Connect("smtp.gmail.com", 587, false);
                            client.Authenticate(model.FromEmail, model.Password);
                            client.Send(message);
                            client.Disconnect(true);
                        }

                        ViewBag.Message = "Gửi email thành công!";
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Message = "Lỗi gửi email: " + ex.Message;
                    }
                }
                return View("Index");
            }
        }
    }
