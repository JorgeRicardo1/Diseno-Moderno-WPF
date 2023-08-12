﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Diseno_Moderno_WPF.Models
{
    internal interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential);
        void Add(UserModel userModel);
        void Edit(UserModel userModel);
        void Remove(int id);
        UserModel GetById(int id);
        UserModel GetByUserName(string username);
        IEnumerable<UserModel> GetAll();
        //...

    }
}
