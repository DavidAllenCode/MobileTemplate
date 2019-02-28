using System;
namespace MobileProject
{
    public class User
    {
        public User(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
