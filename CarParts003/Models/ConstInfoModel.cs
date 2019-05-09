using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CarParts003.Models
{
    public class ConstInfoModel : INotifyPropertyChanged, IDataErrorInfo
    {
        private string infostring;

        public string Error { get { return null; } }

        public string this[string columnName]
        {
            get
            {
                string result = string.Empty;
                if (columnName == "InfoString")
                {
                    if (this.InfoString.Trim() == "")
                        result = "Info string can not be empty";
                }
                isvalid = string.IsNullOrEmpty(result);
                return result;
            }
        }

        public string InfoString
        {
            get
            {
                return infostring;
            }
            set
            {
                infostring = value;
                OnPropertyChanged("InfoString");
            }
        }

        private DateTime infodate;

        public DateTime InfoDate {
            get
            {
                return infodate;
            }
            set
            {
                infodate = value;
                OnPropertyChanged("InfoDate");
            }
        }

        private byte[] myimage;

        public byte[] MyImage
        {
            get
            {
                OnPropertyChanged("MyImage");
                return myimage;
               
            }
            set
            {
                myimage = value;
                OnPropertyChanged("MyImage");
            }
        }

        private string moreinfo;
        public string MoreInfoe
        {
            get
            {
                return moreinfo;
            }
            set
            {
                moreinfo = value;
                OnPropertyChanged("MoreInfoe");
            }
        }

        private ImageSource imagesource;

        public ImageSource ImageSourceConst { get { return imagesource; } set {

                imagesource = value;
                OnPropertyChanged("ImageSourceConst");
            } }

        private bool isvalid;
        public bool IsValid { get { return isvalid; } }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string PropertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
