﻿using Randomizer.Stores;
using Randomizer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Randomizer.Commands
{
    public sealed class GenerateDataCommand : CommandBase
    {
        private ListDataStore _listDataStore;
        private MainViewModel _mainViewModel;

        public GenerateDataCommand(MainViewModel mainViewModel, ListDataStore listDataStore)
        {
            _listDataStore = listDataStore;
            _mainViewModel = mainViewModel; 
        }

        public override void Execute(object? parameter)
        {

        }
    }
}
