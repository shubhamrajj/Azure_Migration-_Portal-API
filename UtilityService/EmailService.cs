using Microsoft.Extensions.Configuration;
using MimeKit;
using MailKit.Net.Smtp;
using ctrlspec.Models;
// Add other necessary using directives here

namespace ctrlspec.UtilityService
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration configuration)
        {
            _config = configuration;
        }

        public void SendEmail(EmailModel emailModel)
        {
            // Create a MimeMessage object
            var emailMessage = new MimeMessage();

            // Set the sender's email address
            var from = _config["EmailSettings:From"];
            emailMessage.From.Add(new MailboxAddress("AzureMigrationPortal", from));

            // Set the recipient's email address
            emailMessage.To.Add(new MailboxAddress(emailModel.To, emailModel.To));

            // Set the subject of the email
            emailMessage.Subject = emailModel.Subject;

            // Create an HTML body for the email
            //var bodyBuilder = new BodyBuilder();
            //bodyBuilder.HtmlBody = emailModel.Content;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = string.Format(emailModel.Content)

            };

            // Create an SMTP client and send the email
            using (var client = new SmtpClient())
            {
                try
                {
                    // Connect to the SMTP server using SSL
                    client.Connect(_config["EmailSettings:SmtpServer"], 465, true);

                    // Authenticate with the SMTP server
                    client.Authenticate(_config["EmailSettings:From"], _config["EmailSettings:Password"]);

                    // Send the email
                    client.Send(emailMessage);
                }
                catch (Exception ex)
                {
                    // Handle the exception, log the error, and take appropriate actions
                    Console.WriteLine("Error sending email: " + ex.Message);
                    throw;
                }
                finally
                {
                    // Disconnect from the SMTP server and dispose of the client
                    if (client.IsConnected)
                    {
                        client.Disconnect(true);
                        client.Dispose();
                    }
                }
            }
        }
    }
}
