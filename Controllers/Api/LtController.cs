using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/lt")]
public class LtController : Controller {


    [HttpGet("terrenos-metros")]
    public IActionResult TerrenosMetros(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosConstruccion, 980);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    
    }
    [HttpGet("casas-pisos")]
    public IActionResult CasasPisos(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Lt(x => x.Pisos, 2);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }
     [HttpGet("casas-costo")]
    public IActionResult CasasCosto(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Lt(x => x.Costo, 33421);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }
     [HttpGet("propiedades-terreno")]
    public IActionResult PropiedadesTerreno(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosTerreno, 500);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }
     [HttpGet("Banos-propiedades")]
    public IActionResult BanosPropiedades(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Lt(x => x.Banos, 2);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }
}
