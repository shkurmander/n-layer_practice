

using n_layer.DataAccess;
using System.Linq;

namespace n_layer.Common
{
    public static class Helpers
    {
        public static int getNewId()
        {
            var _da = new DataAccsessImpl();
            var list = _da.GetEntities();
            if (list.Count == 0)
                return 1;
            else
                return list.Select(t => t.Id).ToList().Max() + 1;
            
        }
    }
}
