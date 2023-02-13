using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void SearchProducts(string key)
        {
            //retrieves data from list
            //dgwProducts.DataSource = _productDal.GetAll().Where(p => p.Name.ToLower().Contains(key.ToLower())).ToList();
            //retrieves data from directly database
            var result = _productDal.GetByName(key);
            dgwProducts.DataSource = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();

        }

        
       




        






        private void SearchProductsByUnitPrice(string key)
        {
            decimal price;
            bool valid = decimal.TryParse(key, out price);

            if (valid)
            {
                var result = _productDal.GetByUnitPrice(price);
                dgwProducts.DataSource = result;

            }
            else
            {
                LoadProducts();
            }

        }


        private void SearchProductsById(string key)
        {
            int id;
            bool valid = int.TryParse(key, out id);

            if (valid)
            {
                var result = _productDal.GetById(id);
                List<Product> result2 = new List<Product> { result };
                dgwProducts.DataSource = result2;

            }
            else
            {
                LoadProducts();
            }

        }





        

        

        private void btnGetByUnitPrice_Click(object sender, EventArgs e)
        {
            decimal minPrice;
            decimal maxPrice;
            bool valid = decimal.TryParse(tbxMin.Text, out minPrice);
            bool valid2 = decimal.TryParse(tbxMax.Text, out maxPrice);
            if (valid && valid2)
            {

                var result = _productDal.GetByUnitPrice(minPrice, maxPrice);

                dgwProducts.DataSource = result;
            }
            else
            {
                LoadProducts();
            }
        }

        private void tbxGetById_TextChanged(object sender, EventArgs e)
        {
            SearchProductsById(tbxGetById.Text);
        }

        private void tbxGetByUnitPrice_TextChanged(object sender, EventArgs e)
        {
            SearchProductsByUnitPrice(tbxGetByUnitPrice.Text);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {

                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Deleted");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text),
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),

            });

            LoadProducts();
            MessageBox.Show("Updated");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {

                Name = tbxName.Text,
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text)
            });

            LoadProducts();
            MessageBox.Show("Added!");
        }

    }
}
