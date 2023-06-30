using Business.Concrete;
using DataAccess.Concrete.AdoNet;
using DataAccess.Concrete.EntityFramework;

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
	}
}