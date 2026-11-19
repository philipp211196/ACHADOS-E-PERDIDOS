using AchadosPerdidos.Data;
using AchadosPerdidos.UI;

namespace AchadosPerdidos;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        try
        {
            Database.Initialize();
            Application.Run(new LoginForm());
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Não foi possível iniciar o sistema. Verifique o MySQL e a configuração de acesso.\n\n" + ex.Message,
                "Achados e Perdidos — Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
