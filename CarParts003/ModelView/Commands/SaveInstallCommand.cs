
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CarParts003.ModelView.Commands
{
    public class SaveInstallCommand : ICommand
    {
        private InstallModelView installModelView;

        public SaveInstallCommand(InstallModelView installModelView)
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
            this.installModelView.SaveInstall();
        }
   
}
}
