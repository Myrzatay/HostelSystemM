namespace HOSTEL_SYSTEM_MANAGEMENT
{
    partial class ReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_button = new System.Windows.Forms.Panel();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.dataGridView_reserv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dateTimePicker_dateOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_dateIn = new System.Windows.Forms.DateTimePicker();
            this.comboBox_roomNo = new System.Windows.Forms.ComboBox();
            this.comboBox_roomType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_guestId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_reservId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reserv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label_exit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 79);
            this.panel1.TabIndex = 2;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exit.Location = new System.Drawing.Point(905, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(35, 33);
            this.label_exit.TabIndex = 14;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(358, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Manage Reservation";
            // 
            // panel_button
            // 
            this.panel_button.BackColor = System.Drawing.Color.SkyBlue;
            this.panel_button.Controls.Add(this.button_clean);
            this.panel_button.Controls.Add(this.button_delete);
            this.panel_button.Controls.Add(this.button_update);
            this.panel_button.Controls.Add(this.button_save);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_button.Location = new System.Drawing.Point(0, 600);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(940, 100);
            this.panel_button.TabIndex = 24;
            // 
            // button_clean
            // 
            this.button_clean.FlatAppearance.BorderSize = 0;
            this.button_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clean.ForeColor = System.Drawing.Color.White;
            this.button_clean.Image = global::HOSTEL_SYSTEM_MANAGEMENT.Properties.Resources.imgonline_com_ua_Resize_Md0dtgtIXU;
            this.button_clean.Location = new System.Drawing.Point(527, 3);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(105, 78);
            this.button_clean.TabIndex = 6;
            this.button_clean.Text = "Clean";
            this.button_clean.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_clean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // button_delete
            // 
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Image = global::HOSTEL_SYSTEM_MANAGEMENT.Properties.Resources.imgonline_com_ua_Resize_iiJWMttUb7MsO;
            this.button_delete.Location = new System.Drawing.Point(416, 3);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(105, 78);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "Delete";
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.SkyBlue;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Image = global::HOSTEL_SYSTEM_MANAGEMENT.Properties.Resources.imgonline_com_ua_Resize_4NsOttvmvv;
            this.button_update.Location = new System.Drawing.Point(305, 3);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(105, 78);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "Update";
            this.button_update.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.SkyBlue;
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Image = ((System.Drawing.Image)(resources.GetObject("button_save.Image")));
            this.button_save.Location = new System.Drawing.Point(205, 3);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(105, 78);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "Add";
            this.button_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // dataGridView_reserv
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridView_reserv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_reserv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_reserv.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_reserv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_reserv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_reserv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_reserv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_reserv.ColumnHeadersHeight = 20;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_reserv.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_reserv.EnableHeadersVisualStyles = false;
            this.dataGridView_reserv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_reserv.Location = new System.Drawing.Point(28, 80);
            this.dataGridView_reserv.Name = "dataGridView_reserv";
            this.dataGridView_reserv.RowHeadersVisible = false;
            this.dataGridView_reserv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_reserv.Size = new System.Drawing.Size(886, 349);
            this.dataGridView_reserv.TabIndex = 25;
            this.dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_reserv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_reserv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.Height = 20;
            this.dataGridView_reserv.ThemeStyle.ReadOnly = false;
            this.dataGridView_reserv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_reserv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_reserv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_reserv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_reserv.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_reserv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_reserv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_reserv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_reserv_CellClick);
            // 
            // dateTimePicker_dateOut
            // 
            this.dateTimePicker_dateOut.CustomFormat = "dd/MM/yyy";
            this.dateTimePicker_dateOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_dateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dateOut.Location = new System.Drawing.Point(625, 479);
            this.dateTimePicker_dateOut.Name = "dateTimePicker_dateOut";
            this.dateTimePicker_dateOut.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_dateOut.TabIndex = 38;
            // 
            // dateTimePicker_dateIn
            // 
            this.dateTimePicker_dateIn.CustomFormat = "dd/MM/yyy";
            this.dateTimePicker_dateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dateIn.Location = new System.Drawing.Point(625, 435);
            this.dateTimePicker_dateIn.Name = "dateTimePicker_dateIn";
            this.dateTimePicker_dateIn.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_dateIn.TabIndex = 39;
            // 
            // comboBox_roomNo
            // 
            this.comboBox_roomNo.FormattingEnabled = true;
            this.comboBox_roomNo.Location = new System.Drawing.Point(236, 567);
            this.comboBox_roomNo.Name = "comboBox_roomNo";
            this.comboBox_roomNo.Size = new System.Drawing.Size(141, 21);
            this.comboBox_roomNo.TabIndex = 36;
            // 
            // comboBox_roomType
            // 
            this.comboBox_roomType.FormattingEnabled = true;
            this.comboBox_roomType.Location = new System.Drawing.Point(236, 525);
            this.comboBox_roomType.Name = "comboBox_roomType";
            this.comboBox_roomType.Size = new System.Drawing.Size(141, 21);
            this.comboBox_roomType.TabIndex = 37;
            this.comboBox_roomType.SelectedIndexChanged += new System.EventHandler(this.comboBox_roomType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(519, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Date Out:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(535, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Date In:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(130, 570);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Room No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(115, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Room Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(134, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Guest Id:";
            // 
            // textBox_guestId
            // 
            this.textBox_guestId.Location = new System.Drawing.Point(236, 479);
            this.textBox_guestId.Name = "textBox_guestId";
            this.textBox_guestId.Size = new System.Drawing.Size(141, 20);
            this.textBox_guestId.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(130, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Reserv Id:";
            // 
            // textBox_reservId
            // 
            this.textBox_reservId.Location = new System.Drawing.Point(236, 435);
            this.textBox_reservId.Name = "textBox_reservId";
            this.textBox_reservId.Size = new System.Drawing.Size(141, 20);
            this.textBox_reservId.TabIndex = 28;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 700);
            this.Controls.Add(this.dateTimePicker_dateOut);
            this.Controls.Add(this.dateTimePicker_dateIn);
            this.Controls.Add(this.comboBox_roomNo);
            this.Controls.Add(this.comboBox_roomType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_guestId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_reservId);
            this.Controls.Add(this.dataGridView_reserv);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reserv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_save;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_reserv;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateOut;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateIn;
        private System.Windows.Forms.ComboBox comboBox_roomNo;
        private System.Windows.Forms.ComboBox comboBox_roomType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_guestId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_reservId;
    }
}