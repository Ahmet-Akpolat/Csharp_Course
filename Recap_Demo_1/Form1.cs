namespace Recap_Demo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // button.Width = 50;
            // button.Height = 50;
            // button.Text = "Ahmet";

            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;

            for (int row = 0; row <= buttons.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= buttons.GetUpperBound(1); column++)
                {
                    buttons[row, column] = new Button();
                    buttons[row, column].Height = 50;
                    buttons[row, column].Width = 50;
                    buttons[row, column].Top = top;
                    buttons[row, column].Left = left;
                    left += 50;
                    if ((row + column) % 2 == 0)
                    {
                        buttons[row, column].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[row, column].BackColor = Color.AliceBlue;

                    }
                    this.Controls.Add(buttons[row, column]);
                }

                top += 50;
                left = 0;
            }

        }
    }
}