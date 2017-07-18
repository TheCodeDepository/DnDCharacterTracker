namespace UserConCollection.InventoryUserControls


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
            this.MiscListBox = new System.Windows.Forms.ListView();
            this.ItemIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NotesTb = new System.Windows.Forms.TextBox();
            this.NotesLbl = new System.Windows.Forms.Label();
            this.ItemIDTb = new System.Windows.Forms.TextBox();
            this.ItemIDLbl = new System.Windows.Forms.Label();
            this.WeightTb = new System.Windows.Forms.TextBox();
            this.ValueTB = new System.Windows.Forms.TextBox();
            this.UsageTb = new System.Windows.Forms.TextBox();
            this.UsageLbl = new System.Windows.Forms.Label();
            this.WeightLbl = new System.Windows.Forms.Label();
            this.ValueLbl = new System.Windows.Forms.Label();
            this.FieldsPanel = new System.Windows.Forms.Panel();
            this.FieldsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MiscListBox
            // 
            this.MiscListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemIDColumn});
            this.MiscListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MiscListBox.Location = new System.Drawing.Point(3, 3);
            this.MiscListBox.Name = "MiscListBox";
            this.MiscListBox.Size = new System.Drawing.Size(253, 480);
            this.MiscListBox.TabIndex = 57;
            this.MiscListBox.UseCompatibleStateImageBehavior = false;
            this.MiscListBox.View = System.Windows.Forms.View.Details;
            this.MiscListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.MiscListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDoubleClick);
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
            // NotesLbl
            // 
            this.NotesLbl.AutoSize = true;
            this.NotesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NotesLbl.Location = new System.Drawing.Point(286, 208);
            this.NotesLbl.Margin = new System.Windows.Forms.Padding(10);
            this.NotesLbl.Name = "NotesLbl";
            this.NotesLbl.Size = new System.Drawing.Size(49, 17);
            this.NotesLbl.TabIndex = 55;
            this.NotesLbl.Text = "Notes:";
            // 
            // ItemIDTb
            // 
            this.ItemIDTb.Location = new System.Drawing.Point(3, 3);
            this.ItemIDTb.Name = "ItemIDTb";
            this.ItemIDTb.Size = new System.Drawing.Size(121, 20);
            this.ItemIDTb.TabIndex = 54;
            // 
            // ItemIDLbl
            // 
            this.ItemIDLbl.AutoSize = true;
            this.ItemIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ItemIDLbl.Location = new System.Drawing.Point(280, 22);
            this.ItemIDLbl.Margin = new System.Windows.Forms.Padding(10);
            this.ItemIDLbl.Name = "ItemIDLbl";
            this.ItemIDLbl.Size = new System.Drawing.Size(55, 17);
            this.ItemIDLbl.TabIndex = 53;
            this.ItemIDLbl.Text = "Item ID:";
            // 
            // WeightTb
            // 
            this.WeightTb.Location = new System.Drawing.Point(3, 77);
            this.WeightTb.Name = "WeightTb";
            this.WeightTb.Size = new System.Drawing.Size(121, 20);
            this.WeightTb.TabIndex = 52;
            // 
            // ValueTB
            // 
            this.ValueTB.Location = new System.Drawing.Point(3, 40);
            this.ValueTB.Name = "ValueTB";
            this.ValueTB.Size = new System.Drawing.Size(121, 20);
            this.ValueTB.TabIndex = 49;
            // 
            // UsageTb
            // 
            this.UsageTb.Location = new System.Drawing.Point(3, 115);
            this.UsageTb.Multiline = true;
            this.UsageTb.Name = "UsageTb";
            this.UsageTb.Size = new System.Drawing.Size(262, 57);
            this.UsageTb.TabIndex = 47;
            // 
            // UsageLbl
            // 
            this.UsageLbl.AutoSize = true;
            this.UsageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UsageLbl.Location = new System.Drawing.Point(282, 134);
            this.UsageLbl.Margin = new System.Windows.Forms.Padding(10);
            this.UsageLbl.Name = "UsageLbl";
            this.UsageLbl.Size = new System.Drawing.Size(53, 17);
            this.UsageLbl.TabIndex = 46;
            this.UsageLbl.Text = "Usage:";
            // 
            // WeightLbl
            // 
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WeightLbl.Location = new System.Drawing.Point(279, 96);
            this.WeightLbl.Margin = new System.Windows.Forms.Padding(10);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(56, 17);
            this.WeightLbl.TabIndex = 45;
            this.WeightLbl.Text = "Weight:";
            // 
            // ValueLbl
            // 
            this.ValueLbl.AutoSize = true;
            this.ValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ValueLbl.Location = new System.Drawing.Point(287, 59);
            this.ValueLbl.Margin = new System.Windows.Forms.Padding(10);
            this.ValueLbl.Name = "ValueLbl";
            this.ValueLbl.Size = new System.Drawing.Size(48, 17);
            this.ValueLbl.TabIndex = 41;
            this.ValueLbl.Text = "Value:";
            // 
            // FieldsPanel
            // 
            this.FieldsPanel.Controls.Add(this.ItemIDTb);
            this.FieldsPanel.Controls.Add(this.UsageTb);
            this.FieldsPanel.Controls.Add(this.NotesTb);
            this.FieldsPanel.Controls.Add(this.ValueTB);
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
            this.Controls.Add(this.MiscListBox);
            this.Controls.Add(this.NotesLbl);
            this.Controls.Add(this.ItemIDLbl);
            this.Controls.Add(this.UsageLbl);
            this.Controls.Add(this.WeightLbl);
            this.Controls.Add(this.ValueLbl);
            this.Name = "MiscInvControl";
            this.Size = new System.Drawing.Size(615, 485);
            this.Load += new System.EventHandler(this.Panel_Load);
            this.FieldsPanel.ResumeLayout(false);
            this.FieldsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView MiscListBox;
        private System.Windows.Forms.ColumnHeader ItemIDColumn;
        private System.Windows.Forms.TextBox NotesTb;
        private System.Windows.Forms.Label NotesLbl;
        private System.Windows.Forms.TextBox ItemIDTb;
        private System.Windows.Forms.Label ItemIDLbl;
        private System.Windows.Forms.TextBox WeightTb;
        private System.Windows.Forms.TextBox ValueTB;
        private System.Windows.Forms.TextBox UsageTb;
        private System.Windows.Forms.Label UsageLbl;
        private System.Windows.Forms.Label WeightLbl;
        private System.Windows.Forms.Label ValueLbl;
        private System.Windows.Forms.Panel FieldsPanel;
    }
}
