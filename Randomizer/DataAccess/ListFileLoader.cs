﻿using Randomizer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer.DataAccess
{
    internal static class ListFileLoader
    {
        private static IEnumerable<string> _listFileNames = GetListFileNames();
        private static List<ListData> _list = new();

        public static List<ListData> LoadListData()
        {
            foreach (string listFile in _listFileNames)
            {
                AddList(listFile);
            }

            return _list;
        }

        private static IEnumerable<string> GetListFileNames()
        {
            string listsRootPath = Path.Combine(Directory.GetCurrentDirectory(), "Lists");
            return Directory.GetFiles(listsRootPath);

        }

        private static void AddList(string listFile)
        {
            _list.Add(new ListData
            {
                Name = Path.GetFileNameWithoutExtension(listFile),
                Items = GetListItems(listFile),
                IsSelected = false
            });
        }

        private static List<string> GetListItems(string list)
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