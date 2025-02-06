using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using crudC.models;
using Npgsql;

namespace crudC.conn
{
    public class Conn
    {
        private NpgsqlConnection connection;

        private String cadenaconn = "Host=192.168.0.199;Port=5432;Database=dev;Username=jorge;Password=123";

        public Conn()
        {
            connection = new NpgsqlConnection(cadenaconn);
        }

        public string openConn()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conexion abierta");
                return "Conn ok";

            }
            catch (System.Exception)
            {

                throw;
            }

        }

        public string closeConn()
        {
            try
            {
                connection.Close();
                Console.WriteLine("conn cerrada");
                return "close conn";
            }
            catch (System.Exception)
            {
                throw;
            }

        }
        public void runSql(String query)
        {
            try
            {
                List<User> arrayList = new List<User>();
                openConn();
                using (NpgsqlCommand npgsql = new NpgsqlCommand(query, connection))
                {
                    Console.WriteLine("con");
                    using (NpgsqlDataReader lector = npgsql.ExecuteReader())
                    {
                        var flag = lector.Read();
                        while (flag)
                        {
                            Console.WriteLine("con");
                            User userModel = new User();
                            userModel.Id = lector.GetInt32(0);
                            userModel.Name = lector.GetString(1);

                            arrayList.Add(userModel);

                        }

                    }

                }
                closeConn();
            }
            catch (System.Exception)
            {

                throw;
            }

        }

        public void runSqlDataTable(String query)
        {
            try
            {
                openConn();

                DataTable dataTable = new DataTable();
                using (NpgsqlDataAdapter run = new NpgsqlDataAdapter(query, connection))
                {
                    run.Fill(dataTable);

                }

                foreach (DataRow fila in dataTable.Rows)
                {
                    Console.WriteLine($"ID: {fila["id"]}, ,Nombre: {fila["name"]},Apellido: {fila["lastname"]},Edad: {fila["age"]}");

                }
                closeConn();
            }
            catch (System.Exception)
            {

                throw;
            }

        }

    }
}