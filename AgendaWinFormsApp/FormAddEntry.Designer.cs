namespace AgendaWinFormsApp
{
    partial class FormAddEntry
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddEntry = new System.Windows.Forms.Button();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxPutTime = new System.Windows.Forms.CheckBox();
            this.checkBoxPutDate = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.buttonAddEntry);
            this.panel1.Controls.Add(this.dateTimePickerTime);
            this.panel1.Controls.Add(this.dateTimePickerDate);
            this.panel1.Controls.Add(this.checkBoxPutTime);
            this.panel1.Controls.Add(this.checkBoxPutDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 143);
            this.panel1.TabIndex = 2;
            // 
            // buttonAddEntry
            // 
            this.buttonAddEntry.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAddEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEntry.Location = new System.Drawing.Point(12, 85);
            this.buttonAddEntry.Name = "buttonAddEntry";
            this.buttonAddEntry.Size = new System.Drawing.Size(235, 41);
            this.buttonAddEntry.TabIndex = 4;
            this.buttonAddEntry.Text = "ADD ENTRY";
            this.buttonAddEntry.UseVisualStyleBackColor = false;
            this.buttonAddEntry.Click += new System.EventHandler(this.buttonAddEntry_Click);
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(139, 49);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(108, 20);
            this.dateTimePickerTime.TabIndex = 3;
            this.dateTimePickerTime.Visible = false;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(139, 12);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(108, 20);
            this.dateTimePickerDate.TabIndex = 2;
            this.dateTimePickerDate.Visible = false;
            // 
            // checkBoxPutTime
            // 
            this.checkBoxPutTime.AutoSize = true;
            this.checkBoxPutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPutTime.ForeColor = System.Drawing.Color.White;
            this.checkBoxPutTime.Location = new System.Drawing.Point(12, 49);
            this.checkBoxPutTime.Name = "checkBoxPutTime";
            this.checkBoxPutTime.Size = new System.Drawing.Size(104, 20);
            this.checkBoxPutTime.TabIndex = 1;
            this.checkBoxPutTime.Text = "Include Time";
            this.checkBoxPutTime.UseVisualStyleBackColor = true;
            this.checkBoxPutTime.CheckedChanged += new System.EventHandler(this.checkBoxPutTime_CheckedChanged);
            // 
            // checkBoxPutDate
            // 
            this.checkBoxPutDate.AutoSize = true;
            this.checkBoxPutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPutDate.ForeColor = System.Drawing.Color.White;
            this.checkBoxPutDate.Location = new System.Drawing.Point(12, 12);
            this.checkBoxPutDate.Name = "checkBoxPutDate";
            this.checkBoxPutDate.Size = new System.Drawing.Size(102, 20);
            this.checkBoxPutDate.TabIndex = 0;
            this.checkBoxPutDate.Text = "Include Date";
            this.checkBoxPutDate.UseVisualStyleBackColor = true;
            this.checkBoxPutDate.CheckedChanged += new System.EventHandler(this.checkBoxPutDate_CheckedChanged);
            // 
            // FormAddEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 143);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddEntry";
            this.Text = "FormAddEntry";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddEntry;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.CheckBox checkBoxPutTime;
        private System.Windows.Forms.CheckBox checkBoxPutDate;
    }
}