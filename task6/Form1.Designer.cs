namespace task6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnSort;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnSort = new Button();
            cmbResult = new ListBox();
            SuspendLayout();
          
            btnSort.Location = new Point(424, 162);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 1;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
          
            cmbResult.FormattingEnabled = true;
            cmbResult.ItemHeight = 15;
            cmbResult.Location = new Point(110, 63);
            cmbResult.Name = "cmbResult";
            cmbResult.Size = new Size(236, 244);
            cmbResult.TabIndex = 2;
            cmbResult.SelectedIndexChanged += cmbResult_SelectedIndexChanged;
          
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbResult);
            Controls.Add(btnSort);
            Name = "Form1";
            Text = "Sorting Application";
            Load += Form1_Load;
            ResumeLayout(false);
        }
        private ListBox cmbResult;
    }
}
