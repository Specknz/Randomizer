using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer.Models
{
    public class ListData
    {
        public string Name { get; init; }
        public IEnumerable<string> Items { get; init; }
        public bool IsSelected { get; set; }

        public void IsSelectedChanged(bool accessibility)
        {
            IsSelected = accessibility;
        }
    }
}
