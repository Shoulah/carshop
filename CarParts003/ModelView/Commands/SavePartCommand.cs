using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CarParts003.ModelView.Commands
{
    public class SavePartCommand : ICommand
    {
        private PartMainModelView _MyPartMainModelView;

        public SavePartCommand(PartMainModelView MypartMainModelView)
        {
            this._MyPartMainModelView = MypartMainModelView;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
           
            return true;
        }

        public void Execute(object parameter)
        {
            this._MyPartMainModelView.SavePartMethod();
        }
    }
}
