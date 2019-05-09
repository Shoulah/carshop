using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CarParts003.ModelView.Commands
{
    public class AddPartToListCommand : ICommand
    {
        private InstallModelView installModelView;

        public AddPartToListCommand(InstallModelView installModelView)
        {
            this.installModelView = installModelView;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            /*if (this.installModelView.installPartModelw.IsValid)
            {
                this.installModelView.AddPartToList();
            }
            else
            {
                MessageBox.Show("Invalid part details");
            }
            */
            this.installModelView.AddPartToList();
        }
    }
}
