namespace employment_center
{
    partial class preadmin
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
            this.passwdbox = new System.Windows.Forms.TextBox();
            this.enterbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwdbox
            // 
            this.passwdbox.Location = new System.Drawing.Point(48, 12);
            this.passwdbox.Name = "passwdbox";
            this.passwdbox.Size = new System.Drawing.Size(117, 20);
            this.passwdbox.TabIndex = 0;
            // 
            // enterbtn
            // 
            this.enterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterbtn.Location = new System.Drawing.Point(48, 38);
            this.enterbtn.Name = "enterbtn";
            this.enterbtn.Size = new System.Drawing.Size(117, 23);
            this.enterbtn.TabIndex = 1;
            this.enterbtn.Text = "Авторизироваться";
            this.enterbtn.UseVisualStyleBackColor = true;
            this.enterbtn.Click += new System.EventHandler(this.enterbtn_Click);
            // 
            // preadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 84);
            this.Controls.Add(this.enterbtn);
            this.Controls.Add(this.passwdbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "preadmin";
            this.Text = "preadmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwdbox;
        private System.Windows.Forms.Button enterbtn;
    }
}