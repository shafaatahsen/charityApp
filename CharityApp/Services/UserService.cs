using System;
using System.Collections.Generic;
using System.Linq;
using CharityApp.Models;


namespace CharityApp.Services
{
    public class UserService
    {
        private static List<User> users = new List<User>();
        private static int Count = 1;

        public List<User> GetAll()
        {
            return users;
        }

        public User GetById(int id)
        {
            return users.Where(user => user.Id == id).FirstOrDefault();
        }

        public User Create(User user)
        {
            user.Id = Count++;
            users.Add(user);
            return user;
        }

        public void Update(int id, User user)
        {
            User found = users.Where(user => user.Id == id).FirstOrDefault();
            found.FirstName = user.FirstName;
            found.LastName = user.LastName;
            found.Email = user.Email;
        }

        public void Delete(int id)
        {
            users.RemoveAll(user => user.Id == id);
        }

    }
}