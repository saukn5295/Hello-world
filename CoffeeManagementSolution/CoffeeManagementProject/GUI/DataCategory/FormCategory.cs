using CoffeeManagementProject.BLL;
using CoffeeManagementProject.DAL.Enity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagementProject.GUI.DataCategory
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
            gridData.AutoGenerateColumns = false;
            LoadCategory();
        }
        /// <summary>
        /// deplay active in LoadCategory()
        /// </summary>
        void LoadCategory()
        {
           var ls = BLL.BLLCategory.GetList();
            bsData.DataSource = ls;
            gridData.DataSource = bsData;
            
        }
    }
}
