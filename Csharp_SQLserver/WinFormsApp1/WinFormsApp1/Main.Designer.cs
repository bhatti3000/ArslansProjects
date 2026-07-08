namespace WinFormsApp1
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            contactsToolStripMenuItem = new ToolStripMenuItem();
            bussinessToolStripMenuItem = new ToolStripMenuItem();
            windowsToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            titleVerticalToolStripMenuItem = new ToolStripMenuItem();
            titleHorizontalToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { contactsToolStripMenuItem, windowsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // contactsToolStripMenuItem
            // 
            contactsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bussinessToolStripMenuItem });
            contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            contactsToolStripMenuItem.Size = new Size(66, 20);
            contactsToolStripMenuItem.Text = "Contacts";
            contactsToolStripMenuItem.Click += contactsToolStripMenuItem_Click;
            // 
            // bussinessToolStripMenuItem
            // 
            bussinessToolStripMenuItem.Name = "bussinessToolStripMenuItem";
            bussinessToolStripMenuItem.Size = new Size(124, 22);
            bussinessToolStripMenuItem.Text = "Bussiness";
            bussinessToolStripMenuItem.Click += bussinessToolStripMenuItem_Click;
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, titleVerticalToolStripMenuItem, titleHorizontalToolStripMenuItem });
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(68, 20);
            windowsToolStripMenuItem.Text = "Windows";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(180, 22);
            cascadeToolStripMenuItem.Text = "Cascade";
            // 
            // titleVerticalToolStripMenuItem
            // 
            titleVerticalToolStripMenuItem.Name = "titleVerticalToolStripMenuItem";
            titleVerticalToolStripMenuItem.Size = new Size(180, 22);
            titleVerticalToolStripMenuItem.Text = "Title Vertical";
            titleVerticalToolStripMenuItem.Click += titleVerticalToolStripMenuItem_Click;
            // 
            // titleHorizontalToolStripMenuItem
            // 
            titleHorizontalToolStripMenuItem.Name = "titleHorizontalToolStripMenuItem";
            titleHorizontalToolStripMenuItem.Size = new Size(180, 22);
            titleHorizontalToolStripMenuItem.Text = "Title Horizontal";
            titleHorizontalToolStripMenuItem.Click += titleHorizontalToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Data Management System";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem contactsToolStripMenuItem;
        private ToolStripMenuItem bussinessToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem titleVerticalToolStripMenuItem;
        private ToolStripMenuItem titleHorizontalToolStripMenuItem;
    }
}
