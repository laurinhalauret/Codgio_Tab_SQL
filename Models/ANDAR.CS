using System.Collections.Generic;

namespace MeuProjetoAPI.Models
{
    public class Andar
    {
        public string Descricao { get; set; }
        public List<Container> Containers { get; set; }

        public Andar(string descricao)
        {
            Descricao = descricao;
            Containers = new List<Container>
            {
                new Container(),
                new Container()
            };
        }
    }
}
