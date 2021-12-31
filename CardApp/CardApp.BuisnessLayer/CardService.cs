using CardApp.BuisnessLayer.Contracts;
using CardApp.BuisnessLayer.Models;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApp.BuisnessLayer
{
    public class CardService : ICardService
    {
        private readonly IDataAccess dataAccess;
        public CardService(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }
        public Task<string> AddCard(CardDto card)
        {
            var cardDbo = new Card
            {
                Email = card.Email,
                Name = card.Name,
                Number = card.PhoneNumber
            };
            return this.dataAccess.AddCard(cardDbo);
        }

        public async Task<IEnumerable<CardDto>> GetCards()
        {
            var cards = await this.dataAccess.GetCards();
            return cards.Select(x => new CardDto
            {
                Email = x.Email,
                Name=x.Name,
                PhoneNumber =x.Number
            }).ToList(); 
        }
    }
}
