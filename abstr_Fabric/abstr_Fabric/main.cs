using abstr_Fabric.abstr_Fabric;
using System.Diagnostics;

namespace abstr_Fabric
{
    public partial class main : Form
    {
        private List<Shapes> shapes = new List<Shapes>();
        public main()
        {
            InitializeComponent();
            Color_comboBox.Items.AddRange(new[] { "Red", "Blue", "Green", "Ghost White" });
            Color_comboBox.SelectedIndex = 0;
            Color_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            Shape_comboBox.Items.AddRange(new[] { "Triangle", "Circle", "Square" });
            Shape_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            Shape_comboBox.SelectedIndex = 0;
        }


        private void Size_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Draw_btn_Click(object sender, EventArgs e)
        {


            if (int.TryParse(Size_textBox.Text, out int size))
            {
                if (size > 0)
                {


                    ShapeFactory factory = null;
                    switch (Color_comboBox.SelectedItem.ToString())
                    {
                        case "Red":
                            factory = new RedFactory(); break;
                        case "Blue":
                            factory = new BlueFactory(); break;
                        case "Ghost White":
                            factory = new GhostWhiteFactory(); break;
                        case "Green":
                            factory = new GreenFactory(); break;
                        default:
                            factory = new GreenFactory(); break;
                            break;
                    }

                    Shapes shape = null;
                    int x = X_trackBar.Value;
                    int invertedValue = Y_trackBar.Maximum - Y_trackBar.Value;
                    int y = invertedValue;
                    switch (Shape_comboBox.SelectedItem.ToString())
                    {
                        case "Circle":
                            shape = factory.CreateCircle(size, x, y);
                            Debug.WriteLine($"Size: {shape.Size}, X: {shape.X}, Y: {shape.Y}");
                            break;

                        case "Square":
                            shape = factory.CreateSquare(size, x, y);
                            Debug.WriteLine($"Size: {shape.Size}, X: {shape.X}, Y: {shape.Y}");
                            break;
                        case "Triangle":

                            shape = factory.CreateTriangle(size, x, y);
                            Debug.WriteLine($"Size: {shape.Size}, X: {shape.X}, Y: {shape.Y}");
                            break;
                    }

                    if (shape != null)
                    {
                        shapes.Add(shape);
                        Invalidate(); Invalidate();
                    }
                    else
                    {
                        MessageBox.Show("Eror: Chose shape");
                    }
                }
                else
                {
                    MessageBox.Show("Eror: enter correct size.");
                }
            }
            else
            {
                MessageBox.Show("Eror: enter number correct size.");
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);


            }
        }

       
    }
}
