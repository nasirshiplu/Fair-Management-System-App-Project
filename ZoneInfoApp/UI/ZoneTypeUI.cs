using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZoneInfoApp.BLL;
using ZoneInfoApp.DAL.DAO;

namespace ZoneInfoApp.UI
{
    public partial class ZoneTypeUI : Form
    {
        
        public ZoneTypeUI()
        {
            InitializeComponent();
        }
        ZoneManager zoneManager = new ZoneManager();
        private ZoneForVisit aZone=new ZoneForVisit();
        private void saveButton_Click(object sender, EventArgs e)
        {

            aZone.ZoneName = zoneNameTextBox.Text;

            if (zoneNameTextBox.Text != "")
            {
                MessageBox.Show(zoneManager.Save(aZone));
                LoadListView();
                zoneNameTextBox.Clear();
            }
            else
            {
                MessageBox.Show(@"Please enter the  type ", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadListView()
        {
            zoneListView.Items.Clear();
            List<ZoneForVisit> zoneList = zoneManager.GetZoneListAll();
            int id = 1;
            foreach (ZoneForVisit zone in zoneList)
            {
                ListViewItem items = new ListViewItem(id.ToString());
                items.SubItems.Add(zone.ZoneName);
                zoneListView.Items.Add(items);
                id++;
            }
        }
    }
}
