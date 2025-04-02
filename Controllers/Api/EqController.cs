using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller {
    [HttpGet("listar-agencias")]
    public IActionResult ListarAgencias(){
        //Quiero un listado de todos los inmuebles que estan para renta y que esten con la agencia Fernández Inmuebles

        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroAgencia = Builders<Inmueble>.Filter.Eq(x => x.Agencia, "Fernández Inmuebles");
        var filtroAgente = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente, "Fernández Inmuebles");
        var lista = collection.Find(filtro).ToList();



        //var lista = collection.Find(FilterDefinition<Inmueble>.Empty).ToList();

        return Ok(lista);





    }
}