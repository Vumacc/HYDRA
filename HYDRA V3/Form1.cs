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


			System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
			timer.Interval = (250);
			timer.Tick += new EventHandler(timer_Tick);
			timer.Start();
		}

		private void timer_Tick(object sender, EventArgs e) {
			if (theme == "dark") {
				change_form_theme("light");
				theme = "light";
			} else if (theme == "light") {
				change_form_theme("dark");
				theme = "dark";
			}
		}
	}
}
