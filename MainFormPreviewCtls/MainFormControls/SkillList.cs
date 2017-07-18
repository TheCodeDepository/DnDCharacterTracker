using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFormPreviewCtls


{
    public partial class SkillList : UserControl
    {
        public SkillList()
        {
            InitializeComponent();

        }

        List<SkillControl> SkillItems = new List<SkillControl>();


        private void DrawList()
        {
            int location = 4;
            for (int i = 0; i < 34; i++)
            {
                
                SkillItems.Add(new SkillControl());
            }

            foreach (var item in SkillItems)
            {
                location += 28;
                SkillControl t = item;
                t.Location = new Point(4, location);
                ListPanel.Controls.Add(t);
            }
        }

    }
}
