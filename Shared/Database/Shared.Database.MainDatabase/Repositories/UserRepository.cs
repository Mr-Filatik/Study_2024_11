using Microsoft.EntityFrameworkCore;
using Study_2024_11.Shared.Entities;

namespace Shared.Database.MainDatabase.Repositories
{
    public class UserRepository
    {
        private readonly MainDbContext _context;

        public UserRepository(MainDbContext context)
        {
            _context = context;
        }

        public void Create(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public User? Get(int id)
        {
            var entity = _context.Users.AsNoTracking().FirstOrDefault(e => e.Id == id);
            if (entity != null)
            {
                entity.PasswordHash = string.Empty;
            }
            return entity;
        }

        public User? Get(string email)
        {
            return _context.Users.FirstOrDefault(e => e.Email == email);
        }

        public void Update(User entity)
        {
            _context.Users.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(User entity)
        {
            _context.Users.Remove(entity);
            _context.SaveChanges();
        }
    }
}
