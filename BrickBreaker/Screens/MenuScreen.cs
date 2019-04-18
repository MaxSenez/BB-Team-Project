﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BrickBreaker
{
    public partial class MenuScreen : UserControl
    {
        private static int index = 0;
        private List<Button> buttons = new List<Button>();
        public MenuScreen()
        {
            InitializeComponent();
            //Foreach button in the screen's controls add it to a list and add code to the button Events when it gains and loses focus
            foreach(var button in Controls.OfType<Button>())
            {
                buttons.Add(button);
                button.LostFocus += lostFocus;
                button.GotFocus += gainFocus;
            }
        }

        /// <summary>
        /// Only for buttons made by Thayen
        /// </summary>
        private void gainFocus(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.ForeColor = Color.Red;
        }

        /// <summary>
        /// Only for buttons made by Thayen
        /// </summary>
        private void lostFocus(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.ForeColor = Color.Black;
        }

        /// <summary>
        /// The event code for when the exist button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// The event code for when the play button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButton_Click(object sender, EventArgs e)
        {
            // Goes to the game screen
            GameScreen gs = new GameScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);

            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
        }

        /// <summary>
        /// The event code for when the Menu Screen finishes initializing loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuScreen_Load(object sender, EventArgs e)
        {   
            //For every button in the screen set the location to the middle X of the screen and the Height divided by the number of buttons
            for(int i = 0; i < buttons.Count; i++)
                buttons[i].Location = new Point((Width / 2) - (buttons[i].Width / 2), Height / (buttons.Count - i) - buttons[i].Height);
        }

        /// <summary>
        /// The event code for when the Main Menu detects a key press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuScreen_KeyDown(object sender, KeyEventArgs e)
        {
            //Thayen
            switch(e.KeyCode)
            {
                case Keys.Up:
                    newButton(-1).Focus();
                    break;
                case Keys.Down:
                    newButton(1).Focus();
                    break;
            }
        }

        /// <summary>
        /// Gets the newly selected button based on where the last one was. Pass a negative to go back in the buttons
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        private Button newButton(int changeInIndex)
        { 
            //Thayen
            index += changeInIndex;
            //If the button is out of range set the button within range
            if (index < 0)
                index = 0;
            else if (index >= buttons.Count)
                index = buttons.Count - 1;
            return buttons[index];
        }
    }
}
