namespace Exec2_Star
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.lblRows = new System.Windows.Forms.Label();
			this.btmLeft = new System.Windows.Forms.Button();
			this.txtRows = new System.Windows.Forms.TextBox();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.btmMiddle = new System.Windows.Forms.Button();
			this.btmRight = new System.Windows.Forms.Button();
			this.lblInfo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblRows
			// 
			this.lblRows.AutoSize = true;
			this.lblRows.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblRows.Location = new System.Drawing.Point(20, 46);
			this.lblRows.Name = "lblRows";
			this.lblRows.Size = new System.Drawing.Size(43, 18);
			this.lblRows.TabIndex = 0;
			this.lblRows.Text = "列數 :";
			// 
			// btmLeft
			// 
			this.btmLeft.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btmLeft.Location = new System.Drawing.Point(246, 44);
			this.btmLeft.Name = "btmLeft";
			this.btmLeft.Size = new System.Drawing.Size(75, 32);
			this.btmLeft.TabIndex = 1;
			this.btmLeft.Text = "靠左對齊";
			this.btmLeft.UseVisualStyleBackColor = true;
			this.btmLeft.Click += new System.EventHandler(this.btmLeft_Click);
			// 
			// txtRows
			// 
			this.txtRows.Location = new System.Drawing.Point(66, 44);
			this.txtRows.Name = "txtRows";
			this.txtRows.Size = new System.Drawing.Size(157, 22);
			this.txtRows.TabIndex = 2;
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(24, 81);
			this.txtResult.MaxLength = 2;
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(199, 149);
			this.txtResult.TabIndex = 3;
			this.txtResult.WordWrap = false;
			// 
			// btmMiddle
			// 
			this.btmMiddle.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btmMiddle.Location = new System.Drawing.Point(246, 105);
			this.btmMiddle.Name = "btmMiddle";
			this.btmMiddle.Size = new System.Drawing.Size(75, 32);
			this.btmMiddle.TabIndex = 4;
			this.btmMiddle.Text = "等腰";
			this.btmMiddle.UseVisualStyleBackColor = true;
			this.btmMiddle.Click += new System.EventHandler(this.btmMiddle_Click);
			// 
			// btmRight
			// 
			this.btmRight.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btmRight.Location = new System.Drawing.Point(246, 166);
			this.btmRight.Name = "btmRight";
			this.btmRight.Size = new System.Drawing.Size(75, 32);
			this.btmRight.TabIndex = 5;
			this.btmRight.Text = "靠右對齊";
			this.btmRight.UseVisualStyleBackColor = true;
			this.btmRight.Click += new System.EventHandler(this.btmRight_Click);
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblInfo.Location = new System.Drawing.Point(21, 15);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(208, 17);
			this.lblInfo.TabIndex = 6;
			this.lblInfo.Text = "輸入列數(1~10)，並選擇排列方式";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 242);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.btmRight);
			this.Controls.Add(this.btmMiddle);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.txtRows);
			this.Controls.Add(this.btmLeft);
			this.Controls.Add(this.lblRows);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "星星塔生成器";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblRows;
		private System.Windows.Forms.Button btmLeft;
		private System.Windows.Forms.TextBox txtRows;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.Button btmMiddle;
		private System.Windows.Forms.Button btmRight;
		private System.Windows.Forms.Label lblInfo;
	}
}

