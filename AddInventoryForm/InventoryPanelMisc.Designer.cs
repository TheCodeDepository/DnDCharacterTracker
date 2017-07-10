namespace AddInventoryForm
{
    partial class InventoryPanelMisc
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
            this.WeaponListBox = new System.Windows.Forms.ListView();
            this.ItemIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NotesTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ItemIDTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.WeightTb = new System.Windows.Forms.TextBox();
            this.CostTB = new System.Windows.Forms.TextBox();
            this.UpgradesTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WeaponListBox
            // 
            this.WeaponListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemIDColumn});
            this.WeaponListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WeaponListBox.Location = new System.Drawing.Point(3, 3);
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
            // NotesTb
            // 
            this.NotesTb.Location = new System.Drawing.Point(345, 206);
            this.NotesTb.Multiline = true;
            this.NotesTb.Name = "NotesTb";
            this.NotesTb.Size = new System.Drawing.Size(262, 108);
            this.NotesTb.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(292, 207);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "Notes:";
            // 
            // ItemIDTb
            // 
            this.ItemIDTb.Location = new System.Drawing.Point(345, 20);
            this.ItemIDTb.Name = "ItemIDTb";
            this.ItemIDTb.Size = new System.Drawing.Size(121, 20);
            this.ItemIDTb.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(286, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Item ID:";
            // 
            // WeightTb
            // 
            this.WeightTb.Location = new System.Drawing.Point(345, 94);
            this.WeightTb.Name = "WeightTb";
            this.WeightTb.Size = new System.Drawing.Size(121, 20);
            this.WeightTb.TabIndex = 52;
            // 
            // CostTB
            // 
            this.CostTB.Location = new System.Drawing.Point(345, 57);
            this.CostTB.Name = "CostTB";
            this.CostTB.Size = new System.Drawing.Size(121, 20);
            this.CostTB.TabIndex = 49;
            // 
            // UpgradesTb
            // 
            this.UpgradesTb.Location = new System.Drawing.Point(345, 132);
            this.UpgradesTb.Multiline = true;
            this.UpgradesTb.Name = "UpgradesTb";
            this.UpgradesTb.Size = new System.Drawing.Size(262, 57);
            this.UpgradesTb.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(267, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Upgrades:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(285, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Weight:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(301, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Cost:";
            // 
            // InventoryPanelMisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WeaponListBox);
            this.Controls.Add(this.NotesTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ItemIDTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WeightTb);
            this.Controls.Add(this.CostTB);
            this.Controls.Add(this.UpgradesTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "InventoryPanelMisc";
            this.Size = new System.Drawing.Size(615, 485);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView WeaponListBox;
        private System.Windows.Forms.ColumnHeader ItemIDColumn;
        private System.Windows.Forms.TextBox NotesTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ItemIDTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox WeightTb;
        private System.Windows.Forms.TextBox CostTB;
        private System.Windows.Forms.TextBox UpgradesTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}
