namespace AddInventoryForm
{
    partial class ArmorInvControl
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
            this.ArmorListBox = new System.Windows.Forms.ListView();
            this.ItemIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FieldsPanel = new System.Windows.Forms.Panel();
            this.PenTb = new System.Windows.Forms.TextBox();
            this.NotesTb = new System.Windows.Forms.TextBox();
            this.ItemIDTb = new System.Windows.Forms.TextBox();
            this.WeightTb = new System.Windows.Forms.TextBox();
            this.ACTb = new System.Windows.Forms.TextBox();
            this.ValueTb = new System.Windows.Forms.TextBox();
            this.SpellFailureTb = new System.Windows.Forms.TextBox();
            this.ArmorGradeCbo = new System.Windows.Forms.ComboBox();
            this.PenLbl = new System.Windows.Forms.Label();
            this.NotesLbl = new System.Windows.Forms.Label();
            this.ItemIDLbl = new System.Windows.Forms.Label();
            this.SpellFailureLbl = new System.Windows.Forms.Label();
            this.WeightLbl = new System.Windows.Forms.Label();
            this.ArmorClsLbl = new System.Windows.Forms.Label();
            this.ValueLbl = new System.Windows.Forms.Label();
            this.GradeLbl = new System.Windows.Forms.Label();
            this.FieldsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArmorListBox
            // 
            this.ArmorListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemIDColumn});
            this.ArmorListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ArmorListBox.Location = new System.Drawing.Point(3, 3);
            this.ArmorListBox.Name = "ArmorListBox";
            this.ArmorListBox.Size = new System.Drawing.Size(253, 480);
            this.ArmorListBox.TabIndex = 57;
            this.ArmorListBox.UseCompatibleStateImageBehavior = false;
            this.ArmorListBox.View = System.Windows.Forms.View.Details;
            this.ArmorListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.ArmorListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDoubleClick);
            // 
            // ItemIDColumn
            // 
            this.ItemIDColumn.Text = "Item ID";
            this.ItemIDColumn.Width = 246;
            // 
            // FieldsPanel
            // 
            this.FieldsPanel.Controls.Add(this.PenTb);
            this.FieldsPanel.Controls.Add(this.NotesTb);
            this.FieldsPanel.Controls.Add(this.ItemIDTb);
            this.FieldsPanel.Controls.Add(this.WeightTb);
            this.FieldsPanel.Controls.Add(this.ACTb);
            this.FieldsPanel.Controls.Add(this.ValueTb);
            this.FieldsPanel.Controls.Add(this.SpellFailureTb);
            this.FieldsPanel.Controls.Add(this.ArmorGradeCbo);
            this.FieldsPanel.Location = new System.Drawing.Point(367, 14);
            this.FieldsPanel.Name = "FieldsPanel";
            this.FieldsPanel.Size = new System.Drawing.Size(264, 453);
            this.FieldsPanel.TabIndex = 60;
            // 
            // PenTb
            // 
            this.PenTb.Location = new System.Drawing.Point(3, 190);
            this.PenTb.Multiline = true;
            this.PenTb.Name = "PenTb";
            this.PenTb.Size = new System.Drawing.Size(251, 57);
            this.PenTb.TabIndex = 75;
            // 
            // NotesTb
            // 
            this.NotesTb.Location = new System.Drawing.Point(3, 336);
            this.NotesTb.Multiline = true;
            this.NotesTb.Name = "NotesTb";
            this.NotesTb.Size = new System.Drawing.Size(251, 108);
            this.NotesTb.TabIndex = 74;
            // 
            // ItemIDTb
            // 
            this.ItemIDTb.Location = new System.Drawing.Point(3, 3);
            this.ItemIDTb.Name = "ItemIDTb";
            this.ItemIDTb.Size = new System.Drawing.Size(121, 20);
            this.ItemIDTb.TabIndex = 73;
            // 
            // WeightTb
            // 
            this.WeightTb.Location = new System.Drawing.Point(3, 77);
            this.WeightTb.Name = "WeightTb";
            this.WeightTb.Size = new System.Drawing.Size(121, 20);
            this.WeightTb.TabIndex = 72;
            this.WeightTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForceNum);
            // 
            // ACTb
            // 
            this.ACTb.Location = new System.Drawing.Point(3, 114);
            this.ACTb.Name = "ACTb";
            this.ACTb.Size = new System.Drawing.Size(121, 20);
            this.ACTb.TabIndex = 71;
            this.ACTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForceNum);
            // 
            // ValueTb
            // 
            this.ValueTb.Location = new System.Drawing.Point(3, 40);
            this.ValueTb.Name = "ValueTb";
            this.ValueTb.Size = new System.Drawing.Size(121, 20);
            this.ValueTb.TabIndex = 70;
            this.ValueTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForceNum);
            // 
            // SpellFailureTb
            // 
            this.SpellFailureTb.Location = new System.Drawing.Point(3, 262);
            this.SpellFailureTb.Multiline = true;
            this.SpellFailureTb.Name = "SpellFailureTb";
            this.SpellFailureTb.Size = new System.Drawing.Size(251, 57);
            this.SpellFailureTb.TabIndex = 69;
            // 
            // ArmorGradeCbo
            // 
            this.ArmorGradeCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArmorGradeCbo.FormattingEnabled = true;
            this.ArmorGradeCbo.Items.AddRange(new object[] {
            "Light",
            "Medium",
            "Heavy"});
            this.ArmorGradeCbo.Location = new System.Drawing.Point(3, 151);
            this.ArmorGradeCbo.Name = "ArmorGradeCbo";
            this.ArmorGradeCbo.Size = new System.Drawing.Size(121, 21);
            this.ArmorGradeCbo.TabIndex = 68;
            // 
            // PenLbl
            // 
            this.PenLbl.AutoSize = true;
            this.PenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PenLbl.Location = new System.Drawing.Point(285, 205);
            this.PenLbl.Margin = new System.Windows.Forms.Padding(10);
            this.PenLbl.Name = "PenLbl";
            this.PenLbl.Size = new System.Drawing.Size(77, 17);
            this.PenLbl.TabIndex = 74;
            this.PenLbl.Text = "Penaulty\'s:";
            // 
            // NotesLbl
            // 
            this.NotesLbl.AutoSize = true;
            this.NotesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NotesLbl.Location = new System.Drawing.Point(313, 351);
            this.NotesLbl.Margin = new System.Windows.Forms.Padding(10);
            this.NotesLbl.Name = "NotesLbl";
            this.NotesLbl.Size = new System.Drawing.Size(49, 17);
            this.NotesLbl.TabIndex = 73;
            this.NotesLbl.Text = "Notes:";
            // 
            // ItemIDLbl
            // 
            this.ItemIDLbl.AutoSize = true;
            this.ItemIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ItemIDLbl.Location = new System.Drawing.Point(307, 18);
            this.ItemIDLbl.Margin = new System.Windows.Forms.Padding(10);
            this.ItemIDLbl.Name = "ItemIDLbl";
            this.ItemIDLbl.Size = new System.Drawing.Size(55, 17);
            this.ItemIDLbl.TabIndex = 72;
            this.ItemIDLbl.Text = "Item ID:";
            // 
            // SpellFailureLbl
            // 
            this.SpellFailureLbl.AutoSize = true;
            this.SpellFailureLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SpellFailureLbl.Location = new System.Drawing.Point(272, 277);
            this.SpellFailureLbl.Margin = new System.Windows.Forms.Padding(10);
            this.SpellFailureLbl.Name = "SpellFailureLbl";
            this.SpellFailureLbl.Size = new System.Drawing.Size(90, 17);
            this.SpellFailureLbl.TabIndex = 71;
            this.SpellFailureLbl.Text = "Spell Failure:";
            // 
            // WeightLbl
            // 
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WeightLbl.Location = new System.Drawing.Point(306, 92);
            this.WeightLbl.Margin = new System.Windows.Forms.Padding(10);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(56, 17);
            this.WeightLbl.TabIndex = 70;
            this.WeightLbl.Text = "Weight:";
            // 
            // ArmorClsLbl
            // 
            this.ArmorClsLbl.AutoSize = true;
            this.ArmorClsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ArmorClsLbl.Location = new System.Drawing.Point(274, 129);
            this.ArmorClsLbl.Margin = new System.Windows.Forms.Padding(10);
            this.ArmorClsLbl.Name = "ArmorClsLbl";
            this.ArmorClsLbl.Size = new System.Drawing.Size(88, 17);
            this.ArmorClsLbl.TabIndex = 69;
            this.ArmorClsLbl.Text = "Armor Class:";
            // 
            // ValueLbl
            // 
            this.ValueLbl.AutoSize = true;
            this.ValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ValueLbl.Location = new System.Drawing.Point(314, 55);
            this.ValueLbl.Margin = new System.Windows.Forms.Padding(10);
            this.ValueLbl.Name = "ValueLbl";
            this.ValueLbl.Size = new System.Drawing.Size(48, 17);
            this.ValueLbl.TabIndex = 68;
            this.ValueLbl.Text = "Value:";
            // 
            // GradeLbl
            // 
            this.GradeLbl.AutoSize = true;
            this.GradeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GradeLbl.Location = new System.Drawing.Point(318, 166);
            this.GradeLbl.Margin = new System.Windows.Forms.Padding(10);
            this.GradeLbl.Name = "GradeLbl";
            this.GradeLbl.Size = new System.Drawing.Size(44, 17);
            this.GradeLbl.TabIndex = 67;
            this.GradeLbl.Text = "Type:";
            // 
            // ArmorInvControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PenLbl);
            this.Controls.Add(this.NotesLbl);
            this.Controls.Add(this.ItemIDLbl);
            this.Controls.Add(this.SpellFailureLbl);
            this.Controls.Add(this.WeightLbl);
            this.Controls.Add(this.ArmorClsLbl);
            this.Controls.Add(this.ValueLbl);
            this.Controls.Add(this.GradeLbl);
            this.Controls.Add(this.FieldsPanel);
            this.Controls.Add(this.ArmorListBox);
            this.Name = "ArmorInvControl";
            this.Size = new System.Drawing.Size(643, 485);
            this.Load += new System.EventHandler(this.Panel_Load);
            this.FieldsPanel.ResumeLayout(false);
            this.FieldsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ArmorListBox;
        private System.Windows.Forms.ColumnHeader ItemIDColumn;
        private System.Windows.Forms.Panel FieldsPanel;
        private System.Windows.Forms.TextBox PenTb;
        private System.Windows.Forms.TextBox NotesTb;
        private System.Windows.Forms.TextBox ItemIDTb;
        private System.Windows.Forms.TextBox WeightTb;
        private System.Windows.Forms.TextBox ACTb;
        private System.Windows.Forms.TextBox ValueTb;
        private System.Windows.Forms.TextBox SpellFailureTb;
        private System.Windows.Forms.ComboBox ArmorGradeCbo;
        private System.Windows.Forms.Label PenLbl;
        private System.Windows.Forms.Label NotesLbl;
        private System.Windows.Forms.Label ItemIDLbl;
        private System.Windows.Forms.Label SpellFailureLbl;
        private System.Windows.Forms.Label WeightLbl;
        private System.Windows.Forms.Label ArmorClsLbl;
        private System.Windows.Forms.Label ValueLbl;
        private System.Windows.Forms.Label GradeLbl;
    }
}
