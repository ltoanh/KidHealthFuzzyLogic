﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidHealthFuzzyLogic
{
    public partial class HomepageForm : Form
    {
        public HomepageForm()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            btnExecute.Enabled = false;
            try
            {
                Common.Age = Int32.Parse(txtAge.Text.Trim());
                Common.Gender = rbtnMale.Checked ? 0 : 1;

                if(Common.Age < 2 || Common.Age > 5)
                {
                    throw new Exception("Chương trình chỉ đáp ứng trẻ từ 2-5 tuổi");
                }

                SystemForm systemForm = new SystemForm();
                systemForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnExecute.Enabled = true;
        }
    }
}
