﻿using PracticeAPI.Entities;

namespace PracticeAPI.Repositories
{
    public interface IUserRepository
    {
        void Register(User user);
        User Login(string email, string pwd);

        void EditProfile(User user);

        void ChangePassword(string userId, string oldpwd, string newpwd);
    }
}
