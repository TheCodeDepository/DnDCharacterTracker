namespace AddInventoryForm
{
    partial class MiscInvControl
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
            this.UsageTb = new System.Windows.Forms.TextBox();
            this.UsageLb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FieldsPanel = new System.Windows.Forms.Panel();
            this.FieldsPanel.SuspendLayout();
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
            this.NotesTb.Location = new System.Drawing.Point(3, 189);
            this.NotesTb.Multiline = true;
            this.NotesTb.Name = "NotesTb";
            this.NotesTb.Size = new System.Drawing.Size(262, 108);
            this.NotesTb.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(286, 208);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "Notes:";
            // 
            // ItemIDTb
            // 
            this.ItemIDTb.Location = new System.Drawing.Point(3, 3);
            this.ItemIDTb.Name = "ItemIDTb";
            this.ItemIDTb.Size = new System.Drawing.Size(121, 20);
            this.ItemIDTb.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(280, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Item ID:";
            // 
            // WeightTb
            // 
            this.WeightTb.Location = new System.Drawing.Point(3, 77);
            this.WeightTb.Name = "WeightTb";
            this.WeightTb.Size = new System.Drawing.Size(121, 20);
            this.WeightTb.TabIndex = 52;
            // 
            // CostTB
            // 
            this.CostTB.Location = new System.Drawing.Point(3, 40);
            this.CostTB.Name = "CostTB";
            this.CostTB.Size = new System.Drawing.Size(121, 20);
            this.CostTB.TabIndex = 49;
            // 
            // UsageTb
            // 
            this.UsageTb.Location = new System.Drawing.Point(3, 115);
            this.UsageTb.Multiline = true;
            this.UsageTb.Name = "UsageTb";
            this.UsageTb.Size = new System.Drawing.Size(262, 57);
            this.UsageTb.TabIndex = 47;
            // 
            // UsageLb
            // 
            this.UsageLb.AutoSize = true;
            this.UsageLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UsageLb.Location = new System.Drawing.Point(282, 134);
            this.UsageLb.Margin = new System.Windows.Forms.Padding(10);
            this.UsageLb.Name = "UsageLb";
            this.UsageLb.Size = new System.Drawing.Size(53, 17);
            this.UsageLb.TabIndex = 46;
            this.UsageLb.Text = "Usage:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(279, 96);
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
            this.label1.Location = new System.Drawing.Point(295, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Cost:";
            // 
            // FieldsPanel
            // 
            this.FieldsPanel.Controls.Add(this.ItemIDTb);
            this.FieldsPanel.Controls.Add(this.UsageTb);
            this.FieldsPanel.Controls.Add(this.NotesTb);
            this.FieldsPanel.Controls.Add(this.CostTB);
            this.FieldsPanel.Controls.Add(this.WeightTb);
            this.FieldsPanel.Location = new System.Drawing.Point(340, 18);
            this.FieldsPanel.Name = "FieldsPanel";
            this.FieldsPanel.Size = new System.Drawing.Size(267, 384);
            this.FieldsPanel.TabIndex = 58;
            // 
            // MiscInvControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FieldsPanel);
            this.Controls.Add(this.WeaponListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UsageLb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "MiscInvControl";
            this.Size = new System.Drawing.Size(615, 485);
            this.FieldsPanel.ResumeLayout(false);
            this.FieldsPanel.PerformLayout();
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
        private System.Windows.Forms.TextBox UsageTb;
        private System.Windows.Forms.Label UsageLb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel FieldsPanel;
    }
}
