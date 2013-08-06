namespace WinForm
{
    partial class ConnectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBloggingConnectionString = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomConnectionString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAppSetting1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAppSetting2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Co&nnection to Blogging:";
            // 
            // txtBloggingConnectionString
            // 
            this.txtBloggingConnectionString.Location = new System.Drawing.Point(64, 43);
            this.txtBloggingConnectionString.Multiline = true;
            this.txtBloggingConnectionString.Name = "txtBloggingConnectionString";
            this.txtBloggingConnectionString.Size = new System.Drawing.Size(515, 46);
            this.txtBloggingConnectionString.TabIndex = 1;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(174, 264);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "&Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(390, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connection to Custom:";
            // 
            // txtCustomConnectionString
            // 
            this.txtCustomConnectionString.Location = new System.Drawing.Point(64, 114);
            this.txtCustomConnectionString.Multiline = true;
            this.txtCustomConnectionString.Name = "txtCustomConnectionString";
            this.txtCustomConnectionString.Size = new System.Drawing.Size(515, 46);
            this.txtCustomConnectionString.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "AppSetting 1:";
            // 
            // txtAppSetting1
            // 
            this.txtAppSetting1.Location = new System.Drawing.Point(64, 187);
            this.txtAppSetting1.Name = "txtAppSetting1";
            this.txtAppSetting1.Size = new System.Drawing.Size(515, 21);
            this.txtAppSetting1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "AppSetting 2:";
            // 
            // txtAppSetting2
            // 
            this.txtAppSetting2.Location = new System.Drawing.Point(64, 230);
            this.txtAppSetting2.Name = "txtAppSetting2";
            this.txtAppSetting2.Size = new System.Drawing.Size(515, 21);
            this.txtAppSetting2.TabIndex = 7;
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 307);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtAppSetting2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAppSetting1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomConnectionString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBloggingConnectionString);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConnectionForm";
            this.Text = "Connection Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBloggingConnectionString;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomConnectionString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAppSetting1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAppSetting2;
    }
}

