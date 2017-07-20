using Storage;
namespace ClassSkills
{
    partial class SkillsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Fields = new System.Windows.Forms.Panel();
            this.DesTb = new System.Windows.Forms.TextBox();
            this.ModCombo = new System.Windows.Forms.ComboBox();
            this.skillNamTb = new System.Windows.Forms.TextBox();
            this.ClassSkillCheck = new System.Windows.Forms.CheckBox();
            this.buttonControl = new UserConCollection.ButtonControl();
            this.Namelbl = new System.Windows.Forms.Label();
            this.ClassSkillLbl = new System.Windows.Forms.Label();
            this.ModTypeLbl = new System.Windows.Forms.Label();
            this.DesLbl = new System.Windows.Forms.Label();
            this.skillList = new System.Windows.Forms.ListView();
            this.skillNamCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fields.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fields
            // 
            this.Fields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fields.Controls.Add(this.DesTb);
            this.Fields.Controls.Add(this.ModCombo);
            this.Fields.Controls.Add(this.skillNamTb);
            this.Fields.Controls.Add(this.ClassSkillCheck);
            this.Fields.Location = new System.Drawing.Point(371, 12);
            this.Fields.Name = "Fields";
            this.Fields.Size = new System.Drawing.Size(282, 284);
            this.Fields.TabIndex = 1;
            // 
            // DesTb
            // 
            this.DesTb.Location = new System.Drawing.Point(20, 153);
            this.DesTb.Multiline = true;
            this.DesTb.Name = "DesTb";
            this.DesTb.Size = new System.Drawing.Size(244, 111);
            this.DesTb.TabIndex = 9;
            // 
            // ModCombo
            // 
            this.ModCombo.FormattingEnabled = true;
            this.ModCombo.Items.AddRange(new object[] {
            "STR",
            "DEX",
            "CON",
            "INT",
            "WIS",
            "CHA"});
            this.ModCombo.Location = new System.Drawing.Point(20, 58);
            this.ModCombo.Name = "ModCombo";
            this.ModCombo.Size = new System.Drawing.Size(80, 21);
            this.ModCombo.TabIndex = 8;
            this.ModCombo.SelectedIndexChanged += new System.EventHandler(this.ModCombo_SelectedIndexChanged);
            // 
            // skillNamTb
            // 
            this.skillNamTb.Location = new System.Drawing.Point(20, 104);
            this.skillNamTb.Name = "skillNamTb";
            this.skillNamTb.Size = new System.Drawing.Size(244, 20);
            this.skillNamTb.TabIndex = 7;
            // 
            // ClassSkillCheck
            // 
            this.ClassSkillCheck.AutoSize = true;
            this.ClassSkillCheck.Location = new System.Drawing.Point(20, 17);
            this.ClassSkillCheck.Name = "ClassSkillCheck";
            this.ClassSkillCheck.Size = new System.Drawing.Size(15, 14);
            this.ClassSkillCheck.TabIndex = 6;
            this.ClassSkillCheck.UseVisualStyleBackColor = true;
            this.ClassSkillCheck.CheckedChanged += new System.EventHandler(this.ClassSkillCheck_CheckedChanged);
            // 
            // buttonControl
            // 
            this.buttonControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonControl.Location = new System.Drawing.Point(659, 12);
            this.buttonControl.Name = "buttonControl";
            this.buttonControl.Size = new System.Drawing.Size(88, 285);
            this.buttonControl.TabIndex = 2;
            this.buttonControl.Load += new System.EventHandler(this.buttonControl_Load);
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Namelbl.Location = new System.Drawing.Point(287, 119);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(78, 17);
            this.Namelbl.TabIndex = 0;
            this.Namelbl.Text = "Skill Name:";
            // 
            // ClassSkillLbl
            // 
            this.ClassSkillLbl.AutoSize = true;
            this.ClassSkillLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ClassSkillLbl.Location = new System.Drawing.Point(290, 27);
            this.ClassSkillLbl.Name = "ClassSkillLbl";
            this.ClassSkillLbl.Size = new System.Drawing.Size(75, 17);
            this.ClassSkillLbl.TabIndex = 3;
            this.ClassSkillLbl.Text = "Class Skill:";
            // 
            // ModTypeLbl
            // 
            this.ModTypeLbl.AutoSize = true;
            this.ModTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ModTypeLbl.Location = new System.Drawing.Point(303, 72);
            this.ModTypeLbl.Name = "ModTypeLbl";
            this.ModTypeLbl.Size = new System.Drawing.Size(62, 17);
            this.ModTypeLbl.TabIndex = 4;
            this.ModTypeLbl.Text = "Modifier:";
            // 
            // DesLbl
            // 
            this.DesLbl.AutoSize = true;
            this.DesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DesLbl.Location = new System.Drawing.Point(282, 165);
            this.DesLbl.Name = "DesLbl";
            this.DesLbl.Size = new System.Drawing.Size(83, 17);
            this.DesLbl.TabIndex = 5;
            this.DesLbl.Text = "Description:";
            // 
            // skillList
            // 
            this.skillList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.skillNamCol});
            this.skillList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.skillList.Location = new System.Drawing.Point(12, 12);
            this.skillList.Name = "skillList";
            this.skillList.Size = new System.Drawing.Size(264, 284);
            this.skillList.TabIndex = 6;
            this.skillList.UseCompatibleStateImageBehavior = false;
            this.skillList.View = System.Windows.Forms.View.Details;
            this.skillList.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.skillList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDoubleClick);
            // 
            // skillNamCol
            // 
            this.skillNamCol.Text = "Skill Name";
            this.skillNamCol.Width = 258;
            // 
            // SkillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 308);
            this.Controls.Add(this.skillList);
            this.Controls.Add(this.DesLbl);
            this.Controls.Add(this.ModTypeLbl);
            this.Controls.Add(this.ClassSkillLbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.buttonControl);
            this.Controls.Add(this.Fields);
            this.Name = "SkillsForm";
            this.Text = "Skill\'s";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.Fields.ResumeLayout(false);
            this.Fields.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Fields;
        private UserConCollection.ButtonControl buttonControl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label ClassSkillLbl;
        private System.Windows.Forms.Label ModTypeLbl;
        private System.Windows.Forms.Label DesLbl;
        private System.Windows.Forms.TextBox DesTb;
        private System.Windows.Forms.ComboBox ModCombo;
        private System.Windows.Forms.TextBox skillNamTb;
        private System.Windows.Forms.CheckBox ClassSkillCheck;
        private System.Windows.Forms.ListView skillList;
        private System.Windows.Forms.ColumnHeader skillNamCol;
    }
}

