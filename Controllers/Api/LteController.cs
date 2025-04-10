using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/lte")]
public class LteController : Controller {

     [HttpGet("quinientos-metros")]
    public IActionResult MetrosCuadrados(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosSSConstruccion, 500);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    
    }

     [HttpGet("costo-de-la-propiedad")]
    public IActionResult CostoDeLaPropiedad(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Lte(x => x.Costo, 2000000);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    
    }

    [HttpGet("metros-de-la-construccion")]
    public IActionResult MetrosDeLaConstruccion(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosConstruccion, 800);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    
    }

     [HttpGet("dos-pisos")]
    public IActionResult DosPisos(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Lte(x => x.Pisos, 2);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    
    }

     [HttpGet("dos-banos")]
    public IActionResult DosBanos(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Lte(x => x.Banos, 2);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    
    }

}    