using CalcMVC.Modelo;
using CalcMVC.Vista;

namespace CalcMVC.Controlador
{
    public class ControladorCalc
    {
        IVistaCalc Vista;

        public ControladorCalc(IVistaCalc vista)
        {
            Vista = vista;
        }

        public void ColocarN1()
        {
            ModeloCalc modelo = new ModeloCalc();
            modelo.N1 = Vista.IN1;
            Vista.INumero1 += modelo.N1;
        }

        public void ColocarN2()
        {
            ModeloCalc modelo = new ModeloCalc();
            modelo.N2 = Vista.IN2;
            Vista.INumero1 += modelo.N2;
        }

        public void ColocarN3()
        {
            ModeloCalc modelo = new ModeloCalc();
            modelo.N3 = Vista.IN3;
            Vista.INumero1 += modelo.N3;
        }

        public void ColocarN4()
        {
            ModeloCalc modelo = new ModeloCalc();
            modelo.N4 = Vista.IN4;
            Vista.INumero1 += modelo.N4;
        }

        public void ColocarN5()
        {
            ModeloCalc modelo = new ModeloCalc();
            modelo.N5 = Vista.IN5;
            Vista.INumero1 += modelo.N5;
        }

        public void ColocarN6()
        {
            ModeloCalc modelo = new ModeloCalc();
            modelo.N6 = Vista.IN6;
            Vista.INumero1 += modelo.N6;
        }

        public void ColocarN7()
        {
            ModeloCalc modelo = new ModeloCalc();
            modelo.N7 = Vista.IN7;
            Vista.INumero1 += modelo.N7;
        }

        public void ColocarN8()
        {
            ModeloCalc modelo = new ModeloCalc();
            modelo.N8 = Vista.IN8;
            Vista.INumero1 += modelo.N8;
        }

        public void ColocarN9()
        {
            ModeloCalc modelo = new ModeloCalc();
            modelo.N9 = Vista.IN9;
            Vista.INumero1 += modelo.N9;
        }

        public void ColocarN0()
        {
            ModeloCalc modelo = new ModeloCalc();
            modelo.N0 = Vista.IN0;
            Vista.INumero1 += modelo.N0;
        }

        public void ColocarPunto()
        {
            if (!Vista.INumero1.Contains(".")) 
            {
                ModeloCalc modelo = new ModeloCalc();
                modelo.Punto = Vista.IPunto;
                Vista.INumero1 += modelo.Punto;
            }            
        }
        public void ColocarOperacion(string operador)
        {
            if (Vista.INumero1 != "") 
            {
                ModeloCalc modelo = new ModeloCalc();
                Vista.INumero2 = Vista.INumero1;
                Vista.INumero1 = "";
                modelo.Operacion = operador;
                Vista.IOperacion = modelo.Operacion;
            }            
        }
        public async Task CalcularAsync()
        {
            switch (Vista.IOperacion)
            {
                case "+":
                    Vista.INumero1 = (Double.Parse(Vista.INumero2) + Double.Parse(Vista.INumero1)).ToString();
                    Vista.INumero2 = "";
                    Vista.IOperacion = "";
                    break;
                case "-":
                    Vista.INumero1 = (Double.Parse(Vista.INumero2) - Double.Parse(Vista.INumero1)).ToString();
                    Vista.INumero2 = "";
                    Vista.IOperacion = "";
                    break;
                case "x":
                    Vista.INumero1 = (Double.Parse(Vista.INumero2) * Double.Parse(Vista.INumero1)).ToString();
                    Vista.INumero2 = "";
                    Vista.IOperacion = "";
                    break;
                case "/":
                    if (Vista.INumero1 != "0")
                    {
                        Vista.INumero1 = (Double.Parse(Vista.INumero2) / Double.Parse(Vista.INumero1)).ToString();
                        Vista.INumero2 = "";
                        Vista.IOperacion = "";
                    }
                    else
                    {
                        Vista.INumero2 = "";
                        Vista.IOperacion = "";
                        Vista.INumero1 = "No se puede dividir entre cero.";
                        await Task.Delay(3000);
                        Vista.INumero1 = "";
                    }
                    break;
                default:
                    break;
            }
        }
        public void Clear()
        {
            Vista.INumero1 = "";
            Vista.INumero2 = "";
            Vista.IOperacion = "";
        }
        public void BackSpace()
        {
            if (Vista.INumero1.Length > 0) 
            {
                Vista.INumero1 = Vista.INumero1.Remove(Vista.INumero1.Length - 1);
            }            
        }
    }
}
