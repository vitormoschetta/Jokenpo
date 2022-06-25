using Jokenpo.Entities;
using Jokenpo.Enums;

namespace Jokenpo.Extensions
{
    public static class JokenPowExtensions
    {
        public static Tipo RetornaImplementacaoTipo(this EJokenPo jokenPow)
        {
            switch (jokenPow)
            {
                case EJokenPo.Papel:
                    return new Papel();
                case EJokenPo.Pedra:
                    return new Pedra();
                case EJokenPo.Tesoura:
                    return new Tesoura();
                default:
                    throw new Exception("Tipo nao existe");
            }
        }
    }
}