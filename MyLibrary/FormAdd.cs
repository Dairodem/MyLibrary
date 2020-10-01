using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class FormAdd : Form
    {
        public string Selection = "";
        string[] selectArr = new string[] {"Boek","Auteur","Genre","Uitgeverij" };
        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            cbxAddList.Items.AddRange(selectArr);
            cbxAddList.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Selection = cbxAddList.SelectedItem.ToString();

            DialogResult = DialogResult.OK;
        }
    }
}
