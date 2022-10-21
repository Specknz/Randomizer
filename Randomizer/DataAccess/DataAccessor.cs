using Randomizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer.DataAccess
{
    public class ListDataAccessor
    {
        public static IEnumerable<ListData> GetListsFromFiles()
        {
            IEnumerable<ListData> lists = ListFileLoader.GetAllLists();

            return lists;
        }
    }
}
