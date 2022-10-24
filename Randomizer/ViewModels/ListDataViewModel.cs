using Randomizer.Models;
using System.Collections.Generic;

namespace Randomizer.ViewModels
{
    public sealed class ListDataViewModel : ViewModelBase
    {
        public ListData _listData;
        public string Name => _listData.Name;

        public List<string> Items
        {
            get => _listData.Items;
            set => _listData.Items = value;
        }

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
