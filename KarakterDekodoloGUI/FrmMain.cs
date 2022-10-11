namespace KarakterDekodoloGUI
{
    public partial class FrmMain : Form
    {
        public TextBox[,] textBoxMatrix = new TextBox[7, 4];

        public FrmMain()
        {
            InitializeComponent();
        }

        private void ForMain_Load(object sender, EventArgs e)
        {
            for (int s = 0; s < textBoxMatrix.GetLength(0); s++)
            {
                for (int o = 0; o < textBoxMatrix.GetLength(1); o++)
                {
                    textBoxMatrix[s, o] = new TextBox()
                    {
                        Bounds = new(x: 0, y:0, width: 0, height: 0),
                        Text = "0",
                        
                    };
                }
            }
        }
    }
}