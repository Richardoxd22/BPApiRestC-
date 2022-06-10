using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers1
{
    public class BancoBPController : ApiController
    {        
        
        public List<Banco> Get()
        {
            return BancoData.Listar();
        }
        
        public Banco Get(int idBanco)
        {
            return BancoData.Obtener(idBanco);
        }
       
        public bool Post([FromBody]Banco oBanco)
        {
            return BancoData.Registrar(oBanco);
        }

        public bool Put([FromBody]Banco oBanco)
        {
            return BancoData.Modificar(oBanco);
        }
        
        public bool Delete(int id)
        {
            return BancoData.Eliminar(id);
        }
    }
   
}