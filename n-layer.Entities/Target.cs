using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.Entities
{
    class Target
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public string Text { get; set; }
        public bool State { get; set; }
        public DateTime DateExpired { get; set; }
    }
}
