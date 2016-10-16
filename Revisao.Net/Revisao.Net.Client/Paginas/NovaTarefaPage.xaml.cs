using Newtonsoft.Json;
using Revisao.Net.Client.Logic;
using Revisao.Net.Client.Model;
using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Revisao.Net.Client.Paginas
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NovaTarefaPage : Page
    {
        private Tarefa tarefa;
        public NovaTarefaPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            tarefa = e.Parameter as Tarefa;
            base.OnNavigatedTo(e);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (tarefa == null || tarefa.Id == 0)
            {
                txtCodigo.Visibility = Visibility.Collapsed;
                lblCodigo.Visibility = Visibility.Collapsed;
                var json = MyLocalStorage.GetFromLocalStorage("usuario");
                var dados = JsonConvert.DeserializeObject<Usuario>(json.ToString());

                txtUsuario.Text = dados.Login;
            }
            else
            {
                txtCodigo.Text = tarefa.Id.ToString();
                txtUsuario.Text = tarefa.Username;
                txtDescricao.Text = tarefa.Descricao;
                txtTitulo.Text = tarefa.Titulo;
                dptDataLimite.Date = tarefa.DataLimite;
                chkConcluido.IsChecked = tarefa.Concluido;
            }

            
           
        }
        private async void btnGravar_Click(object sender, RoutedEventArgs e)
        {
            tarefa = new Tarefa
            {
                Id = string.IsNullOrEmpty(txtCodigo.Text) ? 0 : Convert.ToInt32(txtCodigo.Text),
                Titulo = txtTitulo.Text,
                Descricao = txtDescricao.Text,
                Username = txtUsuario.Text,
                Concluido = chkConcluido.IsChecked.Value,
                DataLimite = dptDataLimite.Date.DateTime
            };

            try
            {
                if(tarefa.Id > 0)
                {
                    await TarefasRequestApi.AlterarTarefa(tarefa);
                    var dialog = new MessageDialog("Tarefa alterada.", "Sucesso");
                    await dialog.ShowAsync();

                    Frame.Navigate(typeof(TarefasPage));
                }
                else
                {
                    await TarefasRequestApi.GravarTarefa(tarefa);
                    txtCodigo.Text = "";
                    txtTitulo.Text = "";
                    txtDescricao.Text = "";
                    txtUsuario.Text = "";
                    chkConcluido.IsChecked = false;

                    var dialog = new MessageDialog("Tarefa criada.", "Sucesso");
                    await dialog.ShowAsync();

                    Frame.Navigate(typeof(TarefasPage));
                }

            }
            catch (Exception ex)
            {
                var msg = TratarException.ErrorMessage(ex);
                var dialog = new MessageDialog(msg, "Erro");
                await dialog.ShowAsync();
            }

        }

       
    }
}
