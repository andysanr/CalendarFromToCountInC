namespace Discussion_Forums_2
{
    partial class Form1
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
            fromDateTimePicker = new DateTimePicker();
            toDateTimePicker = new DateTimePicker();
            FromDateLabel = new Label();
            ToDateLabel = new Label();
            CountLabel = new Label();
            numericUpDown = new NumericUpDown();
            menuStrip = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            increaseToolStripMenuItem = new ToolStripMenuItem();
            decreaseToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            fromDateTimePicker.Location = new Point(62, 143);
            fromDateTimePicker.Margin = new Padding(20);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new Size(200, 23);
            fromDateTimePicker.TabIndex = 0;
            // 
            // toDateTimePicker
            // 
            toDateTimePicker.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            toDateTimePicker.Location = new Point(302, 143);
            toDateTimePicker.Margin = new Padding(20);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new Size(200, 23);
            toDateTimePicker.TabIndex = 1;
            // 
            // FromDateLabel
            // 
            FromDateLabel.AutoSize = true;
            FromDateLabel.Location = new Point(126, 186);
            FromDateLabel.Name = "FromDateLabel";
            FromDateLabel.Size = new Size(62, 15);
            FromDateLabel.TabIndex = 2;
            FromDateLabel.Text = "From Date";
            // 
            // ToDateLabel
            // 
            ToDateLabel.AutoSize = true;
            ToDateLabel.Location = new Point(374, 186);
            ToDateLabel.Name = "ToDateLabel";
            ToDateLabel.Size = new Size(46, 15);
            ToDateLabel.TabIndex = 3;
            ToDateLabel.Text = "To Date";
            // 
            // CountLabel
            // 
            CountLabel.AutoSize = true;
            CountLabel.Location = new Point(261, 61);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(40, 15);
            CountLabel.TabIndex = 4;
            CountLabel.Text = "Count";
            // 
            // numericUpDown
            // 
            numericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown.Location = new Point(263, 88);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(38, 23);
            numericUpDown.TabIndex = 5;
            numericUpDown.Click += numericUpDown_ValueChanged;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip.Location = new Point(10, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(564, 24);
            menuStrip.TabIndex = 6;
            menuStrip.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { increaseToolStripMenuItem, decreaseToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // increaseToolStripMenuItem
            // 
            increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            increaseToolStripMenuItem.Size = new Size(180, 22);
            increaseToolStripMenuItem.Text = "Increase";
            increaseToolStripMenuItem.Click += increaseToolStripMenuItem_Click;
            // 
            // decreaseToolStripMenuItem
            // 
            decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            decreaseToolStripMenuItem.Size = new Size(180, 22);
            decreaseToolStripMenuItem.Text = "Decrease";
            decreaseToolStripMenuItem.Click += decreaseToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 236);
            Controls.Add(numericUpDown);
            Controls.Add(CountLabel);
            Controls.Add(ToDateLabel);
            Controls.Add(FromDateLabel);
            Controls.Add(toDateTimePicker);
            Controls.Add(fromDateTimePicker);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Padding = new Padding(10, 0, 10, 10);
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker fromDateTimePicker;
        private DateTimePicker toDateTimePicker;
        private Label FromDateLabel;
        private Label ToDateLabel;
        private Label CountLabel;
        private NumericUpDown numericUpDown;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem increaseToolStripMenuItem;
        private ToolStripMenuItem decreaseToolStripMenuItem;
    }
}