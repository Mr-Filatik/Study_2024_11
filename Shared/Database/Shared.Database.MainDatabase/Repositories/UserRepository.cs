using Microsoft.EntityFrameworkCore;
using Study_2024_11.Shared.Entities;
using System.Security.Cryptography;
using System.Text;

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
            PasswordHash(entity);
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public bool VerifyPassword(int id, string password)
        {
            var user = Get(id);
            if (user == null)
            {
                return false;
            }
            var pass = PasswordHashVerify(password, Convert.FromHexString(user.PasswordSalt));
            return user.PasswordHash == pass;
        }

        public User? Get(int id)
        {
            var entity = _context.Users.AsNoTracking().FirstOrDefault(e => e.Id == id);
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

        private void PasswordHash(User user)
        {
            string pass = user.PasswordHash;

            int keySize = 64;
            int iterations = 350000;
            HashAlgorithmName hashAlgoritm = HashAlgorithmName.SHA512;

            var salt = RandomNumberGenerator.GetBytes(keySize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(pass),
                salt,
                iterations,
                hashAlgoritm,
                keySize);

            user.PasswordHash = Convert.ToHexString(hash);
            user.PasswordSalt = Convert.ToHexString(salt);
        }

        private string PasswordHashVerify(string pass, byte[] salt)
        {
            int keySize = 64;
            int iterations = 350000;
            HashAlgorithmName hashAlgoritm = HashAlgorithmName.SHA512;

            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(pass),
                salt,
                iterations,
                hashAlgoritm,
                keySize);

            return Convert.ToHexString(hash);
        }
    }
}
