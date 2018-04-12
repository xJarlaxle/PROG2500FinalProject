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
        public CardController controller;

        public ObservableCollection<SetModel> viewSetList { get; set; }
        public List<SetModel> setList;
        public SetModel setModel {
            get => _setModel;
            set {
                _setModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(setModel)));
            }
        }
        public string searchText { get; set; } = "";
        

        private SetModel _setModel;


        public void refreshSets() {
            viewSetList.Clear();
            foreach(var set in setList){
                viewSetList.Add(set);
            }
        }

        public SetPageData() {
            viewSetList = new ObservableCollection<SetModel>();
            setList = new List<SetModel>();
            _ssbc = new SetSearchButtonClick(this);
             controller = new CardController();

        }

        
    }
}
