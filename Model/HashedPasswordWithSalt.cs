using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HashedPasswordWithSalt
    {

        public string HashedPassword { get; set; }

        public string Salt { get; set; }

        public HashedPasswordWithSalt(string salt, string hashedPassword)
        {
            Salt = salt;
            HashedPassword = hashedPassword;

        }
    }
}
