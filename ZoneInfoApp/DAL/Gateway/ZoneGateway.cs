using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ZoneInfoApp.DAL.DAO;

namespace ZoneInfoApp.DAL.Gateway
{
    class ZoneGateway
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["FairManagementDBConn"].ConnectionString;

        public string Save(ZoneForVisit aZone)
        {
            string message;
            SqlConnection connection=new SqlConnection(connectionString);
            string query = string.Format("insert Into tbl_Zone Values ('{0}')", aZone.ZoneName);
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            message = aZone.ZoneName+" has been saved";
            return message;
        }

        public bool IsZoneNameExist(string zoneName)
        {
            bool isZoneExist = false;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = string.Format("SELECT * FROM tbl_Zone WHERE name='{0}'", zoneName);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                isZoneExist = true;
                break;
            }
            reader.Close();
            connection.Close();
            return isZoneExist;
        }

        public List<ZoneForVisit> GetAllZone()
        {
            List<ZoneForVisit> zoneList = new List<ZoneForVisit>();
            SqlConnection connection = new SqlConnection(connectionString);

            string query = string.Format("SELECT *  FROM tbl_Zone");
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
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

        public List<ZoneForVisit> GetZoneWiseVisitors(out int zoneWiseTotal)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            List<ZoneForVisit> zones = new List<ZoneForVisit>();

            string query = string.Format(@" select tbl_Zone.name ,  COUNT(tbl_Visitor.email)  
                                         from tbl_Zone join tbl_Reference on tbl_Zone.id = tbl_Reference.zoneId
                                         join tbl_Visitor on tbl_Reference.visitorId = tbl_Visitor.id
                                         group by tbl_Zone.name");

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ZoneForVisit zone = new ZoneForVisit();
                zone.ZoneName = reader["name"].ToString();
                zone.zoneWiseTotalVisitor = Convert.ToInt16(reader[1]);

                zones.Add(zone);
            }
            connection.Close();
            zoneWiseTotal = GetTotalVisitor();
            return zones;
        }

        private int GetTotalVisitor()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = string.Format("select COUNT(visitorId) from tbl_Reference");
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            int totalVisitor = (int) cmd.ExecuteScalar();
            connection.Close();
            return totalVisitor;
        }

        public List<Visitor> GetAllVisitorInSpecificZone(string name)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            List<Visitor> visitors = new List<Visitor>();
            string query = string.Format(@"select tbl_Visitor.name , tbl_Visitor.email , tbl_Visitor.mobile
                                           from tbl_Visitor join tbl_Reference on tbl_Visitor.id =  tbl_Reference.visitorId
                                           join tbl_Zone  on tbl_Zone.id = tbl_Reference.zoneId
                                           where tbl_Zone.name ='{0}'", name);

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Visitor visitor = new Visitor();
                visitor.Name = reader[0].ToString();
                visitor.Email = reader[1].ToString();
                visitor.Mobile = reader[2].ToString();
                visitors.Add(visitor);
            }
            connection.Close();
            return visitors;
        }
    }
}
