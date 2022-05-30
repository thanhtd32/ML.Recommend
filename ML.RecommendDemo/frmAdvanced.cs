using ML.Recommend.Data;
using ML.Recommend.Error;
using ML.Recommend.Predict;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ML.RecommendDemo
{
    public partial class frmAdvanced : Form
    {
        RecommendEngine engine = new RecommendEngine();
        string folder = "Models";
        public List<Customer> customers;
        public List<Product> products;
        public frmAdvanced()
        {
            InitializeComponent();
        }

        private void frmAdvanced_Load(object sender, EventArgs e)
        {
            LoadModelIntoCombo();
            LoadCustomerOnListView();
        }
        private void LoadCustomerOnListView()
        {
            lvCustomer.Items.Clear();
            for(int i=0;i<customers.Count;i++)
            {
                ListViewItem lvi = new ListViewItem((i + 1) + "");
                lvi.SubItems.Add(customers[i].Id + "");
                lvi.SubItems.Add(customers[i].NickName+ "");
                lvi.Tag = customers[i];
                lvCustomer.Items.Add(lvi);
            }
        }

        private void LoadModelIntoCombo()
        {
            cboModel.Items.Clear();

            if (Directory.Exists(folder) == false)
            {
                return;
            }
            string[] files = Directory.GetFiles(folder);
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                cboModel.Items.Add(fi.Name);
            }
        }

        private void cboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                if (cboModel.SelectedIndex == -1)
                    return;
                string modelName = folder + "\\" + cboModel.Text;
                engine.LoadModel(modelName);                
            }
            catch (RecommendError ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void lvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCustomer.SelectedItems.Count == 0) return;
            Customer customer = lvCustomer.SelectedItems[0].Tag as Customer;
            List<Product> rProducts = engine.Predict(customer, products);
            double es=double.Parse(txtExpectedScore.Text);
            List<Product> rProducts1 = rProducts.Where(x => x.Score >= es).ToList();
            showProductOnListView(rProducts1, lvProduct);
            List<Product> rProducts2 = rProducts.Where(x => (x.Score < es || float.IsNaN(x.Score))).ToList();
            showProductOnListView(rProducts2, lvNotRecommendProducts);
        }
        void showProductOnListView(List<Product> rProducts, ListView lvData)
        {
            lvData.Items.Clear();
            int i = 1;
            foreach (Product p in rProducts)
            {
                ListViewItem lvi=new ListViewItem(i+"");
                i++;
                lvi.SubItems.Add(p.Id + "");
                lvi.SubItems.Add(p.Name);
                double score = Math.Min(p.Score, 5);
                lvi.SubItems.Add(Math.Round(p.Score,2)+"");
                lvData.Items.Add(lvi);
            }
        }
    }
}
