using Jokenpo.Entities;
using Jokenpo.Enums;
using Xunit;

namespace Jokenpo;

public class UnitTest1
{
    [Fact]
    public void Se_Empate()
    {
        var jogador1 = new Jogador() { Nome = "Vitor", JokenPo = EJokenPo.Tesoura };
        var jogador2 = new Jogador() { Nome = "João", JokenPo = EJokenPo.Tesoura };

        var resultado = jogador1.Jogar(jogador2);

        Assert.Equal("Empate", resultado);
    }

    [Fact]
    public void Tesoura_Vence_Papel()
    {
        var jogador1 = new Jogador() { Nome = "Vitor", JokenPo = EJokenPo.Tesoura };
        var jogador2 = new Jogador() { Nome = "João", JokenPo = EJokenPo.Papel };

        var vencedor = jogador1.Jogar(jogador2);

        Assert.Equal("Vitor venceu", vencedor);
    }

    [Fact]
    public void Papel_Vence_Pedra()
    {
        var jogador1 = new Jogador() { Nome = "Vitor", JokenPo = EJokenPo.Pedra };
        var jogador2 = new Jogador() { Nome = "João", JokenPo = EJokenPo.Papel };

        var vencedor = jogador1.Jogar(jogador2);

        Assert.Equal("João venceu", vencedor);
    }

    [Fact]
    public void Pedra_Vence_Tesoura()
    {
        var jogador1 = new Jogador() { Nome = "Vitor", JokenPo = EJokenPo.Pedra };
        var jogador2 = new Jogador() { Nome = "João", JokenPo = EJokenPo.Tesoura };

        var vencedor = jogador1.Jogar(jogador2);

        Assert.Equal("Vitor venceu", vencedor);
    }
}
