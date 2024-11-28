public class ProprietariosPf : Proprietarios
{
    public string _cpf;
    public string _rg;
    public string _dataNascimento;
    public string _sexo;

    public void SetCpf(string cpf)
    {
        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");

        if (cpf.Length == 11)
        {
            _cpf = cpf;
        }
        else
        {
            throw new Exception("CPF INVÁLIDO!");
        }

    }

    public string GetCpf()
    {
        return _cpf;
    }
}
