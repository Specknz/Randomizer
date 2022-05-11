using System.IO;
using System.Collections.Generic;

namespace Randomizer.Models
{
    public class DataAccess
    {
        public static List<ListDataModel> GetListDataModelCollecton()
        {
            List<ListDataModel> listDataModelCollection = new();
            Dictionary<string, List<string>> listData = GetListData();

            foreach (var list in listData)
            {
                ListDataModel listDataModel = new();
                listDataModel.ListName = list.Key;
                listDataModel.ListItems = list.Value;
                listDataModel.IsSelected = true;
                listDataModelCollection.Add(listDataModel);
            }

            return listDataModelCollection;
        }

        private static Dictionary<string, List<string>> GetListData()
        {
            Dictionary<string, List<string>> listData = new();

            string[] lists = GetLists();
            foreach (string list in lists)
            {
                string listName = Path.GetFileNameWithoutExtension(list);
                List<string> listItems = GetListItems(list);
                
                listData.Add(listName, listItems);
            }
            return listData;
        }

        private static string[] GetLists()
        {
            string listsRootPath = Path.Combine(Directory.GetCurrentDirectory(), "Lists");
            return Directory.GetFiles(listsRootPath);

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
