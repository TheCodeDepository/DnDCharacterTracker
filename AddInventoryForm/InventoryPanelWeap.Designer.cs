namespace AddInventoryForm
{
    partial class InventoryPanelWeap
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.WeaponListBox = new System.Windows.Forms.ListView();
            this.ItemIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.NotesTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ItemIDTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.WeightTb = new System.Windows.Forms.TextBox();
            this.CriticalTb = new System.Windows.Forms.TextBox();
            this.DamageTb = new System.Windows.Forms.TextBox();
            this.CostTB = new System.Windows.Forms.TextBox();
            this.RangeTb = new System.Windows.Forms.TextBox();
            this.UpgradesTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeOfWeap = new System.Windows.Forms.ComboBox();
            this.WeapTypeLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.WeaponListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 486);
            this.panel1.TabIndex = 0;
            // 
            // WeaponListBox
            // 
            this.WeaponListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemIDColumn});
            this.WeaponListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WeaponListBox.Location = new System.Drawing.Point(5, 3);
            this.WeaponListBox.Name = "WeaponListBox";
            this.WeaponListBox.Size = new System.Drawing.Size(253, 480);
            this.WeaponListBox.TabIndex = 57;
            this.WeaponListBox.UseCompatibleStateImageBehavior = false;
            this.WeaponListBox.View = System.Windows.Forms.View.Details;
            // 
            // ItemIDColumn
            // 
            this.ItemIDColumn.Text = "Item ID";
            this.ItemIDColumn.Width = 246;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NotesTb);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.ItemIDTb);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.WeightTb);
            this.panel2.Controls.Add(this.CriticalTb);
            this.panel2.Controls.Add(this.DamageTb);
            this.panel2.Controls.Add(this.CostTB);
            this.panel2.Controls.Add(this.RangeTb);
            this.panel2.Controls.Add(this.UpgradesTb);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TypeOfWeap);
            this.panel2.Controls.Add(this.WeapTypeLbl);
            this.panel2.Location = new System.Drawing.Point(265, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 479);
            this.panel2.TabIndex = 58;
            // 
            // NotesTb
            // 
            this.NotesTb.Location = new System.Drawing.Point(83, 346);
            this.NotesTb.Multiline = true;
            this.NotesTb.Name = "NotesTb";
            this.NotesTb.Size = new System.Drawing.Size(262, 108);
            this.NotesTb.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(30, 347);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 73;
            this.label8.Text = "Notes:";
            // 
            // ItemIDTb
            // 
            this.ItemIDTb.Location = new System.Drawing.Point(83, 12);
            this.ItemIDTb.Name = "ItemIDTb";
            this.ItemIDTb.Size = new System.Drawing.Size(121, 20);
            this.ItemIDTb.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(24, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 71;
            this.label7.Text = "Item ID:";
            // 
            // WeightTb
            // 
            this.WeightTb.Location = new System.Drawing.Point(83, 86);
            this.WeightTb.Name = "WeightTb";
            this.WeightTb.Size = new System.Drawing.Size(121, 20);
            this.WeightTb.TabIndex = 70;
            // 
            // CriticalTb
            // 
            this.CriticalTb.Location = new System.Drawing.Point(83, 160);
            this.CriticalTb.Name = "CriticalTb";
            this.CriticalTb.Size = new System.Drawing.Size(121, 20);
            this.CriticalTb.TabIndex = 69;
            // 
            // DamageTb
            // 
            this.DamageTb.Location = new System.Drawing.Point(83, 123);
            this.DamageTb.Name = "DamageTb";
            this.DamageTb.Size = new System.Drawing.Size(121, 20);
            this.DamageTb.TabIndex = 68;
            // 
            // CostTB
            // 
            this.CostTB.Location = new System.Drawing.Point(83, 49);
            this.CostTB.Name = "CostTB";
            this.CostTB.Size = new System.Drawing.Size(121, 20);
            this.CostTB.TabIndex = 67;
            // 
            // RangeTb
            // 
            this.RangeTb.Location = new System.Drawing.Point(83, 235);
            this.RangeTb.Name = "RangeTb";
            this.RangeTb.Size = new System.Drawing.Size(121, 20);
            this.RangeTb.TabIndex = 66;
            // 
            // UpgradesTb
            // 
            this.UpgradesTb.Location = new System.Drawing.Point(83, 272);
            this.UpgradesTb.Multiline = true;
            this.UpgradesTb.Name = "UpgradesTb";
            this.UpgradesTb.Size = new System.Drawing.Size(262, 57);
            this.UpgradesTb.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(5, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "Upgrades:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(23, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 63;
            this.label5.Text = "Weight:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(25, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "Range:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(25, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Critical:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(14, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Damage:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "Cost:";
            // 
            // TypeOfWeap
            // 
            this.TypeOfWeap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeOfWeap.FormattingEnabled = true;
            this.TypeOfWeap.Items.AddRange(new object[] {
            "Melee",
            "Ranged"});
            this.TypeOfWeap.Location = new System.Drawing.Point(83, 197);
            this.TypeOfWeap.Name = "TypeOfWeap";
            this.TypeOfWeap.Size = new System.Drawing.Size(121, 21);
            this.TypeOfWeap.TabIndex = 58;
            // 
            // WeapTypeLbl
            // 
            this.WeapTypeLbl.AutoSize = true;
            this.WeapTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WeapTypeLbl.Location = new System.Drawing.Point(35, 198);
            this.WeapTypeLbl.Margin = new System.Windows.Forms.Padding(10);
            this.WeapTypeLbl.Name = "WeapTypeLbl";
            this.WeapTypeLbl.Size = new System.Drawing.Size(44, 17);
            this.WeapTypeLbl.TabIndex = 57;
            this.WeapTypeLbl.Text = "Type:";
            // 
            // InventoryPanelWeap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "InventoryPanelWeap";
            this.Size = new System.Drawing.Size(621, 486);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView WeaponListBox;
        private System.Windows.Forms.ColumnHeader ItemIDColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox NotesTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ItemIDTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox WeightTb;
        private System.Windows.Forms.TextBox CriticalTb;
        private System.Windows.Forms.TextBox DamageTb;
        private System.Windows.Forms.TextBox CostTB;
        private System.Windows.Forms.TextBox RangeTb;
        private System.Windows.Forms.TextBox UpgradesTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeOfWeap;
        private System.Windows.Forms.Label WeapTypeLbl;
    }
}
