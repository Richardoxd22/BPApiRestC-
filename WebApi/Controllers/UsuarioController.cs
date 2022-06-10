using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class UsuarioController : ApiController
    {        
        public List<Usuario> Get()
        {
            return UsuarioData.Listar();
        }
        
        public Usuario Get(int id)
        {
            return UsuarioData.Obtener(id);
        }
       
        public bool Post([FromBody]Usuario oUsuario)
        {
            return UsuarioData.Registrar(oUsuario);
        }

        public bool Put([FromBody]Usuario oUsuario)
        {
            return UsuarioData.Modificar(oUsuario);
        }
        
        public bool Delete(int id)
        {
            return UsuarioData.Eliminar(id);
        }
    }
    class Banco: ApiController
    {
        public List<Usuario> Get()
        {
            return UsuarioData.Listar();
        }

        public Usuario Get(int id)
        {
            return UsuarioData.Obtener(id);
        }

        public bool Post([FromBody] Usuario oUsuario)
        {
            return UsuarioData.Registrar(oUsuario);
        }

        public bool Put([FromBody] Usuario oUsuario)
        {
            return UsuarioData.Modificar(oUsuario);
        }

        public bool Delete(int id)
        {
            return UsuarioData.Eliminar(id);
        }

    }
}