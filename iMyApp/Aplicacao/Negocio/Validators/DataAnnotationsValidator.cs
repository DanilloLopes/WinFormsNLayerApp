using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Validators
{
    public static partial class Validacoes
    {
        ///<summary>
        ///Valida as DataAnotattions de uma classe.
        /// <exemplo>Exemplo:
        /// <code>
        ///     var erros = Validacao.getValidationErros(obj);
        ///     forech (var error in erros)
        ///     {
        ///         MessageBox.Show((error.ErrorMessage));
        ///     }
        /// </code>
        /// <param name="obj">é a classe instanciada</param>
        /// <returns>Lista de erros</returns>
        /// </exemplo>
        /// </summary>
        public static IEnumerable<ValidationResult> ValidationErros(object obj)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
            return resultadoValidacao;
        }
    }
}
