using Randomizer.Stores;
using Randomizer.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Randomizer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly CurrentViewModelStore _currentViewModelStore;
        private readonly ListDataStore _listDataStore;


        public App()
        {
            _currentViewModelStore = new();
            _listDataStore = new();
        }


        protected override void OnStartup(StartupEventArgs e)
        {
            _currentViewModelStore.CurrentViewModel = new MainViewModel(_currentViewModelStore, _listDataStore);

            MainWindow = new MainWindow()
            {
                DataContext = _currentViewModelStore.CurrentViewModel
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
