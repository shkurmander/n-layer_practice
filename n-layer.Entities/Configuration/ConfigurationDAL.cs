using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace n_layer.Entities.Configuration
{
    public class ConfigurationDAL
    {
        public TypeOfDao Type { get; set; }
      
        public string DbConnection { get; set; }
        public string FilePath { get; set; }

    }
}
