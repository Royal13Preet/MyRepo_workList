﻿using Secureuser.DataAccess.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secureuser.DataAccess.Repositories
{
    public interface IUserRepository
    {
        /// <summary>
        /// For admin and user login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        User GetUserByUsernameAndPassword(string username, string password);
        /// <summary>
        /// Get single username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public User GetUserByUsername(string username);

        /// <summary>
        /// creating the user
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(User user);
        /// <summary>
        /// deleting the user
        /// </summary>
        /// <param name="user"></param>
        public void RemoveUser(User user);
        /// <summary>
        /// Saving the data
        /// </summary>
       public void Save();
        /// <summary>
        /// getting all user
        /// </summary>
        /// <returns></returns>
        List<User> GetAllUsers();
    }

    }

