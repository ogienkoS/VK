namespace VkAPITutorial
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
            this.label1 = new System.Windows.Forms.Label();
            this.User_Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.User_Surname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_GetToken = new System.Windows.Forms.Button();
            this.User_City = new System.Windows.Forms.Label();
            this.User_Country = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User_ID = new System.Windows.Forms.TextBox();
            this.Button_GetInformation = new System.Windows.Forms.Button();
            this.User_Photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.User_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // User_Name
            // 
            this.User_Name.AutoSize = true;
            this.User_Name.Location = new System.Drawing.Point(302, 24);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(0, 13);
            this.User_Name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия:";
            // 
            // User_Surname
            // 
            this.User_Surname.AutoSize = true;
            this.User_Surname.Location = new System.Drawing.Point(329, 46);
            this.User_Surname.Name = "User_Surname";
            this.User_Surname.Size = new System.Drawing.Size(0, 13);
            this.User_Surname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Город:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Страна:";
            // 
            // Button_GetToken
            // 
            this.Button_GetToken.Location = new System.Drawing.Point(265, 118);
            this.Button_GetToken.Name = "Button_GetToken";
            this.Button_GetToken.Size = new System.Drawing.Size(106, 23);
            this.Button_GetToken.TabIndex = 6;
            this.Button_GetToken.Text = "Получить токен";
            this.Button_GetToken.UseVisualStyleBackColor = true;
            this.Button_GetToken.Click += new System.EventHandler(this.Button_GetToken_Click);
            // 
            // User_City
            // 
            this.User_City.AutoSize = true;
            this.User_City.Location = new System.Drawing.Point(309, 68);
            this.User_City.Name = "User_City";
            this.User_City.Size = new System.Drawing.Size(0, 13);
            this.User_City.TabIndex = 7;
            // 
            // User_Country
            // 
            this.User_Country.AutoSize = true;
            this.User_Country.Location = new System.Drawing.Point(315, 91);
            this.User_Country.Name = "User_Country";
            this.User_Country.Size = new System.Drawing.Size(0, 13);
            this.User_Country.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID пользователя:";
            // 
            // User_ID
            // 
            this.User_ID.Location = new System.Drawing.Point(572, 21);
            this.User_ID.Name = "User_ID";
            this.User_ID.Size = new System.Drawing.Size(118, 20);
            this.User_ID.TabIndex = 10;
            // 
            // Button_GetInformation
            // 
            this.Button_GetInformation.Location = new System.Drawing.Point(474, 46);
            this.Button_GetInformation.Name = "Button_GetInformation";
            this.Button_GetInformation.Size = new System.Drawing.Size(138, 23);
            this.Button_GetInformation.TabIndex = 11;
            this.Button_GetInformation.Text = "Получить информацию";
            this.Button_GetInformation.UseVisualStyleBackColor = true;
            // 
            // User_Photo
            // 
            this.User_Photo.Location = new System.Drawing.Point(12, 9);
            this.User_Photo.Name = "User_Photo";
            this.User_Photo.Size = new System.Drawing.Size(218, 241);
            this.User_Photo.TabIndex = 12;
            this.User_Photo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 271);
            this.Controls.Add(this.User_Photo);
            this.Controls.Add(this.Button_GetInformation);
            this.Controls.Add(this.User_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.User_Country);
            this.Controls.Add(this.User_City);
            this.Controls.Add(this.Button_GetToken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.User_Surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.User_Name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
           
            ((System.ComponentModel.ISupportInitialize)(this.User_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label User_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label User_Surname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_GetToken;
        private System.Windows.Forms.Label User_City;
        private System.Windows.Forms.Label User_Country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox User_ID;
        private System.Windows.Forms.Button Button_GetInformation;
        private System.Windows.Forms.PictureBox User_Photo;
    }
}

