using Restoran.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Restoran.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public void Execute(object? parameter)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }

        public bool CanExecute(object? parameter)=>true;


    }
}
