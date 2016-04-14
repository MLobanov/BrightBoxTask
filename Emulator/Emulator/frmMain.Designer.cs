namespace Emulator
{
    partial class frmMain
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
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblServer.Location = new System.Drawing.Point(12, 9);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(182, 29);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Адрес сервера";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtServer.Location = new System.Drawing.Point(17, 41);
            this.txtServer.Name = "txtServer";
            this.txtServer.ReadOnly = true;
            this.txtServer.Size = new System.Drawing.Size(455, 35);
            this.txtServer.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Red;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheck.Location = new System.Drawing.Point(12, 82);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(460, 156);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Проверить статус";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 249);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Проверка статуса сервисов";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnCheck;
    }
}

