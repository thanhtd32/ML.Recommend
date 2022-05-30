# ML.Recommend

We inherit and expand the machine learning library of Microsoft ML.NET, and proceed to build a new recommendation model with named ML.Recommend, which will use Matrix Factorization and combine Time Factor for Product Recommendation. The system will provide a complete machine learning model with a set of interactive classes libraries, data and class models are conducted on user reviews for each product with time interaction and the system will recommend products respectively based on the expected score to customers that user configured. The data is experimented on the UELStore e-commerce website (http://ecom.uelstore.com/), the trained models are provided for other researchers to use together with the source code of the ML.Recommend model published by us, the researchers can reuse and expand the features for this model.

Mapping JSon Dataset with Model class (https://github.com/thanhtd32/ML.Recommend/tree/main/Dataset):
|# | Dataset | Model class |Description| Number of object| 
|:---:|:---:|:---:|:---:| :---:| 
|1 | customers.json | Customer | List of Customer dataset|678|
|2 | products.json | Product | List of Product dataset|732|
|3 | ratings.json | Rating | List of Rating dataset|130754|



This Research from KMOU (Korea Maritime & Ocean University) - Data Science Lab - Room 407.

Authors: Duy Thanh Tran, Prof. Jun-Ho Huh

Any question, please free to contact me: thanhtd@uel.edu.vn

My full name: TRAN DUY THANH

Blog study coding: https://duythanhcse.wordpress.com/

# ML.Recommend - model class

![alt text](https://raw.githubusercontent.com/thanhtd32/ML.Recommend/main/images/model-class.png)

RecommendEngine is a center class of the ML.Recommend

GUI Demo:

Test ML.Recommend model

![alt text](https://raw.githubusercontent.com/thanhtd32/ML.Recommend/main/images/ml.recommend.png)

Test recommendation products for customers:

![alt text](https://raw.githubusercontent.com/thanhtd32/ML.Recommend/main/images/ml.recommend_advanced.png)

# ML.Recommend - How to use?

# Install nuget package

```C#
Install-Package ML.Recommend -ProjectName YourProject
```
Full dataset : https://github.com/thanhtd32/ML.Recommend/tree/main/Dataset

Full source code demo in Windows Desktop https://github.com/thanhtd32/ML.Recommend/tree/main/ML.RecommendDemo

Full source code demo in Web .net core https://github.com/thanhtd32/ML.Recommend/tree/main/ML.RecommendWeb


# Windows Desktop demo

```
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
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ML.RecommendDemo
{
    public partial class frmDemoRecommend : Form
    {
        List<Rating> ratings;
        RecommendEngine engine= new RecommendEngine();
        string folder = "Models";
        List<Customer> customers;
        List<Product> products;
        public frmDemoRecommend()
        {
            InitializeComponent();
        }

        private void frmDemoRecommend_Load(object sender, EventArgs e)
        {
            LoadModelIntoCombo();
        }

        private void btnLoadCustomer_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                customers= DataUtils.LoadCustomers(openFileDialog1.FileName);
                cboCustomer.DataSource = customers;
                cboCustomer.ValueMember = "Id";
                cboCustomer.DisplayMember = "NickName";
            }
        }

        private void btnLoadProduct_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                string jsonString = File.ReadAllText(fileName);
                products = JsonSerializer.Deserialize<List<Product>>(jsonString)!;
                cboProduct.DataSource = products;
                cboProduct.ValueMember = "Id";
                cboProduct.DisplayMember = "Name";
            }
            
        }

        private void btnLoadRating_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ratings=DataUtils.LoadRatings(openFileDialog1.FileName,dtpFrom.Value,dtpTo.Value);
                MessageBox.Show("Import ratings dataset is successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmRating frm= new frmRating();
                frm.gvRating.DataSource = ratings;
                frm.lblToTal.Text ="There are "+ ratings.Count + " ratings!";
                frm.Show();
            }
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {
            if (rad1.Checked)
                txtTestRatio.Text = rad1.Text;
        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {
            if (rad2.Checked)
                txtTestRatio.Text = rad2.Text;
        }

        private void rad3_CheckedChanged(object sender, EventArgs e)
        {
            if (rad3.Checked)
                txtTestRatio.Text = rad3.Text;
        }

        private void rad4_CheckedChanged(object sender, EventArgs e)
        {
            if (rad4.Checked)
                txtTestRatio.Text = rad4.Text;
        }

        private void rad5_CheckedChanged(object sender, EventArgs e)
        {
            if (rad5.Checked)
                txtTestRatio.Text = rad5.Text;
        }

        private void btnImportDataset_Click(object sender, EventArgs e)
        {
            try
            {
                double testRatio = double.Parse(txtTestRatio.Text);
                bool ret= engine.ImportAndSplitDataset(ratings, testRatio);
                if (ret)
                {
                    lblImportDatasetMessage.Text = "Import && split dataset for train and test set sucessful!";
                }
            }
            catch(RecommendError ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnBuildModel_Click(object sender, EventArgs e)
        {
            try
            {
                int iterator=int.Parse(txtIterator.Text);
                int approximationRank = int.Parse(txtRank.Text);
                bool ret = engine.BuildModel(iterator, approximationRank);
                if (ret)
                {
                    lblBuildModelMessage.Text = "Build model sucessful!";
                }
            }
            catch (RecommendError ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEvaluateModel_Click(object sender, EventArgs e)
        {
            try
            {
                Metric metric = engine.Evaluate();
                txtMAE.Text=Math.Round(metric.MAE,2).ToString();
                txtMSE.Text= Math.Round(metric.MSE, 2).ToString();
                txtRMSE.Text= Math.Round(metric.RMSE, 2).ToString();    
                txtSquared.Text= Math.Round(metric.RSquared, 2).ToString();
            }
            catch (RecommendError ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveModel_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(folder) == false)
                {
                    Directory.CreateDirectory(folder);
                }
                string path = folder + "\\ML.Recommend-" + DateTime.Now.ToString("ddMMyyyy-hhmmss") + ".zip";
                bool ret = engine.SaveModel(path);
                if (ret)
                    lblSaveModelMessage.Text = "Save Model successfully";
                else
                    lblSaveModelMessage.Text = "Save Model failed";
                LoadModelIntoCombo();
            }
            catch (RecommendError ex)
            {
                MessageBox.Show(ex.Message);
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

        private void btnPredict_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = cboCustomer.SelectedItem as Customer;
                Product product = cboProduct.SelectedItem as Product;

                var testInput = new Rating { CustomerID = customer.Id, ProductID = product.Id };

                var output = engine.Predict(testInput);

                double expectedScore=double.Parse(txtExpectedScore.Text);   

                if (Math.Round(output.Score, 1) >= expectedScore)
                {
                    lblResult.Text = "Score=" + Math.Round(output.Score, 1) + ", Product [" + product.Id+"-"+product.Name+"]" + " is recommended for user [" + customer.Id+" - "+customer.NickName+"]";
                }
                else
                {
                    lblResult.Text = "Score=" + Math.Round(output.Score, 1) + ", Product [" + product.Id + "-" + product.Name + "]" + " is not recommended for user [" + customer.Id + " - " + customer.NickName + "]";
                }
            }
            catch (RecommendError ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLoadModel_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboModel.SelectedIndex == -1)
                return;
                string modelName = folder + "\\" + cboModel.Text;
                bool ret = engine.LoadModel(modelName);
                if (ret)
                    lblLoadModelMessage.Text = "Load Model successfully";
                else
                    lblLoadModelMessage.Text = "Load Model failed";
            }
            catch (RecommendError ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            frmAdvanced frm = new frmAdvanced();
            frm.customers = customers;
            frm.products = products;
            frm.Show();
        }
    }
}
```

# Web .net core Demo

Web Project structure:

![alt text](https://github.com/thanhtd32/ML.Recommend/blob/main/images/web-project.PNG)

in this web project, We use ML.Recommend-1.zip to test

Web list of customers:

![alt text](https://raw.githubusercontent.com/thanhtd32/ML.Recommend/main/images/web-list-customer.png)

Web recommendation products for customers:

![alt text](https://raw.githubusercontent.com/thanhtd32/ML.Recommend/main/images/web-recommendation-products.png)


# CustomerController.cs

```
using Microsoft.AspNetCore.Mvc;
using ML.Recommend.Data;
using ML.Recommend.Predict;
using System.Text.Json;

namespace ML.RecommendWeb.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CustomerController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            string webRootPath = _webHostEnvironment.WebRootPath;
            string contentRootPath = _webHostEnvironment.ContentRootPath;
            string path = "";
            path = Path.Combine(contentRootPath, "Dataset");
            string customerFile= Path.Combine(path,"customers.json");
            string jsonString = System.IO.File.ReadAllText(customerFile);
            List<Customer> customers = JsonSerializer.Deserialize<List<Customer>>(jsonString)!;
            return View(customers);
        }
        public IActionResult Recommends(int id)
        {
            RecommendEngine engine = new RecommendEngine();
            string webRootPath = _webHostEnvironment.WebRootPath;
            string contentRootPath = _webHostEnvironment.ContentRootPath;
            string path = "";
            path = Path.Combine(contentRootPath, "Models");
            string modelPath= Path.Combine(path, "ML.Recommend-1.zip");
            engine.LoadModel(modelPath);
            
            path = "";
            path = Path.Combine(contentRootPath, "Dataset");
            string customerFile = Path.Combine(path, "customers.json");
            string jsonString = System.IO.File.ReadAllText(customerFile);
            List<Customer> customers = JsonSerializer.Deserialize<List<Customer>>(jsonString)!;
            Customer customer = customers.FirstOrDefault(c => c.Id == id);

            path = "";
            path = Path.Combine(contentRootPath, "Dataset");
            string productFile = Path.Combine(path, "products.json");
            jsonString = System.IO.File.ReadAllText(productFile);
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(jsonString)!;
            
            float es = 3.5f;
            List<Product> rProducts = engine.Predict(customer, products,es);
            ViewData["customer"] = customer;
            return View(rProducts);
        }
    }
}

```

# Views/Customer/Index.cshtml

```
@model IEnumerable<ML.Recommend.Data.Customer>

@{
    ViewData["Title"] = "Index";
}
<p>
    List of Customers:
</p>
<table class="table">
    <thead>
        <tr>
            <th>
                @Html.DisplayNameFor(model => model.Id)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.NickName)
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
@foreach (var item in Model) {
        <tr>
            <td>
                @Html.DisplayFor(modelItem => item.Id)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.NickName)
            </td>
            <td>
                |@Html.ActionLink("Recommendation", "Recommends", new { id=item.Id }) |                
            </td>
        </tr>
}
    </tbody>
</table>

```


# Views/Customer/Recommends.cshtml

```
@using ML.Recommend.Data
@model IEnumerable<ML.Recommend.Data.Product>

@{
    ViewData["Title"] = "Recommends";
}
@{
    Customer customer =(Customer) ViewData["customer"];
}

<p>
    List Recommended Products for Customer: <font color='blue'>@Html.Raw(customer .Id +" -"+customer .NickName) </font> 
</p>
<table class="table">
    <thead>
        <tr>
            <th>
                @Html.DisplayNameFor(model => model.Id)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.Name)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.UnitPrice)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.Score)
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
@foreach (var item in Model) {
        <tr>
            <td>
                @Html.DisplayFor(modelItem => item.Id)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Name)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.UnitPrice)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Score)
            </td>
            <td>
              
            </td>
        </tr>
}
    </tbody>
</table>

```
