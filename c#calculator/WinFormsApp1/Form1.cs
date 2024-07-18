namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private double Value = 0; // 값 저장
        private char save = '0'; // 부호 및 부호에 따른 계산
        private bool check = false; // 처음 입력되는건지 확인용

        public void intercheck(char save1) // 3 + 2 * 1 = 의 경우
        {                                  // + 에서 save1(이하 save) 은 + 저장            Value = 3
            if (save == '+')               // * 에서 save는 '+' 인채로 먼저 와서 기존의 값을 더하고 그다음에 save *로 변경       Value = 3 + 2 = 5
            {                              // 즉 사칙연산 부호를 입력 받을 때 사칙연산을 이뤄짐 그리고 입력 받은 사칙연산을 save에 저장
                Value += double.Parse(textBox1.Text);
            }
            else if (save == '-')
            {
                Value -= double.Parse(textBox1.Text);
                
            }
            else if (save == '*' && textBox1.Text != "0")
            {
                Value *= double.Parse(textBox1.Text);
                
            }
            else if (save == '/' && textBox1.Text != "0")
            {
                Value /= double.Parse(textBox1.Text);
            }
            else if(save == '0')
            {
                Value = double.Parse(textBox1.Text);            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "1";
            else
                textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "2";
            else
                textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "3";
            else
                textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "4";
            else
                textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "5";
            else
                textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "6";
            else
                textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "7";
            else
                textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "8";
            else
                textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "9";
            else
                textBox1.Text = textBox1.Text + "9";
        }

        private void btn0_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Value = 0;
            textBox1.Text = string.Join("", textBox1.Text.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0'));
            textBox2.Text = string.Join("", textBox2.Text.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0'));
            PresentValue.Text = "0";
            save = '0';
            check = false;
        }

        private void Equal_Label_Click(object sender, EventArgs e)
        {
            intercheck(save);
            textBox2.Text = Value.ToString();
            textBox1.Text = "0";
            Value = 0;
            check = false;
            save = '0';
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //intercheck(save);

            if (check == false && textBox1.Text != "") // 첫입력이자 입력이 부호가 아닐 때
            {
                Value += double.Parse(textBox1.Text);  // 첫 입력은 무조건 + 한다.
                check = true;                          // 이제 첫 입력이 아니라는 것을 체크
            }
            else
            {
                intercheck(save);                      //save(부호)에 따라 값을 계산 후 Value에 저장 
            }
            PresentValue.Text = Value.ToString() + " +";

            save = '+';                                // + 부호가 눌어짐을 저장 
            textBox1.Text = "0";                       //text를 0으로 초기화 
                //textBox1.Text = string.Join("", textBox1.Text.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0')); // textBox1.Text를 비우는 용도

                textBox2.Text = Value.ToString();      // 결과값을 띄움
        }

        
        private void btnMinus_Click(object sender, EventArgs e)
        {
            //intercheck(save);
            if (check == false && textBox1.Text != "")
            {
                Value += double.Parse(textBox1.Text);
                check = true;
            }
            else
                intercheck(save);
            save = '-';
            PresentValue.Text = Value.ToString() + " -";
            textBox1.Text = "0";
            //textBox1.Text = string.Join("", textBox1.Text.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0'));
            textBox2.Text = Value.ToString();
        }

        private void btnMultply_Click(object sender, EventArgs e)
        {

            if (check == false && textBox1.Text != "")
            {
                Value += double.Parse(textBox1.Text);
                check = true;
            }
           else
                intercheck(save);
            save = '*';
            PresentValue.Text = Value.ToString() + " *";
            textBox1.Text = "0";
            //textBox1.Text = string.Join("", textBox1.Text.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0'));
            textBox2.Text = Value.ToString();
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            
            if (check == false && textBox1.Text != "")
            {
                Value += double.Parse(textBox1.Text);
                check = true;
            }
            else
                intercheck(save);
            save = '/';
            PresentValue.Text = Value.ToString() + " /";
            textBox1.Text = "0";
            //textBox1.Text = string.Join("", textBox1.Text.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0'));
            textBox2.Text = Value.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) // Form1의 속성에서 기타(Misc)에서 Key_Preview = True 할 것
        {
            
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    btn0_Click_Click(sender, e);
                    break;
                case Keys.NumPad1:
                    btn1_Click_Click(sender, e);
                    break;
                case Keys.NumPad2:
                    btn2_Click_Click(sender, e);
                    break;
                case Keys.NumPad3:
                    btn3_Click_Click(sender, e);
                    break;
                case Keys.NumPad4:
                    btn4_Click_Click(sender, e);
                    break;
                case Keys.NumPad5:
                    btn5_Click_Click(sender, e);
                    break;
                case Keys.NumPad6:
                    btn6_Click_Click(sender, e);
                    break;
                case Keys.NumPad7:
                    btn7_Click_Click(sender, e);
                    break;
                case Keys.NumPad8:
                    btn8_Click_Click(sender, e);
                    break;
                case Keys.NumPad9:
                    btn9_Click_Click(sender, e);
                    break;
                case Keys.Enter:                                  // 엔터키, 현재 문제 있음.(1 입력으로 먼저 계산)
                    Equal_Label_Click(sender, e);
                    break;
                case Keys.Add:                                  // + 키
                    btnPlus_Click(sender, e);
                    break;
                case Keys.Subtract:                             // - 키
                    btnMinus_Click(sender, e);
                    break;
                case Keys.Multiply:                             // * 키
                    btnMultply_Click(sender, e);  
                    break;
                case Keys.Divide:                               // / 키
                    btnDevide_Click(sender, e);
                    break;
                case Keys.Back:
                    break;
            }
        }

        
    }
}
/*
  intercheck(save);
            textBox2.Text = Value.ToString();
            textBox1.Text = "0";
            Value = 0;
            check = false;
            save = '0';
*/

/*
 private void btnEqual_Click(object sender, EventArgs e)
        {

            intercheck(save);
            textBox2.Text = Value.ToString();
            textBox1.Text = "0";
            Value = 0;
            check = false;
            save = '0';
        }
 */