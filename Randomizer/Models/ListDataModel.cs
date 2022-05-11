using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer.Models
{
    public class ListDataModel
    {
        public string ListName { get; set; }
        public List<string> ListItems { get; set; }
        public bool IsSelected { get; set; }
    }
}
