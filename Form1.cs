using System.Diagnostics;

namespace FindNumberWithCS
{
    public partial class Form1 : Form
    {
        private int findNumber = -1;
        private int chance = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void randomNumberGeneratorButton_Click(object sender, EventArgs e)
        {
            if (findNumber != -1)
            {
                display.Text = "�̹� ���� ���ڸ� �����߽��ϴ�.";
                return;
            }
            // ���� �ð��� �̿��Ͽ� ���� �õ带 ����
            int seed = (int)DateTime.Now.Ticks;
            Random random = new Random(seed);

            // ����: 1���� 10������ ������ ���� ����
            findNumber = random.Next(0, 101);
            chance = 10;
            display.Text = "���� ���ڸ� �Է��ϼ���.";
        }

        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void answerSubminButton_Click(object sender, EventArgs e)
        {
            if (findNumber == -1)
            {
                display.Text = "���۹�ư�� ��������!";
                return;
            }
            int inputNumber = (string.Equals(answerTextBox.Text, "")) ? -1 : Int32.Parse(answerTextBox.Text);
            if (inputNumber == -1)
            {
                display.Text = "���ڸ� �Է��ϼ���.";
                return;
            }
            chance--;
            if (inputNumber == findNumber)
            {
                display.Text = "�����Դϴ�! ���α׷��� �����մϴ�.";
                Thread.Sleep(100);
                Environment.Exit(0);
            }
            else if (chance == 0)
            {
                display.Text = "��ȸ�� ��� �����Ͽ����ϴ�. ���α׷��� �����մϴ�.";
                Environment.Exit(0);
            }
            else if (inputNumber < findNumber)
            {
                display.Text = $"Ʋ�Ƚ��ϴ�. �ش� ���ں��� Ů�ϴ�. ��ȸ�� {chance}�� ���ҽ��ϴ�.";
            }
            else if (inputNumber > findNumber)
            {
                display.Text = $"Ʋ�Ƚ��ϴ�. �ش� ���ں��� �۽��ϴ�. ��ȸ�� {chance}�� ���ҽ��ϴ�.";
            }
        }
    }
}
