using ProjekatASP.Application.DataTransfer.Email;
using ProjekatASP.Application.Email;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Implementation.Email
{
	public class SmtpEmailSender : IEmailSender
	{
		public void SendEmail(SendEmailDto dto)
		{
			var smtp = new SmtpClient
			{
				Host = "smtp.gmail.com",
				Port = 587,
				EnableSsl = true,
				DeliveryMethod = SmtpDeliveryMethod.Network,
				UseDefaultCredentials = false,
				Credentials = new NetworkCredential("aspblogmejl@gmail.com", "Sifra12345!")
			};

			var message = new MailMessage("aspblogmejl@gmail.com", dto.SendTo);
			message.Subject = dto.Subject;
			message.Body = dto.Content;
			message.IsBodyHtml = true;
			smtp.Send(message);
		}
	}
}
