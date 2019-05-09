using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParts003.Models
{
    public class DataModel : INotifyPropertyChanged, IDataErrorInfo
    {
        private string myname;
        public string myName
        { get
            { return myname; }
            set {
                myname = value;
                OnPropertyChanged("myName");
            }
        }

        private string mydesc1;
        public string myDesc1
        {
            get
            { return mydesc1; }
            set
            {
                mydesc1 = value;
                OnPropertyChanged("myDesc1");
            }
        }

        private DateTime mydesc2;
        public DateTime myDesc2
        {
            get
            { return mydesc2; }
            set
            {
                mydesc2 = value;
                OnPropertyChanged("myDesc2");
            }
        }

        private  bool mydesc3;
        public bool myDesc3
        {
            get
            { return mydesc3; }
            set
            {
                mydesc3 = value;
                OnPropertyChanged("myDesc3");
            }
        }

        private string mydesc4;
        public string myDesc4
        {
            get
            { return mydesc4; }
            set
            {
                mydesc4 = value;
                OnPropertyChanged("myDesc4");
            }
        }

        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string columnName] {
            get
            {
                string result = String.Empty;
                int myNumber;
                if (columnName.Equals("myName"))
                {
                    if (string.IsNullOrEmpty(this.myname))
                    {
                        result = "Name is mandatory field!";
                    }
                    
                }
                else if (columnName.Equals("myDesc1"))
                {
                    
                    if (string.IsNullOrEmpty(this.mydesc1))
                    {
                        result = "this is required number field";
                    }
                    if(!Int32.TryParse(this.mydesc1, out myNumber))
                    {
                        result = "This field should contains numbers only";
                    }
                }
                else if (columnName.Equals("myDesc2"))
                {
                    if(this.mydesc2 == null)
                    {
                        result = "please select valid date";
                    }
                }
                isvalid = string.IsNullOrEmpty(result);
                return result;
            }
        }
        private bool isvalid;
        public bool IsValid { get { return isvalid; } }

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