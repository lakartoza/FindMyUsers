using FindMyUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FindMyUsers.Repository
{
    public interface IUsersRepository
    {
        IQueryable<User> FindAll();
        IQueryable<User> FindByCondition(string first, string last, string interests);
        IQueryable<User> FindById(long id);

        Task<User> Create(User user);
    }
}