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

namespace ClassSkills
{
    public partial class SkillsForm : Form, IButtons
    {

        Action<bool> RemoveBtnEnable;
        public void SubscribeRemove(Action<bool> Method)
        {
            RemoveBtnEnable = Method;
        }
        Action<bool> EditBtnEnable;
        public void SubscribeEdit(Action<bool> Method)
        {
            EditBtnEnable = Method;
        }
        private List<Label> Asterisks = new List<Label>();
        private List<int> CurrentListKeys = new List<int>();


        private List<SkillType> list = Storage.Storage.Skills;
        private int cRecord = -1;


        public SkillsForm()
        {
            InitializeComponent();
        }

        private void ClassSkillCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ModCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void skillNamTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void DesTb_TextChanged(object sender, EventArgs e)
        {

        }

        public void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedRecord();
            if (skillList.SelectedIndices.Count > 0)
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

        public void Panel_Load(object sender, EventArgs e)
        {

            EnableFields(false);
            LoadList();
        }

        public bool SaveRecord()
        {
            if (Asterisks.Count > 0)
            {
                foreach (Label item in Asterisks)
                {
                    item.Dispose();
                }
            }
            if (!ValidateFields())
            {
                MessageBox.Show("Please Ensure you fill all Mandatory Fields");
                return false;
            }
            if (cRecord != -1)
            {
                var query = list.FindIndex(p => p.Key == cRecord);
                list[query].SkillName = skillNamTb.Text;
                list[query].AbilityMod = (Mod)ModCombo.SelectedIndex;
                list[query].Description = DesTb.Text;
                list[query].ClassSkill = ClassSkillCheck.Checked;
            }
            else
            {
                list.Add(new SkillType(skillNamTb.Text, DesTb.Text, (Mod)ModCombo.SelectedIndex, ClassSkillCheck.Checked));

            }
            LoadList();
            ClearFields();
            skillList.Enabled = true;

            return true;
        }


        public void ClearFields()
        {
            ClassSkillCheck.Checked = false;
            skillNamTb.Text = string.Empty;
            ModCombo.SelectedIndex = -1;
            ModCombo.ResetText();
            DesTb.Text = string.Empty;
        }

        public void EditRecord()
        {
            skillList.Enabled = false;
            LoadSelectedRecord();
            EnableFields(true);
        }

        public bool DataLoss()
        {
            if (cRecord != -1)
            {
                if (ClassSkillCheck.Checked != list[cRecord].ClassSkill)
                {
                    return true;
                }
                if ((Mod)ModCombo.SelectedIndex != list[cRecord].AbilityMod)
                {
                    return true;

                }
                if (skillNamTb.Text != list[cRecord].SkillName)
                {
                    return true;

                }
                if (DesTb.Text != list[cRecord].Description)
                {
                    return true;

                }
                return false;
            }


            if (ModCombo.SelectedIndex != -1)
            {
                return true;

            }
            if (!string.IsNullOrEmpty(skillNamTb.Text))
            {
                return true;

            }
            if (!string.IsNullOrEmpty(DesTb.Text))
            {
                return true;

            }
            return false;

        }

        public void RemoveRecord()
        {
            var q = list.FindIndex(p => p.Key == cRecord);
            list.RemoveAt(q);
            LoadList();
        }

        public void EnableFields(bool val)
        {
            foreach (Control item in Fields.Controls)
            {
                item.Enabled = val;
            }
        }

        public void SampleInput()
        {
            
        }

        private void LoadSelectedRecord()
        {
            int temp = -1;
            foreach (var item in skillList.SelectedIndices)
            {
                temp = (int)item;
            }
            if (temp != -1)
            {
                cRecord = CurrentListKeys[temp];
                SkillType q = list.Find(p => p.Key == cRecord);
                ClassSkillCheck.Checked = q.ClassSkill;
                ModCombo.SelectedIndex = (int)q.AbilityMod;
                skillNamTb.Text = q.SkillName;
                DesTb.Text = q.Description;
            }

        }

        private void LoadList()
        {
            CurrentListKeys.Clear();
            skillList.Items.Clear();

            foreach (var item in list)
            {
                skillList.Items.Add(item.SkillName);
                CurrentListKeys.Add(item.Key);
            }
        }

        private bool ValidateFields()
        {
            if (skillNamTb.Text.Length < 1)
            {
                Asterisk(ClassSkillLbl.Location);
                return false;
            }
            if (ModCombo.SelectedIndex < 0)
            {
                Asterisk(ModTypeLbl.Location);
                return false;
            }
            if (DesTb.Text.Length < 1)
            {
                Asterisk(DesLbl.Location);
                return false;
            }
            return true;

        }


        private void Asterisk(Point p)
        {

            Label l = new Label();
            l.Location = new Point(p.X - 10, p.Y);
            l.Text = @"*";
            l.ForeColor = Color.Red;
            l.Font = new Font("Microsoft Sans Serif", 10);
            Asterisks.Add(l);
            this.Controls.Add(l);
        }

        private void buttonControl_Load(object sender, EventArgs e)
        {
            buttonControl.ButtonInterfaces = this;
            buttonControl.SubscribeButtons();
        }
    }
}
