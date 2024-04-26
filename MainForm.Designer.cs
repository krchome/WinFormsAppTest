namespace ObserverPatternDemo
{
    partial class MainForm
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
            txtDataToUpdate = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // txtDataToUpdate
            // 
            txtDataToUpdate.Location = new Point(200, 74);
            txtDataToUpdate.Margin = new Padding(3, 2, 3, 2);
            txtDataToUpdate.Name = "txtDataToUpdate";
            txtDataToUpdate.Size = new Size(110, 23);
            txtDataToUpdate.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(227, 141);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "btnUpdate";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnUpdate);
            Controls.Add(txtDataToUpdate);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDataToUpdate;
        private Button btnUpdate;
    }
}
