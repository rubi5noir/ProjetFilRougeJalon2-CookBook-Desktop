using CookBookAppDesktop.Models.DTO;
using CookBookAppDesktop.Properties;
using System.Data;
using System.IdentityModel.Tokens.Jwt;

namespace CookBookAppDesktop
{
    public partial class FormLogin : Form
    {
        const string URL_GET_LOGIN = "/api/Access/Login/";

        readonly RestClient _rest = new();

        public string JwtToken { get; private set; }

#pragma warning disable S1104 // Fields should not have public accessibility
        public IEnumerable<string> _roles = [];
#pragma warning restore S1104 // Fields should not have public accessibility


#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public FormLogin()
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        {
            InitializeComponent();
        }

#pragma warning disable CS8625 // Impossible de convertir un littéral ayant une valeur null en type référence non-nullable.
        public static IEnumerable<string> GetRolesFromJwt(string token, string[] possibleClaimTypes = null)
#pragma warning restore CS8625 // Impossible de convertir un littéral ayant une valeur null en type référence non-nullable.
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

                _rest.BaseUrl = Settings.Default.BaseUrl;

                var res = await _rest.PostAsync<JwtDTO, LoginDTO>($"{URL_GET_LOGIN}", loginDTO);
                _rest.JwtToken = res.Token;
                _roles = GetRolesFromJwt(res.Token);

                JwtToken = res.Token;
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }




    }
}
