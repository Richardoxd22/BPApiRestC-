using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Banco
    {
        public int saldoac { get; set; }        
        public string NombresBP { get; set; }
        public int IdUsuario { get; internal set; }
    }
}