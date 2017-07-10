namespace CombatAddForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Experience = new System.Windows.Forms.TextBox();
            this.UnitIDFix = new System.Windows.Forms.TextBox();
            this.GoldGained = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LootGrid = new System.Windows.Forms.DataGridView();
            this.Loot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BattleControlGrp = new System.Windows.Forms.GroupBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TestDetails = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Experience :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(38, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unit ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(50, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gold :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(52, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loot :";
            // 
            // LootGrid
            // 
            this.LootGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.LootGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LootGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Loot});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LootGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.LootGrid.Location = new System.Drawing.Point(99, 96);
            this.LootGrid.Name = "LootGrid";
            this.LootGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.LootGrid.RowHeadersVisible = false;
            this.LootGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LootGrid.Size = new System.Drawing.Size(251, 325);
            this.LootGrid.TabIndex = 3;
            this.LootGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LootGrid_CellContentClick);
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
            // TestDetails
            // 
            this.TestDetails.Location = new System.Drawing.Point(11, 317);
            this.TestDetails.Name = "TestDetails";
            this.TestDetails.Size = new System.Drawing.Size(75, 23);
            this.TestDetails.TabIndex = 20;
            this.TestDetails.Text = "Test ";
            this.TestDetails.UseVisualStyleBackColor = true;
            this.TestDetails.Click += new System.EventHandler(this.button1_Click);
            // 
            // CombatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(361, 434);
            this.Controls.Add(this.TestDetails);
            this.Controls.Add(this.BattleControlGrp);
            this.Controls.Add(this.LootGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView LootGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loot;
        private System.Windows.Forms.GroupBox BattleControlGrp;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button TestDetails;
    }
}