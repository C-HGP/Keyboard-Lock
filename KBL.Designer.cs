namespace KBL
{
    partial class KBL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KBL));
            this.label1 = new System.Windows.Forms.Label();
            this.LockKB = new System.Windows.Forms.RadioButton();
            this.UnlockKB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Avita Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keyboard Lock Tool";
            // 
            // LockKB
            // 
            this.LockKB.AutoSize = true;
            this.LockKB.Location = new System.Drawing.Point(6, 43);
            this.LockKB.Name = "LockKB";
            this.LockKB.Size = new System.Drawing.Size(97, 17);
            this.LockKB.TabIndex = 3;
            this.LockKB.TabStop = true;
            this.LockKB.Text = "Lock Keyboard";
            this.LockKB.UseVisualStyleBackColor = true;
            this.LockKB.CheckedChanged += new System.EventHandler(this.lockKB_CheckedChanged);
            // 
            // UnlockKB
            // 
            this.UnlockKB.AutoSize = true;
            this.UnlockKB.Location = new System.Drawing.Point(6, 66);
            this.UnlockKB.Name = "UnlockKB";
            this.UnlockKB.Size = new System.Drawing.Size(107, 17);
            this.UnlockKB.TabIndex = 2;
            this.UnlockKB.TabStop = true;
            this.UnlockKB.Text = "Unlock Keyboard";
            this.UnlockKB.UseVisualStyleBackColor = true;
            this.UnlockKB.CheckedChanged += new System.EventHandler(this.unlockKB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LockKB);
            this.groupBox1.Controls.Add(this.UnlockKB);
            this.groupBox1.Location = new System.Drawing.Point(57, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select State: ";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(57, 175);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(200, 20);
            this.TextBox.TabIndex = 1;
            // 
            // KBL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(344, 196);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KBL";
            this.Text = "KBL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton LockKB;
        private System.Windows.Forms.RadioButton UnlockKB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBox;
    }
}

