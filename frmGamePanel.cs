namespace TetrisGame
{
    public partial class frmGamePanel : Form
    {
        private const int Rows = 20;
        private const int Columns = 10;

        private Label[,] cells = new Label[Rows, Columns];

        // Current block position
        private int currentRow = Rows - 1;
        private int currentColumn = Columns - 1;

        public frmGamePanel()
        {
            InitializeComponent();
        }

        private void frmGamePanel_Load(object sender, EventArgs e)
        {
            // Store every label in the 2D array
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                int row = tableLayoutPanel1.GetRow(control);
                int column = tableLayoutPanel1.GetColumn(control);

                Label label = (Label)control;

                cells[row, column] = label;
                label.BackColor = Color.White;
            }

            // Draw the starting block
            cells[currentRow, currentColumn].BackColor = Color.Black;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Remove the block from its current position
            cells[currentRow, currentColumn].BackColor = Color.White;

            // Move it upward
            if (currentRow > 0)
            {
                currentRow--;
            }
            else
            {
                timer1.Stop();
                return;
            }

            // Draw the block in its new position
            cells[currentRow, currentColumn].BackColor = Color.Black;
        }
    }
}