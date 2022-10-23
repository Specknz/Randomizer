using Randomizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer.ViewModels
{
    public sealed class ListDataViewModel : ViewModelBase
    {
        private ListData _listData;
        public string Name => _listData.Name;
        public IEnumerable<string> Items => _listData.Items;
        public bool IsSelected
        {
            get => _listData.IsSelected;
            set
            {
                _listData.IsSelected = value;
            }
        }

        public ListDataViewModel(ListData listData)
        {
            _listData = listData;
        }
    }
}
