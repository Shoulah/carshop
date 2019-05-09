using CarParts003.Models;
using CarParts003.ModelView.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarParts003.ModelView
{
    public class WizardModelView
    {
        private string searchname;
        public string SearchName
        {
            get
            {
                return searchname;
            }
            set { searchname = SearchName;
                LoadMyCars();
            }
        }


        public ObservableCollection<string> Cars { get; set; }
        public void LoadMyCars()
        {
            MainDatabaseSourceDataContext dataContext = new MainDatabaseSourceDataContext();
            IEnumerable<string> tempCars = dataContext.ExecuteQuery<string>("select name from myCars");

            Cars = new ObservableCollection<string>(tempCars);
        }
      
        public WizardModel MyWizardModel { get; set; }

        public SaveWizardCommand SaveWizardCommand { get; set; }
        //-- the constractor 
        public WizardModelView()
        {
            this.MyWizardModel = new WizardModel()
            {
                CarCode = 0,
                CarName = "",
                CarDesc1 = "",
                CarDesc2 = DateTime.Today,
                CarDesc3 = false,
                CarDesc4 = "",
                //-
                PartName = "",
                PartDesc1 = "",
                PartDesc2 = DateTime.Today,
                PartDesc3 = false,
                PartDesc4 = "",
                //-
                Page3Desc1 = "",
                Page3Desc2 = DateTime.Today,
                Page3Desc3 = false,
                Page3Desc4 = ""
            };

            this.SaveWizardCommand = new SaveWizardCommand(this);

            LoadMyCars();
        }


        public void SaveMethod()
        {
            //Todo
        }
    }
}
