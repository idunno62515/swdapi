using Dapper;
using SwdApp.Data.Dtos.Order;
using SwdApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data;

namespace SwdApp.Data.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly string connecionString;

        public OrderService(string connecionString)
        {
            this.connecionString = connecionString;
        }

        public async Task<OrderDto> GetOrderByTable(int tableId)
        {

            var order = new OrderDto();
            using (var con = new SqlConnection(connecionString))
            using 
                (
                    var result = (await con.QueryMultipleAsync(
                        "spOrderGetByTable",
                        new { tableId = tableId },
                        commandType: CommandType.StoredProcedure))
                )
            {
                var orderId = result.Read<int>().FirstOrDefault();
                var listOrderDetail = result.Read<OrderDetailDto>().DefaultIfEmpty();
                order.OrderId = orderId;
                order.Details = listOrderDetail;

            }

            return order;
        }

        public async Task<bool> ChangeOrderStatus(int id)
        {
            using (var con = new SqlConnection(connecionString))
            {
                var par = new DynamicParameters();
                par.Add("@id", id, DbType.Int32, direction: ParameterDirection.Input);
                par.Add("@ReturnValue", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                await con.ExecuteAsync(
                    "spOrderUpdateStatus",
                    par,
                    commandType: CommandType.StoredProcedure
                    );
                return par.Get<int>("@ReturnValue") == 1;
            }
        }

        public async Task<bool> SubmitOrder(OrderDto order)
        {
            using (var con = new SqlConnection(connecionString))
            {
                var tableDetail = GetDataTableDetail(order.Details);
                var param = new DynamicParameters();

                param.Add("@TotalAmount", order.TotalAmount, dbType: DbType.Double, direction: ParameterDirection.Input);
                param.Add("@TableId", order.TableId, dbType: DbType.Int32, direction: ParameterDirection.Input);
                param.Add("@ServedPerson", order.ServedPerson, dbType: DbType.String, direction: ParameterDirection.Input);
                param.Add("@DetailList", tableDetail.AsTableValuedParameter(), direction: ParameterDirection.Input);
                param.Add("@ReturnValue", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                await con.ExecuteAsync(
                    "spOrderInsert",
                    param,
                    commandType: CommandType.StoredProcedure
                    );

                var returnValue = param.Get<int>("@ReturnValue");

                return returnValue == 1;
            }
        }

        private DataTable GetDataTableDetail(IEnumerable<OrderDetailDto> details)
        {
            var tableDetail = new DataTable();
            tableDetail.Columns.Add("ProductId", typeof(int));
            tableDetail.Columns.Add("ProductCode", typeof(string));
            tableDetail.Columns.Add("ProductName", typeof(string));
            tableDetail.Columns.Add("TotalAmount", typeof(double));
            tableDetail.Columns.Add("Quantity", typeof(int));
            tableDetail.Columns.Add("Notes", typeof(string));
            tableDetail.Columns.Add("UnitPrice", typeof(double));

            foreach (var item in details)
            {

                tableDetail.Rows.Add(
                    new object[] {
                            item.ProductId,
                            item.ProductCode,
                            item.ProductName,
                            item.TotalAmount,
                            item.Quantity,
                            item.Notes,
                            item.UnitPrice
                    });
            }
            return tableDetail;

        }

      
    }
}
