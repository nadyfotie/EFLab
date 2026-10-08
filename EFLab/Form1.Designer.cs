namespace EFLab
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
            lstInvoices = new ListBox();
            lstFiltered1 = new ListBox();
            lstFiltered2 = new ListBox();
            SuspendLayout();
            // 
            // lstInvoices
            // 
            lstInvoices.FormattingEnabled = true;
            lstInvoices.Location = new Point(31, 28);
            lstInvoices.Name = "lstInvoices";
            lstInvoices.Size = new Size(766, 129);
            lstInvoices.TabIndex = 0;
            // 
            // lstFiltered1
            // 
            lstFiltered1.FormattingEnabled = true;
            lstFiltered1.Location = new Point(45, 188);
            lstFiltered1.Name = "lstFiltered1";
            lstFiltered1.Size = new Size(325, 254);
            lstFiltered1.TabIndex = 1;
            // 
            // lstFiltered2
            // 
            lstFiltered2.FormattingEnabled = true;
            lstFiltered2.Location = new Point(398, 188);
            lstFiltered2.Name = "lstFiltered2";
            lstFiltered2.Size = new Size(399, 254);
            lstFiltered2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 478);
            Controls.Add(lstFiltered2);
            Controls.Add(lstFiltered1);
            Controls.Add(lstInvoices);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstInvoices;
        private ListBox lstFiltered1;
        private ListBox lstFiltered2;
    }
}
