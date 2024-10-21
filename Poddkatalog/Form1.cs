using BL;

namespace Poddkatalog
{
    public partial class Form1 : Form
    {

        PoddController poddController;
        //Validering validering
        public Form1()
        {
            poddController = new PoddController();
            //validering = new Validering();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rssLinkSubmitBtn_Click(object sender, EventArgs e)
        {
            string link = rssInputField.Text;
            MessageBox.Show(link);

            //link skall valideras
            //validering.valideraLank(link);

            if (link != null) { 
                poddController.getFromRss(link);
                //Hamnar i poddRepository.poddLista;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
