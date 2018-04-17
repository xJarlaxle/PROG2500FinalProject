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
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="spd"></param>
        public SetSearchButtonClick(SetPageData spd) {
            this._spd = spd;
        }

        
        /// <summary>
        /// Always returns true
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter) {
            return true;
        }

        /// <summary>
        /// Grabs the Set List search from the API and display the result
        /// </summary>
        /// <param name="parameter"></param>
        public async void Execute(object parameter) {
            
           _spd.setList = await _spd.controller.GetSetListAsync(_spd.searchText);
            _spd.refreshSets();
        }



    }
}
