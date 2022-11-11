using Model;
using System;
using System.Security.Cryptography;


namespace Logic
{
    public class LoginService
    {
        public EmployeeService employeeService;
        public LoginService()
        {
            employeeService= new EmployeeService();
        }


        public HashedPasswordWithSalt CreateHashedPasswordWithSalt(string password)
        {
            PasswordWithSaltHasher hasher = new PasswordWithSaltHasher();
            RNG rng = new RNG();
            byte[] saltBytes = rng.GenerateRandomCryptographicBytes(64);
            HashedPasswordWithSalt hashedPasswordWithSalt = hasher.HashWithSalt(password, 64, SHA512.Create(), saltBytes);
            return hashedPasswordWithSalt;
        }



        public bool CheckPasswordUsingHashedPassword(string password, Employee employee)
        {

            byte[] saltBytes = Convert.FromBase64String(employee.Salt);

            bool correctPassword = false;

            PasswordWithSaltHasher hasher = new PasswordWithSaltHasher();

            HashedPasswordWithSalt hashedPasswordWithSalt = hasher.HashWithSalt(password, 64, SHA512.Create(), saltBytes);


            if (hashedPasswordWithSalt.HashedPassword == employee.PasswordHash)
            {
                correctPassword = true;
            }
            return correctPassword;
        }

        public bool CheckUsernameAndPassword(string username, string password)
        {
            bool correctUsernameAndPassword = false;

            string logInFailedMessage = "Log in failed. Please check your username and password and try again.";

            if (username.Length == 0 || password.Length == 0)
            {
                throw new Exception(logInFailedMessage);
            }

            Employee employee = employeeService.GetByUsername(username);
            if (employee == null)
            {
                throw new Exception(logInFailedMessage);
            }

            if (CheckPasswordUsingHashedPassword(password, employee) == true)
            {
                correctUsernameAndPassword = true;
            }

            else { throw new Exception(logInFailedMessage); }


            return correctUsernameAndPassword;
        }
    }
}
