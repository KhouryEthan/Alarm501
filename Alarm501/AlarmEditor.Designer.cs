
namespace Alarm501
{
    partial class AlarmEditor
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
            this.uxSet = new System.Windows.Forms.Button();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxToggle = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // uxSet
            // 
            this.uxSet.Location = new System.Drawing.Point(146, 67);
            this.uxSet.Name = "uxSet";
            this.uxSet.Size = new System.Drawing.Size(75, 23);
            this.uxSet.TabIndex = 1;
            this.uxSet.Text = "Set";
            this.uxSet.UseVisualStyleBackColor = true;
            this.uxSet.Click += new System.EventHandler(this.uxSet_Click);
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(12, 67);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 2;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxToggle
            // 
            this.uxToggle.AutoSize = true;
            this.uxToggle.Location = new System.Drawing.Point(181, 32);
            this.uxToggle.Name = "uxToggle";
            this.uxToggle.Size = new System.Drawing.Size(40, 17);
            this.uxToggle.TabIndex = 3;
            this.uxToggle.Text = "On";
            this.uxToggle.UseVisualStyleBackColor = true;
            this.uxToggle.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AlarmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 97);
            this.Controls.Add(this.uxToggle);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxSet);
            this.Name = "AlarmEditor";
            this.Text = "AlarmEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxSet;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.CheckBox uxToggle;
    }
}