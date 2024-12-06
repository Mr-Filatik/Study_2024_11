using Microsoft.EntityFrameworkCore;
using Study_2024_11.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Database.MainDatabase.Repositories
{
    public class MessageRepository
    {
        private readonly MainDbContext _context;

        public MessageRepository(MainDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Создание сообщения.
        /// </summary>
        /// <param name="entity"></param>
        public void Create(Message entity)
        {
            _context.Messages.Add(entity);
            _context.SaveChanges();
        }

        public Message? Get(int id)
        {
            return _context.Messages
                .Include(x => x.Producer)
                .FirstOrDefault(e => e.UniqId == id);
        }

        public IEnumerable<Message> GetRange(Func<Message, bool> predicate, int take, int skip = 0)
        {
            return _context.Messages
                .Include(x => x.Producer)
                .Where(predicate)
                .Skip(skip)
                .Take(take);
        }

        public IEnumerable<Message> GetRangeByIds(IEnumerable<int> ids, int take, int skip = 0)
        {
            return _context.Messages
                .Include(x => x.Producer)
                .Where(x => ids.Contains(x.UniqId))
                .Skip(skip)
                .Take(take);
        }

        public bool Update(Message entity)
        {
            try
            {
                _context.Messages.Update(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Delete(Message entity)
        {
            _context.Messages.Remove(entity);
            _context.SaveChanges();
        }
    }
}
