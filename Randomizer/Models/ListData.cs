using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer.Models
{
    public sealed class ListData
    {
        public string Name { get; set; }
        public List<string> Items { get; set; }
        public bool IsSelected { get; set; }
    }
}
