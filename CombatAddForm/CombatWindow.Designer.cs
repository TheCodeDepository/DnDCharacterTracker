namespace CombatForm
{
    partial class CombatWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Experience = new System.Windows.Forms.TextBox();
            this.UnitIDFix = new System.Windows.Forms.TextBox();
            this.GoldGained = new System.Windows.Forms.TextBox();
            this.expLbl = new System.Windows.Forms.Label();
            this.unitIDLbl = new System.Windows.Forms.Label();
            this.goldLbl = new System.Windows.Forms.Label();
            this.lootLbl = new System.Windows.Forms.Label();
            this.LootGrid = new System.Windows.Forms.DataGridView();
            this.Loot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BattleControlGrp = new System.Windows.Forms.GroupBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LootGrid)).BeginInit();
            this.BattleControlGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Experience
            // 
            this.Experience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Experience.Location = new System.Drawing.Point(99, 38);
            this.Experience.Name = "Experience";
            this.Experience.Size = new System.Drawing.Size(251, 23);
            this.Experience.TabIndex = 1;
            // 
            // UnitIDFix
            // 
            this.UnitIDFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UnitIDFix.Location = new System.Drawing.Point(99, 9);
            this.UnitIDFix.Name = "UnitIDFix";
            this.UnitIDFix.Size = new System.Drawing.Size(251, 23);
            this.UnitIDFix.TabIndex = 0;
            // 
            // GoldGained
            // 
            this.GoldGained.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GoldGained.Location = new System.Drawing.Point(99, 67);
            this.GoldGained.Name = "GoldGained";
            this.GoldGained.Size = new System.Drawing.Size(251, 23);
            this.GoldGained.TabIndex = 2;
            // 
            // expLbl
            // 
            this.expLbl.AutoSize = true;
            this.expLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.expLbl.Location = new System.Drawing.Point(10, 41);
            this.expLbl.Name = "expLbl";
            this.expLbl.Size = new System.Drawing.Size(86, 17);
            this.expLbl.TabIndex = 3;
            this.expLbl.Text = "Experience :";
            // 
            // unitIDLbl
            // 
            this.unitIDLbl.AutoSize = true;
            this.unitIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.unitIDLbl.Location = new System.Drawing.Point(38, 12);
            this.unitIDLbl.Name = "unitIDLbl";
            this.unitIDLbl.Size = new System.Drawing.Size(58, 17);
            this.unitIDLbl.TabIndex = 4;
            this.unitIDLbl.Text = "Unit ID :";
            // 
            // goldLbl
            // 
            this.goldLbl.AutoSize = true;
            this.goldLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.goldLbl.Location = new System.Drawing.Point(50, 70);
            this.goldLbl.Name = "goldLbl";
            this.goldLbl.Size = new System.Drawing.Size(46, 17);
            this.goldLbl.TabIndex = 5;
            this.goldLbl.Text = "Gold :";
            // 
            // lootLbl
            // 
            this.lootLbl.AutoSize = true;
            this.lootLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lootLbl.Location = new System.Drawing.Point(52, 99);
            this.lootLbl.Name = "lootLbl";
            this.lootLbl.Size = new System.Drawing.Size(44, 17);
            this.lootLbl.TabIndex = 6;
            this.lootLbl.Text = "Loot :";
            // 
            // LootGrid
            // 
            this.LootGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.LootGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LootGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Loot});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LootGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.LootGrid.Location = new System.Drawing.Point(99, 96);
            this.LootGrid.Name = "LootGrid";
            this.LootGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.LootGrid.RowHeadersVisible = false;
            this.LootGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LootGrid.Size = new System.Drawing.Size(251, 325);
            this.LootGrid.TabIndex = 3;
            // 
            // Loot
            // 
            this.Loot.HeaderText = "Loot";
            this.Loot.MinimumWidth = 325;
            this.Loot.Name = "Loot";
            this.Loot.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Loot.ToolTipText = "Non gold loot drops.";
            this.Loot.Width = 325;
            // 
            // BattleControlGrp
            // 
            this.BattleControlGrp.Controls.Add(this.CancelButton);
            this.BattleControlGrp.Controls.Add(this.AddButton);
            this.BattleControlGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BattleControlGrp.Location = new System.Drawing.Point(8, 346);
            this.BattleControlGrp.Name = "BattleControlGrp";
            this.BattleControlGrp.Size = new System.Drawing.Size(84, 75);
            this.BattleControlGrp.TabIndex = 19;
            this.BattleControlGrp.TabStop = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(6, 44);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(72, 23);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(6, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(72, 23);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CombatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(361, 434);
            this.Controls.Add(this.BattleControlGrp);
            this.Controls.Add(this.LootGrid);
            this.Controls.Add(this.lootLbl);
            this.Controls.Add(this.goldLbl);
            this.Controls.Add(this.unitIDLbl);
            this.Controls.Add(this.expLbl);
            this.Controls.Add(this.GoldGained);
            this.Controls.Add(this.UnitIDFix);
            this.Controls.Add(this.Experience);
            this.Name = "CombatWindow";
            this.Text = "CombatWindow";
            this.Load += new System.EventHandler(this.CombatWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LootGrid)).EndInit();
            this.BattleControlGrp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Experience;
        private System.Windows.Forms.TextBox UnitIDFix;
        private System.Windows.Forms.TextBox GoldGained;
        private System.Windows.Forms.Label expLbl;
        private System.Windows.Forms.Label unitIDLbl;
        private System.Windows.Forms.Label goldLbl;
        private System.Windows.Forms.Label lootLbl;
        private System.Windows.Forms.DataGridView LootGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loot;
        private System.Windows.Forms.GroupBox BattleControlGrp;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.Button AddButton;
    }
}