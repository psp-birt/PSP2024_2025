using System.Diagnostics; //Libreria para usar "Process"

namespace PSP01_TA_procesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLanzarProceso_Click(object sender, EventArgs e)
        {
            //Lanza el proceso notepad con el path absoluto
            p=Process.Start(@"C:\Windows\System32\notepad.exe");

            //Si el .exe se encuentra dentro de C:\Windows\System32\ podemos lanzar el proceso sólo con el nombre
            //Process.Start("calc");
        }

        private void buttonMatarProceso_Click(object sender, EventArgs e)
        {
            //Si existe un proceso activo
            if (p != null && !p.HasExited)
            {
                //Muestra el id por pantalla
                this.labelID.Text = "ID:" + p.Id;
                //Mata el proceso
                p.Kill();
                //Inicializa el proceso a null.
                p = null;
            }
        }

        private void buttonMostrarProcSist_Click(object sender, EventArgs e)
        {
            
            //recoge los procesos del sistema en un array de tipo Process
            Process[] misProcesos = Process.GetProcesses();
            //Limmpia datos del comboBox
            this.comboBoxProc.Items.Clear();
            //Por cada proceso del sistema
            foreach(Process mp in misProcesos) 
            {
                //Añade el nombre
                this.comboBoxProc.Items.Add(mp.ProcessName);
            }
            //Muestra el primer nombre del array por defecto.
            this.comboBoxProc.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}