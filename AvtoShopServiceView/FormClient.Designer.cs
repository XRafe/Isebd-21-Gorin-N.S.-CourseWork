namespace AvtoShopServiceView
{
    partial class FormClient
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelPassport = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.CheckStatusClient = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(180, 100);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(261, 100);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(116, 22);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(220, 20);
            this.textBoxFIO.TabIndex = 2;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(115, 74);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(221, 20);
            this.textBoxPhone.TabIndex = 3;
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.Location = new System.Drawing.Point(116, 48);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(220, 20);
            this.textBoxPassport.TabIndex = 4;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(76, 22);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(37, 13);
            this.labelFIO.TabIndex = 5;
            this.labelFIO.Text = "ФИО:";
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.Location = new System.Drawing.Point(12, 48);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(101, 13);
            this.labelPassport.TabIndex = 6;
            this.labelPassport.Text = "Данные паспорта:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(17, 74);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(96, 13);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "Номер телефона:";
            // 
            // CheckStatusClient
            // 
            this.CheckStatusClient.AutoSize = true;
            this.CheckStatusClient.Location = new System.Drawing.Point(12, 106);
            this.CheckStatusClient.Name = "CheckStatusClient";
            this.CheckStatusClient.Size = new System.Drawing.Size(87, 17);
            this.CheckStatusClient.TabIndex = 8;
            this.CheckStatusClient.Text = "Блокировка";
            this.CheckStatusClient.UseVisualStyleBackColor = true;
            this.CheckStatusClient.CheckedChanged += new System.EventHandler(this.CheckStatusClient_CheckedChanged);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 135);
            this.Controls.Add(this.CheckStatusClient);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelPassport);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.textBoxPassport);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormClient";
            this.Text = "Добавление клиента";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelPassport;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.CheckBox CheckStatusClient;
    }
}