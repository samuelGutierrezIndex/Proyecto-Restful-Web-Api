using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pruebas_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pruebas : ControllerBase
    {

        private readonly IConfiguration _configuration;

        public Pruebas(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        // GET: api/<Pruebas>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Pruebas>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Pruebas>
        // Llama al procedimiento almacenado para insertar una nueva categoria.
        //[HttpPost]
        //public IActionResult Post([FromBody] Categoria value)
        //{
        //    string connectionString = _configuration.GetConnectionString("conexion");

        //    SqlConnection cn = new SqlConnection(connectionString);

        //    cn.Open();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = cn;

        //    cmd.CommandText = "spInsertCategoria";
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    SqlParameter Sqlparametros = new SqlParameter();


        //    Sqlparametros = cmd.Parameters.Add("@CATEGORIAID", SqlDbType.Int);
        //    Sqlparametros.Value = Convert.ToInt32(value.id);

        //    Sqlparametros = cmd.Parameters.Add("@CATEGORIANOMBRE", SqlDbType.NVarChar);
        //    Sqlparametros.Value = value.nombre;

        //    var i = cmd.ExecuteNonQuery();

        //    if (i == 1)
        //    {
        //        return Ok("se realizo la accion correctamente");
        //    }

        //    return Ok("accion no realizada");

        //}

        // PUT api/<Pruebas>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Pruebas>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }


    class Categoria {
        public int id { set; get; }
        public string nombre { set; get; }
    }
}
