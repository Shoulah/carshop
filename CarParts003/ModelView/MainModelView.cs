using CarParts003.Models;
using CarParts003.ModelView.Commands;
using MahApps.Metro.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CarParts003.ModelView
{
    public class MainModelView
    {
        public DataModel dataModel { get; set; }

        public SaveCarCommand saveCarCommand { get; set; }

        public MainModelView()
        {
            this.dataModel = new DataModel() { myName = "", myDesc1 = "", myDesc2 = DateTime.Today.Date, myDesc3 = false, myDesc4 = ""};

            this.saveCarCommand = new SaveCarCommand(this);

        }


        ///=======================================================
        ///

        public void SaveCarMethod()
        {
            MainDatabaseSourceDataContext dbContext = new MainDatabaseSourceDataContext();
            myCar car = new myCar();
            car.Name = this.dataModel.myName;
            car.Desc1 = Int32.Parse(this.dataModel.myDesc1);
            car.Desc2 = this.dataModel.myDesc2.Date;
            car.Desc3 = this.dataModel.myDesc3;
            car.Desc4 = this.dataModel.myDesc4;
            dbContext.myCars.InsertOnSubmit(car);
            dbContext.SubmitChanges();
            MessageBox.Show("Saved Successfuly !");
            //---- Clear the object details after saving -----
            ClearObjectDetails();
        }

        public bool IsValidToSave()
        {
            return this.dataModel.IsValid;
        }
       
        private void ClearObjectDetails()
        {
            this.dataModel.myName = "";
            this.dataModel.myDesc1 = "";
            this.dataModel.myDesc3 = false;
            this.dataModel.myDesc4 = "";
        }



        ///---------------------------------------------------------
    }
}
