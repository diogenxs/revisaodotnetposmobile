using Revisao.Net.Client.Logic;
using Revisao.Net.Client.Model;
using System;
using System.Collections.Generic;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Revisao.Net.Client.Paginas
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TarefasPage : Page
    {

        private List<Tarefa> lista;
        public TarefasPage()
        {
            this.InitializeComponent();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var token = MyLocalStorage.GetFromLocalStorage("token");

                lista = await TarefasRequestApi.ListarTarefas(token.ToString());

                lstDados.ItemsSource = lista;
            }
            catch (Exception ex)
            {
                var dialog = new MessageDialog(TratarException.ErrorMessage(ex));

                await dialog.ShowAsync();
            }
        }

        private void lstDados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listbox = sender as ListBox;

            var tarefa = listbox.SelectedItem as Tarefa;

            Frame.Navigate(typeof(NovaTarefaPage), tarefa);
        }
    }
}
