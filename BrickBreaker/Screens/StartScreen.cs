using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class StartScreen : UserControl
    {
        static int i = 1;
        public StartScreen()
        {
            InitializeComponent();
            startTimer.Enabled = true;

        }
        private void StartScreen_KeyDown(object sender, KeyEventArgs e)
        {
            MenuScreen ms = new MenuScreen();
            Form1 form = FindForm() as Form1;

            form.ChangeScreen(this, ms);
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                anyButtonPB.Image = new Bitmap(Properties.Resources.buttonPressSelect);
            }
            else
            {
                anyButtonPB.Image = new Bitmap(Properties.Resources.pressAnyButton);
            }
            i++;
            Refresh();
        }
    }
}
