using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParts003.Models
{
    public class InstallPartModelw : INotifyPropertyChanged, IDataErrorInfo
    {
        private string partname;
        public string PartName
        {
            get
            {
                return partname;
            }
            set
            {
                partname = value;
                OnProperyChanged("PartName");
            }
        }

        private string partdesc;
        public string PartDesc
        {
            get
            {
                return partdesc;
            }
            set
            {
                partdesc = value;
                OnProperyChanged("PartDesc");
            }
        }
//-------------------------validation------------------------------
        public string Error {
            get
            {
                return null;
            }
        }


        public string this[string columnName]
        {
            get
            {
                string result = string.Empty;

                if (columnName.Equals("PartName"))
                {
                    if (string.IsNullOrEmpty(partname))
                    {
                        result = "Please enter partname";
                    }
                    
                }
                isvalid = string.IsNullOrEmpty(result);
              
                return result;
            }
        }

        private bool isvalid;
        public bool IsValid { get { return isvalid; } }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnProperyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
