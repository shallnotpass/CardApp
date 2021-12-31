using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataAccess : IDataAccess
    {
        private readonly ApplicationContext dataContext;

        public DataAccess(ApplicationContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task<string> AddCard(Card card)
        {
            this.dataContext.Cards.Add(card);
            await this.dataContext.SaveChangesAsync();
            return "200";
        }
        public async Task<IEnumerable<Card>> GetCards()
        {
            return await dataContext.Cards.ToListAsync();
        }
    }
}
