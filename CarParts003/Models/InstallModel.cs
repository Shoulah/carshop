using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParts003.Models
{
    public class InstallModel : INotifyPropertyChanged, IDataErrorInfo
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private int carid;
        public int CarId
        {
            get
            {
                return carid;
            }
            set
            {
                carid = value;
                OnPropertyChanged("CarId");
            }
        }

        private string installdesc;
        public string InstallDisc
        {
            get
            {
                return installdesc;
            }
            set
            {
                installdesc = value;
                OnPropertyChanged("InstallDisc");
            }
        }

        private string carname;
        public string CarName
        {
            get
            {
                return carname;
            }
            set
            {
                carname = value;
                OnPropertyChanged("CarName");
            }
        }

        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string columnName] { get {

                string result = string.Empty;

                if (columnName.Equals("CarName"))
                {
                    if (string.IsNullOrEmpty(carname))
                    {
                        result = "CarName required field please select carname";
                    }

                }
                isvalid = string.IsNullOrEmpty(result);
                return result;
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
