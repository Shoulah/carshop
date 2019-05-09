using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParts003.Models
{
    public class PartDatModel : INotifyPropertyChanged, IDataErrorInfo

    {
        private string name;
        public string Name {
            get {
                return name;
            } set {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private string desc1;
        public string Desc1
        {
            get
            {
                return desc1;
            }
            set
            {
                desc1 = value;
                OnPropertyChanged("Desc1");
            }
        }

        private DateTime desc2;
        public DateTime Desc2
        {
            get
            {
                return desc2;
            }
            set
            {
                desc2 = value;
                OnPropertyChanged("Desc2");
            }
        }

        private bool desc3;
        public bool Desc3
        {
            get
            {
                return desc3;
            }
            set
            {
                desc3 = value;
                OnPropertyChanged("Desc3");
            }
        }

        private string desc4;
        public string Desc4
        {
            get
            {
                return desc4;
            }
            set
            {
                desc4 = value;
                OnPropertyChanged("Desc4");
            }
        }
        //------------------Validation--------------------------------

        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string columnName]
        {
            get
            {
                string result = String.Empty;
                int myNumber;
                if (columnName.Equals("Name"))
                {
                    if (string.IsNullOrEmpty(this.name))
                    {
                        result = "Name is mandatory field!";
                    }

                }
                else if (columnName.Equals("Desc1"))
                {

                    if (string.IsNullOrEmpty(this.desc1))
                    {
                        result = "this is required number field";
                    }
                    if (!Int32.TryParse(this.desc1, out myNumber))
                    {
                        result = "This field should contains numbers only";
                    }
                }
                else if (columnName.Equals("Desc2"))
                {
                    if (this.desc2 == null)
                    {
                        result = "please select valid date";
                    }
                }
                isvalid = string.IsNullOrEmpty(result);
                return result;
            }
        }


        private bool isvalid;

        public bool IsValid {
          
            get { return isvalid; } }

        public event PropertyChangedEventHandler PropertyChanged;


        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        
    }
    }
}
