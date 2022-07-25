using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Models.Entities;

namespace TestTask.Models.Intefaces
{
    public interface IFormPostRepository
    {
        void AddOrder(FormPost form);
        Task<IEnumerable<FormPost>> GetAllOrder();
        FormPost GetOrderOnId(int id);

    }
}
