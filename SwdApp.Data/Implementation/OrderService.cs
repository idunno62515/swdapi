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

        public async Task<bool> SubmitOrder(OrderDto order)
        {
            using (var con = new SqlConnection(connecionString))
            {
                var tableDetail = GetDataTableDetail(order.Details);
                var table = new DataTable { Columns = { { "id", typeof(int) } }, Rows = { { 1 }, { 2 }, { 3 } } };

                var param = new DynamicParameters();

                param.Add("@TotalAmount", order.TotalAmount, dbType: DbType.Double, direction: ParameterDirection.Input);
                param.Add("@TableId", order.TableId, dbType: DbType.Int32, direction: ParameterDirection.Input);
                param.Add("@ServedPerson", order.ServedPerson, dbType: DbType.String, direction: ParameterDirection.Input);
                param.Add("@DetailList", tableDetail.AsTableValuedParameter(), direction: ParameterDirection.Input);
                param.Add("@ReturnValue", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                var res = await con.ExecuteAsync(
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

            //details.ToList().ForEach(x => tableDetail.Rows.Add(
            //        x.ProductId,
            //        x.ProductCode,
            //        x.ProductName,
            //        x.TotalAmount,
            //        x.Quantity,
            //        x.Notes,
            //        x.UnitPrice
            //    ));



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
