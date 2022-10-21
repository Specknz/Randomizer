using Randomizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer.ViewModels
{
    public class ListDataViewModel : ViewModelBase
    {
        private readonly ListData _listData;
        public string Name => _listData.Name;
        public IEnumerable<string> Items => _listData.Items;
        public bool IsSelected => _listData.IsSelected;

        public ListDataViewModel(ListData listData)
        {
            _listData = listData;
        }
    }
}
