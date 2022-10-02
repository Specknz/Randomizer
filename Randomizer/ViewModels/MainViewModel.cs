using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Randomizer.DataAccess;
using Randomizer.Models;
using Randomizer.DataAccess;

namespace Randomizer.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ListData> ListData { get; }
        public MainViewModel()
        {
            ListData = new ObservableCollection<ListData>(DataAccessor.GetListsFromFiles());
        }
    }
}
