namespace CashierQueueu
{
    partial class CashierWindowQueueForm
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
            listCashierQueue = new ListBox();
            btnNext = new Button();
            btnRefresh = new Button();
            SuspendLayout();
            // 
            // listCashierQueue
            // 
            listCashierQueue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listCashierQueue.FormattingEnabled = true;
            listCashierQueue.ItemHeight = 21;
            listCashierQueue.Location = new Point(134, 14);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(251, 382);
            listCashierQueue.TabIndex = 8;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.Control;
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(12, 59);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(116, 31);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.Control;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(12, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 31);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 423);
            Controls.Add(listCashierQueue);
            Controls.Add(btnNext);
            Controls.Add(btnRefresh);
            Name = "CashierWindowQueueForm";
            Text = "CashierWindowQueueForm";
            Load += CashierWindowQueueForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listCashierQueue;
        private Button btnNext;
        private Button btnRefresh;
    }
}