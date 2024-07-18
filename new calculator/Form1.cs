using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace new_calculator
{
    public partial class Form1 : Form
    {
        private double Value = 0; // 값 저장
        private char save = '0'; // 부호 및 부호에 따른 계산
        private bool check = false; // 처음 입력되는건지 확인용
        private String saveText = ""; // 백스페이스 쓸 때 남은 텍스트(숫자) 살리기 위해 사용

        public void intercheck(char save1) // 3 + 2 * 1 = 의 경우
        {                                  // + 에서 save1(이하 save) 은 + 저장            Value = 3
            if (save == '+' && textBox1.Text != "0")               // * 에서 save는 '+' 인채로 먼저 와서 기존의 값을 더하고 그다음에 save *로 변경       Value = 3 + 2 = 5
            {                              // 즉 사칙연산 부호를 입력 받을 때 사칙연산을 이뤄짐 그리고 입력 받은 사칙연산을 save에 저장
                Value += double.Parse(textBox1.Text);
            }
            else if (save == '-' && textBox1.Text != "0")
            {
                Value -= double.Parse(textBox1.Text);

            }
            else if (save == '*' && textBox1.Text != "0") //textBox1.Text != "0"
            {
                Value *= double.Parse(textBox1.Text);

            }
            else if (save == '/' && textBox1.Text != "0")
            {
                Value /= double.Parse(textBox1.Text);
            }
            else if (save == '0')
            {
                if (textBox1.Text.Length > 0)
                {
                    Value = double.Parse(textBox1.Text);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "1";
            else
                textBox1.Text = textBox1.Text + "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "2";
            else
                textBox1.Text = textBox1.Text + "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "3";
            else
                textBox1.Text = textBox1.Text + "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "4";
            else
                textBox1.Text = textBox1.Text + "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "5";
            else
                textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "6";
            else
                textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "7";
            else
                textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "8";
            else
                textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "9";
            else
                textBox1.Text = textBox1.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text + "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Value = 0;
            textBox1.Text = string.Join("", textBox1.Text.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0'));
            textBox2.Text = string.Join("", textBox2.Text.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0'));
            PresentValue.Text = "0";
            save = '0';
            check = false;
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            
            intercheck(save);
            PresentValue.Text = "0";
            textBox1.Text = "0";
            textBox2.Text = Value.ToString();
            Value = 0;
            save = '0';
            check = false;
           
            /*
            if (Value.ToString().Length > 0) // 결과값을 계산하고 난 값의 길이가 0보다 클 때
            {
                
            }
            */
        }
        private void buttonPlus_Click(object sender, EventArgs e)
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
        private void buttonMinus_Click(object sender, EventArgs e)
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

        private void buttonMultiply_Click(object sender, EventArgs e)
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

        private void buttonDevide_Click(object sender, EventArgs e)
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
                    button0_Click(sender, e);
                    break;
                case Keys.NumPad1:
                    button1_Click(sender, e);
                    break;
                case Keys.NumPad2:
                    button2_Click(sender, e);
                    break;
                case Keys.NumPad3:
                    button3_Click(sender, e);
                    break;
                case Keys.NumPad4:
                    button4_Click(sender, e);
                    break;
                case Keys.NumPad5:
                    button5_Click(sender, e);
                    break;
                case Keys.NumPad6:
                    button6_Click(sender, e);
                    break;
                case Keys.NumPad7:
                    button7_Click(sender, e);
                    break;
                case Keys.NumPad8:
                    button8_Click(sender, e);
                    break;
                case Keys.NumPad9:
                    button9_Click(sender, e);
                    break;
                /*
                case Keys.Enter:                                  // 엔터키, 현재 문제 있음.(1 입력으로 먼저 계산)
                    Debug.WriteLine("Enter");
                    buttonEqual_Click(sender, e);
                    break;
                */
                case Keys.Add:                                  // + 키
                    buttonPlus_Click(sender, e);
                    break;
                case Keys.Subtract:                             // - 키
                    buttonMinus_Click(sender, e);
                    break;
                case Keys.Multiply:                             // * 키
                    buttonMultiply_Click(sender, e);
                    break;
                case Keys.Divide:                               // / 키
                    buttonDevide_Click(sender, e);
                    break;
                case Keys.Back:
                    if (textBox1.Text.Length > 0)
                    {
                        saveText = textBox1.Text.ToString();
                        saveText = saveText.Substring(0, saveText.Length - 1);
                        textBox1.Text = saveText;
                    }
                    break;
                default:
                    break;
            }
        }

        
    }
}
