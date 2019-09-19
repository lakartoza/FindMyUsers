using FindMyUsers.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FindMyUsers.Repository
{
    public class UsersRepository : IUsersRepository
    {
        protected UsersContext _context { get; set; }

        public UsersRepository(UsersContext repositoryContext)
        {
            this._context = repositoryContext;
        }

        public IQueryable<User> FindAll()
        {
            var users = from u in _context.Users
                        select u;

            return users;
        }

        public IQueryable<User> FindByCondition(string first, string last, string interests)
        {

            var users = from u in _context.Users
                        select u;


            if (!string.IsNullOrEmpty(first))
            {
                users = users.Where((User user) => user.First.Contains(first));
            }
            if (!string.IsNullOrEmpty(last))
            {
                users = users.Where((User user) => user.Last.Contains(last));
            }
            if (!string.IsNullOrEmpty(interests))
            {
                users = users.Where((User user) => user.Interests.Contains(interests));
            }

            return users;
        }

        public IQueryable<User> FindById(long id)
        {
            var user = from u in _context.Users
                       where u.Id == id
                       select u;
                
            return user;

        }

        public async Task<User> Create(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

    }
}
