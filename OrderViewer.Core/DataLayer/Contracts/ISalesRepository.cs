using OrderViewer.Core.DataLayer.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.DataLayer.Contracts
{
    public interface ISalesRepository : IDisposable
    {
        IEnumerable<OrderSummaryViewModel> GetOrders(Int32 pageSize, Int32 pageNumber, string salesOrderName, string customerName);

        OrderHeaderViewModel GetOrder(Int32 orderId);
    }
}
