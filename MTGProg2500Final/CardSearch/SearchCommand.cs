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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mpd"></param>
        public SearchCommand(MainPageData mpd)
        {
            this.mpd = mpd;
        }

        /// <summary>
        /// Always returns true
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Searches for the cards using the API
        /// </summary>
        /// <param name="parameter"></param>
        public async void Execute(object parameter)
        {
            mpd.cardList = await mpd.controller.GetCardListAsync(mpd.Text);
            mpd.RefreshCards();
        }

    }
}
