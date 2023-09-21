namespace CashierQueueu
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
            btnCashier = new Button();
            label1 = new Label();
            lblQueue = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.BackColor = Color.White;
            btnCashier.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCashier.Location = new Point(25, 73);
            btnCashier.Margin = new Padding(4);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(171, 161);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(304, 73);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 1;
            label1.Text = "Position In Queue";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblQueue.Location = new Point(319, 148);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(112, 37);
            lblQueue.TabIndex = 2;
            lblQueue.Text = "Position";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(36, 247);
            label2.Name = "label2";
            label2.Size = new Size(149, 19);
            label2.TabIndex = 3;
            label2.Text = "*Click to get a Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(576, 313);
            Controls.Add(label2);
            Controls.Add(lblQueue);
            Controls.Add(label1);
            Controls.Add(btnCashier);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "QueuingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label label1;
        private Label lblQueue;
        private Label label2;
    }
}