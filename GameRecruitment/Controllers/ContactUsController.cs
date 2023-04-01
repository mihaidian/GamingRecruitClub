using GameRecruitment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace GameRecruitment.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactUsModel vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msz = new MailMessage();
                    msz.From = new MailAddress(vm.Email);//Email which you are getting from contact us page 

                    msz.To.Add("mihaidian979@gmail.com");//Where mail will be sent 
                    msz.Subject = vm.Subject;
                    msz.Body = vm.Message;
                    SmtpClient smtp = new SmtpClient();

                    smtp.Host = "smtp.gmail.com";

                    smtp.Port = 587;

                    smtp.Credentials = new System.Net.NetworkCredential
                    ("mihaidian979@gmail.com", "nscihlfxwxmhdyep");

                    smtp.EnableSsl = true;

                    smtp.Send(msz);

                    ModelState.Clear();
                    ViewBag.Message ="Thank you for contacting us! We will send you a response ASAP via Email! ";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Sorry! There was a problem sending your message: {ex.Message}";
                }
            }

            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
