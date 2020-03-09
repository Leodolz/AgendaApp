namespace AgendaWinFormsApp
{
    partial class FormFilter
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
            this.dateTimePickerIfDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxIfText = new System.Windows.Forms.TextBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.dateTimePickerIfDate);
            this.panel1.Controls.Add(this.textBoxIfText);
            this.panel1.Controls.Add(this.labelFilter);
            this.panel1.Controls.Add(this.buttonFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 113);
            this.panel1.TabIndex = 3;
            // 
            // dateTimePickerIfDate
            // 
            this.dateTimePickerIfDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerIfDate.Location = new System.Drawing.Point(90, 19);
            this.dateTimePickerIfDate.Name = "dateTimePickerIfDate";
            this.dateTimePickerIfDate.Size = new System.Drawing.Size(157, 20);
            this.dateTimePickerIfDate.TabIndex = 7;
            this.dateTimePickerIfDate.Visible = false;
            // 
            // textBoxIfText
            // 
            this.textBoxIfText.Location = new System.Drawing.Point(90, 18);
            this.textBoxIfText.Name = "textBoxIfText";
            this.textBoxIfText.Size = new System.Drawing.Size(157, 20);
            this.textBoxIfText.TabIndex = 6;
            this.textBoxIfText.Visible = false;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.ForeColor = System.Drawing.Color.White;
            this.labelFilter.Location = new System.Drawing.Point(12, 19);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(72, 16);
            this.labelFilter.TabIndex = 5;
            this.labelFilter.Text = "Date|Text :";
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.LightBlue;
            this.buttonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilter.Location = new System.Drawing.Point(12, 49);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(235, 41);
            this.buttonFilter.TabIndex = 4;
            this.buttonFilter.Text = "FILTER";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // FormFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 113);
            this.Controls.Add(this.panel1);
            this.Name = "FormFilter";
            this.Text = "FormFilter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerIfDate;
        private System.Windows.Forms.TextBox textBoxIfText;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Button buttonFilter;
    }
}