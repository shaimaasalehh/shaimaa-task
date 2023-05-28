using System.Net.Mail;
using System.Net;
using System.ComponentModel.DataAnnotations;

namespace testtask.Models;

using MimeKit;
using System.Threading.Tasks;
using Task.Models;

public class Emailsender : IEmailSender
{
    public  Task SendEmailAsync(string email, string subject, string message)
    {
      

        
        var client = new SmtpClient("smtp.gmail.com", 587)
        {
            EnableSsl = true,
            UseDefaultCredentials = true,
            Credentials = new NetworkCredential("shimaahakeem1998@gmail.com", "oimktutszauivsqm")
        };

        return client.SendMailAsync(
            new MailMessage(from: "shimaahakeem1998@gmail.com",
                            to: email,
                            subject,
                            message
                            ));

       
    }
}
