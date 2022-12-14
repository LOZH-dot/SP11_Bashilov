using System;
using System.Windows.Forms;

namespace Ex1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            int a, b, c;

            try
            {
                a = int.Parse(ATextBox.Text);
                b = int.Parse(BTextBox.Text);
                c = int.Parse(CTextBox.Text);

                if (a <= 0 || b <= 0 || c <= 0) throw new Exception("Стороны треугольника не могут быть меньше или равны нулю!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные в поля сторон треугольника!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Triangle triangle = new Triangle(a, b, c);
            triangle.A = a;
            triangle.B = b;
            triangle.C = c;

            string result = string.Empty;

            result = triangle.ShowSides();

            result += ($"Периметр треугольника: {triangle.GetPerimeter()}\n");
            result += ($"Площадь треугольника: {triangle.GetSquare()}\n");
            result += ($"Существует ли треугольник: {triangle.Exists}\n");

            MessageBox.Show(result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
