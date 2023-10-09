
//using System;
//using System.Security.Cryptography;
//using Library.Data.Repositories;
//using System.Text;
//using System.Net.Mail;
//using System.Net;
//using Library.Web;

//namespace Library.Web.Services
//{
//    public class RegisterService
//    {
//        private readonly UsersRepository _usersRepository;

//        public RegisterService(UsersRepository userRepository)
//        {
//            _usersRepository = userRepository;
//        }

//        public bool RegisterUser(User model)
//        {
//            if (_usersRepository.GetUserByUsername(model.UserName) != null)
//            {
//                return false;
//            }

//            string verificationCode = GenerateVerificationCode();
//            //byte[] hashedPassword = GetHashedPassword(model.Password);

//            var newUser = new User
//            {
//                UserName = model.UserName,
//                Password = "",// hashedPassword,
//                Email = model.Email,
//                RegistrationDate = model.RegistrationDate,
//                VerificationCode = verificationCode
//            };

//            _usersRepository.AddUser(newUser);
//            _usersRepository.Save();

//            SendVerificationEmail(newUser);

//            return true;
//        }

//        //private byte[] GetHashedPassword(byte[] password)
//        //{
//        //    using (var sha256 = SHA256.Create())
//        //    {
//        //        return sha256.ComputeHash(password);
//        //    }
//        //}

//        private string GenerateVerificationCode()
//        {
//            string verificationCode = Guid.NewGuid().ToString();
//            return verificationCode;
//        }

//        private string GetHashedPassword(string password)
//        {
//            using (var sha256 = SHA256.Create())
//            {
//                byte[] bytes = Encoding.UTF8.GetBytes(password);
//                byte[] hash = sha256.ComputeHash(bytes);
//                return Convert.ToBase64String(hash);
//            }
//        }

//        private void SendVerificationEmail(User user)
//        {
//            string verificationLink = $"https://example.com/verify?code={user.VerificationCode}";

//            string subject = "Email Verification";
//            string body = $"Dear {user.UserName},\n\n"
//                + "Thank you for registering. Please click on the following link to verify your email:\n"
//                + $"{verificationLink}";

//            using (SmtpClient client = new SmtpClient("smtp.example.com", 587))
//            {
//                client.EnableSsl = true;
//                client.UseDefaultCredentials = false;
//                client.Credentials = new NetworkCredential("your-email@example.com", "your-password");

//                MailMessage message = new MailMessage();
//                message.From = new MailAddress("your-email@example.com");
//                message.To.Add(new MailAddress(user.Email));
//                message.Subject = subject;
//                message.Body = body;

//                client.Send(message);
//            }
//        }
//    }
//}
