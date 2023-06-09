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
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Desconto { get; set; }
        public string Endereco { get; set; }
    }

    public class ClienteValidator : AbstractValidator<Cliente>
    { 
        public ClienteValidator()
        {
            RuleFor(customer => customer.Nome).NotNull();
            RuleFor (customer => customer.Endereco).NotEqual("Meu Endereço").WithMessage("Ei este endereço não pode ser utilizado!"); ;
        }
    }
}
