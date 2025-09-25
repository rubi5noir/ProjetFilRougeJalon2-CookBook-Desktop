using CookBookAppDesktop.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBookAppDesktop
{
    public partial class FormManageEtapes : Form
    {
        private const string URL_GET_ETAPES = "api/Etapes";

        readonly RestClient _rest = new();
        BindingList<EtapeDTO> _etapes;

        public FormManageEtapes()
        {
            InitializeComponent();
            InitializeBinding();
        }

        #region Methods

        private void InitializeBinding()
        {
            _etapes = new();
            bindingSourceEtapes.DataSource = _etapes;
            dataGridViewEtapes.DataSource = bindingSourceEtapes;
        }

        private async Task RefreshEtapes()
        {
            EtapeDTO current = bindingSourceEtapes.Current as EtapeDTO;

            // Remplissage de la liste
            var res = await _rest.GetAsync<IEnumerable<EtapeDTO>>(URL_GET_ETAPES);

            _etapes.Clear();
            foreach (EtapeDTO e in res)
            {
                _etapes.Add(e);
            }

            // On se repositionne sur le current
            if (current is not null)
                bindingSourceEtapes.Position = _etapes.IndexOf(_etapes.Where(e => e.numero == current.numero).FirstOrDefault());
        }

        #endregion

        #region Events

        private async void FormManageEtapes_Load(object sender, EventArgs e)
        {
            await RefreshEtapes();
        }

        #endregion
    }
}
