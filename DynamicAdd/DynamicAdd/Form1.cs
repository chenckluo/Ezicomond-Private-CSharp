using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicAdd
{
    public partial class Form1 : Form
    {
        public Panel mainPanel = new Panel();

        public Form1()
        {
            InitializeComponent();
        }

        void FormSample_MouseWheel(object sender, MouseEventArgs e)
        {
            Point mousePoint = new Point(e.X,e.Y);
            mousePoint.Offset(this.Location.X, this.Location.Y);    
   
            if (mainPanel.RectangleToScreen(mainPanel.DisplayRectangle).Contains(mousePoint))
            {
                mainPanel.AutoScrollPosition = new Point(1, mainPanel.VerticalScroll.Value - e.Delta);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Button closeButton = new Button();
            closeButton.Text = "Close";
            closeButton.Left = 1460;
            this.Controls.Add(closeButton);
            closeButton.Click+=closeButton_Click;

            Label titleLabel = new Label();
            titleLabel.Text = "欢迎参加XXX比赛！";
            titleLabel.Top = 10;
            titleLabel.Size = new Size(300,40);
            titleLabel.Font = new Font("SimSun", 20);
            titleLabel.Left = 650;
            this.Controls.Add(titleLabel);
            
            
            mainPanel.Size=new Size(1520,800);
           // mainPanel.BackColor = Color.SeaGreen;
            mainPanel.Top = 50;
            mainPanel.Left = 10;
            mainPanel.AutoScroll = true;
            this.Controls.Add(mainPanel);


            for (int i = 0; i < 100; ++i)
            {
                Panel newPanel = new Panel();
                newPanel.Width = 1490;
                newPanel.Height = 200;
                newPanel.Top = i * 200+i*10;
                //newPanel.Left = 10;
                newPanel.BackColor = Color.AliceBlue;
                mainPanel.Controls.Add(newPanel);

                Label questionLabel = new Label();
                //questionLabel.BackColor = Color.Yellow;
                questionLabel.Text = (i + 1).ToString() + "、第" + (i + 1).ToString() + "题测试文本";
                questionLabel.Font = new Font("SimSum", 18);
                questionLabel.Left = 5;
                questionLabel.Top = 5;
                questionLabel.Size = new Size(1510, 130);
                newPanel.Controls.Add(questionLabel);

                RadioButton one = new RadioButton();
                //one.BackColor = Color.Purple;
                one.Font = new Font("SimSum", 15);
                one.Size = new Size(290, 30);
                one.Text = "测试选项1";
                one.Top = questionLabel.Top + 150;
                one.Left = questionLabel.Left;
                newPanel.Controls.Add(one);

                RadioButton two = new RadioButton();
                //two.BackColor = Color.Purple;
                two.Font = new Font("SimSum", 15);
                two.Size = new Size(290, 30);
                two.Text = "测试选项2";
                two.Top = questionLabel.Top + 150;
                two.Left = one.Left + 290 + 80;
                newPanel.Controls.Add(two);

                RadioButton three = new RadioButton();
                //three.BackColor = Color.Purple;
                three.Font = new Font("SimSum", 15);
                three.Size = new Size(290, 30);
                three.Text = "测试选项3";
                three.Top = questionLabel.Top + 150;
                three.Left = two.Left + 290 + 80;
                newPanel.Controls.Add(three);

                RadioButton four = new RadioButton();
                //four.BackColor = Color.Purple;
                four.Font = new Font("SimSum", 15);
                four.Size = new Size(290, 30);
                four.Text = "测试选项4";
                four.Top = questionLabel.Top + 150;
                four.Left = three.Left + 290 + 80;
                newPanel.Controls.Add(four);
            }

            this.MouseWheel += new MouseEventHandler(FormSample_MouseWheel);
        }

        private void closeButton_Click(object sender,EventArgs e)
        {
            this.Dispose();
        }

    }
}
