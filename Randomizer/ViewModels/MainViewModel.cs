﻿using System;
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
        private ListDataStore _listDataStore;
        public bool AllowDuplicateListItems { get; set; }
        public int NumberOfListItemsToDisplay { get; set; }
        public ObservableCollection<ListDataViewModel> DisplayListData { get; set; }
        public ViewModelBase CurrentViewModel => _currentViewModelStore.CurrentViewModel;   

        public ICommand GenerateData { get; }

        public MainViewModel(CurrentViewModelStore currentViewModelStore, ListDataStore listDataStore)
        {
            _currentViewModelStore = currentViewModelStore;
            _listDataStore = listDataStore;
            DisplayListData = new();
            GenerateData = new GenerateDataCommand(this, listDataStore);

            _currentViewModelStore.CurrentViewModelChanged += OnCurrentViewModelChanged;

            UpdateListData();
        }

        private void UpdateListData()
        {
            DisplayListData.Clear();

            foreach (var list in _listDataStore.GetLists())
            {
                if (list.IsSelected)
                {
                    DisplayListData.Add(new ListDataViewModel(list));
                }
            }
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
