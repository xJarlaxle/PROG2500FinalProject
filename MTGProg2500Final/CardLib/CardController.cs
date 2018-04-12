using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public class CardController
    {
        private string _baseUrl = "https://api.magicthegathering.io/v1/";
        public async Task<List<CardModel>> GetCardListAsync(string name = "")
        {
            var escapedName = Uri.EscapeDataString(name);
            var url = String.Format("{0}cards?name={1}", _baseUrl, escapedName);
            var json = await new HttpClient().GetStringAsync(url);
            var cardList = JsonConvert.DeserializeObject<CardList>(json).cards;
            return cardList;
        }

        public async Task<List<SetModel>> GetSetListAsync(string name = "")
        {
            var escapedName = Uri.EscapeDataString(name);
            var url = String.Format("{0}sets?name={1}", _baseUrl, escapedName);
            var json = await new HttpClient().GetStringAsync(url);
            var setList = JsonConvert.DeserializeObject<SetList>(json).sets;
            return setList;
        }

        public async Task<List<CardModel>> GetBooster(string setCode)
        {
            var escapedSetCode = Uri.EscapeDataString(setCode);
            var url = String.Format("{0}sets/{1}/booster", _baseUrl, escapedSetCode);
            var json = await new HttpClient().GetStringAsync(url);
            var cardList = JsonConvert.DeserializeObject<CardList>(json).cards;
            return cardList;
        }

    }
}
