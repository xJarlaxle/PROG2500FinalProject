using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CardSearch
{
    public class SearchCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MainPageData mpd;

        public SearchCommand(MainPageData mpd)
        {
            this.mpd = mpd;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            mpd.cardList = await mpd.controller.GetCardListAsync(mpd.Text);
            mpd.RefreshCards();
        }

    }
}
