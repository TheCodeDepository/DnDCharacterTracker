namespace DnDCharacterTracker
{
    partial class SkillControl
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
            this.SkillName = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.ModTb = new System.Windows.Forms.TextBox();
            this.TotalTb = new System.Windows.Forms.TextBox();
            this.label111 = new System.Windows.Forms.Label();
            this.MiscMod = new System.Windows.Forms.TextBox();
            this.ModTypeLbl = new System.Windows.Forms.Label();
            this.RankTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SkillName
            // 
            this.SkillName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SkillName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillName.Location = new System.Drawing.Point(-3, 1);
            this.SkillName.Name = "SkillName";
            this.SkillName.Size = new System.Drawing.Size(185, 23);
            this.SkillName.TabIndex = 1;
            this.SkillName.Text = "Knowledge (dungeoneering)";
            this.SkillName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label156.Location = new System.Drawing.Point(283, 2);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(18, 20);
            this.label156.TabIndex = 325;
            this.label156.Text = "+";
            this.label156.Click += new System.EventHandler(this.label156_Click);
            // 
            // ModTb
            // 
            this.ModTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ModTb.Location = new System.Drawing.Point(256, 1);
            this.ModTb.Margin = new System.Windows.Forms.Padding(2);
            this.ModTb.Name = "ModTb";
            this.ModTb.ReadOnly = true;
            this.ModTb.Size = new System.Drawing.Size(23, 23);
            this.ModTb.TabIndex = 324;
            this.ModTb.Text = "-5";
            this.ModTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ModTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModTb_KeyPress);
            // 
            // TotalTb
            // 
            this.TotalTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalTb.Location = new System.Drawing.Point(354, 1);
            this.TotalTb.Name = "TotalTb";
            this.TotalTb.ReadOnly = true;
            this.TotalTb.Size = new System.Drawing.Size(23, 23);
            this.TotalTb.TabIndex = 323;
            this.TotalTb.Text = "-5";
            this.TotalTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label111.Location = new System.Drawing.Point(332, 2);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(18, 20);
            this.label111.TabIndex = 322;
            this.label111.Text = "=";
            this.label111.Click += new System.EventHandler(this.label111_Click);
            // 
            // MiscMod
            // 
            this.MiscMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MiscMod.Location = new System.Drawing.Point(305, 1);
            this.MiscMod.Name = "MiscMod";
            this.MiscMod.Size = new System.Drawing.Size(23, 23);
            this.MiscMod.TabIndex = 321;
            this.MiscMod.Text = "0";
            this.MiscMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MiscMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModTb_KeyPress);
            // 
            // ModTypeLbl
            // 
            this.ModTypeLbl.AutoSize = true;
            this.ModTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ModTypeLbl.Location = new System.Drawing.Point(212, 4);
            this.ModTypeLbl.Name = "ModTypeLbl";
            this.ModTypeLbl.Size = new System.Drawing.Size(40, 17);
            this.ModTypeLbl.TabIndex = 320;
            this.ModTypeLbl.Text = "DEX:";
            this.ModTypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModTypeLbl.Click += new System.EventHandler(this.ModTypeLbl_Click);
            // 
            // RankTb
            // 
            this.RankTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RankTb.Location = new System.Drawing.Point(185, 1);
            this.RankTb.Margin = new System.Windows.Forms.Padding(2);
            this.RankTb.Name = "RankTb";
            this.RankTb.ReadOnly = true;
            this.RankTb.Size = new System.Drawing.Size(23, 23);
            this.RankTb.TabIndex = 326;
            this.RankTb.Text = "0";
            this.RankTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RankTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModTb_KeyPress);
            // 
            // SkillControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SkillName);
            this.Controls.Add(this.RankTb);
            this.Controls.Add(this.label156);
            this.Controls.Add(this.ModTb);
            this.Controls.Add(this.TotalTb);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.MiscMod);
            this.Controls.Add(this.ModTypeLbl);
            this.Name = "SkillControl";
            this.Size = new System.Drawing.Size(381, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SkillName;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.TextBox ModTb;
        private System.Windows.Forms.TextBox TotalTb;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.TextBox MiscMod;
        private System.Windows.Forms.Label ModTypeLbl;
        private System.Windows.Forms.TextBox RankTb;
    }
}
