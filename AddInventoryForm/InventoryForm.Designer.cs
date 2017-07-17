namespace AddInventoryForm
{
    partial class InventoryForm
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
            this.InvTabControl = new System.Windows.Forms.TabControl();
            this.WeapTab = new System.Windows.Forms.TabPage();
            this.ArmorTab = new System.Windows.Forms.TabPage();
            this.MiscTab = new System.Windows.Forms.TabPage();
            this.InvTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // InvTabControl
            // 
            this.InvTabControl.Controls.Add(this.WeapTab);
            this.InvTabControl.Controls.Add(this.ArmorTab);
            this.InvTabControl.Controls.Add(this.MiscTab);
            this.InvTabControl.Location = new System.Drawing.Point(13, 48);
            this.InvTabControl.Name = "InvTabControl";
            this.InvTabControl.SelectedIndex = 0;
            this.InvTabControl.Size = new System.Drawing.Size(681, 501);
            this.InvTabControl.TabIndex = 0;
            // 
            // WeapTab
            // 
            this.WeapTab.Location = new System.Drawing.Point(4, 22);
            this.WeapTab.Name = "WeapTab";
            this.WeapTab.Padding = new System.Windows.Forms.Padding(3);
            this.WeapTab.Size = new System.Drawing.Size(192, 74);
            this.WeapTab.TabIndex = 0;
            this.WeapTab.Text = "Weapon\'s";
            this.WeapTab.UseVisualStyleBackColor = true;
            // 
            // ArmorTab
            // 
            this.ArmorTab.Location = new System.Drawing.Point(4, 22);
            this.ArmorTab.Name = "ArmorTab";
            this.ArmorTab.Padding = new System.Windows.Forms.Padding(3);
            this.ArmorTab.Size = new System.Drawing.Size(192, 74);
            this.ArmorTab.TabIndex = 1;
            this.ArmorTab.Text = "Armour";
            this.ArmorTab.UseVisualStyleBackColor = true;
            // 
            // MiscTab
            // 
            this.MiscTab.Location = new System.Drawing.Point(4, 22);
            this.MiscTab.Name = "MiscTab";
            this.MiscTab.Padding = new System.Windows.Forms.Padding(3);
            this.MiscTab.Size = new System.Drawing.Size(673, 475);
            this.MiscTab.TabIndex = 2;
            this.MiscTab.Text = "Misc";
            this.MiscTab.UseVisualStyleBackColor = true;
            // 
            // InventoryForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.InvTabControl);
            this.Name = "InventoryForm";
            this.InvTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl InvTabControl;
        private System.Windows.Forms.TabPage WeapTab;
        private System.Windows.Forms.TabPage ArmorTab;
        private System.Windows.Forms.TabPage MiscTab;
    }
}
#endregion