using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFluentvalidation
{
    public class Cliente
    {
        public Cliente()
        {
            Endereco = "Meu Endereço";
            TipoCliente = (TipoCliente)3;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Desconto { get; set; }
        public string Endereco { get; set; }

        public TipoCliente TipoCliente { get; set; }
    }

    public enum TipoCliente
    {
        PessoaFisica = 1,
        PessoaJuridica = 2
    }

    public class ClienteValidator : AbstractValidator<Cliente>
    { 
        public ClienteValidator()
        {
            RuleFor(customer => customer.Nome).NotNull();
            RuleFor (customer => customer.Endereco).NotEqual("Meu Endereço").WithMessage("Ei este endereço não pode ser utilizado!");
            RuleFor(x => x.TipoCliente).IsInEnum();
            RuleFor(x => x.Id).Must(id =>
            {
                return id == 1;
            });
        }
    }
}
