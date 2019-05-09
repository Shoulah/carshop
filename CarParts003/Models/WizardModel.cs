using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParts003.ModelView
{
    public class WizardModel : INotifyPropertyChanged
    {
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

        private int carcode;
        public int CarCode
        {
            get
            {
                return carcode;
            }

            set
            {
                carcode = value;
                OnPropertyChanged("CarCode");
            }
        }

        private string cardesc1;
        public string CarDesc1
        {
            get
            {
                return cardesc1;
            }
            set
            {
                cardesc1 = value;
                OnPropertyChanged("CarDesc1");
            }
        }

        private DateTime cardesc2;
        public DateTime CarDesc2
        {
            get
            {
                return cardesc2;
            }
            set
            {
                cardesc2 = value;
                OnPropertyChanged("CarDesc2");
            }
        }

        private bool cardesc3;
        public bool CarDesc3
        {
            get
            {
                return cardesc3;
            }
            set
            {
                cardesc3 = value;
                OnPropertyChanged("CarDesc3");
            }
        }

        private string cardesc4;
        public string CarDesc4
        {
            get
            {
                return cardesc4;
            }
            set
            {
                cardesc4 = value;
                OnPropertyChanged("CarDesc4");
            }
        }

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
                OnPropertyChanged("PartName");
            }
        }

        

        private string partdesc1;
        public string PartDesc1
        {
            get
            {
                return partdesc1;
            }
            set
            {
                partdesc1 = value;
                OnPropertyChanged("PartDesc1");
            }
        }

        private DateTime partdesc2;
        public DateTime PartDesc2
        {
            get
            {
                return partdesc2;
            }
            set
            {
                partdesc2 = value;
                OnPropertyChanged("PartDesc2");
            }
        }

        private bool partdesc3;
        public bool PartDesc3
        {
            get
            {
                return partdesc3;
            }
            set
            {
                partdesc3 = value;
                OnPropertyChanged("PartDesc3");
            }
        }

        private string partdesc4;
        public string PartDesc4
        {
            get
            {
                return partdesc4;
            }
            set
            {
                partdesc4 = value;
                OnPropertyChanged("PartDesc4");
            }
        }

        private string page3desc1;
        public string Page3Desc1
        {
            get
            {
                return page3desc1;
            }
            set
            {
                page3desc1 = value;
                OnPropertyChanged("Page3Desc1");
            }
        }

        private DateTime page3desc2;
        public DateTime Page3Desc2
        {
            get
            {
                return page3desc2;
            }
            set
            {
                page3desc2 = value;
                OnPropertyChanged("Page3Desc2");
            }
        }

        private bool page3desc3;
        public bool Page3Desc3
        {
            get
            {
                return page3desc3;
            }
            set
            {
                page3desc3 = value;
                OnPropertyChanged("Page3Desc3");
            }
        }

        private string page3desc4;
        public string Page3Desc4
        {
            get
            {
                return page3desc4;
            }
            set
            {
                page3desc4 = value;
                OnPropertyChanged("Page3Desc4");
            }
        }

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
