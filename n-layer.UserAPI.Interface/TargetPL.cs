using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.UserAPI.Interface
{
    public class TargetPL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public string Text { get; set; }
        public bool State { get; set; } = false;
    }
}
