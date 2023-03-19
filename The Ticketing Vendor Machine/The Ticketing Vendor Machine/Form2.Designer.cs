namespace The_Ticketing_Vendor_Machine
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            name = new TextBox();
            cvv = new TextBox();
            num = new TextBox();
            pay = new Button();
            date = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 43);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 0;
            label1.Text = "Cardholder's Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 101);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 1;
            label2.Text = "Card Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(104, 148);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 2;
            label3.Text = "CVV/CVC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(104, 199);
            label4.Name = "label4";
            label4.Size = new Size(144, 28);
            label4.TabIndex = 3;
            label4.Text = "Expriation date";
            // 
            // name
            // 
            name.Location = new Point(311, 51);
            name.Name = "name";
            name.Size = new Size(323, 23);
            name.TabIndex = 4;
            // 
            // cvv
            // 
            cvv.Location = new Point(311, 156);
            cvv.Name = "cvv";
            cvv.Size = new Size(323, 23);
            cvv.TabIndex = 5;
            // 
            // num
            // 
            num.Location = new Point(311, 109);
            num.Name = "num";
            num.Size = new Size(323, 23);
            num.TabIndex = 6;
            // 
            // pay
            // 
            pay.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            pay.Location = new Point(290, 305);
            pay.Name = "pay";
            pay.Size = new Size(180, 67);
            pay.TabIndex = 8;
            pay.Text = " Proceed to payment";
            pay.UseVisualStyleBackColor = true;
            pay.Click += pay_Click;
            // 
            // date
            // 
            date.Location = new Point(311, 204);
            date.Name = "date";
            date.Size = new Size(323, 23);
            date.TabIndex = 9;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 417);
            Controls.Add(date);
            Controls.Add(pay);
            Controls.Add(num);
            Controls.Add(cvv);
            Controls.Add(name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Paying with credit card";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox name;
        private TextBox cvv;
        private TextBox num;
        private Button pay;
        private DateTimePicker date;
    }
}