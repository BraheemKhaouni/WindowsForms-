using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Task
{

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        int TaskTime,TaskTimeADD;
        void ShowAllPictures()
        {
            PB1.Visible = true;
            PB2.Visible = true;
            PB3.Visible = true;
            PB4.Visible = true;
            PB5.Visible = true;
            PB6.Visible = true;
            PB7.Visible = true;
            PB8.Visible = true;
            PB9.Visible = true;
        }
        void ShowAllLables()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
        }
        void VisibleAllPictures()
        {
            PB1.Visible = false;
            PB2.Visible = false;
            PB3.Visible = false;
            PB4.Visible = false;
            PB5.Visible = false;
            PB6.Visible = false;
            PB7.Visible = false;
            PB8.Visible = false;
            PB9.Visible = false;
        }
        void VisibleAllLables()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
        }
        void VisibleAllPboxAndLables()
        {
            VisibleAllPictures();
            VisibleAllLables();
        }
        void ShowAllPboxAndLables()
        {
            ShowAllPictures();
            ShowAllLables();
        }

        void ShowADDtask()
        {
            tbADDTimer.Visible = true;
            pbAddNew.Visible = true;
            btnStarADD.Visible = true;
            lblADDtime.Visible = true;
            gbAddNEW.Visible = true;
            lblTimerAdd.Visible = true;
            btnCancel.Visible = true;

        }
        void ShowTaskAdd()
        {
            if(timer1.Enabled==true)
            {
                MessageBox.Show("Sorry, You Cant Work On To Taskes In The Same Time\nYou Have End The Task And Try Again","Wrong",MessageBoxButtons.OK, MessageBoxIcon.Hand);   
            }
            else
            {
               
                VisibleAllPboxAndLables();
                VisibleBTNSAndLablesForTask();
                returnPictureLoctaion();
                ShowADDtask();
                

                
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowTaskAdd();
        }
      
        private void btnSetting_Click(object sender, EventArgs e)
        {
            
        }


        private void btnShere_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form About = new About();
            About.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void ChangePictureLoctaion(PictureBox PBOX)
        {
            PBOX.Location = new Point(283, 17);
        }
        void ShowPictureLocationWhenTaskStar(PictureBox PBOX)
        {
            PBOX.Visible= true;
        }
        void returnPictureLoctaion()
        {
            PB1.Location = new Point(49, 17);
            PB2.Location = new Point(283, 17);
            PB3.Location = new Point(507, 11);
            PB4.Location = new Point(49, 188);
            PB5.Location = new Point(283, 188);
            PB6.Location = new Point(507, 188);
            PB7.Location = new Point(49, 358);
            PB8.Location = new Point(283, 358);
            PB9.Location = new Point(507, 358);

        }
        void ShowVisibleBTNSAndLablesForTask()
        {
            btnStop.Visible= true;
            btnRusem.Visible= true;
            btnEnd.Visible= true;
            lblTimer.Visible= true;
        }
        void VisibleBTNSAndLablesForTask()
        {
            btnStop.Visible = false;
            btnRusem.Visible = false;
            btnEnd.Visible = false;
            lblTimer.Visible = false;
        }

        void TaskBegin(PictureBox Pbox)
        {
            timer1.Enabled= true;
            TaskTime = int.Parse(Pbox.Tag.ToString());

        }

       
        private void PB1_Click(object sender, EventArgs e)
        {
            VisibleAllPboxAndLables();
            ChangePictureLoctaion(PB1);
            ShowPictureLocationWhenTaskStar(PB1);
            ShowVisibleBTNSAndLablesForTask();
            TaskBegin(PB1);

        }

        private void PB2_Click(object sender, EventArgs e)
        {
            VisibleAllPboxAndLables();
            ChangePictureLoctaion(PB2);
            ShowPictureLocationWhenTaskStar(PB2);
            ShowVisibleBTNSAndLablesForTask();
            TaskBegin(PB2);
        }

        private void PB3_Click(object sender, EventArgs e)
        {
            VisibleAllPboxAndLables();
            ChangePictureLoctaion(PB3);
            ShowPictureLocationWhenTaskStar(PB3);
            ShowVisibleBTNSAndLablesForTask();
            TaskBegin(PB3);
        }

        private void PB4_Click(object sender, EventArgs e)
        {
            VisibleAllPboxAndLables();
            ChangePictureLoctaion(PB4);
            ShowPictureLocationWhenTaskStar(PB4);
            ShowVisibleBTNSAndLablesForTask();
            TaskBegin(PB4);
        }

        private void PB5_Click(object sender, EventArgs e)
        {
            VisibleAllPboxAndLables();
            ChangePictureLoctaion(PB5);
            ShowPictureLocationWhenTaskStar(PB5);
            ShowVisibleBTNSAndLablesForTask();
            TaskBegin(PB5);
        }

        private void PB6_Click(object sender, EventArgs e)
        {
            VisibleAllPboxAndLables();
            ChangePictureLoctaion(PB6);
            ShowPictureLocationWhenTaskStar(PB6);
            ShowVisibleBTNSAndLablesForTask();
            TaskBegin(PB6);
        }

        private void PB7_Click(object sender, EventArgs e)
        {
            VisibleAllPboxAndLables();
            ChangePictureLoctaion(PB7);
            ShowPictureLocationWhenTaskStar(PB7);
            ShowVisibleBTNSAndLablesForTask();
            TaskBegin(PB7);
        }

        private void PB8_Click(object sender, EventArgs e)
        {
            VisibleAllPboxAndLables();
            ChangePictureLoctaion(PB8);
            ShowPictureLocationWhenTaskStar(PB8);
            ShowVisibleBTNSAndLablesForTask();
            TaskBegin(PB8);
        }

        private void PB9_Click(object sender, EventArgs e)
        {
            VisibleAllPboxAndLables();
            ChangePictureLoctaion(PB9);
            ShowPictureLocationWhenTaskStar(PB9);
            ShowVisibleBTNSAndLablesForTask();
            TaskBegin(PB9);
        }
        void ShowHappyPic()
        {
            Form HappyF=new HappyForm();
            HappyF.ShowDialog();
        }
        void SendNotification()
        {
            
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "End";
            notifyIcon1.BalloonTipText = "Your Time Is Finish";
            notifyIcon1.ShowBalloonTip(1000);
            ShowHappyPic();
            UpdateTimer();
           



        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TaskTime--;
            lblTimer.Text=TaskTime.ToString();
            if(TaskTime==0)
            {

                timer1.Enabled = false;
                SendNotification();

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            timer1.Stop();
        }

        private void btnRusem_Click(object sender, EventArgs e)
        {
            if(TaskTime==0)
            {
                MessageBox.Show("Time Is Finish,You Have Create New Task","Wrong",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                timer1.Start();
            }
        }
        void UpdateTimer()
        {
            tbADDTimer.Text = "";
            lblTimer.Text = "00:00";
            lblTimerAdd.Text = "00:00";
            timer1.Enabled = false;
            timer2.Enabled = false;
            TaskTime = 0;
            TaskTimeADD = 0;
        }
        void EndTask()
        {
            UpdateTimer();
            ShowAllPboxAndLables();
            VisibleBTNSAndLablesForTask();
            returnPictureLoctaion();


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TaskTimeADD--;
            lblTimerAdd.Text=TaskTimeADD.ToString();
            if(TaskTimeADD==0)
            {
                SendNotification();
            }
        }

        private void btnStarADD_Click(object sender, EventArgs e)
        {
            if(tbADDTimer.Text=="")
            {
                MessageBox.Show("Please Enter Time", "wrong",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
            else
            {
                timer2.Enabled = true;
                TaskTimeADD = int.Parse(tbADDTimer.Text.ToString());
            }
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateTimer();
            ShowAllPboxAndLables();
            gbAddNEW.Visible = false;
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            Form Note = new Note();
            Note.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
          DialogResult Answer=  MessageBox.Show("Are You Sure You Want To End This Task ? ", "End", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(Answer==DialogResult.Yes)
            {

                EndTask();
            }

        }
    }
}
