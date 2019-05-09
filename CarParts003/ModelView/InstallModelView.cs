using CarParts003.Models;
using CarParts003.ModelView.Commands;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CarParts003.ModelView
{
    public class InstallModelView
    {
        
        public InstallModel MyInstallModel { get; set; }

        public InstallPartModelw installPartModelw { get; set; }

        public AddPartToListCommand MyAddPartToListCommand { get; set; }

        public SaveInstallCommand MySaveInstallCommand { get; set; }

        public SearchModel searchModel { get; set; }

        List<InstalPartDetails> myPartsList = new List<InstalPartDetails>();

        public InstallModelView()
        {
            this.MyInstallModel = new InstallModel() { CarId = 0, Id = 0, InstallDisc = "" ,CarName="" };
            this.installPartModelw = new InstallPartModelw() { PartName = "", PartDesc = "" };
            this.MyAddPartToListCommand = new AddPartToListCommand(this);
            this.MySaveInstallCommand = new SaveInstallCommand(this);
            this.searchModel = new SearchModel() { Mycars007 = null, MySelectedItem = "" ,MyPartsToDisp = null};
        }

        public int GetPartIdByName(string myPartName)
        {
            try
            { 
            MainDatabaseSourceDataContext dbContext = new MainDatabaseSourceDataContext();
            var res = (from p in dbContext.myParts
                       where p.Name == myPartName
                       select p.ID);
            return res.First();
            }
            catch (System.InvalidOperationException ex)
            {
                return 0;
            }
        }

        public int GetCarIdByName(string CarName)
        {
            try
            {
                MainDatabaseSourceDataContext dbContext = new MainDatabaseSourceDataContext();
                var res = (from p in dbContext.myCars
                           where p.Name == CarName
                           select p.ID).Take(1);

                return res.First();
            }
            catch(System.InvalidOperationException ex)
            {
                return 0;
            }
        }

        public int GetMaxInstallId()
        {
            MainDatabaseSourceDataContext dbContext = new MainDatabaseSourceDataContext();
           
            var res = dbContext.Installs.OrderByDescending(p => p.ID).FirstOrDefault();

            return res.ID;
        }


        public int GetMaxInstallPartId()
        {
            MainDatabaseSourceDataContext dbContext = new MainDatabaseSourceDataContext();

            var res = dbContext.Install_Details.OrderByDescending(p => p.ID).FirstOrDefault();

            return res.ID;
        }
        public void AddPartToList()
        {
            if (!CheckPartAvailability())
            {
                MessageBox.Show("Part name not valid..");
                return;
            }
            
            InstalPartDetails part = new InstalPartDetails();
            part.PartId = GetPartIdByName(installPartModelw.PartName);
            part.Disc = this.installPartModelw.PartDesc;
            myPartsList.Add(part);
            this.installPartModelw.PartName = "";
            this.installPartModelw.PartDesc = "";
            //----
            this.searchModel.MyPartsToDisp = myPartsList;
        }

        public void SaveInstall()
        {
            if (!CheckCarAvailability())
            {
                MessageBox.Show("Car name not found.");
                return;
            }

            if (myPartsList.Count == 0)
            {
                MessageBox.Show("Please add at least one part");
                return;
            }

            MainDatabaseSourceDataContext dbContext = new MainDatabaseSourceDataContext();
            int myId = GetMaxInstallId() + 1;
            Install install = new Install();
            install.ID = myId;
            install.Car_ID = GetCarIdByName(this.MyInstallModel.CarName);
            install.other_desc_fields = this.MyInstallModel.InstallDisc;
            dbContext.Installs.InsertOnSubmit(install);

            int instapPartID = GetMaxInstallPartId();
            foreach (var item in myPartsList)
            {
                Install_Detail install_Detail = new Install_Detail();

                install_Detail.ID = instapPartID + 1;

                instapPartID += 1;

                install_Detail.Part_ID = item.PartId;

                install_Detail.Other_desc_fields = item.Disc;

                install_Detail.Install_ID = myId;

                install.Install_Details.Add(install_Detail);

                dbContext.Install_Details.InsertOnSubmit(install_Detail);
            }
            dbContext.SubmitChanges();
            //--------------Confirmation message ------------------
            MessageBox.Show("saved successfuly");
            myPartsList.Clear();
            this.installPartModelw.PartName = "";
            this.installPartModelw.PartDesc = "";
            this.MyInstallModel.CarName = "";
            this.MyInstallModel.InstallDisc = "";
            this.searchModel.MyPartsToDisp = myPartsList;

        }

        public bool CheckCarAvailability()
        {
            if(GetCarIdByName(this.MyInstallModel.CarName) == 0)
            {
                return false;// MessageBox.Show("Car not found");
            }
            else
            {
                return true;// MessageBox.Show("this.MyInstallModel.CarName");
            }
        }

        public bool CheckPartAvailability()
        {
            //MessageBox.Show(this.installPartModelw.PartName);
            if (GetPartIdByName(this.installPartModelw.PartName) == 0)
            {
                return false;// MessageBox.Show("part not found");
            }
            else
            {
                return true;// MessageBox.Show("part name");
            }
        }


    }
}
