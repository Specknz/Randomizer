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
        private readonly ListDataViewModel _listDataViewModel;
        private readonly CurrentViewModelStore _currentViewModelStore;
        public ViewModelBase CurrentViewModel => _currentViewModelStore.CurrentViewModel;   

        public ICommand GenerateData;

        public MainViewModel(CurrentViewModelStore currentViewModelStore)
        {
            _listDataViewModel = new ListDataViewModel();
            _currentViewModelStore = currentViewModelStore;
            GenerateData = new GenerateDataCommand();

            _currentViewModelStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
