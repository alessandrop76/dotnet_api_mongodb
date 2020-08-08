using System;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Api.Data.Collections
{
    public class Infectado
    {
        public Infectado(DateTime dataNascimento, string sexo, double latitude, double longitude)
        {
            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;
            this.Localizacao = new GeoJson2DGeographicCoordinates(longitude,latitude);
        }
//estamos criando uma classe para representar a Collection do mongo
// vamos usar o MONGODB DRIVER - no terminal digitar > dotnet add package MongoDB.Driver - rá aí a magia acontece de novo
        public DateTime DataNascimento {get; set;}
        
        public string Sexo {get; set;}

        public GeoJson2DGeographicCoordinates Localizacao {get; set;}
    }
}