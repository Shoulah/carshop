using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParts003.Models
{
    public class SearchModel : INotifyPropertyChanged
    {
        private string _selectedItem;
        public string MySelectedItem
        {
            get {
                return _selectedItem;
            }
            set {
                _selectedItem = value;
                OnPropertyChanged("MySelectedItem");
            }
        }

        public List<string> MyNames { get

            {
                List<string> mylista = new List<string>();

                MainDatabaseSourceDataContext db = new MainDatabaseSourceDataContext();

                var myres = (from a in db.myCars select a);

                foreach (var x in myres)
                {

                    mylista.Add(x.Name.ToString().Trim());

                }

                return mylista;

            }
        }

        public List<string> MyParts
        {
            get

            {
                List<string> mylistb = new List<string>();

                MainDatabaseSourceDataContext db = new MainDatabaseSourceDataContext();

                var myres = (from a in db.myParts select a);

                foreach (var x in myres)
                {

                    mylistb.Add(x.Name.ToString().Trim());

                }

                return mylistb;

            }
        }

        public ObservableCollection<myCar> Mycars007 { get; set; }
        public SearchModel()
        {
            MainDatabaseSourceDataContext dataContext = new MainDatabaseSourceDataContext();
            IEnumerable<myCar> tempCars = dataContext.ExecuteQuery<myCar>("select * from myCars");
            if (Mycars007 != null)
            {
                Mycars007.Clear();
            }
            Mycars007 = new ObservableCollection<myCar>(tempCars);

        }

        private List<InstalPartDetails> myparttodisp;
        public List<InstalPartDetails> MyPartsToDisp {

            get
            {
                return myparttodisp;
            }
            set {
                if(myparttodisp == null)
                {
                    myparttodisp = new List<InstalPartDetails>();
                }
                myparttodisp = value;
                OnPropertyChanged("MyPartsToDisp");
            } }




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
