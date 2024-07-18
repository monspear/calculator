namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private double Value = 0; // �� ����
        private char save = '0'; // ��ȣ �� ��ȣ�� ���� ���
        private bool check = false; // ó�� �ԷµǴ°��� Ȯ�ο�

        public void intercheck(char save1) // 3 + 2 * 1 = �� ���
        {                                  // + ���� save1(���� save) �� + ����            Value = 3
            if (save == '+')               // * ���� save�� '+' ��ä�� ���� �ͼ� ������ ���� ���ϰ� �״����� save *�� ����       Value = 3 + 2 = 5
            {                              // �� ��Ģ���� ��ȣ�� �Է� ���� �� ��Ģ������ �̷��� �׸��� �Է� ���� ��Ģ������ save�� ����
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

            if (check == false && textBox1.Text != "") // ù�Է����� �Է��� ��ȣ�� �ƴ� ��
            {
                Value += double.Parse(textBox1.Text);  // ù �Է��� ������ + �Ѵ�.
                check = true;                          // ���� ù �Է��� �ƴ϶�� ���� üũ
            }
            else
            {
                intercheck(save);                      //save(��ȣ)�� ���� ���� ��� �� Value�� ���� 
            }
            PresentValue.Text = Value.ToString() + " +";

            save = '+';                                // + ��ȣ�� �������� ���� 
            textBox1.Text = "0";                       //text�� 0���� �ʱ�ȭ 
                //textBox1.Text = string.Join("", textBox1.Text.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0')); // textBox1.Text�� ���� �뵵

                textBox2.Text = Value.ToString();      // ������� ���
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

        private void Form1_KeyDown(object sender, KeyEventArgs e) // Form1�� �Ӽ����� ��Ÿ(Misc)���� Key_Preview = True �� ��
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
                case Keys.Enter:                                  // ����Ű, ���� ���� ����.(1 �Է����� ���� ���)
                    Equal_Label_Click(sender, e);
                    break;
                case Keys.Add:                                  // + Ű
                    btnPlus_Click(sender, e);
                    break;
                case Keys.Subtract:                             // - Ű
                    btnMinus_Click(sender, e);
                    break;
                case Keys.Multiply:                             // * Ű
                    btnMultply_Click(sender, e);  
                    break;
                case Keys.Divide:                               // / Ű
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