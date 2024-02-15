﻿using EstudandoAutenticacaoJWT.Models;
using System.Collections.Generic;
using System.Linq;

namespace EstudandoAutenticacaoJWT.Repositories
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "batman", Password = "batman", Role = "manager" });
            users.Add(new User { Id = 2, Username = "robin", Password = "robin", Role = "employee" });
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password.ToLower()).FirstOrDefault();
        }
    }
}
