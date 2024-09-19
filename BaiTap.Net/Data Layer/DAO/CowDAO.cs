using FarmManagement.Data_Layer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagement.Data_Layer.DAO
{
    public class CowDAO
    {
        string connectionString = "Data Source=NAMDAM\\SQLEXPRESS;Initial Catalog=ADO.Net;Integrated Security=True;";
        string querry = "INSERT INTO Cow (Name, Description) VALUES (@Name, @Description)";
        public CowDAO()
        {
            
        }
        public void InsertCow(Animal[] listAnimals)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();    
                for(int i = 0; i < listAnimals.Length; i++)
                {
                    if (listAnimals[i] is Cow)
                    {
                        SqlCommand cmd = new SqlCommand(querry, conn);
                        cmd.Parameters.AddWithValue("@Name", listAnimals[i].Name);
                        cmd.Parameters.AddWithValue("@Description", listAnimals[i].Description);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} row(s) inserted.");
                    }
                }
                conn.Close();
            }
        }
    }
}
