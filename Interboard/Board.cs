using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interboard
{
    public class Board
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<String> Lines { get; set; }
        public List<String> Items { get; set; }

        public Board(string name)
        {
            this.Name = name;
            this.Lines = new List<string>();
            this.Items = new List<string>();
        }

        public bool IsEmpty()
        {
            return (Lines.Count==0);
        }
    }
}
