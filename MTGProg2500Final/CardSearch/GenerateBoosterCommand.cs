using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CardSearch
{
    public class GenerateBoosterCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private SetPageData _spd;

        public GenerateBoosterCommand(SetPageData spd)
        {
            _spd = spd;
        }

        public bool CanExecute(object parameter)
        {
            return _spd.setModel != null && _spd.setModel.booster != null;
        }

        public async void Execute(object parameter)
        {
            _spd.cardList = await _spd.controller.GetBoosterAsync(_spd.setModel.code);
            _spd.refreshCards();
        }

        public void FireCanExectueChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
