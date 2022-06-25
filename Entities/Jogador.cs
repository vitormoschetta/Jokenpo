using Jokenpo.Enums;
using Jokenpo.Extensions;

namespace Jokenpo.Entities
{
    public class Jogador
    {
        public string Nome { get; set; }
        public EJokenPo JokenPo { get; set; }

        public string Jogar(Jogador adversario)
        {
            if (this.JokenPo == adversario.JokenPo)
                return "Empate";

            var tipo = this.JokenPo.RetornaImplementacaoTipo();

            if (tipo.Vence.Contains(adversario.JokenPo))
                return $"{this.Nome} venceu";

            return $"{adversario.Nome} venceu";
        }
    }
}