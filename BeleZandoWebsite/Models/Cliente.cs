using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeleZando.Models
{
    public class Cliente
    {
        [DisplayName("Código")]
        [Key]
        public int CodigoCliente { get; set; }

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]
        [DisplayName("Nome")]
        [StringLength(250, ErrorMessage = "São permitidos até 250 caracteres.")]
        public string NomeCliente { get; set; }

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage = "Por favor insira um email válido")]
        [DisplayName("Email")]
        [StringLength(250, ErrorMessage = "São permitidos até 250 caracteres.")]
        public string EmailCliente { get; set; }

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]
        [DisplayName("Cpf")]
        [StringLength(14, ErrorMessage = "Devem ser incluídos 14 caracteres.")]
        [MaxLength(14, ErrorMessage = "Preenchimento máximo de 14 caracteres.")]
        [MinLength(14, ErrorMessage = "Preenchimento mínimo de 14 caracteres.")]
        [RegularExpression(@"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}", ErrorMessage = "Digite no formato 000.000.000-00")]
        public string CpfCliente { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimentoCliente { get; set; }

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]
        [DisplayName("Telefone")]
        [StringLength(14, ErrorMessage = "Devem ser incluídos 14 caracteres.")]
        [MaxLength(14, ErrorMessage = "Preenchimento máximo de 14 caracteres.")]
        [MinLength(14, ErrorMessage = "Preenchimento mínimo de 14 caracteres.")]
        [RegularExpression(@"\(?[0-9]{2}\)?[0-9]{5}\-?[0-9]{4}", ErrorMessage = "Digite no formato (00)00000-0000")]
        public string TelefoneCliente { get; set; }

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]
        [DisplayName("Senha")]
        [MaxLength(32, ErrorMessage = "Preenchimento máximo de 32 caracteres.")]
        [MinLength(6, ErrorMessage = "Preenchimento mínimo de 6 caracteres.")]
        [StringLength(32, ErrorMessage = "São permitidos até 32 caracteres.")]
        public string SenhaCliente { get; set; }

        [Required(ErrorMessage = "O preenchimento é obrigatório", AllowEmptyStrings = false)]
        [DisplayName("Situação Cliente")]
        [StringLength(250)]
        public string SituacaoCliente { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]        
        [DisplayName("Última Atualização")]
        public DateTime UltimaAtualizacaoCliente { get; set; }

        public readonly string TIPO_USUARIO_CLIENTE = "Cliente";
    }
}