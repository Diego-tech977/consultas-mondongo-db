using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gte")]
public class GteController : Controller {

[HttpGet("propiedades-pisos")]
    public IActionResult PisosCasa(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Gte(x => x.Pisos, 2);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }
    [HttpGet("banos-giova")]
    public IActionResult BanosCasa(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Gte(x => x.Banos, 2);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }
     [HttpGet("terrenos-casa")]
    public IActionResult TerrenosCasa(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Gte(x => x.Costo, 900);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }
     [HttpGet("terrenos-propiedad")]
    public IActionResult TerrenosPropiedad(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Gte(x => x.MetrosTerreno, 500);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }
    [HttpGet("terrenos-casitas")]
    public IActionResult TerrenosCasitas(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Gte(x => x.MetrosConstruccion, 600);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }


}
    