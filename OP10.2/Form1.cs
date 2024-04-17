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

                resultLabel.Text = $"��������� ��������� ����������: {totalCost} ������.";
            }
            catch (FormatException)
            {
                MessageBox.Show("����������, ������� ���������� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalculateCostPerMinute(string timeOfDay)
        {
            const double dayRate = 5.0;
            const double nightRate = 5.0;
            const double nightDiscount = 0.7;

            if (timeOfDay.ToLower() == "����")
            {
                return dayRate;
            }
            else if (timeOfDay.ToLower() == "����")
            {
                return nightRate * nightDiscount;
            }
            else
            {
                throw new ArgumentException("������� ������� ����� ���������. ������� '����' ��� '����'.");
            }
        }
    }
}
