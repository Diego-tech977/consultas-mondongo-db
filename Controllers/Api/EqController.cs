using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller {

    [HttpGet("listar-agencias")]
    public IActionResult ListarAgencias(string agencia, string? agente){
        //Quiero un listado de todos los inmuebles que estan para renta y que esten con la agencia Fernández Inmuebles

        MongoClient client = new MongoClient (CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        //Que la agencia sea Fernández Inmuebles
        var FiltroAgencia = Builders<Inmueble>.Filter.Eq(x => x.Agencia, "Fernández Inmuebles");

        if(!string.IsNullOrWhiteSpace(agente)){
        var FiltroAgente = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente, "Carlos García");
        var filtroCompuesto = Builders<Inmueble>.Filter.And(FiltroAgencia, FiltroAgente);

        var lista = collection.Find(filtroCompuesto).ToList();                     
        return Ok(lista);

    }
        else {
            var lista = collection.Find(FiltroAgencia).ToList();
            return Ok(lista);
        }    
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

