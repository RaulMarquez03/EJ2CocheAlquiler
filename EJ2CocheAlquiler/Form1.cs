namespace EJ2CocheAlquiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void messagePrice(object sender, EventArgs e)
        {
            if (kmInicio.Value>kmFin.Value)
            {
                MessageBox.Show("El valor de los Km de inicio no\r\npuede ser mayor que los km de finalización.");

            }
            else
            {
                calculatePrice();
                
            }
        }
      
        private void calculatePrice()
        {
            int kmRec = (int)(kmFin.Value - kmInicio.Value);
            float kmPrice = 0.39f;
            float price = kmRec * kmPrice;
            labelPrice.Text=$"El precio es {price.ToString("C")}";


        }
        private void kmMessage(object sender, EventArgs e)
        {
            int kmRec = (int)(kmFin.Value - kmInicio.Value);
            MessageBox.Show(kmRec.ToString());
        }




    }
}