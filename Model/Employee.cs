using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        int id;
        string email;
        string username;
        string firstName;
        string lastName;
        string passwordHash;
        string salt;

        public Employee(int id, string email, string username, string firstName, string lastName, string passwordHash, string salt)
        {
            this.id = id;
            this.email = email;
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.passwordHash = passwordHash;
            this.salt = salt;
        }
    }
}
