using Microsoft.AspNetCore.Mvc;
using Task.data;
using Task.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using Castle.Core.Smtp;
using testtask.Models;
using Habanero.Util;
using System.Net.Mail;
using System.Net;
using System.ComponentModel.DataAnnotations;

using System.Threading.Tasks;

namespace Task.Controllers
{
    public class userController : Controller
    {
        private readonly Models.IEmailSender emailSender;

        public  userController(Models.IEmailSender emailSender)
        {
            this.emailSender = emailSender;
        }
        public async Task<IActionResult> Index()
        {
            await emailSender.SendEmailAsync("shimaahakeem1998@gmail.com", "subject", "message");

            return View();
        }
        public IActionResult newuser()
        {
            return View("newuser");
        }

      

    
    public void save(userDTO userDTO)
        {

            using (var context = new context())
            {
                var user = new user
                {
                    name = userDTO.name,
                    phone = userDTO.phone,
                    email = userDTO.email
                };

                context.Users.Add(user);
                context.SaveChanges();

                var selectedService = Request.Form["serviceName"].ToString();
                var selectedInterest = Request.Form["interestName"].ToString();

                
                var subject = "New User Registration";
                var message = $"Name: {userDTO.name}\nPhone: {userDTO.phone}\nEmail: {userDTO.email}\nService: {selectedService}\nInterest: {selectedInterest}";

                
                emailSender.SendEmailAsync(userDTO.email, subject, message);





            }
        }

        public IActionResult GetServices()
        {
            using (var context = new context())
            {
                var services = context.Services.Select(s => s.name).ToList();
                return Json(services);
            }
        }

        public IActionResult Gettime()
        {
            using (var context = new context())
            {
                var interested = context.Interested.Select(s => s.name).ToList();
                return Json(interested);
            }
        }
    }
}