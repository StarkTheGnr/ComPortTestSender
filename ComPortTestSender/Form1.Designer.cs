namespace ComPortTestSender
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
			this.btnSend = new System.Windows.Forms.Button();
			this.txtPortName = new System.Windows.Forms.TextBox();
			this.lblPortName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSend
			// 
			this.btnSend.BackColor = System.Drawing.Color.White;
			this.btnSend.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSend.Location = new System.Drawing.Point(317, 188);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(127, 51);
			this.btnSend.TabIndex = 0;
			this.btnSend.Text = "Send ABC to ComPort";
			this.btnSend.UseVisualStyleBackColor = false;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtPortName
			// 
			this.txtPortName.Location = new System.Drawing.Point(317, 162);
			this.txtPortName.Name = "txtPortName";
			this.txtPortName.Size = new System.Drawing.Size(100, 20);
			this.txtPortName.TabIndex = 1;
			// 
			// lblPortName
			// 
			this.lblPortName.AutoSize = true;
			this.lblPortName.Location = new System.Drawing.Point(240, 165);
			this.lblPortName.Name = "lblPortName";
			this.lblPortName.Size = new System.Drawing.Size(60, 13);
			this.lblPortName.TabIndex = 2;
			this.lblPortName.Text = "Port Name:";
			this.lblPortName.Click += new System.EventHandler(this.label1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblPortName);
			this.Controls.Add(this.txtPortName);
			this.Controls.Add(this.btnSend);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtPortName;
		private System.Windows.Forms.Label lblPortName;
	}
}

