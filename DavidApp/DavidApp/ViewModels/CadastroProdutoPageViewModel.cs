using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using DavidApp.Models;
using DavidApp.Data;

namespace DavidApp.ViewModels
{
    public class CadastroProdutoPageViewModel : ViewModelBase, IInitialize
    {
        private DelegateCommand _saveCommand;

        public CadastroProdutoPageViewModel(INavigationService navigationService) :base(navigationService)
        {
            _saveCommand = new DelegateCommand(OnSave);
        }

        public void Initialize(INavigationParameters parameters)
        {
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { SetProperty(ref nome, value); }
        }

        private string descricao;
        public string Descricao
        {
            get { return nome; }
            set { SetProperty(ref descricao, value); }
        }

        private int quantidade;
        public int Quantidade
        {
            get { return quantidade; }
            set { SetProperty(ref quantidade, value); }
        }

        // => get
        public DelegateCommand SaveCommand => _saveCommand;
      
        private async void OnSave()
        {
            var produto = new Produto();
            produto.Id = 1;
            produto.Nome = Nome;
            produto.Quantidade = Quantidade;
            produto.Descricao = Descricao;
           
            Database.Produtos.Add(produto); ///Produto foi salvo em memória.

           await NavigationService.GoBackAsync();
        }
    }
}
