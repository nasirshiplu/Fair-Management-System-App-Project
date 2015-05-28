using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZoneInfoApp.DAL.DAO;
using ZoneInfoApp.DAL.Gateway;

namespace ZoneInfoApp.BLL
{
    class ZoneManager
    {
        ZoneGateway gateway = new ZoneGateway();
        
        public string Save(ZoneForVisit aZone)
        {
            if(gateway.IsZoneNameExist(aZone.ZoneName))
            {
                return "Zone Type Already Exists";
            }
            else
            {
                return gateway.Save(aZone);
            }
        }

        public List<ZoneForVisit> GetZoneListAll()
        {
            return gateway.GetAllZone();
        }


        public List<ZoneForVisit> GetZoneWiseVisitors(out int totalZoneVisitor)
        {

            int totalVisitor = 0;

            List<ZoneForVisit> zones = gateway.GetZoneWiseVisitors(out totalVisitor);

            totalZoneVisitor = totalVisitor;
            return zones;
        }

        public List<Visitor> GetAllVisitorInSpecificZone(string zoneType)
        {
            return gateway.GetAllVisitorInSpecificZone(zoneType);
        }
       
    }
}
