using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace Notification.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VerifyEmailController : ControllerBase
    {
        [HttpGet()]
        public IActionResult VerifyEmail()
        {
            SmtpClient smtpClient = new SmtpClient("localhost", 1025);
            smtpClient.SendMailAsync(new MailMessage
            {
                From = new MailAddress("test@example.com"),
                Subject = "Test Email",
                Body = "This is a test email.",
                To = { new MailAddress("test@example.com") }
            });
            return Ok();
        }
    }
}