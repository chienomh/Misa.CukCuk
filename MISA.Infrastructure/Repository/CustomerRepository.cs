using MISA.Core.Entites;
using MISA.Core.Interface.Infrastrure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySqlConnector;

namespace MISA.Infrastructure.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public int Delete(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            string connectionString = "" +
               "Host = 47.241.69.179;" +
               "Port = 3306;" +
               "Database = MF_FS_CukCuk;" +
               "User Id = nvmanh;" +
               "Password = 12345678";
            // Khởi tạo đối tượng kết nối và làm việc với Database
            IDbConnection dbConnection = new MySqlConnection(connectionString);

            // Thực thi các câu lệch dữ liệu trong Database
            var sqlCommand = $"SELECT * FROM Customer";

            var customers = dbConnection.Query<Customer>(sqlCommand).ToList();
            return customers;
        }

        public Customer GetById(Guid customerId)
        {
            // Khởi tạo kết nối với Database
            string connectionString = "" +
               "Host = 47.241.69.179;" +
               "Port = 3306;" +
               "Database = MF_FS_CukCuk;" +
               "User Id = nvmanh;" +
               "Password = 12345678";
            // Khởi tạo đối tượng kết nối và làm việc với Database
            IDbConnection dbConnection = new MySqlConnection(connectionString);

            // Thực thi các câu lệch dữ liệu trong Database
            var sqlCommand = $"SELECT * FROM Customer WHERE CustomerId = @CustomerId";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CustomerId", customerId);
            var customer = dbConnection.QueryFirstOrDefault<Customer>(sqlCommand, param: parameters);
            return customer;
        }

        public int Insert(Customer customer)
        {
            throw new NotImplementedException();
        }

        public int Update(Customer customer, Guid customerId)
        {
            throw new NotImplementedException();
        }
    }
}
