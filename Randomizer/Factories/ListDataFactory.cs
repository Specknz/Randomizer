using Randomizer.Models;
using Randomizer.Stores;
using Randomizer.ViewModels;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Randomizer.Factories
{
    public static class ListDataFactory
    {
        private static Random _random = new();

        public static void GetListData(List<ListDataViewModel> listOfListData, ListDataStore listDataStore)
        {
            listOfListData.Clear();

            foreach (var list in listDataStore.GetLists())
            {
                listOfListData.Add(new ListDataViewModel(list));
            }
        }

        public static void GenerateRandomItems(MainViewModel mainViewModel)
        {
            mainViewModel.ListDataDisplayItems.Clear();

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

            mainViewModel.ListDataDisplayItems.Add(new ListDataViewModel(
                new ListData 
                { 
                    Name = list.Name, 
                    Items = randomisedList
                }));
        }

        private static List<string> ExtractListItems(List<string> listItemsToBeExtracted)
        {
            List<string> extractedItems = new();

            foreach (string item in listItemsToBeExtracted)
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
                string randomListItem = extractedListItems[_random.Next(extractedListItems.Count)];
                randomizedListItem.Add(randomListItem);
            }

            return randomizedListItem;
        }
    }
}
