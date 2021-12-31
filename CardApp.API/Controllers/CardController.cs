using CardApp.BuisnessLayer.Contracts;
using CardApp.BuisnessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CardApp.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private static readonly CardDto[] Summaries = new[]
        {
            new CardDto{Email="Freezing", Name = "Freezing", PhoneNumber = "Freezing"}, new CardDto{Email="Wet", Name = "Wet", PhoneNumber = "Wet"}
        };
        private ICardService cardService { get; set; }
        public CardController(ICardService cardService)
        {
            this.cardService = cardService ?? throw new ArgumentNullException();
        }
        [HttpGet(Name = "GetCards")]
        public Task<IEnumerable<CardDto>> GetCards()
        {
            //return Summaries;
            return this.cardService.GetCards();
        }

        [HttpPost(Name = "AddCard")]
        public Task<string> AddCard([FromBody]CardDto card)
        {
            return cardService.AddCard(card);
        }
    }
}
