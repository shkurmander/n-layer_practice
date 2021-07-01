using System;

namespace n_layer.DataAccess
{
    public class Notify : INotify
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public string Text { get; set; }
    }
}
