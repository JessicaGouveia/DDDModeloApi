using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDModeloApi.Domain.Core.Enums
{
    public enum LanguageEnum
    {
        [Description("pt-BR")]
        [Display(Name = "Português")]
        Portugues,
        [Description("en-US")]
        [Display(Name = "English")]
        English
    }
}
