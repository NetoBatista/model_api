﻿using Model.Domain.Interfaces.Repository;

namespace Model.Infra.Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public bool Add(string userName)
        {
            return true;
        }

        public bool Delete(string userId)
        {
            return true;
        }

        public string Get(string userId)
        {
            return "user";
        }

        public bool Update(string userName, string userId)
        {
            return true;
        }
    }
}
