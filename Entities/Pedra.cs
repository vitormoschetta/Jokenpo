using Jokenpo.Enums;

namespace Jokenpo.Entities
{
    public class Pedra : Tipo
    {
        public Pedra()
        {
            Vence = new List<EJokenPo>
            {
                EJokenPo.Tesoura
            };
        }
    }
}