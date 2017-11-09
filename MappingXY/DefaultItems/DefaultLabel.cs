using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingXY.DefaultItems
{
    class DefaultLabel : Label
    {
        public DefaultLabel(string labelName, string labelText) 
        {
            this.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            this.AutoSize = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Location = new System.Drawing.Point(6, 98);
            this.Name = labelName;
            this.Size = new System.Drawing.Size(24, 13);
            this.TabIndex = 12;
            this.Text = labelText;
        }
    }
}
