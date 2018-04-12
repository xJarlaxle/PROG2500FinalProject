using CardLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardSearch
{
    public class MainPageData : INotifyPropertyChanged
    {
        private CardModel card;
        public CardModel Card
        {
            get => card;
            set
            {
                card = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Card"));
            }
        }

        public CardController controller;

        public List<CardModel> cardList;
        public ObservableCollection<CardModel> ViewCardList { get; set; }

        public String Text { get; set; } = "";

        public event PropertyChangedEventHandler PropertyChanged;

        public SearchCommand cmd_search { get; set; }

        public MainPageData()
        {
            controller = new CardController();
            cardList = new List<CardModel>();
            ViewCardList = new ObservableCollection<CardModel>();
            cmd_search = new SearchCommand(this);
        }

        public void RefreshCards()
        {
            ViewCardList.Clear();

            foreach (CardModel card in cardList)
            {
                ViewCardList.Add(card);
            }
        }

        public void OnNavigatedTo(object param)
        {
            if (param.GetType() != ViewCardList.GetType()) return;
            var list = (ObservableCollection<CardModel>)param;

            ViewCardList.Clear();
            cardList.Clear();

            foreach(var card in list)
            {
                cardList.Add(card);
                ViewCardList.Add(card);
            }

        }

    }
}
