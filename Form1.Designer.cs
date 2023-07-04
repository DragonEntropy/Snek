namespace Snek
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.complexityBar = new System.Windows.Forms.TrackBar();
            this.start = new System.Windows.Forms.Button();
            this.variantMode = new System.Windows.Forms.CheckBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorryNoHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madeByAlexanderJephthaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madeWithMicrosoftVisualStudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codedInCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complexityBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(879, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sorryNoHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Complexity";
            // 
            // speedBar
            // 
            this.speedBar.Location = new System.Drawing.Point(68, 32);
            this.speedBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speedBar.Maximum = 5;
            this.speedBar.Minimum = 1;
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(200, 56);
            this.speedBar.TabIndex = 3;
            this.speedBar.Value = 1;
            // 
            // complexityBar
            // 
            this.complexityBar.Location = new System.Drawing.Point(372, 31);
            this.complexityBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.complexityBar.Minimum = 1;
            this.complexityBar.Name = "complexityBar";
            this.complexityBar.Size = new System.Drawing.Size(200, 56);
            this.complexityBar.TabIndex = 4;
            this.complexityBar.Value = 1;
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(780, 39);
            this.start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(85, 23);
            this.start.TabIndex = 5;
            this.start.Text = "Start";
            this.start.UseMnemonic = false;
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // variantMode
            // 
            this.variantMode.AutoSize = true;
            this.variantMode.Location = new System.Drawing.Point(600, 40);
            this.variantMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.variantMode.Name = "variantMode";
            this.variantMode.Size = new System.Drawing.Size(116, 20);
            this.variantMode.TabIndex = 7;
            this.variantMode.Text = "Variant mode?";
            this.variantMode.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainPanel.Location = new System.Drawing.Point(13, 68);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(853, 492);
            this.mainPanel.TabIndex = 8;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.madeByAlexanderJephthaToolStripMenuItem,
            this.madeWithMicrosoftVisualStudioToolStripMenuItem,
            this.codedInCToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // sorryNoHelpToolStripMenuItem
            // 
            this.sorryNoHelpToolStripMenuItem.Name = "sorryNoHelpToolStripMenuItem";
            this.sorryNoHelpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sorryNoHelpToolStripMenuItem.Text = "Sorry, no help :(";
            // 
            // madeByAlexanderJephthaToolStripMenuItem
            // 
            this.madeByAlexanderJephthaToolStripMenuItem.Name = "madeByAlexanderJephthaToolStripMenuItem";
            this.madeByAlexanderJephthaToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.madeByAlexanderJephthaToolStripMenuItem.Text = "Made by Alexander Jephtha";
            // 
            // madeWithMicrosoftVisualStudioToolStripMenuItem
            // 
            this.madeWithMicrosoftVisualStudioToolStripMenuItem.Name = "madeWithMicrosoftVisualStudioToolStripMenuItem";
            this.madeWithMicrosoftVisualStudioToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.madeWithMicrosoftVisualStudioToolStripMenuItem.Text = "Made with Microsoft Visual Studio";
            // 
            // codedInCToolStripMenuItem
            // 
            this.codedInCToolStripMenuItem.Name = "codedInCToolStripMenuItem";
            this.codedInCToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.codedInCToolStripMenuItem.Text = "Coded in C#";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 572);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.variantMode);
            this.Controls.Add(this.start);
            this.Controls.Add(this.complexityBar);
            this.Controls.Add(this.speedBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Snek";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complexityBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.TrackBar complexityBar;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.CheckBox variantMode;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem madeByAlexanderJephthaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem madeWithMicrosoftVisualStudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codedInCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorryNoHelpToolStripMenuItem;
    }
}

