using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/in")]
public class InController : Controller {

    [HttpGet("inmuebles-agencia")]
    public IActionResult AgenciaInmuebles(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> valores = new List<string>();
        valores.Add("Torres Realty");
        valores.Add("Inmobiliaria Pérez");

        var Filtro = Builders<Inmueble>.Filter.In(x => x.Agencia, valores);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }


    [HttpGet("fecha-publicacion")]
    public IActionResult Fechas(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> valores = new List<string>();
        valores.Add("2025-02-26");
        valores.Add("2025-01-30");

        var Filtro = Builders<Inmueble>.Filter.In(x => x.FechaPublicacion, valores);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }

    [HttpGet("pisos-de-casa")]
    public IActionResult PisosDeLaCasa(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> valores = new List<int>();
        valores.Add(2);
        valores.Add(3);

        var Filtro = Builders<Inmueble>.Filter.In(x => x.Pisos, valores);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }
    
    [HttpGet("banos-de-casa")]
    public IActionResult CasaConBanos(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> valores = new List<int>();
        valores.Add(2);
        valores.Add(3);

        var Filtro = Builders<Inmueble>.Filter.In(x => x.Banos, valores);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }

    [HttpGet("metros-de-la-casa")]
    public IActionResult CasaConLosMetros(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> valores = new List<int>();
        valores.Add(500);
        valores.Add(600);

        var Filtro = Builders<Inmueble>.Filter.In(x => x.MetrosConstruccion, valores);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }

}    