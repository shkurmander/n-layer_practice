using n_layer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.DataAccess
{
    class MemoryContext
    {
        public List<Target> Targets { get; set; }
        public MemoryContext()
        {
            Targets = new List<Target>();
        }
    }
}
