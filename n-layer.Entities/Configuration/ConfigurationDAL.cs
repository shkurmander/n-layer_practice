using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.Entities.Configuration
{
    public class ConfigurationDAL
    {
        public TypeOfDao Type { get; set; }
        public string DbConnection { get; set; }
    }
}
