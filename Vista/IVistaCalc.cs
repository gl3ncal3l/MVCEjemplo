namespace CalcMVC.Vista
{
    public interface IVistaCalc
    {
        string IN1 { get; }
        string IN2 { get; }
        string IN3 { get; }
        string IN4 { get; }
        string IN5 { get; }
        string IN6 { get; }
        string IN7 { get; }
        string IN8 { get; }
        string IN9 { get; }
        string IN0 { get; }
        string IPunto { get; }

        string INumero1 { get; set; }
        string INumero2 { get; set; }
        string IOperacion { get; set; }
    }
}
