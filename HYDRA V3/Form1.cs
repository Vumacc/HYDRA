/* -- NOTE --
 hydra_FormClosing() is in Form1.Designer.cs
 It's located on ln 109 

 Don't ask me why it's like that,
 I'll fix it in a new update
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HYDRA_V3
{
    public partial class hydra : Form {
        public hydra() {
			InitializeComponent();
        }

		string theme = "dark";

		private void change_form_theme(string theme) {
			/*
			 You can add your own themes here if you like,
			 Make sure to put it in the time_Tick() method aswell
			*/
			if (theme == "light") {
				this.BackColor = System.Drawing.Color.White;
				label_title.ForeColor = System.Drawing.Color.Black;
				label_description.ForeColor = System.Drawing.Color.Black;
				label_footer.ForeColor = System.Drawing.Color.Black;
			} else if (theme == "dark") {
				this.BackColor = System.Drawing.Color.Black;
				label_title.ForeColor = System.Drawing.Color.White;
				label_description.ForeColor = System.Drawing.Color.White;
				label_footer.ForeColor = System.Drawing.Color.White;
			} else {
				Console.WriteLine("change_form_theme() >>> You forgor to add the colour parem :skull:");
			}
		}

		private void hydra_Load(object sender, EventArgs e) {
			this.WindowState = FormWindowState.Normal;
			this.StartPosition = FormStartPosition.CenterScreen;

			System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

			// Change timer interval if you wanna make the colour change faster
			timer.Interval = (200);

			timer.Tick += new EventHandler(timer_Tick);
			timer.Start();
		}

		private void timer_Tick(object sender, EventArgs e) {
			// Very simple way to do this, not gonna change it lol
			if (theme == "dark") {
				change_form_theme("light");
				theme = "light";
			} else if (theme == "light") {
				change_form_theme("dark");
				theme = "dark";
			}
		}

		private void hydra_MouseHover(object sender, EventArgs e) {
			Random random = new Random();

			Screen screen = Screen.FromPoint(this.Location);
			int screenWidth = screen.WorkingArea.Width;
			int screenHeight = screen.WorkingArea.Height;

			int margin = 350;

			for (int i = 0; i < 5; i++) {
				int jiggleLocationX = random.Next(margin, screenWidth - margin);
				int jiggleLocationY = random.Next(margin, screenHeight - margin);

				// Adjust the jiggle's left, and right jiggleness
				jiggleLocationX += random.Next(-5, 5);

				this.Location = new Point(jiggleLocationX, jiggleLocationY);

				try {
					/*
					 Makes the jiggle look nicer
					 Preferably keep in the 20-75 range

					 Setting it too *low* makes the movements speratic
					 Setting it too *high* make the movements sluggish
					*/
					Thread.Sleep(50);
				} catch (ThreadInterruptedException ex) {
					// handle interruption if needed (Not really needed fr)
				}
			}
		}
	}
}
