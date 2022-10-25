using Randomizer.Models;
using System.Collections.Generic;

namespace Randomizer.ViewModels
{
    public sealed class ListDataViewModel : ViewModelBase
    {
        private readonly ListData _listData;

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
