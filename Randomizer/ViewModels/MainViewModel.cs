using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Randomizer.Commands;
using Randomizer.Stores;
using System.Windows;

namespace Randomizer.ViewModels
{
    public sealed class MainViewModel : ViewModelBase
    {
        private readonly CurrentViewModelStore _currentViewModelStore;
        private readonly ListDataStore _listDataStore;

        public bool AllowDuplicateListItems { get; set; } = true;
        private int _numberOfListItemsToDisplay = 1;
        public int NumberOfListItemsToDisplay
        {
            get => _numberOfListItemsToDisplay;
            set
            {
                try
                {
                    _numberOfListItemsToDisplay = value;
                }
                catch
                {
                    MessageBox.Show("Please enter a valid value for number of results.", "Value error",
                        MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
        }

        public List<ListDataViewModel> ListDataSelectors { get; }
        public ObservableCollection<ListDataViewModel> ListDataDisplayItems { get; set; }

        public ViewModelBase CurrentViewModel => _currentViewModelStore.CurrentViewModel;

        public ICommand GenerateData { get; }

        public MainViewModel(CurrentViewModelStore currentViewModelStore, ListDataStore listDataStore)
        {
            _currentViewModelStore = currentViewModelStore;
            _listDataStore = listDataStore;

            GenerateData = new GenerateDataCommand(this);

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
