using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeleZando.Models
{
    public class Profissional
    {
        [DisplayName("Código")]
        [Key]
        public int CodigoProfissional { get; set; }        

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]        
        [DisplayName("Razão Social")]
        [StringLength(250, ErrorMessage = "São permitidos até 250 caracteres.")]
        public string RazaoSocialProfissional { get; set; }

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]
        [DisplayName("Nome Fantasia")]
        [StringLength(250, ErrorMessage = "São permitidos até 250 caracteres.")]
        public string NomeFantasiaProfissional { get; set; }

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage = "Por favor insira um email válido")]
        [DisplayName("Email")]
        [StringLength(250, ErrorMessage = "São permitidos até 250 caracteres.")]
        public string EmailProfissional { get; set; }

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]
        [DisplayName("Cpf")]
        [StringLength(14, ErrorMessage = "Devem ser incluídos 14 caracteres.")]
        [MaxLength(14, ErrorMessage = "Preenchimento máximo de 14 caracteres.")]
        [MinLength(14, ErrorMessage = "Preenchimento mínimo de 14 caracteres.")]
        [RegularExpression(@"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}", ErrorMessage = "Digite no formato 000.000.000-00")]
        public string CpfProfissional { get; set; }
                
        [DisplayName("Cnpj")]
        [StringLength(18, ErrorMessage = "Devem ser incluídos 18 caracteres.")]
        [MaxLength(18, ErrorMessage = "Preenchimento máximo de 18 caracteres.")]
        [MinLength(18, ErrorMessage = "Preenchimento mínimo de 18 caracteres.")]
        [RegularExpression(@"[0-9]{2}\.?[0-9]{3}\.?[0-9]{3}\/?[0-9]{4}\-?[0-9]{2}", ErrorMessage = "Digite no formato 00.000.000/0000-00")]
        public string CnpjProfissional { get; set; }

        // ([0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}|[0-9]{2}\.?[0-9]{3}\.?[0-9]{3}\/?[0-9]{4}\-?[0-9]{2}) Expressão Regular para ambos em um mesmo input

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]
        [DisplayName("Telefone")]
        [StringLength(14, ErrorMessage = "Devem ser incluídos 14 caracteres.")]
        [MaxLength(14, ErrorMessage = "Preenchimento máximo de 14 caracteres.")]
        [MinLength(14, ErrorMessage = "Preenchimento mínimo de 14 caracteres.")]
        [RegularExpression(@"\(?[0-9]{2}\)?[0-9]{5}\-?[0-9]{4}", ErrorMessage = "Digite no formato (00)00000-0000")]
        public string TelefoneProfissional { get; set; }
                
        [DisplayName("Número")]
        [StringLength(14, ErrorMessage = "São permitidos até 14 caracteres.")]
        public string NumeroEnderecoProfissional { get; set; }

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]
        [DisplayName("Endereço")]
        [StringLength(250, ErrorMessage = "São permitidos até 250 caracteres.")]
        public string EnderecoProfissional { get; set; }

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]
        [DisplayName("Bairro")]
        [StringLength(250, ErrorMessage = "São permitidos até 250 caracteres.")]
        public string BairroProfissional { get; set; }

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]
        [DisplayName("Cidade")]
        [StringLength(250, ErrorMessage = "São permitidos até 250 caracteres.")]
        public string CidadeProfissional { get; set; }

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]
        [DisplayName("Estado")]
        [StringLength(2)]
        public string EstadoProfissional { get; set; }

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]
        [DisplayName("CEP")]
        [StringLength(9, ErrorMessage = "São permitidos até 9 caracteres.")]
        [RegularExpression(@"[0-9]{5}\-?[0-9]{3}", ErrorMessage = "Digite no formato 00000-000")]
        public string CepProfissional { get; set; }

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]
        [DisplayName("Senha")]
        [MaxLength(32, ErrorMessage = "Preenchimento máximo de 32 caracteres.")]
        [MinLength(6, ErrorMessage = "Preenchimento mínimo de 6 caracteres.")]
        [StringLength(32, ErrorMessage = "São permitidos até 32 caracteres.")]
        public string SenhaProfissional { get; set; }

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]
        [DisplayName("Situação Profissional")]
        [StringLength(250)]
        public string SituacaoProfissional { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Última Atualização")]
        public DateTime UltimaAtualizacaoProfissional { get; set; }      

        public readonly string TIPO_USUARIO_PROFISSIONAL = "Profissional";
    }
}