namespace KarakterDekodoloGUI
{
    public partial class FrmMain : Form
    {
        public Label[,] labelMatrix = new Label[7, 4];

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            for (int s = 0; s < labelMatrix.GetLength(0); s++)
            {
                for (int o = 0; o < labelMatrix.GetLength(1); o++)
                {
                    labelMatrix[s, o] = new Label()
                    {
                        AutoSize = false,
                        BackColor = Color.White,
                        BorderStyle = BorderStyle.FixedSingle,
                        Bounds = new(
                            x: o * 50 + (Width / 2  - labelMatrix.GetLength(1) * 50 / 2),
                            y: s * 50 + (Height / 2 - labelMatrix.GetLength(0) * 50 / 2),
                            width: 50,
                            height: 50),
                        Text = "0",
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    labelMatrix[s, o].Click += Label_Click;

                    this.Controls.Add(labelMatrix[s, o]);
                }
            }
        }

        private void Label_Click(object? sender, EventArgs e)
        {
            if ((sender is Label) && (sender as Label).Text == "0")
            {
                (sender as Label).Text = "1";
                (sender as Label).BackColor = Color.Gray;
            }
            else
            {
                (sender as Label).Text = "0";
                (sender as Label).BackColor = Color.White;
            }
        }
    }
}