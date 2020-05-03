namespace KaboomInstaller
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonInstall64 = new System.Windows.Forms.Button();
            this.buttonInstall86 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBit = new System.Windows.Forms.Label();
            this.labelFolder = new System.Windows.Forms.Label();
            this.buttonHuston = new System.Windows.Forms.Button();
            this.buttonDisableBitCheck = new System.Windows.Forms.Button();
            this.buttonClean86 = new System.Windows.Forms.Button();
            this.buttonClean64 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInstall64
            // 
            this.buttonInstall64.Location = new System.Drawing.Point(12, 94);
            this.buttonInstall64.Name = "buttonInstall64";
            this.buttonInstall64.Size = new System.Drawing.Size(173, 48);
            this.buttonInstall64.TabIndex = 0;
            this.buttonInstall64.Text = "Скачать установщик Kaboom 2.0 [X64]\r\n";
            this.buttonInstall64.UseVisualStyleBackColor = true;
            this.buttonInstall64.Click += new System.EventHandler(this.ButtonInstall64_Click);
            // 
            // buttonInstall86
            // 
            this.buttonInstall86.Location = new System.Drawing.Point(191, 94);
            this.buttonInstall86.Name = "buttonInstall86";
            this.buttonInstall86.Size = new System.Drawing.Size(167, 48);
            this.buttonInstall86.TabIndex = 1;
            this.buttonInstall86.Text = "Скачать установщик Kaboom 2.0 [X86]";
            this.buttonInstall86.UseVisualStyleBackColor = true;
            this.buttonInstall86.Click += new System.EventHandler(this.ButtonInstall86_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Мы определили вашу систему:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(302, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Бит";
            // 
            // labelBit
            // 
            this.labelBit.AutoSize = true;
            this.labelBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBit.Location = new System.Drawing.Point(269, 9);
            this.labelBit.Name = "labelBit";
            this.labelBit.Size = new System.Drawing.Size(38, 20);
            this.labelBit.TabIndex = 4;
            this.labelBit.Text = "Бит";
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFolder.Location = new System.Drawing.Point(28, 44);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(56, 20);
            this.labelFolder.TabIndex = 5;
            this.labelFolder.Text = "Папка";
            // 
            // buttonHuston
            // 
            this.buttonHuston.Location = new System.Drawing.Point(12, 203);
            this.buttonHuston.Name = "buttonHuston";
            this.buttonHuston.Size = new System.Drawing.Size(346, 48);
            this.buttonHuston.TabIndex = 8;
            this.buttonHuston.Text = "Проблема осталась?";
            this.buttonHuston.UseVisualStyleBackColor = true;
            this.buttonHuston.Click += new System.EventHandler(this.ButtonHuston_Click);
            // 
            // buttonDisableBitCheck
            // 
            this.buttonDisableBitCheck.Location = new System.Drawing.Point(12, 257);
            this.buttonDisableBitCheck.Name = "buttonDisableBitCheck";
            this.buttonDisableBitCheck.Size = new System.Drawing.Size(346, 44);
            this.buttonDisableBitCheck.TabIndex = 9;
            this.buttonDisableBitCheck.Text = "Отключить проверку разрядности системы (Ахтунг!!!)";
            this.buttonDisableBitCheck.UseVisualStyleBackColor = true;
            this.buttonDisableBitCheck.Click += new System.EventHandler(this.ButtonDisableBitCheck_Click);
            // 
            // buttonClean86
            // 
            this.buttonClean86.Location = new System.Drawing.Point(191, 148);
            this.buttonClean86.Name = "buttonClean86";
            this.buttonClean86.Size = new System.Drawing.Size(167, 49);
            this.buttonClean86.TabIndex = 10;
            this.buttonClean86.Text = "Запустить очистку [X86]";
            this.buttonClean86.UseVisualStyleBackColor = true;
            this.buttonClean86.Click += new System.EventHandler(this.ButtonClean86_Click);
            // 
            // buttonClean64
            // 
            this.buttonClean64.Location = new System.Drawing.Point(12, 148);
            this.buttonClean64.Name = "buttonClean64";
            this.buttonClean64.Size = new System.Drawing.Size(173, 49);
            this.buttonClean64.TabIndex = 11;
            this.buttonClean64.Text = "Запустить очистку [X64]";
            this.buttonClean64.UseVisualStyleBackColor = true;
            this.buttonClean64.Click += new System.EventHandler(this.ButtonClean64_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 313);
            this.Controls.Add(this.buttonClean64);
            this.Controls.Add(this.buttonClean86);
            this.Controls.Add(this.buttonDisableBitCheck);
            this.Controls.Add(this.buttonHuston);
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.labelBit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInstall86);
            this.Controls.Add(this.buttonInstall64);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "KaboomCleanInstallator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInstall64;
        private System.Windows.Forms.Button buttonInstall86;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBit;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.Button buttonHuston;
        private System.Windows.Forms.Button buttonDisableBitCheck;
        private System.Windows.Forms.Button buttonClean86;
        private System.Windows.Forms.Button buttonClean64;
    }
}

