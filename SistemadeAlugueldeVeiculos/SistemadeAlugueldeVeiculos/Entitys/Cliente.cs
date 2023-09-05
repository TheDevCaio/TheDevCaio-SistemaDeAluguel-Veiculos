public class Cliente
{

    public string nome;
    public string email;
    public int cpf;
    public DateTime dataNasc;
    public int tel;
    public int cel;
    public bool zap;
    public string obs;
    public string Nome { get; set; }
    public string End { get; set; }
    public string Obs { get; set; }
    public string Email { get; set; }
    public int Cpf { get; set; }
    public int Tel { get; set; }
    public bool Zap { get; set; }
    public DateTime DataNasc { get; set; }


    public string Salvar()
    {
        return "Dados capturados"; 
    }
}