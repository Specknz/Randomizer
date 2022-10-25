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
using System.Windows.Input;
using Randomizer.Commands;
using Randomizer.Stores;

namespace Randomizer.ViewModels
{
    public sealed class MainViewModel : ViewModelBase
    {
        private readonly CurrentViewModelStore _currentViewModelStore;
        private readonly ListDataStore _listDataStore;

        public bool AllowDuplicateListItems { get; set; } = true;
        public int NumberOfListItemsToDisplay { get; set; } = 4;

        public List<ListDataViewModel> ListDataSelectors { get; }
        public ObservableCollection<ListDataViewModel> ListDataDisplayItems { get; set; }

        public ViewModelBase CurrentViewModel => _currentViewModelStore.CurrentViewModel;

        public ICommand GenerateData { get; }

        public MainViewModel(CurrentViewModelStore currentViewModelStore, ListDataStore listDataStore)
        {
            _currentViewModelStore = currentViewModelStore;
            _listDataStore = listDataStore;

            GenerateData = new GenerateDataCommand(this, listDataStore);

            ListDataSelectors = new();
            ListDataDisplayItems = new();

            _currentViewModelStore.CurrentViewModelChanged += OnCurrentViewModelChanged;

            GetListDataSelectors();
        }

        private void GetListDataSelectors()
        {
            ListDataSelectors.Clear();

            foreach (var list in _listDataStore.GetLists())
            {
                ListDataSelectors.Add(new ListDataViewModel(list));
            }
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
