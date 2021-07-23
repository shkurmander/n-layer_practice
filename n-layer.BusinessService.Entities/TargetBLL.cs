

using System;

namespace n_layer.BusinessService
{
    public class TargetBLL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public string Text { get; set; }
        public bool State { get; set; } = false;
        public DateTime DateExpired { get; set; }
    }
}
