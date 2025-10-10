using CookBookAppDesktop.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBookAppDesktop
{
    public partial class FormRecetteDetails : Form
    {
        private int idRecette;

        public FormRecetteDetails(int id)
        {
            idRecette = id;
            InitializeComponent();

        }

        #region Methods



        #endregion

        #region Events

        private async void FormRecetteDetails_FormLoad(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
