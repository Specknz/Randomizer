using Randomizer.DataAccess;
using Randomizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer.Stores
{
    public sealed class ListDataStore
    {
        private IEnumerable<ListData> _listData;

        public ListDataStore()
        {
            _listData = ListFileLoader.LoadListData();
        }

        public IEnumerable<ListData> GetLists()
        {
            return _listData;
        }
    }
}
