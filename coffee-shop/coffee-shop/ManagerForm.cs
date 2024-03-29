﻿using coffee_shop_test.Components;
using Repository.Models;
using Repository.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_shop_test
{
    public partial class ManagerForm : Form
    {
        CategoryService _categoryService = new CategoryService();
        ItemService _itemService = new ItemService();
        public int userID = 0;
        public ManagerForm()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public void AddControls(Form form)
        {
            ControlsPanel.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            ControlsPanel.Controls.Add(form);
            form.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            PosForm posForm = new PosForm();
            AddControls(posForm);
            posForm.userID = userID;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Form categoryForm = new CategoryManagementForm();
            AddControls(categoryForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form loginForm = new Login();
            loginForm.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Form itemForm = new ItemManagementForm();
            AddControls(itemForm);
        }
    }
}
