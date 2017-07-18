namespace UserConCollection
{
    partial class SkillsInputControl
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
            this.Fields = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Fields
            // 
            this.Fields.Location = new System.Drawing.Point(3, 3);
            this.Fields.Name = "Fields";
            this.Fields.Size = new System.Drawing.Size(435, 470);
            this.Fields.TabIndex = 0;
            // 
            // SkillsInputControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Fields);
            this.Name = "SkillsInputControl";
            this.Size = new System.Drawing.Size(559, 476);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Fields;
    }
}
