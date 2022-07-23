using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Models.DataBaseContext;
using TestTask.Models.Entities;
using TestTask.Models.Intefaces;

namespace TestTask.Models.Repositories
{
    public class FormPostRepository : IFormPostRepository
    {
        private readonly Context _context;
        public FormPostRepository(Context context)
        {
            _context = context;
        }

        public void AddOrder(FormPost form)
        {
            if(form.Id == default)
            {
                _context.Entry(form).State = EntityState.Added;
            }
            else
            {
                _context.Entry(form).State = EntityState.Modified;
            }
            _context.SaveChanges();
        }

        public void RemoveOrder(int id)
        {
            _context.FormPost.Remove(new FormPost() { Id = id });
            _context.SaveChanges();
        }

        public async Task<IEnumerable<FormPost>> GetAllOrder()
        {
           IEnumerable<FormPost> OrderList = await _context.FormPost.ToListAsync();
           return OrderList; 
        } 

        public FormPost GetOrderOnId(int id)
        {
            return _context.FormPost.FirstOrDefault(i => i.Id == id);
        }
    }
}
