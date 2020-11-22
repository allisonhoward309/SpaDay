using System;
using Microsoft.AspNetCore.Mvc;

namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; }

        public User()
        {
            Date = DateTime.Now;
        }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
            Date = DateTime.Now;
        }
    }
}
