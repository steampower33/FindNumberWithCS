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
                display.Text = "이미 랜덤 숫자를 생성했습니다.";
                return;
            }
            // 현재 시간을 이용하여 랜덤 시드를 설정
            int seed = (int)DateTime.Now.Ticks;
            Random random = new Random(seed);

            // 예시: 1부터 10까지의 랜덤한 숫자 생성
            findNumber = random.Next(0, 101);
            chance = 10;
            display.Text = "맞출 숫자를 입력하세요.";
        }

        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void answerSubminButton_Click(object sender, EventArgs e)
        {
            if (findNumber == -1)
            {
                display.Text = "시작버튼을 누르세요!";
                return;
            }
            int inputNumber = (string.Equals(answerTextBox.Text, "")) ? -1 : Int32.Parse(answerTextBox.Text);
            if (inputNumber == -1)
            {
                display.Text = "숫자를 입력하세요.";
                return;
            }
            chance--;
            if (inputNumber == findNumber)
            {
                display.Text = "정답입니다! 프로그램을 종료합니다.";
                Thread.Sleep(100);
                Environment.Exit(0);
            }
            else if (chance == 0)
            {
                display.Text = "기회를 모두 소진하였습니다. 프로그램을 종료합니다.";
                Environment.Exit(0);
            }
            else if (inputNumber < findNumber)
            {
                display.Text = $"틀렸습니다. 해당 숫자보다 큽니다. 기회는 {chance}번 남았습니다.";
            }
            else if (inputNumber > findNumber)
            {
                display.Text = $"틀렸습니다. 해당 숫자보다 작습니다. 기회는 {chance}번 남았습니다.";
            }
        }
    }
}
