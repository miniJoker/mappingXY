using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingXY.DefaultItems
{
    class ImaginaryMessage : Button
    {
        private delegate void ShowHandler();

        public void ShowMessage(string message)
        {
            this.Text = message;
            this.Show();
            ShowHandler handler = new ShowHandler(Count);
            IAsyncResult resultObj = handler.BeginInvoke(null, null);
            handler.EndInvoke(resultObj);
            //System.Timers.Timer timer = new System.Timers.Timer(5000);
            //timer.BeginInit();
            //timer.Start();
            //timer.EndInit();
            //Console.WriteLine("timer end");
            this.Hide();
        }

        private void Count()
        {
            for (int i = 200; i > 0; i--)
            {
                Thread.Sleep(1);
            }
        }
        public void Show(string message)
        {
            this.Text = message;
            this.Show();
        }
    }
}
