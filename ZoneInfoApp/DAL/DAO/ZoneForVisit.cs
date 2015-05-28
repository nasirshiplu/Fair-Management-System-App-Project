using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ZoneInfoApp.DAL.DAO
{
    public class ZoneForVisit
    {
        public int Id { set; get; }
        public string ZoneName { set; get; }
        public int zoneWiseTotalVisitor { get; set; }  
    }
}
