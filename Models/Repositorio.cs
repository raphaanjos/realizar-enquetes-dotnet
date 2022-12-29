using System.Collections.Generic;

namespace _aula_06.Models
{
    public static class Repositorio
    {
        private static List<Resposta> respostas = new List<Resposta>();
        public static IEnumerable<Resposta> Respostas {get {return respostas; }}
        public static void AdicionarResposta(Resposta resposta) 
        {
            respostas.Add(resposta);
        }
    }
}