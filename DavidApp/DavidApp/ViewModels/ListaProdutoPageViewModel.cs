using DavidApp.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace DavidApp.ViewModels
{
    public class ListaProdutoPageViewModel : ViewModelBase
    {
        private DelegateCommand _navegaParaCadastroCommand;

        public ListaProdutoPageViewModel(INavigationService navigationService) :base(navigationService)
        {
            Produtos = new ObservableCollection<Produto>();
            _navegaParaCadastroCommand = new DelegateCommand(NavegarParaCadastro);
        }

        public DelegateCommand NavegarParaCadastroCommand => _navegaParaCadastroCommand;

        private ObservableCollection<Produto> _produtos;
        public ObservableCollection<Produto> Produtos
        {
            get { return _produtos; }
            set { SetProperty(ref _produtos, value); }
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Produtos.Clear();
            //var produtosDb = Database.Produtos;

            //foreach (var item in produtosDb)
            //{
            //    Produtos.Add(item);
            //}
        }

        private async void NavegarParaCadastro()
        {
            await NavigationService.NavigateAsync("CadastroProdutoPage");
        }

    }
}
