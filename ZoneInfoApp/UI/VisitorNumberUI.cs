using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZoneInfoApp.BLL;
using ZoneInfoApp.DAL.DAO;

namespace ZoneInfoApp.UI
{
    public partial class VisitorNumberUI : Form
    {
        public VisitorNumberUI()
        {
            InitializeComponent();
        }

        ZoneManager manager=new ZoneManager();
        
        public void LoadZoneWiseVisitorInListView()
        {
            int message = 0;

            List<ZoneForVisit> zones = manager.GetZoneWiseVisitors(out message);
            int id = 1;
            zoneWithVisitorListView.Items.Clear();
            foreach (ZoneForVisit zone in zones)
            {
                ListViewItem listViewItem = new ListViewItem(id.ToString());
                listViewItem.SubItems.Add(zone.ZoneName);
                listViewItem.SubItems.Add(zone.zoneWiseTotalVisitor.ToString());


                zoneWithVisitorListView.Items.Add(listViewItem);
                id++;

            }
            grandTotalTextBox.Text = Convert.ToString(message);


        }

        
        private void VisitorNumberUI_Load(object sender, EventArgs e)
        {
            LoadZoneWiseVisitorInListView();
        }
    }
}
