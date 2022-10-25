using Randomizer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer.DataAccess
{
    public static class ListFileLoader
    {
        public static IEnumerable<ListData> LoadListData()
        {
            IEnumerable<string> listFileNames = GetListFileNames();
            List<ListData> list = new();

            foreach (string listFileName in listFileNames)
            {
                AddList(listFileName, list);
            }

            return list;
        }

        private static IEnumerable<string> GetListFileNames()
        {
            string listsRootPath = Path.Combine(Directory.GetCurrentDirectory(), "Lists");
            return Directory.GetFiles(listsRootPath);

        }

        private static void AddList(string listFileName, List<ListData> list)
        {
            list.Add(new ListData
            {
                Name = Path.GetFileNameWithoutExtension(listFileName),
                Items = GetListItems(listFileName),
                IsSelected = false
            });
        }

        private static IEnumerable<string> GetListItems(string list)
        {
            List<string> listItems = new();

            foreach (string item in File.ReadLines(list))
            {
                listItems.Add(item);
            }

            return listItems;
        }
    }
}