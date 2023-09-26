

using promedio;

namespace examen_JOSE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_eva1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;

            if (!(char.IsDigit(a) || a == '\b'))
            {
                e.Handled = true;
            }
        }

        public void lim()
        {
            txt_Acti.Text = "";
            txt_eva1.Text = "";
            txt_eva2.Text = "";
            txt_eva3.Text = "";
            txt_nombre.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_nombre.Enabled = false; 
            txt_eva1.Enabled = false;   
            txt_eva2.Enabled = false;   
            txt_eva3.Enabled = false;   
            txt_Acti.Enabled = false;   
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_nombre.Enabled = true;
            txt_eva1.Enabled = true;
            txt_eva2.Enabled = true;
            txt_eva3.Enabled = true;
            txt_Acti.Enabled = true;
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "" || txt_eva1.Text == "" || txt_eva2.Text == "" || txt_eva3.Text == ""
               || txt_Acti.Text == "")
            {
                MessageBox.Show("TIENE QUE LLENAR TODOS LOS CAMPOS PARA PODER REGISTRAR");
            }
            else
            {
                string nombre = txt_nombre.Text;
                double eva1 =double.Parse(txt_eva1.Text);
                double eva2 =double.Parse(txt_eva2.Text);
                double eva3 =double.Parse(txt_eva3.Text);
                double acti = double.Parse(txt_Acti.Text);
                
                Promedio es = new Promedio(eva1, eva2, eva3, nombre);

                double nota1fi = es.CALCUNOTA1(eva1);
                double nota2fi = es.CALCUNOTA2(eva2);
                double nota3fi = es.CALCUNOTA3(eva3);
                double actiFi = es.CALCU_Acti(acti);

                double promeFi = es.CalcularPromedio(nota1fi, nota2fi, nota3fi);

                ListViewItem a = new ListViewItem(nombre);
                a.SubItems.Add(nota1fi.ToString("0.00"));
                a.SubItems.Add(nota2fi.ToString("0.00"));
                a.SubItems.Add(nota3fi.ToString("0.00"));
                a.SubItems.Add(actiFi.ToString("0.00"));
                a.SubItems.Add(promeFi.ToString("0.00"));

                if (promeFi >= 12.5)
                {
                    a.SubItems.Add("aprobado");
                }
                else
                {
                    a.SubItems.Add("Desaprobado");
                }

                LstV_Notas.Items.Add(a);
            }

            lim();
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;

            if (!(char.IsLetter(a) || a == '\b'|| a == ' '))
            { 
                e.Handled = true;   
            }
        }
    }
}