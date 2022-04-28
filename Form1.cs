using CalcMVC.Vista;
using CalcMVC.Controlador;

namespace CalcMVC
{
    public partial class Form1 : Form, IVistaCalc
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string IN1 => btn1.Text;

        public string IN2 => btn2.Text;

        public string IN3 => btn3.Text;

        public string IN4 => btn4.Text;

        public string IN5 => btn5.Text;

        public string IN6 => btn6.Text;

        public string IN7 => btn7.Text;

        public string IN8 => btn8.Text;

        public string IN9 => btn9.Text;

        public string IN0 => btn0.Text;

        public string IPunto => btnPunto.Text;

        public string INumero1 { get => txtNumero1.Text; set => txtNumero1.Text = value; }
        public string INumero2 { get => lblNumero2.Text; set => lblNumero2.Text = value; }
        public string IOperacion { get => lblOperacion.Text; set => lblOperacion.Text = value; }

        private void btn1_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.ColocarN1();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.ColocarN2();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.ColocarN3();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.ColocarN4();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.ColocarN5();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.ColocarN6();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.ColocarN7();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.ColocarN8();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.ColocarN9();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.ColocarN0();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.ColocarPunto();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.ColocarOperacion(btnSuma.Text);
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.ColocarOperacion(btnResta.Text);
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.ColocarOperacion(btnMultiplicacion.Text);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.ColocarOperacion(btnDivision.Text);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.CalcularAsync();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ControladorCalc controlador = new ControladorCalc(this);
            controlador.BackSpace();
        }
    }
}