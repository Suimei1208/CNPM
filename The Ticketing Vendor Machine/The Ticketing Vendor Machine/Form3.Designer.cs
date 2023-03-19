namespace The_Ticketing_Vendor_Machine
{
    partial class Form3
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
            pb = new PictureBox();
            label1 = new Label();
            name = new TextBox();
            ok = new Button();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            SuspendLayout();
            // 
            // pb
            // 
            pb.Location = new Point(279, 104);
            pb.Name = "pb";
            pb.Size = new Size(227, 221);
            pb.TabIndex = 0;
            pb.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(138, 54);
            label1.Name = "label1";
            label1.Size = new Size(167, 28);
            label1.TabIndex = 1;
            label1.Text = "Vui lòng nhập tên";
            // 
            // name
            // 
            name.Location = new Point(339, 59);
            name.Name = "name";
            name.Size = new Size(323, 23);
            name.TabIndex = 5;
            name.KeyDown += name_KeyDown;
            // 
            // ok
            // 
            ok.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ok.Location = new Point(268, 348);
            ok.Name = "ok";
            ok.Size = new Size(252, 76);
            ok.TabIndex = 6;
            ok.Text = "Tôi đã thanh toán thành công";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ok);
            Controls.Add(name);
            Controls.Add(label1);
            Controls.Add(pb);
            Name = "Form3";
            Text = "Payment via ZaloPay";
            FormClosing += Form3_FormClosing;
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb;
        private Label label1;
        private TextBox name;
        private Button ok;
    }
}