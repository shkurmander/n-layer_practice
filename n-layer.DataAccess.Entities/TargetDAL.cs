using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.DataAccess
{
    [Serializable]
    public class TargetDAL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public string Text { get; set; }
        public bool State { get; set; }

    }
}
