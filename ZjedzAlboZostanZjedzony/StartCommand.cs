using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ZjedzAlboZostanZjedzony
{
    public class StartCommand : ICommand
    {
        private readonly MainViewModel _mainViewModel;
        public StartCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _mainViewModel.ViewState = ViewState.SimulationView;
        }

        public event EventHandler CanExecuteChanged;
    }
}
