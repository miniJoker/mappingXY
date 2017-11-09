using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingXY.DefaultItems
{
    class DefaultInput : TextBox
    {
        private static ImaginaryMessage imaginaryMessage;

        public DefaultInput(string inputName, ImaginaryMessage im)
        {
            imaginaryMessage = im;
            this.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right )));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Location = new System.Drawing.Point(36, 95);
            this.Name = inputName;
            this.Margin = new Padding(0,0,2,0);
            this.Size = new System.Drawing.Size(151, 20);
            this.TabIndex = 15;
            //this.KeyUp += DefaultInput_KeyUp;
            this.TextChanged += DefaultInput_KeyUp;
        }

        private void DefaultInput_KeyUp(object sender, EventArgs e)
        {
            string innerText = (sender as TextBox).Text;
            Regex regExp = new Regex("^-?[0-9]+\\,?[0-9]{0,10}$");
            if (regExp.IsMatch(innerText) || innerText=="")
            {
                this.BackColor = System.Drawing.Color.White;
                imaginaryMessage.Hide();
                
            }
            else
            {
                this.BackColor=System.Drawing.Color.FromArgb(255, 192, 192);
                imaginaryMessage.Show("Недопустимые символы");
                
            }
        }
    }
}
