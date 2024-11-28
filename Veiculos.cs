public class Veiculos
{
    public int _idVeiculo;
    private string _chassi;
    public string _numPlaca;
    public string _numMotor;
    public string _renavam;
    public string _anoModelo;
    public string _situacao;
    public string _cor;
    public Cidades _cidade;
    public Proprietarios _proprietario;
    public Modelos _modelo;

    public void SetChassi(string chassi)
    {
        if(chassi.Length == 17)
        {
           _chassi = chassi;
        }
        else
        {
            throw new Exception("CHASSI INVÁLIDO");
        }
       
    }

    public string GetChassi()
    {
        return _chassi;
    }
}
