using Randomizer.Stores;
using Randomizer.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer.Factories
{
    public static class DisplayListDataFactory
    {
        private static Random random = new();

        public static void GenerateRandomItems(MainViewModel? mainViewModel)
        {
            mainViewModel.ListDataItems.Clear();

            foreach (ListDataViewModel list in mainViewModel.ListDataSelectors)
            {
                if (list.IsSelected)
                {
                    AddList(list, mainViewModel.ListDataItems);
                    RandomizeItems(mainViewModel.NumberOfListItemsToDisplay, mainViewModel.AllowDuplicateListItems, mainViewModel.ListDataItems);
                }
            }
        }

        private static void AddList(ListDataViewModel listToAdd, ObservableCollection<ListDataViewModel> listToBeAddedTo)
        {
            
        }

        private static void RandomizeItems(int numOfSelectedItems, bool allowDuplicates, ObservableCollection<ListDataViewModel> itemsToBeDisplayed)
        {
            foreach(ListDataViewModel list in itemsToBeDisplayed)
            {
                List<string> items = list.Items.ToList();

                list.Items.Clear();

                for(int i = 0; i <= numOfSelectedItems; i++)
                {
                    list.Items.Add(items[random.Next(items.Count)]);;
                }
            }
        }
    }
}
