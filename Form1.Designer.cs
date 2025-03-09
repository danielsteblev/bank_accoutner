namespace bank_accounter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.BIK = new System.Windows.Forms.TextBox();
            this.INN = new System.Windows.Forms.TextBox();
            this.bankName = new System.Windows.Forms.TextBox();
            this.bankNameLabel = new System.Windows.Forms.Label();
            this.INNLabel = new System.Windows.Forms.Label();
            this.BIKLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.getMoneyButton = new System.Windows.Forms.Button();
            this.getMoneyLabel = new System.Windows.Forms.TextBox();
            this.putMoneyLabel = new System.Windows.Forms.TextBox();
            this.putMoneyButton = new System.Windows.Forms.Button();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.accountOwner = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.accountOwnerLabel = new System.Windows.Forms.Label();
            this.creditLimit = new System.Windows.Forms.TextBox();
            this.comissionRate = new System.Windows.Forms.TextBox();
            this.interestRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.creditLimitLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comissionRateLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TakeCreditLabel = new System.Windows.Forms.TextBox();
            this.takeCreditButton = new System.Windows.Forms.Button();
            this.RepayCreditLabel = new System.Windows.Forms.TextBox();
            this.repayCreditButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.creditUsedLabel = new System.Windows.Forms.Label();
            this.creditInterestButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.interestRate);
            this.panel1.Controls.Add(this.comissionRate);
            this.panel1.Controls.Add(this.creditLimit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.accountOwner);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.createAccountButton);
            this.panel1.Controls.Add(this.BIK);
            this.panel1.Controls.Add(this.INN);
            this.panel1.Controls.Add(this.bankName);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 314);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "БИК";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ИНН";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название банка";
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(17, 273);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(319, 23);
            this.createAccountButton.TabIndex = 4;
            this.createAccountButton.Text = "Открыть счет";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click_1);
            // 
            // BIK
            // 
            this.BIK.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BIK.Location = new System.Drawing.Point(108, 70);
            this.BIK.Name = "BIK";
            this.BIK.Size = new System.Drawing.Size(223, 18);
            this.BIK.TabIndex = 3;
            // 
            // INN
            // 
            this.INN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.INN.Location = new System.Drawing.Point(108, 46);
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(223, 18);
            this.INN.TabIndex = 2;
            // 
            // bankName
            // 
            this.bankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bankName.Location = new System.Drawing.Point(108, 22);
            this.bankName.Name = "bankName";
            this.bankName.Size = new System.Drawing.Size(223, 18);
            this.bankName.TabIndex = 1;
            // 
            // bankNameLabel
            // 
            this.bankNameLabel.AutoSize = true;
            this.bankNameLabel.Location = new System.Drawing.Point(146, 51);
            this.bankNameLabel.Name = "bankNameLabel";
            this.bankNameLabel.Size = new System.Drawing.Size(133, 13);
            this.bankNameLabel.TabIndex = 1;
            this.bankNameLabel.Text = "Информации не найдено";
            // 
            // INNLabel
            // 
            this.INNLabel.AutoSize = true;
            this.INNLabel.Location = new System.Drawing.Point(146, 64);
            this.INNLabel.Name = "INNLabel";
            this.INNLabel.Size = new System.Drawing.Size(133, 13);
            this.INNLabel.TabIndex = 2;
            this.INNLabel.Text = "Информации не найдено";
            // 
            // BIKLabel
            // 
            this.BIKLabel.AutoSize = true;
            this.BIKLabel.Location = new System.Drawing.Point(146, 77);
            this.BIKLabel.Name = "BIKLabel";
            this.BIKLabel.Size = new System.Drawing.Size(133, 13);
            this.BIKLabel.TabIndex = 3;
            this.BIKLabel.Text = "Информации не найдено";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.creditInterestButton);
            this.panel2.Controls.Add(this.creditUsedLabel);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.RepayCreditLabel);
            this.panel2.Controls.Add(this.repayCreditButton);
            this.panel2.Controls.Add(this.TakeCreditLabel);
            this.panel2.Controls.Add(this.takeCreditButton);
            this.panel2.Controls.Add(this.interestRateLabel);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.comissionRateLabel);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.creditLimitLabel);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.accountOwnerLabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.getMoneyButton);
            this.panel2.Controls.Add(this.getMoneyLabel);
            this.panel2.Controls.Add(this.putMoneyLabel);
            this.panel2.Controls.Add(this.putMoneyButton);
            this.panel2.Controls.Add(this.balanceLabel);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.BIKLabel);
            this.panel2.Controls.Add(this.bankNameLabel);
            this.panel2.Controls.Add(this.INNLabel);
            this.panel2.Location = new System.Drawing.Point(381, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 433);
            this.panel2.TabIndex = 4;
            // 
            // getMoneyButton
            // 
            this.getMoneyButton.Location = new System.Drawing.Point(239, 283);
            this.getMoneyButton.Name = "getMoneyButton";
            this.getMoneyButton.Size = new System.Drawing.Size(187, 23);
            this.getMoneyButton.TabIndex = 13;
            this.getMoneyButton.Text = "Снять средства";
            this.getMoneyButton.UseVisualStyleBackColor = true;
            this.getMoneyButton.Click += new System.EventHandler(this.getMoneyButton_Click);
            // 
            // getMoneyLabel
            // 
            this.getMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getMoneyLabel.Location = new System.Drawing.Point(239, 259);
            this.getMoneyLabel.Name = "getMoneyLabel";
            this.getMoneyLabel.Size = new System.Drawing.Size(187, 18);
            this.getMoneyLabel.TabIndex = 12;
            // 
            // putMoneyLabel
            // 
            this.putMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.putMoneyLabel.Location = new System.Drawing.Point(18, 259);
            this.putMoneyLabel.Name = "putMoneyLabel";
            this.putMoneyLabel.Size = new System.Drawing.Size(187, 18);
            this.putMoneyLabel.TabIndex = 8;
            // 
            // putMoneyButton
            // 
            this.putMoneyButton.Location = new System.Drawing.Point(18, 283);
            this.putMoneyButton.Name = "putMoneyButton";
            this.putMoneyButton.Size = new System.Drawing.Size(187, 23);
            this.putMoneyButton.TabIndex = 11;
            this.putMoneyButton.Text = "Зачислить средства";
            this.putMoneyButton.UseVisualStyleBackColor = true;
            this.putMoneyButton.Click += new System.EventHandler(this.putMoneyButton_Click);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(162, 228);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(133, 13);
            this.balanceLabel.TabIndex = 10;
            this.balanceLabel.Text = "Информации не найдено";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Баланс:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(15, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "БИК";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(15, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "ИНН";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(15, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Название банка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(145, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "ИНФОРМАЦИЯ ПО СЧЕТУ";
            // 
            // accountOwner
            // 
            this.accountOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountOwner.Location = new System.Drawing.Point(108, 94);
            this.accountOwner.Name = "accountOwner";
            this.accountOwner.Size = new System.Drawing.Size(223, 18);
            this.accountOwner.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ФИО держателя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Держатель";
            // 
            // accountOwnerLabel
            // 
            this.accountOwnerLabel.AutoSize = true;
            this.accountOwnerLabel.Location = new System.Drawing.Point(146, 90);
            this.accountOwnerLabel.Name = "accountOwnerLabel";
            this.accountOwnerLabel.Size = new System.Drawing.Size(133, 13);
            this.accountOwnerLabel.TabIndex = 15;
            this.accountOwnerLabel.Text = "Информации не найдено";
            // 
            // creditLimit
            // 
            this.creditLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creditLimit.Location = new System.Drawing.Point(167, 118);
            this.creditLimit.Name = "creditLimit";
            this.creditLimit.Size = new System.Drawing.Size(164, 18);
            this.creditLimit.TabIndex = 10;
            // 
            // comissionRate
            // 
            this.comissionRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comissionRate.Location = new System.Drawing.Point(167, 142);
            this.comissionRate.Name = "comissionRate";
            this.comissionRate.Size = new System.Drawing.Size(164, 18);
            this.comissionRate.TabIndex = 11;
            // 
            // interestRate
            // 
            this.interestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interestRate.Location = new System.Drawing.Point(119, 166);
            this.interestRate.Name = "interestRate";
            this.interestRate.Size = new System.Drawing.Size(212, 18);
            this.interestRate.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Сумма кредитных средств";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Комиссия за снятие кредита";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Процент на кредит";
            // 
            // creditLimitLabel
            // 
            this.creditLimitLabel.AutoSize = true;
            this.creditLimitLabel.Location = new System.Drawing.Point(146, 103);
            this.creditLimitLabel.Name = "creditLimitLabel";
            this.creditLimitLabel.Size = new System.Drawing.Size(133, 13);
            this.creditLimitLabel.TabIndex = 17;
            this.creditLimitLabel.Text = "Информации не найдено";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(15, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Одобренный кредит:";
            // 
            // comissionRateLabel
            // 
            this.comissionRateLabel.AutoSize = true;
            this.comissionRateLabel.Location = new System.Drawing.Point(146, 118);
            this.comissionRateLabel.Name = "comissionRateLabel";
            this.comissionRateLabel.Size = new System.Drawing.Size(133, 13);
            this.comissionRateLabel.TabIndex = 19;
            this.comissionRateLabel.Text = "Информации не найдено";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(15, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Комиссия за снятие:";
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(146, 133);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(133, 13);
            this.interestRateLabel.TabIndex = 21;
            this.interestRateLabel.Text = "Информации не найдено";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(15, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Процент на кредит:";
            // 
            // TakeCreditLabel
            // 
            this.TakeCreditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TakeCreditLabel.Location = new System.Drawing.Point(20, 316);
            this.TakeCreditLabel.Name = "TakeCreditLabel";
            this.TakeCreditLabel.Size = new System.Drawing.Size(187, 18);
            this.TakeCreditLabel.TabIndex = 22;
            // 
            // takeCreditButton
            // 
            this.takeCreditButton.Location = new System.Drawing.Point(20, 340);
            this.takeCreditButton.Name = "takeCreditButton";
            this.takeCreditButton.Size = new System.Drawing.Size(187, 23);
            this.takeCreditButton.TabIndex = 23;
            this.takeCreditButton.Text = "Взять кредит";
            this.takeCreditButton.UseVisualStyleBackColor = true;
            this.takeCreditButton.Click += new System.EventHandler(this.takeCreditButton_Click);
            // 
            // RepayCreditLabel
            // 
            this.RepayCreditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepayCreditLabel.Location = new System.Drawing.Point(239, 316);
            this.RepayCreditLabel.Name = "RepayCreditLabel";
            this.RepayCreditLabel.Size = new System.Drawing.Size(187, 18);
            this.RepayCreditLabel.TabIndex = 24;
            // 
            // repayCreditButton
            // 
            this.repayCreditButton.Location = new System.Drawing.Point(239, 340);
            this.repayCreditButton.Name = "repayCreditButton";
            this.repayCreditButton.Size = new System.Drawing.Size(187, 23);
            this.repayCreditButton.TabIndex = 25;
            this.repayCreditButton.Text = "Частично погасить кредит";
            this.repayCreditButton.UseVisualStyleBackColor = true;
            this.repayCreditButton.Click += new System.EventHandler(this.repayCreditButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(421, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "_____________________________________________________________________";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Использованный  кредит:";
            // 
            // creditUsedLabel
            // 
            this.creditUsedLabel.AutoSize = true;
            this.creditUsedLabel.Location = new System.Drawing.Point(162, 201);
            this.creditUsedLabel.Name = "creditUsedLabel";
            this.creditUsedLabel.Size = new System.Drawing.Size(133, 13);
            this.creditUsedLabel.TabIndex = 28;
            this.creditUsedLabel.Text = "Информации не найдено";
            // 
            // creditInterestButton
            // 
            this.creditInterestButton.Location = new System.Drawing.Point(149, 385);
            this.creditInterestButton.Name = "creditInterestButton";
            this.creditInterestButton.Size = new System.Drawing.Size(187, 23);
            this.creditInterestButton.TabIndex = 29;
            this.creditInterestButton.Text = "Начислить проценты по кредиту";
            this.creditInterestButton.UseVisualStyleBackColor = true;
            this.creditInterestButton.Click += new System.EventHandler(this.creditInterestButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox bankName;
        private System.Windows.Forms.TextBox BIK;
        private System.Windows.Forms.TextBox INN;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bankNameLabel;
        private System.Windows.Forms.Label INNLabel;
        private System.Windows.Forms.Label BIKLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button putMoneyButton;
        private System.Windows.Forms.TextBox putMoneyLabel;
        private System.Windows.Forms.Button getMoneyButton;
        private System.Windows.Forms.TextBox getMoneyLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox accountOwner;
        private System.Windows.Forms.Label accountOwnerLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox interestRate;
        private System.Windows.Forms.TextBox comissionRate;
        private System.Windows.Forms.TextBox creditLimit;
        private System.Windows.Forms.TextBox TakeCreditLabel;
        private System.Windows.Forms.Button takeCreditButton;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label comissionRateLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label creditLimitLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox RepayCreditLabel;
        private System.Windows.Forms.Button repayCreditButton;
        private System.Windows.Forms.Label creditUsedLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button creditInterestButton;
    }
}

