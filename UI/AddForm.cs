using Business.Validation;
using Core.CrossCuttingConcerns.Validation;
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
	public partial class AddForm : Form
	{
		public AddForm()
		{
			InitializeComponent();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			
			var result = Form1.serviceManager.Add(new Product
			{
				ProductName = productNameBox.Text,
				UnitInPrice = Convert.ToDecimal(priceBox.Text),
				UnitInStock = Convert.ToInt32(stockBox.Text)
			});
			if (result.Success)
				this.Close();

		}
	}
}
