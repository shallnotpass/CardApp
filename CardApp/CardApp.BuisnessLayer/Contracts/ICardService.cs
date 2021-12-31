using CardApp.BuisnessLayer.Models;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApp.BuisnessLayer.Contracts
{
    public interface ICardService
    {
        Task<string> AddCard(CardDto card);
        Task<IEnumerable<CardDto>> GetCards();
    }
}
