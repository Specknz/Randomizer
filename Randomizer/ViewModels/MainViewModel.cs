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
    public class MainViewModel : ViewModelBase
    {
        private ListDataStore _listDataStore;
        public ObservableCollection<ListDataViewModel> ListData { get; set; }

        private readonly CurrentViewModelStore _currentViewModelStore;
        public ViewModelBase CurrentViewModel => _currentViewModelStore.CurrentViewModel;   

        public ICommand GenerateData;

        public MainViewModel(CurrentViewModelStore currentViewModelStore, ListDataStore listDataStore)
        {
            _currentViewModelStore = currentViewModelStore;
            _listDataStore = listDataStore;
            ListData = new();
            GenerateData = new GenerateDataCommand(this, listDataStore);

            _currentViewModelStore.CurrentViewModelChanged += OnCurrentViewModelChanged;

            UpdateListData();
        }

        private void UpdateListData()
        {
            ListData.Clear();

            foreach (var list in _listDataStore.GetAllListsData())
            {
                if (list.IsSelected)
                {
                    ListData.Add(new ListDataViewModel(list));
                }
            }
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
