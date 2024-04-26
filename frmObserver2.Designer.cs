namespace ObserverPatternDemo
{
    partial class frmObserver2
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
            txtData = new TextBox();
            btnUnsubscribe = new Button();
            btnSubscribe = new Button();
            SuspendLayout();
            // 
            // txtData
            // 
            txtData.Location = new Point(301, 215);
            txtData.Name = "txtData";
            txtData.Size = new Size(174, 27);
            txtData.TabIndex = 0;
            // 
            // btnUnsubscribe
            // 
            btnUnsubscribe.Location = new Point(310, 129);
            btnUnsubscribe.Name = "btnUnsubscribe";
            btnUnsubscribe.Size = new Size(116, 29);
            btnUnsubscribe.TabIndex = 4;
            btnUnsubscribe.Text = "De-Register";
            btnUnsubscribe.UseVisualStyleBackColor = true;
            btnUnsubscribe.Click += btnUnsubscribe_Click;
            // 
            // btnSubscribe
            // 
            btnSubscribe.Location = new Point(310, 56);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(94, 29);
            btnSubscribe.TabIndex = 3;
            btnSubscribe.Text = "Register";
            btnSubscribe.UseVisualStyleBackColor = true;
            btnSubscribe.Click += btnSubscribe_Click;
            // 
            // frmObserver2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUnsubscribe);
            Controls.Add(btnSubscribe);
            Controls.Add(txtData);
            Name = "frmObserver2";
            Text = "frmObserver2";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtData;
        private Button btnUnsubscribe;
        private Button btnSubscribe;
    }
}