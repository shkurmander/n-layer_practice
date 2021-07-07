
using n_layer.BusinessService;
using n_layer.DataAccess;

namespace n_layer.Common
{
    public static class TargetMapper
    {
        public static Target ToDAL(TargetBLL bllObj)
        {
            return new Target
            {
                Id = bllObj.Id,
                Name = bllObj.Name,
                Priority = bllObj.Priority,
                Text = bllObj.Text,
                State = bllObj.State
            };
        }
    }
}
