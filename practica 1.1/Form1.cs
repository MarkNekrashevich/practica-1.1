using System;
using System.Windows.Forms;

namespace practica_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = Convert.ToDouble(textBox3.Text);

                
                double part1 = 2 * Math.Cos(x - Math.PI / 6);
                double part2 = 0.5 + Math.Pow(Math.Sin(y), 2);
                double numerator = 1 + Math.Pow(z, 2) / (3 - Math.Pow(z, 2) / 5);
                double g = part1 / part2 * numerator;

                
                label1.Text = $"g = {g:F6}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: Неверный формат числа. Пожалуйста, введите числовое значение для всех полей.Для обозначения дробных значений используйте запятую", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Здесь можете добавить инициализацию формы, если это необходимо
        }
    }
}
