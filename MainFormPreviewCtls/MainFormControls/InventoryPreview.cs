using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage;
using InventoryForm;



namespace MainFormPreviewCtls

{

    public partial class InventoryPreview : UserControl
    {

        private enum Filter
        {
            Catagory, Weapon, Armour, Misc

        }

        private List<GenericValues> InventoryList;


        public InventoryPreview()
        {
            InitializeComponent();
            InventoryList = Storage.Storage.InventoryList;
            

        }


        private void MngInvButton_Click(object sender, EventArgs e)
        {
            inventoryForm window = new inventoryForm();

            window.ShowDialog();
            RefreshList();

        }

        private void InventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FilterCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            InventoryListBox.Items.Clear();
            switch (FilterCbo.SelectedIndex)
            {
                case (int)Filter.Catagory:
                    RefreshList();
                    break;
                case (int)Filter.Weapon:

                    foreach (var item in InventoryList)
                    {
                        if (item is WeaponItem)
                        {
                            var t = new string[] { item.ItemID, item.Value.ToString(), item.Notes };
                            InventoryListBox.Items.Add(new ListViewItem(t));
                        }

                    }

                    break;
                case (int)Filter.Armour:

                    foreach (var item in InventoryList)
                    {
                        if (item is ArmorItem)
                        {
                            var t = new string[] { item.ItemID, item.Value.ToString(), item.Notes };
                            InventoryListBox.Items.Add(new ListViewItem(t));
                        }

                    }
                    break;
                case (int)Filter.Misc:

                    foreach (var item in InventoryList)
                    {
                        if (item is MiscInvItem)
                        {
                            var t = new string[] { item.ItemID, item.Value.ToString(), item.Notes };
                            InventoryListBox.Items.Add(new ListViewItem(t));
                        }

                    }

                    break;
                default:
                    break;
            }

        }

        private void RefreshList()
        {
            InventoryListBox.Items.Clear();
            foreach (var item in InventoryList)
            {
                var t = new string[] { item.ItemID, item.Value.ToString(), item.Notes };
                InventoryListBox.Items.Add(new ListViewItem(t));
            }
        }


    }
}
