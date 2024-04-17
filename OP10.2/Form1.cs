using System;
using System.Windows.Forms;

namespace InternationalCallCostCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int duration = int.Parse(durationTextBox.Text);
                string timeOfDay = timeOfDayComboBox.Text;

                double costPerMinute = CalculateCostPerMinute(timeOfDay);
                double totalCost = duration * costPerMinute;

                resultLabel.Text = $"Стоимость разговора составляет: {totalCost} рублей.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalculateCostPerMinute(string timeOfDay)
        {
            const double dayRate = 5.0;
            const double nightRate = 5.0;
            const double nightDiscount = 0.7;

            if (timeOfDay.ToLower() == "день")
            {
                return dayRate;
            }
            else if (timeOfDay.ToLower() == "ночь")
            {
                return nightRate * nightDiscount;
            }
            else
            {
                throw new ArgumentException("Неверно указано время разговора. Введите 'день' или 'ночь'.");
            }
        }
    }
}
