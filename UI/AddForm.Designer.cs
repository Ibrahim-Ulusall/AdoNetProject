namespace UI
{
	partial class AddForm
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
			productNameBox = new TextBox();
			stockBox = new TextBox();
			priceBox = new TextBox();
			AddButton = new Button();
			SuspendLayout();
			// 
			// productNameBox
			// 
			productNameBox.Location = new Point(12, 47);
			productNameBox.Name = "productNameBox";
			productNameBox.PlaceholderText = "Product Name";
			productNameBox.Size = new Size(227, 23);
			productNameBox.TabIndex = 0;
			// 
			// stockBox
			// 
			stockBox.Location = new Point(12, 95);
			stockBox.Name = "stockBox";
			stockBox.PlaceholderText = "Unit in Stock";
			stockBox.Size = new Size(227, 23);
			stockBox.TabIndex = 1;
			// 
			// priceBox
			// 
			priceBox.Location = new Point(12, 147);
			priceBox.Name = "priceBox";
			priceBox.PlaceholderText = "Unit in Price";
			priceBox.Size = new Size(227, 23);
			priceBox.TabIndex = 2;
			// 
			// AddButton
			// 
			AddButton.Location = new Point(12, 195);
			AddButton.Name = "AddButton";
			AddButton.Size = new Size(227, 23);
			AddButton.TabIndex = 3;
			AddButton.Text = "Add";
			AddButton.UseVisualStyleBackColor = true;
			AddButton.Click += AddButton_Click;
			// 
			// AddForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(251, 245);
			Controls.Add(AddButton);
			Controls.Add(priceBox);
			Controls.Add(stockBox);
			Controls.Add(productNameBox);
			Name = "AddForm";
			Text = "AddForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox productNameBox;
		private TextBox stockBox;
		private TextBox priceBox;
		private Button AddButton;
	}
}