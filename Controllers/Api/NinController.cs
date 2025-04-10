using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/nin")]
public class NinController : Controller {

   [HttpGet("cien-docientos")]
    public IActionResult CienDocientos(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> valores = new List<int>();
        valores.Add(551);
        valores.Add(578);

        var Filtro = Builders<Inmueble>.Filter.Nin(x => x.MetrosConstruccion, valores);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }

     [HttpGet("agentes-inmobiliaria")]
    public IActionResult AgentesInmobiliaria(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> valores = new List<string>();
        valores.Add("Juan Pérez");
        valores.Add("Fernández");

        var Filtro = Builders<Inmueble>.Filter.Nin(x => x.NombreAgente, valores);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }

    [HttpGet("inmuebles-agencia")]
    public IActionResult InmueblesAgencia(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> valores = new List<string>();
        valores.Add("Torres Realty");
        valores.Add("Inmobiliaria Pérez");

        var Filtro = Builders<Inmueble>.Filter.Nin(x => x.Agencia, valores);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }

    [HttpGet("D")]
    public IActionResult PisosDepartamento(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> valores = new List<int>();
        valores.Add(2);
        valores.Add(3);

        var Filtro = Builders<Inmueble>.Filter.Nin(x => x.Pisos, valores);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }

     [HttpGet("banos-departamento")]
    public IActionResult BanosDepartamento(){
        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> valores = new List<int>();
        valores.Add(4);
        valores.Add(3);

        var Filtro = Builders<Inmueble>.Filter.Nin(x => x.Banos, valores);
        var lista = collection.Find(Filtro).ToList();
        
        return Ok(lista);
    }
}