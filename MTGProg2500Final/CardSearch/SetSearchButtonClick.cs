using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CardSearch
{
    public class SetSearchButtonClick : ICommand {

        SetPageData _spd;
        
        public event EventHandler CanExecuteChanged;
        

        public SetSearchButtonClick(SetPageData spd) {
            this._spd = spd;
        }

        

        public bool CanExecute(object parameter) {
            return true;
        }

        public async void Execute(object parameter) {
            
            var result = await _spd.controller.GetSetListAsync();
        }



    }
}
