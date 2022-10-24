using Randomizer.Models;
using Randomizer.Stores;
using Randomizer.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Randomizer.Factories
{
    public static class ListDataFactory
    {
        private static Random random = new();

        public static void GenerateRandomItems(MainViewModel mainViewModel)
        {
            mainViewModel.ListDataItems.Clear();

            foreach (ListDataViewModel list in mainViewModel.ListDataSelectors)
            {
                if (list.IsSelected)
                {
                    RandomizeItems(mainViewModel, list);
                }
            }
        }

        private static void RandomizeItems(MainViewModel mainViewModel, ListDataViewModel list)
        {
            List<string> extractedListItems = ExtractListItems(list.Items.ToList());

            List<string> randomisedList = AddRandomItems(mainViewModel, extractedListItems);

            mainViewModel.ListDataItems.Add(new ListDataViewModel(new ListData { Name = list.Name, Items = randomisedList}));
        }

        private static List<string> ExtractListItems(List<string> listItemsToBeExtracted)
        {
            List<string> extractedItems = new();

            foreach(string item in listItemsToBeExtracted)
            {
                extractedItems.Add(item);
            }

            return extractedItems;
        }

        private static List<string> AddRandomItems(MainViewModel mainViewModel, List<string> extractedListItems)
        {
            List<string> randomizedListItem = new();

            for (int i = 0; i < mainViewModel.NumberOfListItemsToDisplay; i++)
            {
                string randomListItem = extractedListItems[random.Next(extractedListItems.Count)];
                randomizedListItem.Add(randomListItem);
            }

            return randomizedListItem;
        }
    }
}
