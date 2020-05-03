using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KaboomInstaller
{
   // private wegotaproblem huston;
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (Environment.Is64BitOperatingSystem)
            {
                labelBit.Text = "64";
                buttonInstall86.Enabled = false;
                buttonClean86.Enabled = false;
            }
            else
            {
                labelBit.Text = "32/86";
                buttonInstall64.Enabled = false;
                buttonClean64.Enabled = false;
            }
            string path = @"C:\Kaboom 2.0";
            if (!Directory.Exists(path))
            {
                labelFolder.Text = "Папка Kaboom2 не обнаружена!";
            }
            if (Directory.Exists(path))
            {
                labelFolder.Text = "Присутствует установленная игра!";
            }
        }

        private void ButtonHuston_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ВНИМАНИЕ! АХТУНГ! ПЕРЕДАВАЯ МНЕ ВАШ ID и Пароль от TeamViewer, вы осознаёте и разрешаете мне управлять вашим компьютером. Всю ответсвенность за манипуляции вы берёте исключительно на себя! Если вы НЕ СОГЛАСНЫ с данным предупреждением - закройте приложение!");
            wegotaproblem myForm = new wegotaproblem();
            myForm.ShowDialog();
        }

        private void ButtonDisableBitCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я осознаю, что понимаю работу разрядности ОС Windows и об особенностях работы ПО под разную архитектуру. При активации этой кнопки мы не проводим технической поддержки!");
            buttonInstall86.Enabled = true;
            buttonClean86.Enabled = true;
            buttonInstall64.Enabled = true;
            buttonClean64.Enabled = true;
            buttonDisableBitCheck.Enabled = false;
            buttonDisableBitCheck.Text = "Проверка разрядности отключена!";
        }

        private void ButtonInstall64_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скачивайте приложение, запускайте и следуйте указаниям мастера. Если после очистки вы не смогли установить кабум - запустите очистку, после чего ПЕРЕЗАГРУЗИТЕ ПК и после установите кабум снова. При проблемах - нажимать на кнопку ниже.");
            System.Diagnostics.Process.Start("https://drive.google.com/uc?export=download&id=1ii0nX7AJZ60zFqhsj1_LPrkVIA7GumOj");
        }

        private void ButtonInstall86_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скачивайте приложение, запускайте и следуйте указаниям мастера. Если после очистки вы не смогли установить кабум - запустите очистку, после чего ПЕРЕЗАГРУЗИТЕ ПК и после установите кабум снова. При проблемах - нажимать на кнопку ниже.");
            System.Diagnostics.Process.Start("https://drive.google.com/uc?export=download&id=1YC8RMmcqYbjaxDokcJi1_-m2D7bqNsMV");
        }

        private void ButtonClean64_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скачивайте приложение, запускайте и следуйте указаниям мастера.");
            System.Diagnostics.Process.Start("https://drive.google.com/uc?export=download&id=1q7TXiRRKX120h1HbNebVonGz7ebCFlR8");
        }

        private void ButtonClean86_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скачивайте приложение, запускайте и следуйте указаниям мастера.");
            System.Diagnostics.Process.Start("https://drive.google.com/uc?export=download&id=1jCfyhIhJYXl0Hl2kTeckdb8oE2kc2pMA");
        }
    }
}
