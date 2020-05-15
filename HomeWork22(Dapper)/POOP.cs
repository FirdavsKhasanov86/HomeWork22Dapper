using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using System.Data;
using System.Linq;

namespace HomeWork22_Dapper
{
    class POOP
    {
        //Insert
        const string ConnectionString = "Data Source=localhost;Initial Catalog=Shop;Integrated Security=True";
        public static void Add(AlifShop product)
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                con.Query($"INSERT INTO AlifShop (Company, Model) Values('{product.Company}','{product.Model}')");
               
            }


        }
        //Select
        public static List<T> Read<T>()
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                return con.Query<T>($"SELECT * FROM {typeof(T).Name?.ToUpper()}").ToList();
            }
        }

        //Update
        public static void Update(AlifShop product)
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                con.Query<AlifShop>($"Update AlifShop SET Company='{product.Company}', Model='{product.Model}' WHERE ID={product.Id}");
            }
        }

        //Delete
        public static void Delete(AlifShop product)
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                con.Query<AlifShop>($"DELETE FROM AlifShop WHERE ID={product.Id}");
            }
        }


    }
}
