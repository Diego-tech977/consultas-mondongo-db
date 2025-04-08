using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gt")]
public class GtController : Controller {


    [HttpGet("costo-mayor")]
    public IActionResult RegistrarCosto(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Gt(x => x.Costo, 22043);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    
    }

    [HttpGet("propiedad-metros")]
    public IActionResult Propiedad(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Gt(x => x.MetrosTerreno, 200);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    
    }

    [HttpGet("casa-banos")]
    public IActionResult Casa(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Gt(x => x.Banos, 1);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);

    }
     [HttpGet("casa-metro")]
    public IActionResult Metrasao(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Gt(x => x.MetrosConstruccion, 150);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);

    }

    [HttpGet("metros-casa")]
    public IActionResult ConstruccionMetros(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var Filtro = Builders<Inmueble>.Filter.Gt(x => x.MetrosConstruccion, 150);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);

    }
}

    

