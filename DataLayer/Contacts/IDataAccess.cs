using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDataAccess
    {
        Task<string> AddCard(Card card);
        Task<IEnumerable<Card>> GetCards();
    }
}
