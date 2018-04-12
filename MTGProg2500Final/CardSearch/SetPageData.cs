using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLib;

namespace CardSearch
{
    public class SetPageData : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;
        public SetSearchButtonClick _ssbc { get; }
        public GenerateBoosterCommand gbc { get; }

        public CardController controller;

        public ObservableCollection<CardModel> viewCardList { get; set; }
        public List<CardModel> cardList;

        public ObservableCollection<SetModel> viewSetList { get; set; }
        public List<SetModel> setList;
        public SetModel setModel {
            get => _setModel;
            set {
                _setModel = value;
                gbc.FireCanExectueChanged();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(setModel)));
            }
        }
        public string searchText { get; set; } = "";
        
        private SetModel _setModel;
        public bool CanNavToCardSearch
        {
            get
            {
                return viewCardList.Count > 0;
            }
        }


        public void refreshSets() {
            viewSetList.Clear();
            foreach(var set in setList){
                viewSetList.Add(set);
            }
        }

        public void refreshCards()
        {
            viewCardList.Clear();
            foreach(var card in cardList)
            {
                viewCardList.Add(card);
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CanNavToCardSearch)));
        }

        public SetPageData() {
            viewSetList = new ObservableCollection<SetModel>();
            setList = new List<SetModel>();
            viewCardList = new ObservableCollection<CardModel>();
            cardList = new List<CardModel>();
            _ssbc = new SetSearchButtonClick(this);
            gbc = new GenerateBoosterCommand(this);
             controller = new CardController();
        }

        
    }
}
