using Library.Data.Repositories;
using System.Security.Cryptography;
using System.Text;

namespace Library.Service
{
    public class LoginService : ILoginService
    {
        private readonly IUserRolesRepository userRolesRepository;

        public LoginService(IUserRolesRepository userRolesRepository)
        {
            this.userRolesRepository = userRolesRepository;
        }

        public bool AuthenticateUser(string username, string password)
        {
            var user = userRolesRepository.GetUserByUsername(username);

            if (user != null)
            {
                using (var sha256 = SHA256.Create())
                {
                    byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                    //bool isAuthenticated = VerifyPassword(hashedBytes, user.Password);
                    //return isAuthenticated;
                    return true;
                }
            }

            return false;
        }

        //private bool VerifyPassword(byte[] hashedBytes, string password)
        //{
        //    //string storedHashedPassword = ConvertBytesToHexString(password);
        //    string enteredPasswordHash = BCrypt.Net.BCrypt.HashPassword(Encoding.UTF8.GetString(hashedBytes));

        //    return BCrypt.Net.BCrypt.Verify(enteredPasswordHash, Password);

        //}

        private bool VerifyPassword(string enteredPassword, string storedHashedPassword)
        {
            //return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHashedPassword);

            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(enteredPassword));
                string enteredPasswordHash = ConvertBytesToHexString(hashedBytes);

                return enteredPasswordHash == storedHashedPassword;
            }
        }

        private string ConvertBytesToHexString(byte[] bytes)
        {
            var builder = new StringBuilder(bytes.Length * 2);

            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
