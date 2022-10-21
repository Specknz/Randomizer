using Randomizer.DataAccess;
using Randomizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer.Stores
{
    public class ListDataStore
    {
        private List<ListData> _listData;
        public event Action ListDataChanged;

        public ListDataStore()
        {
            _listData = ListFileLoader.GetAllLists();
        }

        public IEnumerable<ListData> GetAllListsData()
        {
            return _listData;
        }

        public void OnListDataChanged()
        {
            ListDataChanged?.Invoke();
        }
    }
}
