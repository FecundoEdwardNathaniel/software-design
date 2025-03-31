namespace lab1
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
            listBoxResults = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(308, 79);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(278, 289);
            listBoxResults.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(67, 73);
            button1.Name = "button1";
            button1.Size = new Size(95, 35);
            button1.TabIndex = 1;
            button1.Text = "Sort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSort;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBoxResults);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxResults;
        private Button button1;
    }
}
