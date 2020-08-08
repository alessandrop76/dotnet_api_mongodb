using System;

namespace Api.Models
{
//essa classe é para o retorno dos dados do banco nosql
//o ideal para cada ViewlModel/DTO ou EndPoint eu tenha uma classe 

    public class InfectadoDto
    {
        public DateTime DataNascimento { get; set; }

         public string Sexo { get; set; }

          public double Latitude { get; set; }

           public double Longitude { get; set; }

    }



}