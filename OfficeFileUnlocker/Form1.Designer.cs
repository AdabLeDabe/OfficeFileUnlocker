namespace OfficeFileUnlocker
{
    partial class MainForm
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
            this.bt_browse = new System.Windows.Forms.Button();
            this.lbl_filename = new System.Windows.Forms.Label();
            this.bt_unlock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_browse
            // 
            this.bt_browse.Location = new System.Drawing.Point(12, 12);
            this.bt_browse.Name = "bt_browse";
            this.bt_browse.Size = new System.Drawing.Size(253, 23);
            this.bt_browse.TabIndex = 0;
            this.bt_browse.Text = "Browse file";
            this.bt_browse.UseVisualStyleBackColor = true;
            this.bt_browse.Click += new System.EventHandler(this.bt_browse_Click);
            // 
            // lbl_filename
            // 
            this.lbl_filename.AutoSize = true;
            this.lbl_filename.Location = new System.Drawing.Point(12, 38);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Size = new System.Drawing.Size(55, 13);
            this.lbl_filename.TabIndex = 1;
            this.lbl_filename.Text = "File name:";
            // 
            // bt_unlock
            // 
            this.bt_unlock.Location = new System.Drawing.Point(12, 68);
            this.bt_unlock.Name = "bt_unlock";
            this.bt_unlock.Size = new System.Drawing.Size(253, 44);
            this.bt_unlock.TabIndex = 2;
            this.bt_unlock.Text = "Unlock!";
            this.bt_unlock.UseVisualStyleBackColor = true;
            this.bt_unlock.Click += new System.EventHandler(this.bt_unlock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_status.Location = new System.Drawing.Point(58, 132);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(70, 13);
            this.lbl_status.TabIndex = 4;
            this.lbl_status.Text = "Not started";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 154);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_unlock);
            this.Controls.Add(this.lbl_filename);
            this.Controls.Add(this.bt_browse);
            this.Name = "MainForm";
            this.Text = "Office file unlocker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_browse;
        private System.Windows.Forms.Label lbl_filename;
        private System.Windows.Forms.Button bt_unlock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_status;
    }
}

