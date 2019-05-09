using CarParts003.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarParts003.ModelView.Commands;
using System.Windows;

namespace CarParts003.ModelView
{
   public class PartMainModelView
    {
        public PartDatModel partDateModel { get; set; }

        public SavePartCommand SavePartCommand { get; set; }

        public PartMainModelView()
        {
           
            this.partDateModel = new PartDatModel() {Name = "", Desc1 = "", Desc2 = DateTime.Today.Date, Desc3 = false, Desc4 = ""};

            this.SavePartCommand = new SavePartCommand(this);
        }

        public void SavePartMethod()
        {
            if (string.IsNullOrEmpty(this.partDateModel.Name))
            {
                MessageBox.Show("Part name can not be empty.");
                return;
            }
            if (string.IsNullOrEmpty(this.partDateModel.Desc1))
            {
                MessageBox.Show("Number field is required.");
                return;
            }
            int myNumber;
            if (!Int32.TryParse(this.partDateModel.Desc1, out myNumber))
            {
                MessageBox.Show("It Should contain numbers only");
                return;
            }

            MainDatabaseSourceDataContext dbContext = new MainDatabaseSourceDataContext();
            myPart part = new myPart();
            part.Name = this.partDateModel.Name;
            part.Desc1 = Int32.Parse(this.partDateModel.Desc1);
            part.Desc2 = this.partDateModel.Desc2.Date;
            part.Desc3 = this.partDateModel.Desc3;
            part.desc4 = this.partDateModel.Desc4;
            dbContext.myParts.InsertOnSubmit(part);
            dbContext.SubmitChanges();

            MessageBox.Show("Saved Successfuly !");
            //---- Clear the object details after saving -----
            ClearObjectDetails();

        }

        private void ClearObjectDetails()
        {
            this.partDateModel.Name = "";
            this.partDateModel.Desc1 = "";
            this.partDateModel.Desc3 = false;
            this.partDateModel.Desc4 = "";
        }
        public void DisplayErrorMessage()
        {
            MessageBox.Show(this.partDateModel.Error);
        }
        public bool IsValidToSave()
        {
            return this.partDateModel.IsValid;
        }
    }
}
