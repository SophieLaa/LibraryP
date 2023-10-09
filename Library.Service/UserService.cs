using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Library.Data.Repositories;
using Library.Web;

namespace Library.Service
{
    public class UserService : IUserService
    {
        private readonly IUsersRepository _userRepository;

        public UserService(IUsersRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool ValidateUser(string username, string password)
        {
            var user = _userRepository.GetUserByUserName(username);

            if (user != null && user.Password == password)
            {
                return true;
            }

            return false;
        }

        public bool UserExists(string username)
        {
            return _userRepository.GetUserByUserName(username) != null;
        }
        public bool RegisterUser(User model)
        {
            try
            {
                if (_userRepository.GetUserByUserName(model.UserName) != null)
                {
                    return false;
                }

                string verificationCode = GenerateVerificationCode();
                model.VerificationCode = verificationCode;

                _userRepository.AddUser(model);
                _userRepository.Save();

                SendVerificationEmail(model);

                return true;
            }
            catch (Exception ex)
            {
               
                Console.WriteLine($"An error occurred during user registration: {ex.Message}");

                
                return false;
            }
        }

       

        private string GenerateVerificationCode()
        {
            return Guid.NewGuid().ToString();
        }

        private void SendVerificationEmail(User user)
        {
            string verificationLink = $"https://example.com/verify?code={user.VerificationCode}";

            string subject = "Email Verification";
            string body = $"Dear {user.UserName},\n\n"
                + "Thank you for registering. Please click on the following link to verify your email:\n"
                + $"{verificationLink}";

            using (SmtpClient client = new SmtpClient("smtp.example.com", 587))
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("your-email@example.com", "your-password");

                MailMessage message = new MailMessage();
                message.From = new MailAddress("yourmail");
                message.To.Add(new MailAddress(user.Email));
                message.Subject = subject;
                message.Body = body;

                client.Send(message);
            }
        }

        public IEnumerable<User> GetUsersInRole(string role)
        {
            var usersInRole = _userRepository.GetUsersInRole(role);
            yield return (User)usersInRole;
        }


        IEnumerable<object> IUserService.GetUsersInRole(string v)
        {
            throw new NotImplementedException();
        }
    }
}   
        