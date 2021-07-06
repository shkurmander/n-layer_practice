using System;
using System.Collections.Generic;

namespace n_layer.DataAccess
{
    public class Target : ITarget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public string Text { get; set; }
        public bool State { get; set; } = false;
    }
}
