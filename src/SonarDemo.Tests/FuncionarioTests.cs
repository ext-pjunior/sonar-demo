using SonarDemo.Domain;

namespace SonarDemo.Tests;

public class FuncionarioTests
{
    [Fact]
    public void Funcionario_Nome_NaoDeveSerNuloOuVazio()
    {
        // Arrange & Act
        var funcionario = new Funcionario("", 1000);

        // Assert
        Assert.False(string.IsNullOrEmpty(funcionario.Nome));
    }

    [Fact]
    public void Funcionario_Apelido_NaoDeveTerApelido()
    {
        // Arrange & Act
        var funcionario = new Funcionario("Bruce Wayne", 1000);

        // Assert
        Assert.Null(funcionario.Apelido);

        // Assert Bool
        Assert.True(string.IsNullOrEmpty(funcionario.Apelido));
        Assert.False(funcionario.Apelido?.Length > 0);
    }

    // [Theory]
    // [InlineData(700)]
    // [InlineData(1500)]
    // [InlineData(2000)]
    // [InlineData(7500)]
    // [InlineData(8000)]
    // [InlineData(15000)]
    // public void Funcionario_Salario_FaixasSalariaisDevemRespeitarNivelProfissional(double salario)
    // {
    //     // Arrange & Act
    //     var funcionario = new Funcionario("Bruce Wayne", salario);

    //     // Assert
    //     if (funcionario.NivelProfissional == NivelProfissional.Junior)
    //         Assert.InRange(funcionario.Salario, 500, 1999);

    //     if (funcionario.NivelProfissional == NivelProfissional.Pleno)
    //         Assert.InRange(funcionario.Salario, 2000, 7999);

    //     if (funcionario.NivelProfissional == NivelProfissional.Senior)
    //         Assert.InRange(funcionario.Salario, 8000, double.MaxValue);

    //     Assert.NotInRange(funcionario.Salario, 0, 499);
    // }

    // [Fact]
    // public void FuncionarioFactory_Criar_DeveRetornarTipoFuncionario()
    // {
    //     // Arrange & Act
    //     var funcionario = FuncionarioFactory.Criar("Bruce Wayne", 10000);

    //     // Assert
    //     Assert.IsType<Funcionario>(funcionario);
    // }
        
    // [Fact]
    // public void FuncionarioFactory_Criar_DeveRetornarTipoDerivadoPessoa()
    // {
    //     // Arrange & Act
    //     var funcionario = FuncionarioFactory.Criar("Bruce Wayne", 10000);

    //     // Assert
    //     Assert.IsAssignableFrom<Pessoa>(funcionario);
    // }
}
