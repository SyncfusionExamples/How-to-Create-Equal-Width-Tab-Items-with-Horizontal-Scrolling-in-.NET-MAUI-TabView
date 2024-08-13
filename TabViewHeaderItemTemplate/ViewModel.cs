using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabViewHeaderItemTemplate
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private ObservableCollection<Model>? tabHeaderCollection;
        public ObservableCollection<Model>? TabHeaderCollection
        {
            get { return tabHeaderCollection; }
            set { tabHeaderCollection = value; OnPropertyChanged(nameof(TabHeaderCollection)); }

        }
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ViewModel()
        {
            TabHeaderCollection = new ObservableCollection<Model>()
            {
                new Model(){Name = "Call"},
                new Model(){Name = "Favourite"},
                new Model(){Name = "Contacts"},
                new Model(){Name = "More"},
                new Model(){Name = "Help"},
                new Model(){Name = "Info" },
                new Model(){Name = "About"},
                new Model(){Name = "Settings"},
            };
        }
    }

    public class Model
    {
        public string? Name { get; set; }
    }
}
