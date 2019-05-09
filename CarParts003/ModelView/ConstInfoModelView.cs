using CarParts003.Models;
using CarParts003.ModelView.Commands;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace CarParts003.ModelView
{
    public class ConstInfoModelView
    {
        public ConstInfoModel constInfoModel { get; set; }

        public ConstSaveCommand MyConstSaveCommand { get; set; }

        public UpdateImageCommand updateImageCommand { get; set; }

        public ConstInfoModelView()
        {
            string mystr = "";

            mystr = GetConstInfo();
            
            this.constInfoModel = new ConstInfoModel() { InfoString = mystr ,InfoDate = DateTime.Today.Date, MoreInfoe="",MyImage = GetImageFromDB()};

            UpdateImageSource();

            this.MyConstSaveCommand = new ConstSaveCommand(this);

            this.updateImageCommand = new UpdateImageCommand(this);
            DisplayValue();

        }

        public void UpdateImageSource()
        {
            if (this.constInfoModel.MyImage != null)
            {
                BitmapImage bitmapImage = new BitmapImage();
                MemoryStream ms = new MemoryStream(this.constInfoModel.MyImage);

                bitmapImage.BeginInit();
                bitmapImage.StreamSource = ms;
                bitmapImage.EndInit();

                this.constInfoModel.ImageSourceConst = bitmapImage;
            }
        }

        public byte[] GetImageFromDB()
        {
            MainDatabaseSourceDataContext dbContext = new MainDatabaseSourceDataContext();
            MyConstantInfo myConstantInfo = new MyConstantInfo();
            myConstantInfo = dbContext.MyConstantInfos.Single(p => p.ID == 1);
            return myConstantInfo.MyImage.ToArray();
        }

        public void SaveMethod()
        {
            MainDatabaseSourceDataContext dbContext = new MainDatabaseSourceDataContext();

            MyConstantInfo myConstantInfo = new MyConstantInfo();
            /*string ImageStringName = SelectImageToBeSaved();
            if (!string.IsNullOrEmpty(ImageStringName))
            {
                this.constInfoModel.MyImage = File.ReadAllBytes(ImageStringName);
                //using UploadImage stored procedure
                dbContext.UploadImage(this.constInfoModel.MyImage);
            }
            */
            // --- to be able to update
            myConstantInfo = dbContext.MyConstantInfos.Single(p => p.ID == 1);

            myConstantInfo.MYINFO = this.constInfoModel.InfoString;
            myConstantInfo.more = this.constInfoModel.MoreInfoe;
            myConstantInfo.myDate = this.constInfoModel.InfoDate;
            dbContext.SubmitChanges();
            MessageBox.Show("Informations has been saved.");

        }

        public string GetConstInfo()
        {
            MainDatabaseSourceDataContext dbContext = new MainDatabaseSourceDataContext();

            var res = dbContext.MyConstantInfos.OrderByDescending(p => p.MYINFO).FirstOrDefault();
            return res.MYINFO;
        }

        public void DisplayValue()
        {
            this.constInfoModel.InfoString = GetConstInfo();
            MainDatabaseSourceDataContext dbContext = new MainDatabaseSourceDataContext();

            var res = dbContext.MyConstantInfos.OrderByDescending(p => p.MYINFO).FirstOrDefault();
            //return res.MYINFO;
            this.constInfoModel.InfoDate = res.myDate.GetValueOrDefault(DateTime.Today.Date);
            this.constInfoModel.MoreInfoe = res.more;
        }

        public string SelectImageToBeSaved()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select image";

            openFileDialog.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                                                "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                                                "Portable Network Graphic (*.png)|*.png";

            string myFileName = string.Empty;

            if (openFileDialog.ShowDialog() == true)
            {
                myFileName = openFileDialog.FileName;
            }
            return myFileName;
        }

        public void UpdateMyImage()
        {
            MainDatabaseSourceDataContext dbContext = new MainDatabaseSourceDataContext();

            MyConstantInfo myConstantInfo = new MyConstantInfo();
            string ImageStringName = SelectImageToBeSaved();
            if (!string.IsNullOrEmpty(ImageStringName))
            {
                
                this.constInfoModel.MyImage = File.ReadAllBytes(ImageStringName);

                //using UploadImage stored procedure
                dbContext.UploadImage(this.constInfoModel.MyImage);

                UpdateImageSource();
            }

        }
    }
}
