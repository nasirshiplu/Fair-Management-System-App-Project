using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZoneInfoApp.DAL.DAO;
using ZoneInfoApp.DAL.Gateway;

namespace ZoneInfoApp.BLL
{
    class VisitorManager
    {
        VisitorGateway vGateway = new VisitorGateway();
        public List<ZoneForVisit> LoadCheckedListBox()
        {
            return vGateway.LoadCheckedListBox();
        }

        public int SaveVisitorZone(int zoneId, int visitorId)
        {
            return vGateway.SaveVisitorZone(zoneId, visitorId);
        }

        public int GetZoneIDByName(string name)
        {
            return vGateway.GetZoneIDByName(name);
        }

        public int SaveVisitor(Visitor aVisitor)
        {
            return vGateway.SaveVisitor(aVisitor);
        }
    }
}
