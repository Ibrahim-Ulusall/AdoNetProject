namespace UI
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dataGridView1 = new DataGridView();
			panel1 = new Panel();
			panel2 = new Panel();
			button3 = new Button();
			button2 = new Button();
			DeleteButton = new Button();
			btnAdd = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.BackgroundColor = Color.White;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.GridColor = Color.White;
			dataGridView1.Location = new Point(71, 41);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(892, 541);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellClick += dataGridView1_CellClick;
			// 
			// panel1
			// 
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(963, 39);
			panel1.TabIndex = 1;
			// 
			// panel2
			// 
			panel2.Controls.Add(button3);
			panel2.Controls.Add(button2);
			panel2.Controls.Add(DeleteButton);
			panel2.Controls.Add(btnAdd);
			panel2.Dock = DockStyle.Left;
			panel2.Location = new Point(0, 39);
			panel2.Name = "panel2";
			panel2.Size = new Size(69, 542);
			panel2.TabIndex = 2;
			// 
			// button3
			// 
			button3.Location = new Point(12, 507);
			button3.Name = "button3";
			button3.Size = new Size(49, 23);
			button3.TabIndex = 3;
			button3.Text = "Exit";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.Location = new Point(12, 155);
			button2.Name = "button2";
			button2.Size = new Size(49, 23);
			button2.TabIndex = 2;
			button2.Text = "Upd";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// DeleteButton
			// 
			DeleteButton.Location = new Point(12, 109);
			DeleteButton.Name = "DeleteButton";
			DeleteButton.Size = new Size(49, 23);
			DeleteButton.TabIndex = 1;
			DeleteButton.Text = "Del";
			DeleteButton.UseVisualStyleBackColor = true;
			DeleteButton.Click += DeleteButton_Click;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(12, 63);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(49, 23);
			btnAdd.TabIndex = 0;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(963, 581);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(dataGridView1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridView1;
		private Panel panel1;
		private Panel panel2;
		private Button button3;
		private Button button2;
		private Button DeleteButton;
		private Button btnAdd;
	}
}