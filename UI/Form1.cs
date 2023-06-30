using Business.Concrete;
using DataAccess.Concrete.AdoNet;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace UI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public static ProductServiceManager serviceManager = new ProductServiceManager(new EfProductDal());

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		private void LoadData()
		{
			dataGridView1.DataSource = serviceManager.GetAll().Data;
		}
		private void button3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			AddForm add = new AddForm();
			add.ShowDialog();
			LoadData();
		}
		UpdateForm updateForm = new UpdateForm();
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			updateForm.productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			updateForm.productName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			updateForm.unitInStock = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
			updateForm.unitInPrice = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			updateForm.ShowDialog();
			LoadData();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			var result = serviceManager.Delete(new Product
			{
				Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
				ProductName = dataGridView1.CurrentRow.Cells[1].Value.ToString(),
				UnitInStock = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value),
				UnitInPrice = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value)
			});
			if(result.Success)
				MessageBox.Show(result.Message);
			LoadData();
		}
	}
}