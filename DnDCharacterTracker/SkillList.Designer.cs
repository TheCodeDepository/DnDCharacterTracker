namespace DnDCharacterTracker
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.skillControl1 = new DnDCharacterTracker.SkillControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label157
            // 
            this.label157.AutoSize = true;
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
            this.label114.AutoSize = true;
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
            this.label115.AutoSize = true;
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
            this.label116.AutoSize = true;
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
            this.label117.AutoSize = true;
            this.label117.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label117.Location = new System.Drawing.Point(355, 17);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(40, 17);
            this.label117.TabIndex = 358;
            this.label117.Text = "Total";
            this.label117.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.skillControl1);
            this.panel1.Location = new System.Drawing.Point(3, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 200);
            this.panel1.TabIndex = 360;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 361;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // skillControl1
            // 
            this.skillControl1.AbilityModifier = -5;
            this.skillControl1.AbilityModType = "DEX:";
            this.skillControl1.Location = new System.Drawing.Point(4, 4);
            this.skillControl1.Name = "skillControl1";
            this.skillControl1.RankTextBox = 0;
            this.skillControl1.Size = new System.Drawing.Size(381, 25);
            this.skillControl1.SkilName = "Knowledge (dungeoneering)";
            this.skillControl1.TabIndex = 0;
            // 
            // SkillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label157);
            this.Controls.Add(this.label114);
            this.Controls.Add(this.label115);
            this.Controls.Add(this.label116);
            this.Controls.Add(this.label117);
            this.Name = "SkillList";
            this.Size = new System.Drawing.Size(421, 242);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private SkillControl skillControl1;
    }
}
