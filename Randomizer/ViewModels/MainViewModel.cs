using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Randomizer.DataAccess;
using Randomizer.Models;
using System.Windows.Controls;
using System.Data;
using System.Data.Common;

namespace Randomizer.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ListData> ListData { get; }
        public ObservableCollection<ListData> SelectedListData { get; set; }
        public string someString = "Hello World";
        public DataGrid myDataGrid { get; set; }

        public MainViewModel()
        {
            ListData = new ObservableCollection<ListData>(DataAccessor.GetListsFromFiles());
            DataGridTextColumn dgtc = new();
            dgtc.Header = "Text";

            myDataGrid.Columns.Add(dgtc);
        }
    }
}
