using CircConCentroFer2023.Entidades;
using System;
using System.Windows.Forms;

namespace CircConCentroFer2023.Windows
{
    public partial class frmCircAE : Form
    {
        public frmCircAE()
        {
            InitializeComponent();
        }

        public Circunferencia GetCircunferencia()
        {
            return c;
        }

        //TODO:definir variables privadas locales
        private Circunferencia c;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;//no hice nada
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                int radio = int.Parse(txtRadio.Text);
                int x = int.Parse(txtCoordX.Text);
                int y = int.Parse(txtCoordY.Text);
                if (c == null)
                {
                    c = new Circunferencia(radio, new Punto(x, y));

                }
                else
                {
                    c.Centro=new Punto(x,y);
                    c.Radio=radio;
                }
                DialogResult = DialogResult.OK;
            }
        }
        /// <summary>
        /// Método para validar los datos ingresados
        /// </summary>
        /// <returns>Resultado de la validación de los mismos</returns>
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtCoordX.Text, out int x))
            {
                valido = false;
                errorProvider1.SetError(txtCoordX, "Coord X mal ingresada");
            }
            if (!int.TryParse(txtCoordY.Text, out int y))
            {
                valido = false;
                errorProvider1.SetError(txtCoordY, "Coord Y mal ingresada");
            }
            if (!int.TryParse(txtRadio.Text, out int radio))
            {
                valido = false;
                errorProvider1.SetError(txtRadio, "Medida del radio no válida");
            }
            else if (radio <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtRadio, "Media del radio debe ser positiva");
            }
            return valido;
        }

        public void SetCircunferencia(Circunferencia c)
        {
            this.c=c;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (c!= null) { 
                txtCoordX.Text=c.Centro.CoordX.ToString();
                txtCoordY.Text=c.Centro.CoordY.ToString();
                txtRadio.Text=c.Radio.ToString();
            }
        }
    }
}
