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
using ZoneInfoApp.DAL.Gateway;

namespace ZoneInfoApp.UI
{
    public partial class VisitorEntryUI : Form
    {
        int lastGeneratedId = 0;
        public VisitorEntryUI()
        {
            InitializeComponent();
            LoadCheckedListBox();
        }
       VisitorManager vManager=new VisitorManager();
        VisitorGateway vGateway=new VisitorGateway();
        ZoneForVisit zoneForVisit=new ZoneForVisit();
        Visitor aVisitor=new Visitor();
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (visitorNameTextBox.Text == "" || emailTextBox.Text == "" || contactNumberTextBox.Text == "")
            {
                MessageBox.Show("pls fill up the text box !");
            }
            else
            {
                aVisitor.Name = visitorNameTextBox.Text;
                aVisitor.Email = emailTextBox.Text;
                aVisitor.Mobile = contactNumberTextBox.Text;

                if (vGateway.HasEmailExists(aVisitor.Email))
                {
                    MessageBox.Show("A Visitor already Exist with this Email ! ", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lastGeneratedId = (vManager.SaveVisitor(aVisitor));
                    if (lastGeneratedId > 0)
                    {
                        MessageBox.Show("Visitor Added Successfully", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetTextTextBoxesClear();
                    }
                    else
                    {
                        MessageBox.Show("Not Added !!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            List<string> items = new List<string> { };
            foreach (var checkedItem in zoneNameCheckedListBox.CheckedItems)
            {
                items.Add(zoneNameCheckedListBox.GetItemText(checkedItem));
            }
            foreach (var item in items)
            {
                int zoneID = vManager.GetZoneIDByName(item);
                vManager.SaveVisitorZone(zoneID, lastGeneratedId);
            }
        }
        public void LoadCheckedListBox()
        {
            List<ZoneForVisit> zoneList = vManager.LoadCheckedListBox();
            foreach (ZoneForVisit zone in zoneList)
            {
                zoneNameCheckedListBox.Items.Add(zone.ZoneName, true);
            }
        }
        public void GetTextTextBoxesClear()
        {
            visitorNameTextBox.Clear();
            emailTextBox.Clear();
            contactNumberTextBox.Clear();
        }
    }
}
