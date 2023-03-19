namespace The_Ticketing_Vendor_Machine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            grp1 = new GroupBox();
            grd = new DataGridView();
            des = new ComboBox();
            grp2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            b1 = new Button();
            grp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            grp2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 38);
            label1.Name = "label1";
            label1.Size = new Size(182, 28);
            label1.TabIndex = 0;
            label1.Text = "Choose Destination";
            // 
            // grp1
            // 
            grp1.Controls.Add(grd);
            grp1.Controls.Add(des);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(12, 12);
            grp1.Name = "grp1";
            grp1.Size = new Size(776, 282);
            grp1.TabIndex = 1;
            grp1.TabStop = false;
            grp1.Text = "Destination";
            // 
            // grd
            // 
            grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(20, 104);
            grd.Name = "grd";
            grd.RowTemplate.Height = 25;
            grd.Size = new Size(732, 164);
            grd.TabIndex = 2;
            grd.Click += grd_Click;
            // 
            // des
            // 
            des.FormattingEnabled = true;
            des.Location = new Point(328, 43);
            des.Name = "des";
            des.Size = new Size(345, 23);
            des.TabIndex = 1;
            des.SelectedIndexChanged += des_SelectedIndexChanged;
            // 
            // grp2
            // 
            grp2.Controls.Add(button2);
            grp2.Controls.Add(button1);
            grp2.Controls.Add(b1);
            grp2.Location = new Point(12, 300);
            grp2.Name = "grp2";
            grp2.Size = new Size(776, 138);
            grp2.TabIndex = 2;
            grp2.TabStop = false;
            grp2.Text = "Payment";
            // 
            // button2
            // 
            button2.Location = new Point(563, 48);
            button2.Name = "button2";
            button2.Size = new Size(189, 49);
            button2.TabIndex = 2;
            button2.Text = "Momo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(291, 48);
            button1.Name = "button1";
            button1.Size = new Size(189, 49);
            button1.TabIndex = 1;
            button1.Text = "Zalo Pay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // b1
            // 
            b1.Image = (Image)resources.GetObject("b1.Image");
            b1.Location = new Point(20, 48);
            b1.Name = "b1";
            b1.Size = new Size(189, 49);
            b1.TabIndex = 0;
            b1.Text = " ";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 455);
            Controls.Add(grp2);
            Controls.Add(grp1);
            Name = "Form1";
            Text = "The Ticketing Vendor Machine";
            Load += Form1_Load;
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            grp2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox grp1;
        private ComboBox des;
        private DataGridView grd;
        private GroupBox grp2;
        private Button b1;
        private Button button2;
        private Button button1;
    }
}