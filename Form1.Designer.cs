
namespace TectClientNet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSelectFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btGetFile = new System.Windows.Forms.Button();
            this.txtPathGet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сервер";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(11, 41);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(489, 27);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "http://127.0.0.1:8081/";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(11, 116);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(349, 27);
            this.txtPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Путь к файлу";
            // 
            // btSelectFile
            // 
            this.btSelectFile.Location = new System.Drawing.Point(367, 115);
            this.btSelectFile.Name = "btSelectFile";
            this.btSelectFile.Size = new System.Drawing.Size(133, 29);
            this.btSelectFile.TabIndex = 4;
            this.btSelectFile.Text = "Выбрать файл";
            this.btSelectFile.UseVisualStyleBackColor = true;
            this.btSelectFile.Click += new System.EventHandler(this.btSelectFile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(367, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Отправить файл";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btGetFile
            // 
            this.btGetFile.Location = new System.Drawing.Point(367, 323);
            this.btGetFile.Name = "btGetFile";
            this.btGetFile.Size = new System.Drawing.Size(133, 29);
            this.btGetFile.TabIndex = 6;
            this.btGetFile.Text = "Получить файл";
            this.btGetFile.UseVisualStyleBackColor = true;
            this.btGetFile.Click += new System.EventHandler(this.btGetFile_Click);
            // 
            // txtPathGet
            // 
            this.txtPathGet.Location = new System.Drawing.Point(11, 265);
            this.txtPathGet.Name = "txtPathGet";
            this.txtPathGet.Size = new System.Drawing.Size(489, 27);
            this.txtPathGet.TabIndex = 8;
            this.txtPathGet.Text = "123.txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя файла";
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.ItemHeight = 20;
            this.lbMessages.Location = new System.Drawing.Point(15, 372);
            this.lbMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(484, 204);
            this.lbMessages.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Сообщения:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 612);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.txtPathGet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btGetFile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btSelectFile);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTTP  Клиент ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSelectFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btGetFile;
        private System.Windows.Forms.TextBox txtPathGet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbMessages;
        private System.Windows.Forms.Label label4;
    }
}

