using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZoneInfoApp.DAL.DAO;

namespace ZoneInfoApp.DAL.Gateway
{
    class VisitorGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["FairManagementDBConn"].ConnectionString;

        public List<ZoneForVisit> LoadCheckedListBox()
        {

            List<ZoneForVisit> zoneList = new List<ZoneForVisit>();
            SqlConnection connection = new SqlConnection(connectionString);

            string query = string.Format("SELECT * FROM tbl_Zone ");
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ZoneForVisit aZone = new ZoneForVisit();
                aZone.Id = Convert.ToInt32(reader["id"]);
                aZone.ZoneName = reader["name"].ToString();
                zoneList.Add(aZone);
            }
            reader.Close();
            connection.Close();
            return zoneList;
        }

        public int GetZoneIDByName(string name)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT ID FROM tbl_Zone WHERE name='" + name + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int Id = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return Id;
        }
        public int SaveVisitor(Visitor aVisitor)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = string.Format("INSERT INTO  tbl_Visitor OUTPUT INSERTED.id VALUES('{0}','{1}','{2}')", aVisitor.Name, aVisitor.Email, aVisitor.Mobile);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowsInserted = (int)command.ExecuteScalar();
            connection.Close();
            return rowsInserted;
        }

        public int SaveVisitorZone(int zoneId, int visitorId)
        {
            int rowsAffected = 0;
            string query = string.Format("INSERT INTO  tbl_Reference VALUES('{0}','{1}')", zoneId, visitorId);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
               rowsAffected = cmd.ExecuteNonQuery();
                connection.Close();
            }
            
            return rowsAffected;
        }
        public bool HasEmailExists(string email)
        {
            bool isEmailExist = false;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = string.Format("SELECT email FROM tbl_Visitor WHERE email='{0}'", email);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                isEmailExist = true;
                break;
            }
            reader.Close();
            connection.Close();
            return isEmailExist;
        }
    }
}
