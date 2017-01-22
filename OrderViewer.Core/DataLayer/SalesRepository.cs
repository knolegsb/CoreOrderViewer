using OrderViewer.Core.DataLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderViewer.Core.DataLayer.DataContracts;
using OrderViewer.Core.EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace OrderViewer.Core.DataLayer
{
    public class SalesRepository : Repository, ISalesRepository
    {
        public SalesRepository(AdventureWorksDbContext dbContext) : base(dbContext)
        {

        }

        public OrderHeaderViewModel GetOrder(Int32 orderId)
        {
            var entity = DbContext
                        .Set<SalesOrderHeader>()
                        .Include(p => p.CustomerFk.PersonFk)
                        .Include(p => p.CustomerFk.StoreFk)
                        .Include(p => p.SalesPersonFk)
                        .Include(p => p.SalesTerritoryFk)
                        .Include(p => p.ShipAddressFk)
                        .Include(p => p.BillAddressFk)
                        .Include(p => p.ShipAddressFk)
                        .Include(p => p.SalesOrderDetails)
                        .ThenInclude(p => p.ProductFk)
                        .FirstOrDefault(item => item.SalesOrderId == orderId);

            return entity == null ? null : new OrderHeaderViewModel(entity)
            {
                BillAddress = new AddressViewModel(entity.BillAddressFk),
                ShipAddress = new AddressViewModel(entity.ShipAddressFk),
                OrderDetails = new List<OrderDetailViewModel>(entity.SalesOrderDetails.Select(item => new OrderDetailViewModel(item)))
            };
        }

        public IEnumerable<OrderSummaryViewModel> GetOrders(Int32 pageSize, Int32 pageNumber, string salesOrderNumber, string customerName)
        {
            var query =
                from orderHeader in DbContext.Set<SalesOrderHeader>()
                join customer in DbContext.Set<Customer>()
                    on orderHeader.CustomerId equals customer.CustomerId
                join customerPersonJoin in DbContext.Set<Person>()
                    on customer.PersonId equals customerPersonJoin.BusinessEntityId
                        into customerPersonTemp
                from customerPerson in customerPersonTemp
                    .Where(relation => relation.BusinessEntityId == customer.PersonId)
                        .DefaultIfEmpty()
                join customerStoreJoin in DbContext.Set<Store>()
                    on customer.StoreId equals customerStoreJoin.BusinessEntityId
                        into customerStoreTemp
                from customerStore in customerStoreTemp
                    .Where(relation => relation.BusinessEntityId == customer.StoreId)
                        .DefaultIfEmpty()
                select new OrderSummaryViewModel
                {
                    SalesOrderId = orderHeader.SalesOrderId,
                    OrderDate = orderHeader.OrderDate,
                    DueDate = orderHeader.DueDate,
                    ShipDate = orderHeader.ShipDate,
                    SalesOrderNumber = orderHeader.SalesOrderNumber,
                    CustomerId = orderHeader.CustomerId,
                    CustomerName = customerPerson.FirstName + (customerPerson.MiddleName == null ? string.Empty : " " + customerPerson.MiddleName) + " " + customerPerson.LastName,
                    StoreName = customerStore == null ? string.Empty : customerStore.Name,
                    Lines = orderHeader.SalesOrderDetails.Count(),
                    TotalDue = orderHeader.TotalDue
                };

            if (!string.IsNullOrEmpty(salesOrderNumber))
            {
                query = query.Where(item => item.SalesOrderNumber.ToLower().Contains(salesOrderNumber.ToLower()));
            }

            if (!string.IsNullOrEmpty(customerName))
            {
                query = query.Where(item => item.CustomerName.ToLower().Contains(customerName.ToLower()));
            }

            if (string.IsNullOrEmpty(salesOrderNumber) && string.IsNullOrEmpty(customerName))
            {
                query = query.OrderByDescending(item => item.SalesOrderId);
            }

            return query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }
    }
}
