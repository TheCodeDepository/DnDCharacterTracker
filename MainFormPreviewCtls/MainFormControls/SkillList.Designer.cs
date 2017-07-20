namespace MainFormPreviewCtls


{
    partial class SkillList
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
            this.label157 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.ListPanel = new System.Windows.Forms.Panel();
            this.MngInvButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label157
            // 
            this.label157.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label157.Location = new System.Drawing.Point(301, 0);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(45, 34);
            this.label157.TabIndex = 359;
            this.label157.Text = "Misc\r\nMod\'s";
            this.label157.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label114
            // 
            this.label114.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label114.Location = new System.Drawing.Point(127, 0);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(51, 34);
            this.label114.TabIndex = 355;
            this.label114.Text = "Class \r\nSkill\'s?";
            this.label114.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label115
            // 
            this.label115.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label115.Location = new System.Drawing.Point(184, 17);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(41, 17);
            this.label115.TabIndex = 356;
            this.label115.Text = "Rank";
            this.label115.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label116
            // 
            this.label116.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label116.Location = new System.Drawing.Point(252, 0);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(45, 34);
            this.label116.TabIndex = 357;
            this.label116.Text = "Ability\r\nMod";
            this.label116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label117
            // 
            this.label117.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label117.Location = new System.Drawing.Point(355, 17);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(40, 17);
            this.label117.TabIndex = 358;
            this.label117.Text = "Total";
            this.label117.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListPanel
            // 
            this.ListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListPanel.AutoScroll = true;
            this.ListPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ListPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ListPanel.Location = new System.Drawing.Point(3, 39);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(415, 200);
            this.ListPanel.TabIndex = 360;
            // 
            // MngInvButton
            // 
            this.MngInvButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MngInvButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MngInvButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MngInvButton.Location = new System.Drawing.Point(8, 4);
            this.MngInvButton.Margin = new System.Windows.Forms.Padding(4);
            this.MngInvButton.Name = "MngInvButton";
            this.MngInvButton.Size = new System.Drawing.Size(100, 30);
            this.MngInvButton.TabIndex = 361;
            this.MngInvButton.Text = "Manage";
            this.MngInvButton.UseVisualStyleBackColor = true;
            this.MngInvButton.Click += new System.EventHandler(this.MngInvButton_Click);
            // 
            // SkillList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.MngInvButton);
            this.Controls.Add(this.ListPanel);
            this.Controls.Add(this.label157);
            this.Controls.Add(this.label114);
            this.Controls.Add(this.label115);
            this.Controls.Add(this.label116);
            this.Controls.Add(this.label117);
            this.Name = "SkillList";
            this.Size = new System.Drawing.Size(421, 242);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Button MngInvButton;
    }
}
