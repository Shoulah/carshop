using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarParts003.ModelView.Commands
{
   public class UpdateImageCommand : ICommand
    {
        public ConstInfoModelView constInfoModelView;

        public UpdateImageCommand(ConstInfoModelView constInfoModelView)
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
            this.constInfoModelView.UpdateMyImage();
        }
    }
}
