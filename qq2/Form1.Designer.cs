namespace qq2
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
            label1 = new Label();
            btn_price = new Button();
            label2 = new Label();
            btn_clear = new Button();
            btn_exit = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtRooms = new TextBox();
            txtTotal = new TextBox();
            cmb_room = new ComboBox();
            cmb_extra = new ComboBox();
            label8 = new Label();
            txtdays = new TextBox();
            lableDis = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 111);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // btn_price
            // 
            btn_price.Location = new Point(598, 111);
            btn_price.Name = "btn_price";
            btn_price.Size = new Size(135, 32);
            btn_price.TabIndex = 1;
            btn_price.Text = "Calculate the Price";
            btn_price.UseVisualStyleBackColor = true;
            btn_price.Click += btn_price_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 22);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Booking Form";
            label2.Click += label2_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(598, 171);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(69, 32);
            btn_clear.TabIndex = 3;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(598, 229);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(69, 32);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 157);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 203);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 6;
            label4.Text = "Room Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 246);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 7;
            label5.Text = "Number of Rooms";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 356);
            label6.Name = "label6";
            label6.Size = new Size(201, 15);
            label6.TabIndex = 8;
            label6.Text = "Do you want to do another booking?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(518, 356);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 9;
            label7.Text = "Total Cost";
            // 
            // txtName
            // 
            txtName.Location = new Point(245, 108);
            txtName.Name = "txtName";
            txtName.Size = new Size(195, 23);
            txtName.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(245, 154);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(195, 23);
            txtAddress.TabIndex = 11;
            // 
            // txtRooms
            // 
            txtRooms.Location = new Point(245, 243);
            txtRooms.Name = "txtRooms";
            txtRooms.Size = new Size(100, 23);
            txtRooms.TabIndex = 12;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(598, 353);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 13;
            // 
            // cmb_room
            // 
            cmb_room.FormattingEnabled = true;
            cmb_room.Items.AddRange(new object[] { "Single", "Double", "Family", "Suite" });
            cmb_room.Location = new Point(245, 200);
            cmb_room.Name = "cmb_room";
            cmb_room.Size = new Size(121, 23);
            cmb_room.TabIndex = 14;
            // 
            // cmb_extra
            // 
            cmb_extra.FormattingEnabled = true;
            cmb_extra.Items.AddRange(new object[] { "Yes", "No" });
            cmb_extra.Location = new Point(317, 353);
            cmb_extra.Name = "cmb_extra";
            cmb_extra.Size = new Size(76, 23);
            cmb_extra.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(101, 289);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 16;
            label8.Text = "Number of Days";
            // 
            // txtdays
            // 
            txtdays.Location = new Point(245, 286);
            txtdays.Name = "txtdays";
            txtdays.Size = new Size(100, 23);
            txtdays.TabIndex = 17;
            // 
            // lableDis
            // 
            lableDis.AutoSize = true;
            lableDis.Location = new Point(614, 389);
            lableDis.Name = "lableDis";
            lableDis.Size = new Size(0, 15);
            lableDis.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lableDis);
            Controls.Add(txtdays);
            Controls.Add(label8);
            Controls.Add(cmb_extra);
            Controls.Add(cmb_room);
            Controls.Add(txtTotal);
            Controls.Add(txtRooms);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_exit);
            Controls.Add(btn_clear);
            Controls.Add(label2);
            Controls.Add(btn_price);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Booking Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_price;
        private Label label2;
        private Button btn_clear;
        private Button btn_exit;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtRooms;
        private TextBox txtTotal;
        private ComboBox cmb_room;
        private ComboBox cmb_extra;
        private Label label8;
        private TextBox txtdays;
        private Label lableDis;
    }
}