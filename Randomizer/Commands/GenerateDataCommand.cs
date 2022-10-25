using Randomizer.Factories;
using Randomizer.Stores;
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
        private readonly MainViewModel _mainViewModel;

        public GenerateDataCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel; 
        }

        public override void Execute(object? parameter)
        {
            ListDataFactory.GenerateRandomItems(_mainViewModel);
        }
    }
}
