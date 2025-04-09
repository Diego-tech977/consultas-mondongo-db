using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/ne")]
public class NeController : Controller {

     [HttpGet("Nombre-Agente")]
    public IActionResult NombreAgente(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Ne(x => x.NombreAgente, "CarlosGarcia");
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    
    }
    [HttpGet("no-inmuebles")]
    public IActionResult NoInmuebles(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Ne(x => x.Agencia, "Inmobiliaria Pérez");
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    
    }
    [HttpGet("no-3-pisos")]
    public IActionResult No3Pisos(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Ne(x => x.Pisos, 3);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    
    }
    [HttpGet("no-cien-metros")]
    public IActionResult NoCienMetros(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Ne(x => x.MetrosConstruccion, 100);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    
    }
    [HttpGet("propiedades-venta")]
    public IActionResult PropiedadesVenta(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Ne(x => x.Costo, 500000);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    
    }
}