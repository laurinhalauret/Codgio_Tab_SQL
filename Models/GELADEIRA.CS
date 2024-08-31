using System.Collections.Generic;

namespace MeuProjetoAPI.Models
{
    public class Geladeira : Eletrodomestico
    {
        public List<Andar> Andares { get; set; }

        public Geladeira()
        {
            Andares = new List<Andar>
            {
                new Andar("Hortifrutis"),
                new Andar("Laticínios e Enlatados"),
                new Andar("Charcutaria, Carnes e Ovos")
            };
        }

        public void AdicionarItem(int andarIndex, int containerIndex, int posicaoIndex, string item)
        {
            if (andarIndex < Andares.Count && containerIndex < Andares[andarIndex].Containers.Count)
            {
                Andares[andarIndex].Containers[containerIndex].AdicionarItem(posicaoIndex, item);
            }
        }

        public string GetItemById(int andarIndex, int containerIndex, int posicaoIndex)
        {
            if (andarIndex < Andares.Count && containerIndex < Andares[andarIndex].Containers.Count)
            {
                return Andares[andarIndex].Containers[containerIndex].GetItem(posicaoIndex);
            }
            return null;
        }

        public void AlterarItem(int andarIndex, int containerIndex, int posicaoIndex, string novoItem)
        {
            if (andarIndex < Andares.Count && containerIndex < Andares[andarIndex].Containers.Count)
            {
                Andares[andarIndex].Containers[containerIndex].AlterarItem(posicaoIndex, novoItem);
            }
        }

        public void RemoverItem(int andarIndex, int containerIndex, int posicaoIndex)
        {
            if (andarIndex < Andares.Count && containerIndex < Andares[andarIndex].Containers.Count)
            {
                Andares[andarIndex].Containers[containerIndex].RemoverItem(posicaoIndex);
            }
        }
    }
}
