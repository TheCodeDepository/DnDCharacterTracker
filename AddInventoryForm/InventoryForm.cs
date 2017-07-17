using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddInventoryForm
{
    public enum Tab
    {
        Weap, Armor, Misc
    }

    public partial class InventoryForm : Form
    {


        public InventoryForm()
        {
            InitializeComponent();


        }
        public ListView CList { get; set; }


        public List<InvPanel> InventoryPanels = new List<InvPanel>();

        public InvPanel CurrentPanel
        {
            get
            {
                return InventoryPanels[InvTabControl.SelectedIndex];

            }
            set
            {
                CurrentPanel = value;
            }
        }
        ButtonControl Controller = new ButtonControl();

        private void Inventory_Load(object sender, EventArgs e)
        {
            InventoryPanels.Add(new WeaponInvControl());
            InventoryPanels.Add(new ArmorInvControl());
            InventoryPanels.Add(new MiscInvControl());
            CurrentPanel = InventoryPanels[0];

            Controller.Location = new Point(685, 50);
            Controls.Add(Controller);

            foreach (InvPanel item in InventoryPanels)
            {
                item.Location = new Point(5, 5);
            }
            for (int i = 0; i < InventoryPanels.Count; i++)
            {
                InvTabControl.TabPages[i].Controls.Add(InventoryPanels[i]);

            }


        }

        private void InvTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controller.CurrentPanel = CurrentPanel;
            InvPanel.CInventoryPanel = CurrentPanel;

        }



    }
}
