using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CarParts003.ModelView.Commands
{
    public class SaveCarCommand : ICommand
    {
        private MainModelView mainModelView;

        public SaveCarCommand(MainModelView MainModelView)
        {
            this.mainModelView = MainModelView;      
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //--------------checking for validity before save
            if (this.mainModelView.IsValidToSave())
            {
                this.mainModelView.SaveCarMethod();
            }
            else
            {
                MessageBox.Show("Invalid car details");
            }
            //this.mainModelView.SaveCarMethod();
        }
    }
}
