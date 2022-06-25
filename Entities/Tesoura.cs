using Jokenpo.Enums;

namespace Jokenpo.Entities
{
    public class Tesoura : Tipo
    {
        public Tesoura()
        {
            Vence = new List<EJokenPo>
            {
                EJokenPo.Papel
            };
        }
    }
}