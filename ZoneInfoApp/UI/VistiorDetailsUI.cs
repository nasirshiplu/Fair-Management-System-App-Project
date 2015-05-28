using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZoneInfoApp.BLL;
using ZoneInfoApp.DAL.DAO;

namespace ZoneInfoApp.UI
{

    public partial class VistiorDetailsUI : Form
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["FairManagementDBConn"].ConnectionString;

        public VistiorDetailsUI()
        {
            InitializeComponent();
        }

        private ZoneManager manager = new ZoneManager();

        private void LoadAllZonesInComboBox()
        {
            List<ZoneForVisit> zones = manager.GetZoneListAll();
            foreach (ZoneForVisit zone in zones)
            {
                zoneComboBox.Items.Add(zone.ZoneName);
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (zoneComboBox.SelectedIndex == -1)
            {
                MessageBox.Show(@"Please select a zone type .", @"Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                List<Visitor> visitors = manager.GetAllVisitorInSpecificZone(zoneComboBox.SelectedItem.ToString());
                int id = 1;
                visitorDetailsListView.Items.Clear();
                foreach (Visitor visitor in visitors)
                {
                    ListViewItem item = new ListViewItem(id.ToString());

                    item.SubItems.Add(visitor.Name.ToString());
                    item.SubItems.Add(visitor.Email.ToString());
                    item.SubItems.Add(visitor.Mobile.ToString());
                    visitorDetailsListView.Items.Add(item);
                    id++;
                }
                totalTextBox.Text = (id - 1).ToString();
            }
        }

        private void VistiorDetailsUI_Load(object sender, EventArgs e)
        {
            LoadAllZonesInComboBox();
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet) wb.Worksheets[1];
            int i = 1;
            int i2 = 1;

            foreach (ListViewItem lvi in visitorDetailsListView.Items)
            {
                i = 1;
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    ws.Cells[i2, i] = lvs.Text;
                    i++;
                }
                i2++;
            }

        }
    }
}
