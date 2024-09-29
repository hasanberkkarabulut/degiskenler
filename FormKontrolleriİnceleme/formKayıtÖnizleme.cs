using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormKontrolleriİnceleme
{
    public partial class formKayıtÖnizleme : Form
    {
        public formKayıtÖnizleme()
        {
            InitializeComponent();
        }

        private void formKayıtÖnizleme_Load(object sender, EventArgs e)
        {
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {

            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "Form1")
                {
                    foreach (Control FormItem in item.Controls)
                    {
                        if (FormItem is TextBox)
                        {
                            ((TextBox)FormItem).Text = string.Empty;
                        }
                    }
                }
            }

            this.Close();
        }
    }
}
