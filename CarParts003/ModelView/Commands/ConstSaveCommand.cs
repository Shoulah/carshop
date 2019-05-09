using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CarParts003.ModelView;

namespace CarParts003.ModelView.Commands
{
    public class ConstSaveCommand : ICommand
    {
        public ConstInfoModelView constInfoModelView;

        public ConstSaveCommand(ConstInfoModelView constInfoModelView)
        {
            this.constInfoModelView = constInfoModelView;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            
            return true;
        }

        public void Execute(object parameter)
        {
            this.constInfoModelView.SaveMethod();
            //this.constInfoModelView.DisplayValue();
        }
    }
}
