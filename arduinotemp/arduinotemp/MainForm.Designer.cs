/*
 * Created by SharpDevelop.
 * User: Z9TOWNERDEVELOPER
 * Date: 02.05.2025
 * Time: 15:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace arduinotemp
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxPorts = new System.Windows.Forms.ComboBox();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxTemp = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxHumid = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxLight = new System.Windows.Forms.TextBox();
			this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(195, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(403, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Arduino Sensor Monitor";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "COM port:";
			// 
			// comboBoxPorts
			// 
			this.comboBoxPorts.FormattingEnabled = true;
			this.comboBoxPorts.Location = new System.Drawing.Point(109, 92);
			this.comboBoxPorts.Name = "comboBoxPorts";
			this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);
			this.comboBoxPorts.TabIndex = 2;
			// 
			// buttonConnect
			// 
			this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonConnect.Location = new System.Drawing.Point(248, 92);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(138, 23);
			this.buttonConnect.TabIndex = 3;
			this.buttonConnect.Text = "Connect";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Temperature:";
			// 
			// textBoxTemp
			// 
			this.textBoxTemp.Location = new System.Drawing.Point(134, 155);
			this.textBoxTemp.Name = "textBoxTemp";
			this.textBoxTemp.Size = new System.Drawing.Size(136, 20);
			this.textBoxTemp.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 195);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Humidity:";
			// 
			// textBoxHumid
			// 
			this.textBoxHumid.Location = new System.Drawing.Point(109, 195);
			this.textBoxHumid.Name = "textBoxHumid";
			this.textBoxHumid.Size = new System.Drawing.Size(161, 20);
			this.textBoxHumid.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 238);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Light:";
			// 
			// textBoxLight
			// 
			this.textBoxLight.Location = new System.Drawing.Point(76, 238);
			this.textBoxLight.Name = "textBoxLight";
			this.textBoxLight.Size = new System.Drawing.Size(194, 20);
			this.textBoxLight.TabIndex = 9;
			// 
			// richTextBoxLog
			// 
			this.richTextBoxLog.Location = new System.Drawing.Point(12, 311);
			this.richTextBoxLog.Name = "richTextBoxLog";
			this.richTextBoxLog.Size = new System.Drawing.Size(757, 181);
			this.richTextBoxLog.TabIndex = 10;
			this.richTextBoxLog.Text = "";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(12, 277);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(240, 31);
			this.label6.TabIndex = 11;
			this.label6.Text = "Arduino Log";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(781, 504);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.richTextBoxLog);
			this.Controls.Add(this.textBoxLight);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxHumid);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxTemp);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonConnect);
			this.Controls.Add(this.comboBoxPorts);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "arduinotemp";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox richTextBoxLog;
		private System.Windows.Forms.TextBox textBoxLight;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxHumid;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxTemp;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.ComboBox comboBoxPorts;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
