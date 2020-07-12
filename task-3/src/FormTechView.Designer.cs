namespace CS_operator
{
    partial class FormTechView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeButton = new System.Windows.Forms.Button();
            this.engineLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.clutchLabel = new System.Windows.Forms.Label();
            this.doorLabel = new System.Windows.Forms.Label();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.wheelLabel = new System.Windows.Forms.Label();
            this.statusEngine = new System.Windows.Forms.Label();
            this.statusClutch = new System.Windows.Forms.Label();
            this.statusDoors = new System.Windows.Forms.Label();
            this.statusBody = new System.Windows.Forms.Label();
            this.statusWheels = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(97, 286);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(178, 47);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Хорошо";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // engineLabel
            // 
            this.engineLabel.AutoSize = true;
            this.engineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engineLabel.Location = new System.Drawing.Point(60, 90);
            this.engineLabel.Name = "engineLabel";
            this.engineLabel.Size = new System.Drawing.Size(124, 16);
            this.engineLabel.TabIndex = 1;
            this.engineLabel.Text = "Проверка мотора";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(10, 50);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(222, 16);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Технический осмотр машины";
            // 
            // clutchLabel
            // 
            this.clutchLabel.AutoSize = true;
            this.clutchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clutchLabel.Location = new System.Drawing.Point(60, 120);
            this.clutchLabel.Name = "clutchLabel";
            this.clutchLabel.Size = new System.Drawing.Size(146, 16);
            this.clutchLabel.TabIndex = 3;
            this.clutchLabel.Text = "Проверка сцепления";
            // 
            // doorLabel
            // 
            this.doorLabel.AutoSize = true;
            this.doorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doorLabel.Location = new System.Drawing.Point(60, 150);
            this.doorLabel.Name = "doorLabel";
            this.doorLabel.Size = new System.Drawing.Size(124, 16);
            this.doorLabel.TabIndex = 4;
            this.doorLabel.Text = "Проверка дверей";
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bodyLabel.Location = new System.Drawing.Point(60, 180);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(130, 16);
            this.bodyLabel.TabIndex = 5;
            this.bodyLabel.Text = "Проверка корпуса";
            // 
            // wheelLabel
            // 
            this.wheelLabel.AutoSize = true;
            this.wheelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wheelLabel.Location = new System.Drawing.Point(60, 210);
            this.wheelLabel.Name = "wheelLabel";
            this.wheelLabel.Size = new System.Drawing.Size(114, 16);
            this.wheelLabel.TabIndex = 6;
            this.wheelLabel.Text = "Проверка колес";
            // 
            // statusEngine
            // 
            this.statusEngine.AutoSize = true;
            this.statusEngine.Location = new System.Drawing.Point(216, 90);
            this.statusEngine.Name = "statusEngine";
            this.statusEngine.Size = new System.Drawing.Size(16, 13);
            this.statusEngine.TabIndex = 7;
            this.statusEngine.Text = "-1";
            // 
            // statusClutch
            // 
            this.statusClutch.AutoSize = true;
            this.statusClutch.Location = new System.Drawing.Point(219, 120);
            this.statusClutch.Name = "statusClutch";
            this.statusClutch.Size = new System.Drawing.Size(16, 13);
            this.statusClutch.TabIndex = 8;
            this.statusClutch.Text = "-1";
            // 
            // statusDoors
            // 
            this.statusDoors.AutoSize = true;
            this.statusDoors.Location = new System.Drawing.Point(219, 150);
            this.statusDoors.Name = "statusDoors";
            this.statusDoors.Size = new System.Drawing.Size(16, 13);
            this.statusDoors.TabIndex = 9;
            this.statusDoors.Text = "-1";
            // 
            // statusBody
            // 
            this.statusBody.AutoSize = true;
            this.statusBody.Location = new System.Drawing.Point(219, 180);
            this.statusBody.Name = "statusBody";
            this.statusBody.Size = new System.Drawing.Size(16, 13);
            this.statusBody.TabIndex = 10;
            this.statusBody.Text = "-1";
            // 
            // statusWheels
            // 
            this.statusWheels.AutoSize = true;
            this.statusWheels.Location = new System.Drawing.Point(219, 210);
            this.statusWheels.Name = "statusWheels";
            this.statusWheels.Size = new System.Drawing.Size(16, 13);
            this.statusWheels.TabIndex = 11;
            this.statusWheels.Text = "-1";
            // 
            // FormTechView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 371);
            this.Controls.Add(this.statusWheels);
            this.Controls.Add(this.statusBody);
            this.Controls.Add(this.statusDoors);
            this.Controls.Add(this.statusClutch);
            this.Controls.Add(this.statusEngine);
            this.Controls.Add(this.wheelLabel);
            this.Controls.Add(this.bodyLabel);
            this.Controls.Add(this.doorLabel);
            this.Controls.Add(this.clutchLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.engineLabel);
            this.Controls.Add(this.closeButton);
            this.Name = "FormTechView";
            this.Text = "Детальная информация об осмотре машины";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label engineLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label clutchLabel;
        private System.Windows.Forms.Label doorLabel;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.Label wheelLabel;
        private System.Windows.Forms.Label statusEngine;
        private System.Windows.Forms.Label statusClutch;
        private System.Windows.Forms.Label statusDoors;
        private System.Windows.Forms.Label statusBody;
        private System.Windows.Forms.Label statusWheels;
    }
}