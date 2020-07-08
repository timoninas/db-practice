namespace CS_operator
{
    partial class Form1
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
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetDataButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.dataPerson = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPersonInfo = new System.Windows.Forms.DataGridView();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCar = new System.Windows.Forms.DataGridView();
            this.car_model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataService = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataMessage = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dataEquipment = new System.Windows.Forms.DataGridView();
            this.id_equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_maintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.address_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_with_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emei_equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message_longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message_latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(278, 60);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(103, 20);
            this.IDTextBox.TabIndex = 1;
            this.IDTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID пользователя";
            // 
            // GetDataButton
            // 
            this.GetDataButton.Location = new System.Drawing.Point(278, 86);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(103, 23);
            this.GetDataButton.TabIndex = 3;
            this.GetDataButton.Text = "Получить данные";
            this.GetDataButton.UseVisualStyleBackColor = true;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.errorLabel.Location = new System.Drawing.Point(375, 38);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(15, 13);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.Text = "O";
            // 
            // dataPerson
            // 
            this.dataPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Surname,
            this.gender});
            this.dataPerson.Location = new System.Drawing.Point(12, 38);
            this.dataPerson.Name = "dataPerson";
            this.dataPerson.Size = new System.Drawing.Size(246, 108);
            this.dataPerson.TabIndex = 5;
            this.dataPerson.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.Width = 75;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.Width = 75;
            // 
            // gender
            // 
            this.gender.HeaderText = "Пол";
            this.gender.Name = "gender";
            this.gender.Width = 50;
            // 
            // dataPersonInfo
            // 
            this.dataPersonInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPersonInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.address,
            this.phone,
            this.email});
            this.dataPersonInfo.Location = new System.Drawing.Point(13, 184);
            this.dataPersonInfo.Name = "dataPersonInfo";
            this.dataPersonInfo.Size = new System.Drawing.Size(246, 113);
            this.dataPersonInfo.TabIndex = 6;
            // 
            // address
            // 
            this.address.HeaderText = "Адрес";
            this.address.Name = "address";
            this.address.Width = 65;
            // 
            // phone
            // 
            this.phone.HeaderText = "Телефон";
            this.phone.Name = "phone";
            this.phone.Width = 65;
            // 
            // email
            // 
            this.email.HeaderText = "Почта";
            this.email.Name = "email";
            this.email.Width = 65;
            // 
            // dataCar
            // 
            this.dataCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.car_model,
            this.number,
            this.color});
            this.dataCar.Location = new System.Drawing.Point(13, 337);
            this.dataCar.Name = "dataCar";
            this.dataCar.Size = new System.Drawing.Size(246, 128);
            this.dataCar.TabIndex = 7;
            // 
            // car_model
            // 
            this.car_model.HeaderText = "Модель м.";
            this.car_model.Name = "car_model";
            this.car_model.Width = 75;
            // 
            // number
            // 
            this.number.HeaderText = "Номер";
            this.number.Name = "number";
            this.number.Width = 75;
            // 
            // color
            // 
            this.color.HeaderText = "Цвет";
            this.color.Name = "color";
            this.color.Width = 75;
            // 
            // dataService
            // 
            this.dataService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.address_service,
            this.number_car,
            this.longitude,
            this.latitude});
            this.dataService.Location = new System.Drawing.Point(13, 508);
            this.dataService.Name = "dataService";
            this.dataService.Size = new System.Drawing.Size(246, 150);
            this.dataService.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Person";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Person Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Car";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Service Center";
            // 
            // dataMessage
            // 
            this.dataMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.message,
            this.date_with_time,
            this.emei_equipment,
            this.message_longitude,
            this.message_latitude});
            this.dataMessage.Location = new System.Drawing.Point(412, 38);
            this.dataMessage.Name = "dataMessage";
            this.dataMessage.Size = new System.Drawing.Size(432, 427);
            this.dataMessage.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Message";
            // 
            // dataEquipment
            // 
            this.dataEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_equipment,
            this.emei,
            this.date_maintenance});
            this.dataEquipment.Location = new System.Drawing.Point(412, 508);
            this.dataEquipment.Name = "dataEquipment";
            this.dataEquipment.Size = new System.Drawing.Size(278, 150);
            this.dataEquipment.TabIndex = 15;
            // 
            // id_equipment
            // 
            this.id_equipment.HeaderText = "id";
            this.id_equipment.Name = "id_equipment";
            this.id_equipment.Width = 40;
            // 
            // emei
            // 
            this.emei.HeaderText = "Emei";
            this.emei.Name = "emei";
            // 
            // date_maintenance
            // 
            this.date_maintenance.HeaderText = "Дата поддержки";
            this.date_maintenance.Name = "date_maintenance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Equipment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(863, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Operator";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.Location = new System.Drawing.Point(862, 64);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(160, 25);
            this.usernameLabel.TabIndex = 18;
            this.usernameLabel.Text = "usernameLabel";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(862, 96);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(157, 25);
            this.passwordLabel.TabIndex = 19;
            this.passwordLabel.Text = "passwordLabel";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(868, 136);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 20;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // address_service
            // 
            this.address_service.HeaderText = "Адрес";
            this.address_service.Name = "address_service";
            this.address_service.Width = 67;
            // 
            // number_car
            // 
            this.number_car.HeaderText = "Номер машины";
            this.number_car.Name = "number_car";
            // 
            // longitude
            // 
            this.longitude.HeaderText = "Долгота";
            this.longitude.Name = "longitude";
            this.longitude.Width = 67;
            // 
            // latitude
            // 
            this.latitude.HeaderText = "Широта";
            this.latitude.Name = "latitude";
            this.latitude.Width = 67;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 40;
            // 
            // message
            // 
            this.message.HeaderText = "Сообщение";
            this.message.Name = "message";
            // 
            // date_with_time
            // 
            this.date_with_time.HeaderText = "Дата и время";
            this.date_with_time.Name = "date_with_time";
            this.date_with_time.Width = 120;
            // 
            // emei_equipment
            // 
            this.emei_equipment.HeaderText = "Emei Обр.";
            this.emei_equipment.Name = "emei_equipment";
            this.emei_equipment.Width = 110;
            // 
            // message_longitude
            // 
            this.message_longitude.HeaderText = "Долгота";
            this.message_longitude.Name = "message_longitude";
            // 
            // message_latitude
            // 
            this.message_latitude.HeaderText = "Широта";
            this.message_latitude.Name = "message_latitude";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 741);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataEquipment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataService);
            this.Controls.Add(this.dataCar);
            this.Controls.Add(this.dataPersonInfo);
            this.Controls.Add(this.dataPerson);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.GetDataButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetDataButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.DataGridView dataPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridView dataPersonInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridView dataCar;
        private System.Windows.Forms.DataGridView dataService;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_model;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_equipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn emei;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_maintenance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_car;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_with_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn emei_equipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn message_longitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn message_latitude;
    }
}

