using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HYDRA_V3
{
    partial class hydra
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hydra));
			this.label_title = new System.Windows.Forms.Label();
			this.label_description = new System.Windows.Forms.Label();
			this.label_footer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label_title
			// 
			this.label_title.AutoSize = true;
			this.label_title.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label_title.Location = new System.Drawing.Point(187, 22);
			this.label_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_title.Name = "label_title";
			this.label_title.Size = new System.Drawing.Size(177, 41);
			this.label_title.TabIndex = 0;
			this.label_title.Text = "HYDRA   ";
			this.label_title.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label_description
			// 
			this.label_description.AutoSize = true;
			this.label_description.Font = new System.Drawing.Font("NewsGoth BT", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_description.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label_description.Location = new System.Drawing.Point(88, 78);
			this.label_description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_description.Name = "label_description";
			this.label_description.Size = new System.Drawing.Size(348, 81);
			this.label_description.TabIndex = 2;
			this.label_description.Text = "Cut off a head,\r\nand two more shall take it\'s place!\r\n\r\n";
			this.label_description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label_footer
			// 
			this.label_footer.AutoSize = true;
			this.label_footer.Font = new System.Drawing.Font("NewsGoth BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_footer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label_footer.Location = new System.Drawing.Point(190, 160);
			this.label_footer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_footer.Name = "label_footer";
			this.label_footer.Size = new System.Drawing.Size(152, 22);
			this.label_footer.TabIndex = 3;
			this.label_footer.Text = "Made by Vumacc";
			// 
			// hydra
			// 
			this.AccessibleName = "";
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(536, 228);
			this.Controls.Add(this.label_footer);
			this.Controls.Add(this.label_description);
			this.Controls.Add(this.label_title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "hydra";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowIcon = false;
			this.Text = "HYDRA";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.hydra_FormClosing);
			this.Load += new System.EventHandler(this.hydra_Load);
			this.MouseHover += new System.EventHandler(this.hydra_MouseHover);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		private void hydra_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = true;

			Random random = new Random();

			Screen screen = Screen.FromPoint(this.Location);
			int screenWidth = screen.WorkingArea.Width;
			int screenHeight = screen.WorkingArea.Height;

			// Making 2 new heads
			// Add more if you wish
			hydra newHead1 = new hydra();
			hydra newHead2 = new hydra();

			newHead1.WindowState = FormWindowState.Normal;
			newHead2.WindowState = FormWindowState.Normal;

			newHead1.StartPosition = FormStartPosition.Manual;
			newHead2.StartPosition = FormStartPosition.Manual;

			newHead1.BringToFront();
			newHead2.BringToFront();

			newHead1.Show();
			newHead2.Show();

			// Increase or decrease to adjust where the new heads are placed
			int margin = 50;

			int newHead1X = random.Next(margin, screenWidth - newHead1.Width - margin);
			int newHead1Y = random.Next(margin, screenHeight - newHead1.Height - margin);
			int newHead2X = random.Next(margin, screenWidth - newHead2.Width - margin);
			int newHead2Y = random.Next(margin, screenHeight - newHead2.Height - margin);

			newHead1.Location = new Point(newHead1X, newHead1Y);
			newHead2.Location = new Point(newHead2X, newHead2Y);

			this.Hide();
		}

		#endregion

		private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_description;
		private System.Windows.Forms.Label label_footer;
		}
}

