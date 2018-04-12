using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardSearch
{
    public class SetPageData : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;
        public SetSearchButtonClick _ssbc { get; }
        public CardLib.CardController controller;

        public string Name { get; set; } = "This";
        public string Block { get; set; } = "is";
        public string Code { get; set; } = "a";
        public string GatherCode { get; set; } = "test";
        public string OldCode { get; set; } = "to";
        public string Rarity { get; set; } = "see";
        public string ReleaseDate { get; set; } = "if";
        public string Border { get; set; } = "the";
        public string Expansion { get; set; } = "text";
        public string OnlineOnly { get; set; } = "displays";

        
        

        public SetPageData() {
            _ssbc = new SetSearchButtonClick(this);
             controller = new CardLib.CardController();

        }

        
    }
}
