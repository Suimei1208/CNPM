namespace The_Ticketing_Vendor_Machine
{
    partial class Form4
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
            ok = new Button();
            name = new TextBox();
            label1 = new Label();
            pb = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            SuspendLayout();
            // 
            // ok
            // 
            ok.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ok.Location = new Point(268, 334);
            ok.Name = "ok";
            ok.Size = new Size(252, 76);
            ok.TabIndex = 10;
            ok.Text = "Tôi đã thanh toán thành công";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // name
            // 
            name.Location = new Point(339, 45);
            name.Name = "name";
            name.Size = new Size(323, 23);
            name.TabIndex = 9;
            name.KeyDown += name_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(138, 40);
            label1.Name = "label1";
            label1.Size = new Size(167, 28);
            label1.TabIndex = 8;
            label1.Text = "Vui lòng nhập tên";
            // 
            // pb
            // 
            pb.Location = new Point(279, 90);
            pb.Name = "pb";
            pb.Size = new Size(227, 221);
            pb.TabIndex = 7;
            pb.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ok);
            Controls.Add(name);
            Controls.Add(label1);
            Controls.Add(pb);
            Name = "Form4";
            Text = "Payment via Momo";
            FormClosing += Form4_FormClosing;
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ok;
        private TextBox name;
        private Label label1;
        private PictureBox pb;
    }
}