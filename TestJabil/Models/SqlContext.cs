using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TestJabil.Models
{
    public class SqlContext
    {
        SqlConnection conn;
        SqlCommand cmd;

        public SqlContext()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString);
        }

        public void runStoredProcedure(String building)
        {
            cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_InsertBuilding";
            cmd.Parameters.Add("@Building", System.Data.SqlDbType.VarChar, 255).Value = building;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void runStoredProcedure(String customer, String prefix, int FKBuilding)
        {
            cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_InsertCustomers";
            cmd.Parameters.Add("@Customer", System.Data.SqlDbType.VarChar, 255).Value = customer;
            cmd.Parameters.Add("@Prefix", System.Data.SqlDbType.VarChar, 255).Value = prefix;
            cmd.Parameters.Add("@FKBuilding", System.Data.SqlDbType.VarChar, 255).Value = FKBuilding;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Building> getAvailableBuildings()
        {
            List<Building> buildings = new List<Building>();
            cmd = new SqlCommand("SELECT * FROM Buildings", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Building building = new Building();
                building.PKBuilding = Int32.Parse(reader.GetValue(0).ToString());
                building.BuildingName = reader.GetValue(1).ToString();
                buildings.Add(building);
            }
            conn.Close();
            return buildings;
        }
    }
}