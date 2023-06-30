using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
	public partial class UpdateForm : Form
	{
		public UpdateForm()
		{
			InitializeComponent();
		}
		public int productId;
		public string productName;
		public int unitInStock;
		public decimal unitInPrice;

		private void UpdateButton_Click(object sender, EventArgs e)
		{
			var result = Form1.serviceManager.Update(new Product
			{
				Id = productId,
				ProductName = productNameBox.Text,
				UnitInStock = Convert.ToInt32(stockBox.Text),
				UnitInPrice = Convert.ToDecimal(priceBox.Text),
			});
			if (result.Success)
				MessageBox.Show(result.Message);
		}

		private void UpdateForm_Load(object sender, EventArgs e)
		{
			productNameBox.Text = productName;
			stockBox.Text = unitInStock.ToString();
			priceBox.Text = unitInPrice.ToString();
		}
	}
}
