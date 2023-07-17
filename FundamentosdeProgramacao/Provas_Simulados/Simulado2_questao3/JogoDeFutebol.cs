class JogodeFutebol
{
    private string _adversario;
    public string Adversario
    {
        get { return _adversario; }
        set { _adversario=value; }
    }

    private int _numPontos;
    public int NumPontos
    {
        get { return _numPontos; }
        set { _numPontos=value; }
    }
    
    private int _numQuedas;
    public int NumQuedas
    {
        get { return _numQuedas; }
        set { _numQuedas=value; }
    }
}