namespace ObserverPatternDemo
{
    partial class frmObserver1
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
            lblData = new Label();
            btnSubscribe = new Button();
            btnUnsubscribe = new Button();
            SuspendLayout();
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(170, 140);
            lblData.Name = "lblData";
            lblData.Size = new Size(79, 15);
            lblData.TabIndex = 0;
            lblData.Text = "Updated Data";
            // 
            // btnSubscribe
            // 
            btnSubscribe.Location = new Point(178, 68);
            btnSubscribe.Margin = new Padding(3, 2, 3, 2);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(82, 22);
            btnSubscribe.TabIndex = 1;
            btnSubscribe.Text = "Register";
            btnSubscribe.UseVisualStyleBackColor = true;
            btnSubscribe.Click += btnSubscribe_Click;
            // 
            // btnUnsubscribe
            // 
            btnUnsubscribe.Location = new Point(178, 104);
            btnUnsubscribe.Margin = new Padding(3, 2, 3, 2);
            btnUnsubscribe.Name = "btnUnsubscribe";
            btnUnsubscribe.Size = new Size(82, 22);
            btnUnsubscribe.TabIndex = 2;
            btnUnsubscribe.Text = "De-Register";
            btnUnsubscribe.UseVisualStyleBackColor = true;
            btnUnsubscribe.Click += btnUnsubscribe_Click;
            // 
            // frmObserver1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnUnsubscribe);
            Controls.Add(btnSubscribe);
            Controls.Add(lblData);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmObserver1";
            Text = "frmObserver1";
            Load += frmObserver1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblData;
        private Button btnSubscribe;
        private Button btnUnsubscribe;
    }
}