namespace UI
{
	partial class UpdateForm
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
			UpdateButton = new Button();
			priceBox = new TextBox();
			stockBox = new TextBox();
			productNameBox = new TextBox();
			SuspendLayout();
			// 
			// UpdateButton
			// 
			UpdateButton.Location = new Point(20, 203);
			UpdateButton.Name = "UpdateButton";
			UpdateButton.Size = new Size(227, 23);
			UpdateButton.TabIndex = 7;
			UpdateButton.Text = "Update";
			UpdateButton.UseVisualStyleBackColor = true;
			UpdateButton.Click += UpdateButton_Click;
			// 
			// priceBox
			// 
			priceBox.Location = new Point(20, 155);
			priceBox.Name = "priceBox";
			priceBox.PlaceholderText = "Unit in Price";
			priceBox.Size = new Size(227, 23);
			priceBox.TabIndex = 6;
			// 
			// stockBox
			// 
			stockBox.Location = new Point(20, 103);
			stockBox.Name = "stockBox";
			stockBox.PlaceholderText = "Unit in Stock";
			stockBox.Size = new Size(227, 23);
			stockBox.TabIndex = 5;
			// 
			// productNameBox
			// 
			productNameBox.Location = new Point(20, 55);
			productNameBox.Name = "productNameBox";
			productNameBox.PlaceholderText = "Product Name";
			productNameBox.Size = new Size(227, 23);
			productNameBox.TabIndex = 4;
			// 
			// UpdateForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(266, 280);
			Controls.Add(UpdateButton);
			Controls.Add(priceBox);
			Controls.Add(stockBox);
			Controls.Add(productNameBox);
			Name = "UpdateForm";
			Text = "UpdateForm";
			Load += UpdateForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button UpdateButton;
		private TextBox priceBox;
		private TextBox stockBox;
		private TextBox productNameBox;
	}
}