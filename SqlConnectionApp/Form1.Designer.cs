namespace SqlConnectionApp
{
    partial class Form1
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
            this.btnGlobalConn = new System.Windows.Forms.Button();
            this.btnLocalConn = new System.Windows.Forms.Button();
            this.btnAppConfigConn = new System.Windows.Forms.Button();
            this.btnClassConn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGlobalConn
            // 
            this.btnGlobalConn.Location = new System.Drawing.Point(58, 26);
            this.btnGlobalConn.Name = "btnGlobalConn";
            this.btnGlobalConn.Size = new System.Drawing.Size(251, 49);
            this.btnGlobalConn.TabIndex = 0;
            this.btnGlobalConn.Text = "Global Bağlantı";
            this.btnGlobalConn.UseVisualStyleBackColor = true;
            this.btnGlobalConn.Click += new System.EventHandler(this.btnGlobalConn_Click);
            // 
            // btnLocalConn
            // 
            this.btnLocalConn.Location = new System.Drawing.Point(58, 106);
            this.btnLocalConn.Name = "btnLocalConn";
            this.btnLocalConn.Size = new System.Drawing.Size(251, 49);
            this.btnLocalConn.TabIndex = 1;
            this.btnLocalConn.Text = "Local Bağlantı";
            this.btnLocalConn.UseVisualStyleBackColor = true;
            this.btnLocalConn.Click += new System.EventHandler(this.btnLocalConn_Click);
            // 
            // btnAppConfigConn
            // 
            this.btnAppConfigConn.Location = new System.Drawing.Point(58, 257);
            this.btnAppConfigConn.Name = "btnAppConfigConn";
            this.btnAppConfigConn.Size = new System.Drawing.Size(251, 49);
            this.btnAppConfigConn.TabIndex = 2;
            this.btnAppConfigConn.Text = "App.Config Bağlantısı";
            this.btnAppConfigConn.UseVisualStyleBackColor = true;
            this.btnAppConfigConn.Click += new System.EventHandler(this.btnAppConfigConn_Click);
            // 
            // btnClassConn
            // 
            this.btnClassConn.Location = new System.Drawing.Point(58, 182);
            this.btnClassConn.Name = "btnClassConn";
            this.btnClassConn.Size = new System.Drawing.Size(251, 49);
            this.btnClassConn.TabIndex = 3;
            this.btnClassConn.Text = "Class Bağlantısı";
            this.btnClassConn.UseVisualStyleBackColor = true;
            this.btnClassConn.Click += new System.EventHandler(this.btnClassConn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClassConn);
            this.Controls.Add(this.btnAppConfigConn);
            this.Controls.Add(this.btnLocalConn);
            this.Controls.Add(this.btnGlobalConn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGlobalConn;
        private System.Windows.Forms.Button btnLocalConn;
        private System.Windows.Forms.Button btnAppConfigConn;
        private System.Windows.Forms.Button btnClassConn;
    }
}

