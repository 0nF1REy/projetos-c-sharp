using Gtk;

namespace GTKLogin
{
    public class LoginWindow : Window
    {
        private Entry usernameEntry;
        private Entry passwordEntry;

        public LoginWindow() : base("Favor, Por Gentileza, Realize o seu Login!")
        {
            // Configurações iniciais da janela
            SetDefaultSize(500, 50);
            SetPosition(WindowPosition.Center);
            DeleteEvent += delegate { Application.Quit(); };

            // Layout principal - Grid
            var grid = new Grid();
            grid.RowSpacing = 10;
            grid.ColumnSpacing = 10;

            // Criando widgets (labels e entries)
            var usernameLabel = new Label("Usuário:");
            usernameEntry = new Entry();
            var passwordLabel = new Label("Senha:");
            passwordEntry = new Entry { Visibility = false }; // Senha oculta
            var loginButton = new Button("Login");

            // Adicionando widgets ao grid
            grid.Attach(usernameLabel, 0, 0, 1, 1);
            grid.Attach(usernameEntry, 1, 0, 1, 1);
            grid.Attach(passwordLabel, 0, 1, 1, 1);
            grid.Attach(passwordEntry, 1, 1, 1, 1);
            grid.Attach(loginButton, 0, 2, 2, 1);

            // Conectando o evento do botão de login
            loginButton.Clicked += OnLoginButtonClicked;

            // Adicionando o grid à janela
            Add(grid);

            ShowAll();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Obtenção dos valores dos campos
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            // Verificando se o login é válido (aqui, apenas um exemplo simples)
            if (username == "admin" && password == "senha123")
            {
                MessageDialog md = new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Login bem-sucedido!");
                md.Run();
                md.Destroy();
            }
            else
            {
                MessageDialog md = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Usuário ou senha inválidos.");
                md.Run();
                md.Destroy();
            }
        }

        public static void Main()
        {
            Application.Init();
            new LoginWindow();
            Application.Run();
        }
    }
}
