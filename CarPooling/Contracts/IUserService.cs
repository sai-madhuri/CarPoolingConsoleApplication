﻿using CarPooling.Concerns;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarPooling.Contracts
{
    public interface IUserService
    {
        void AddUser(User user);

        User GetUser(string id);

        bool IsValidUser(string email, string password);

        bool IsExistingUser(string email);

        User GetUserByMail(string email);

        User UpdateUser(User user);
    }
}
