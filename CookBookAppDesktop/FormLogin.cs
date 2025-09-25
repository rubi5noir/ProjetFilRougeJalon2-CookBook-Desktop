using CookBookAppDesktop.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBookAppDesktop
{
    public partial class FormLogin : Form
    {
        const string URL_GET_LOGIN = "/api/Access/Login/";

        readonly RestClient _rest = new();

        public string JwtToken { get; private set; }

        public IEnumerable<string> _roles = [];


        public FormLogin()
        {
            InitializeComponent();
        }

        public static IEnumerable<string> GetRolesFromJwt(string token, string[] possibleClaimTypes = null)
        {
            possibleClaimTypes ??=
            [
                "http://schemas.microsoft.com/ws/2008/06/identity/claims/role",
                "role",
                "roles"
            ];

            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jwtToken = handler.ReadJwtToken(token);

                var roles = jwtToken.Claims
                    .Where(c => possibleClaimTypes.Contains(c.Type))
                    .Select(c => c.Value);

                return roles;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Erreur lors du décodage du JWT : {ex.Message}");
            }
        }

        public void ButtonLogInPerformClick()
        {
            buttonLogIn.PerformClick();
        }

        private async void ButtonLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginDTO loginDTO = new()
                {
                    Username = textBoxUsername.Text,
                    Password = textBoxMotDePasse.Text
                };

                _rest.BaseUrl = "http://localhost:5555";

                var res = await _rest.PostAsync<JwtDTO, LoginDTO>($"{URL_GET_LOGIN}", loginDTO);
                _rest.JwtToken = res.Token;
                _roles = GetRolesFromJwt(res.Token);

                JwtToken = res.Token;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
        }
    }
}
