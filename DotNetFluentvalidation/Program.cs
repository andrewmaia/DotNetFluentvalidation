using DotNetFluentvalidation;
using FluentValidation.Results;

Cliente cliente = new Cliente();
ClienteValidator validator= new ClienteValidator();
ValidationResult  result = validator.Validate(cliente); 

if(!result.IsValid)
{
    foreach (var erro in result.Errors)
        Console.WriteLine($"Erro na propriedade {erro.PropertyName}:{erro.ErrorMessage}");
}