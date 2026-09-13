using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando objeto e atribuindo valores com notação de ponto
        Emprego emprego1 = new Emprego();
        emprego1._cargo = "Engenheiro de Software";
        emprego1._empresa = "Microsoft";
        emprego1._anoInicio = 2020;
        emprego1._anoFim = 2023;

        // Exibindo informações
        emprego1.ExibirInformacoes();
        Console.WriteLine("Empresa deste emprego: " + emprego1._empresa);
    }
}
public class Emprego
{
    // Variáveis membro privadas
    public string _cargo;
    public string _empresa;
    public int _anoInicio;
    public int? _anoFim; // int? permite valor nulo

    // Construtor
    public Emprego() {}
   
 // Método para exibir informações
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Cargo: {_cargo}");
        Console.WriteLine($"Empresa: {_empresa}");
        Console.WriteLine($"Período: {_anoInicio} - {(_anoFim.HasValue ? _anoFim.Value.ToString() : "Atualmente")}");
    }
}



