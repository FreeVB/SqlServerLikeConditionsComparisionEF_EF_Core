using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkCoreLikeLibrary;
using EntityFrameworkCoreLikeLibrary.Models;
using LanguageExtensionsLibrary;
using LikeConditionsWithEntityFrameworkCore.Classes;

namespace LikeConditionsWithEntityFrameworkCore
{
    public partial class Form1 : Form
    {
        private BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            CompanyNameConditionsComboBox.Items.AddRange(Enum.GetNames(typeof(LikeOptions)));
            CompanyNameConditionsComboBox.SelectedIndex = 0;

            var ops = new EntityFrameworkCoreOperations();

            ContactTypeComboBox.DataSource = ops.ContactTypesList();
        }

        private void CompanyNameFindButton_Click(object sender, EventArgs e)
        {
            _bindingSource.DataSource = null;

            var nameCondition = CompanyNameConditionsComboBox.Text.ToEnum<LikeOptions>();
            var contactTypeCondition = ((ContactType) ContactTypeComboBox.SelectedItem).ContactTypeIdentifier;

            if (CompanyNameFindTextBox.Text.IsNullOrWhiteSpace() && contactTypeCondition == 0)
            {
                return;
            }

            var ops = new EntityFrameworkCoreOperations();
            
            var customerEntities = ops.GetCustomersLikeCustomerEntities(
                nameCondition, 
                CompanyNameFindTextBox.Text,
                contactTypeCondition);

            _bindingSource.DataSource = customerEntities;
            dataGridView1.DataSource = _bindingSource;
            dataGridView1.ExpandColumns();

            CurrentCustomerButton.Enabled = _bindingSource.Count > 0;

        }

        private void CurrentCustomerButton_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current != null)
            {
                var customer = (CustomerEntity) _bindingSource.Current;
                MessageBox.Show($"Customer id {customer.CustomerIdentifier}");
            }
        }
    }
}
