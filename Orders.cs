using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOA_CheckoutApp
{
    class Orders
    {
        public interface IOrderDetails
        {
            List<object> OrderDetails(int a, int o, string l);
        }
    }

    
}
