using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller {

   [HttpGet("renta-inmobiliaria")]
    public IActionResult Renta(){
        
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Eq(x => x.Operacion, "Renta");
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }
    
    [HttpGet("registrar-terrenos")]
    public IActionResult RegistrarTerrenos(){
        
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Terreno");
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
          
    }

    [HttpGet("registrar-casas")]
    public IActionResult RegistrarCasas(){
        
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Casa");
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);

    }

     [HttpGet("inmuebles-venta")]
    public IActionResult Venta(){
        
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Eq(x => x.Operacion, "Venta");
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);

    }

    [HttpGet("inmuebles-AnaTorres")]
    public IActionResult Ana(){
        
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente, "Ana Torres");
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);

    }


}

