using Jokenpo.Enums;

namespace Jokenpo.Entities
{
    public class Papel : Tipo
    {
        public Papel()
        {
            Vence = new List<EJokenPo>
            {
                EJokenPo.Pedra
            };
        }
    }
}