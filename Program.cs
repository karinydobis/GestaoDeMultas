
Veiculos v1 = new Veiculos();
ProprietariosPf pf = new ProprietariosPf();

/*
try
{
    Console.WriteLine("Insira o ID do veículo: ");
    v1._idVeiculo = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira o Chassi do veículo: ");
    string chassi = Console.ReadLine();
    v1.SetChassi(chassi);

    Console.WriteLine($"\nID:{v1._idVeiculo}");
    Console.WriteLine($"Chassi:{v1.GetChassi()}");
}
catch(Exception ex )
{
    Console.WriteLine(ex.Message);
}
*/
try
{
    
    Console.WriteLine("Insira o CPF: ");
    pf.SetCpf(Console.ReadLine());

    Console.WriteLine(pf.GetCpf());

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


