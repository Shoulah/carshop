using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarParts003.ModelView.Commands
{
    public class SaveWizardCommand : ICommand
    {

        private WizardModelView wizardModelView;

        public SaveWizardCommand(WizardModelView wizardModelView)
        {
            this.wizardModelView = wizardModelView;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            // throw new NotImplementedException();
            this.wizardModelView.SaveMethod();
        }
    }
}
