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



namespace AddInventoryForm
{
    public abstract class InvPanel : UserControl, IButtons
    {

        protected int CurrentRecord { get; set; }
        public List<GenericValues> InventoryList { get; set; }
        private List<Label> Asterisks = new List<Label>();
        public List<int> CurrentListKeys = new List<int>();



        public ListView CList;
        public static InvPanel CInventoryPanel { get; set; }
        public void EnableFields(bool val)
        {
            val = !val;
            foreach (var item in CInventoryPanel.Controls)
            {
                var textBoxs = item as TextBox;
                if (textBoxs != null)
                {
                    textBoxs.ReadOnly = val;
                }
                else
                {
                    ComboBox CboBox = (ComboBox)item;
                    CboBox.Enabled = !val;
                }
            }

        }
       

        public virtual bool SaveRecord()
        {
            LoadList();
            ClearFields();
            return true;
        }



        public void ClearAsterisks()
        {
            if (Asterisks.Count > 0)
            {
                foreach (Label item in Asterisks)
                {
                    item.Dispose();
                }
            }
        }
        public void Asterisk(Point p)
        {

            Label l = new Label();
            l.Location = new Point(p.X - 10, p.Y);
            l.Text = @"*";
            l.ForeColor = Color.Red;
            l.Font = new Font("Microsoft Sans Serif", 10);
            Asterisks.Add(l);
            CInventoryPanel.Controls.Add(l);
        }


        public virtual bool DataLoss()
        {
            foreach (var item in CInventoryPanel.Controls)
            {
                var textBoxs = item as TextBox;
                if (textBoxs != null)
                {
                    if (!string.IsNullOrEmpty(textBoxs.Text))
                    {
                        return true;
                    }
                }
                else
                {
                    ComboBox CboBox = (ComboBox)item;
                    if (!string.IsNullOrEmpty(CboBox.Text))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public void RemoveRecord()
        {

            var q = InventoryList.FindIndex(p => p.Key == CurrentRecord);
            InventoryList.RemoveAt(q);
            LoadList();
            ClearFields();


        }
        public void EditRecord()
        {


            LoadSelectedRecord();
            EnableFields(true);
        }
        public void ClearFields()
        {
            foreach (var item in CInventoryPanel.Controls)
            {
                var textBoxs = item as TextBox;
                if (textBoxs != null)
                {
                    textBoxs.Clear();
                }
                else
                {
                    ComboBox CboBox = (ComboBox)item;
                    CboBox.ResetText();
                    CboBox.SelectedIndex = -1;
                }
            }

        }
        bool tf = true;

        public void CancelProcess()
        {
            ClearFields();
            Asterisks.Clear();
            CurrentRecord = -1;
            EnableFields(false);



        }

        public void ForceNum(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedRecord();
            if (CList.SelectedIndices.Count > 0)
            {
                EditBtnEnable(true);
                RemoveBtnEnable(true);
            }
            else
            {
                EditBtnEnable(false);
                RemoveBtnEnable(false);
            }
        }
        public void ListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditRecord();
        }
        public abstract void Panel_Load(object sender, EventArgs e);

        Action<bool> EditBtnEnable;
        public void SubscribeEdit(Action<bool> Method)
        {
            EditBtnEnable = Method;
        }

        Action<bool> RemoveBtnEnable;
        public void SubscribeRemove(Action<bool> Method)
        {
            RemoveBtnEnable = Method;
        }

        public void LoadList()
        {
            CurrentListKeys.Clear();
            CList.Items.Clear();
            var q = InventoryList.Where(p => p is WeaponItem);
            foreach (var item in q.ToList())
            {
                CList.Items.Add(item.ItemID);
                CurrentListKeys.Add(item.Key);
            }
        }



        public abstract void LoadSelectedRecord();
        public abstract void SampleInput();
      
    }
}
