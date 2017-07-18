using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage;
using UserConCollection;

namespace InventoryForm
{
    public enum Tab
    {
        Weap,Armor,Misc
    }

    public partial class inventoryForm : Form
    {
        public inventoryForm()
        {
            InitializeComponent();
        }

        public IButtons CurrentPanel
        {
            get
            {
                if (InvTabControl.SelectedIndex == 2)
                {
                    return miscInvControl1;
                }
                if (InvTabControl.SelectedIndex == 1)
                {
                    return armorInvControl1;
                }
                else
                {
                    return weaponInvControl1;
                }
            }
            set
            {
                CurrentPanel = value;
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            buttonControl1.ButtonInterfaces = CurrentPanel;
            buttonControl1.SubscribeButtons();
        }        

        private void InvTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonControl1.ButtonInterfaces = CurrentPanel;
            buttonControl1.SubscribeButtons();

        }

            

    }
}
