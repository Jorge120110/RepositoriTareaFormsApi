using Newtonsoft.Json.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TareaPrograApi
{
    public partial class Form1 : Form
    {
        private HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string url = "https://raw.githubusercontent.com/Bowserinator/Periodic-Table-JSON/refs/heads/master/PeriodicTableJSON.json";

            using (HttpClient client = new HttpClient())
            {
                string nombre = txtbusqueda.Text.Trim();
                string response = await client.GetStringAsync(url);
                JObject json = JObject.Parse(response);

                var elemento = json["elements"]
                ?.FirstOrDefault(el => el["name"]?.ToString().Equals(nombre, StringComparison.OrdinalIgnoreCase) == true);

                if (elemento != null)
                {
                    label2.Text = elemento["name"]?.ToString();
                    label3.Text = $"{elemento["category"]}";
                    label4.Text = $" {elemento["atomic_mass"]}";
                    label5.Text = $"{elemento["discovered_by"]}";
                    label6.Text = $"{elemento["summary"]}";
                    pictureBox1.ImageLocation = $"{elemento["bohr_model_image"]}";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Width = 200;
                    pictureBox1.Height = 200;
                }
                else
                {
                    label2.Text = "Elemento no encontrado";
                    label3.Text = "";
                    label4.Text = "";
                    label5.Text = "";
                    label6.Text = "";
                    pictureBox1.ImageLocation = null;
                }
            }

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtelemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void btnlimpiar_Click(object sender, EventArgs e)
        {

            LimpiarFormulario();
        
        }
        private void LimpiarFormulario()
        {
            txtbusqueda.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            pictureBox1.ImageLocation = null;
        }

    }
}
