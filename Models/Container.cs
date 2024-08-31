namespace MeuProjetoAPI.Models
{
    public class Container
    {
        private string[] Posicoes;

        public Container()
        {
            Posicoes = new string[4];
        }

        public void AdicionarItem(int posicaoIndex, string item)
        {
            if (posicaoIndex < Posicoes.Length && string.IsNullOrEmpty(Posicoes[posicaoIndex]))
            {
                Posicoes[posicaoIndex] = item;
            }
        }

        public string GetItem(int posicaoIndex)
        {
            if (posicaoIndex < Posicoes.Length)
            {
                return Posicoes[posicaoIndex];
            }
            return null;
        }

        public void AlterarItem(int posicaoIndex, string novoItem)
        {
            if (posicaoIndex < Posicoes.Length)
            {
                Posicoes[posicaoIndex] = novoItem;
            }
        }

        public void RemoverItem(int posicaoIndex)
        {
            if (posicaoIndex < Posicoes.Length)
            {
                Posicoes[posicaoIndex] = null;
            }
        }

        public bool EstaCheio()
        {
            foreach (var posicao in Posicoes)
            {
                if (string.IsNullOrEmpty(posicao))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
