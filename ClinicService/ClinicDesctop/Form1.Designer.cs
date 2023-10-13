namespace ClinicDesctop
{
    partial class mainForm
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
            listViewClients = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderSurName = new ColumnHeader();
            columnHeaderFirstName = new ColumnHeader();
            columnHeaderPatronymic = new ColumnHeader();
            columnBirthDate = new ColumnHeader();
            deleteButton = new Button();
            process1 = new System.Diagnostics.Process();
            birthdateInput = new DateTimePicker();
            nameInput = new TextBox();
            surnameInput = new TextBox();
            patronymicInput = new TextBox();
            addButton = new Button();
            documentInput = new TextBox();
            documentLabel = new Label();
            nameLabel = new Label();
            surnameLabel = new Label();
            patronomycLabel = new Label();
            birthdateLabel = new Label();
            SuspendLayout();
            // 
            // listViewClients
            // 
            listViewClients.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderSurName, columnHeaderFirstName, columnHeaderPatronymic, columnBirthDate });
            listViewClients.FullRowSelect = true;
            listViewClients.GridLines = true;
            listViewClients.Location = new Point(14, 16);
            listViewClients.Margin = new Padding(3, 4, 3, 4);
            listViewClients.MultiSelect = false;
            listViewClients.Name = "listViewClients";
            listViewClients.Size = new Size(1014, 411);
            listViewClients.TabIndex = 1;
            listViewClients.UseCompatibleStateImageBehavior = false;
            listViewClients.View = View.Details;
            listViewClients.SelectedIndexChanged += listViewClients_SelectedIndexChanged;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "#";
            // 
            // columnHeaderSurName
            // 
            columnHeaderSurName.Text = "Фамилия";
            columnHeaderSurName.Width = 150;
            // 
            // columnHeaderFirstName
            // 
            columnHeaderFirstName.Text = "Имя";
            columnHeaderFirstName.Width = 150;
            // 
            // columnHeaderPatronymic
            // 
            columnHeaderPatronymic.Text = "Отчество";
            columnHeaderPatronymic.Width = 150;
            // 
            // columnBirthDate
            // 
            columnBirthDate.Text = "Дата рождения";
            columnBirthDate.Width = 150;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(786, 435);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(242, 27);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // birthdateInput
            // 
            birthdateInput.Location = new Point(539, 461);
            birthdateInput.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            birthdateInput.Name = "birthdateInput";
            birthdateInput.Size = new Size(241, 27);
            birthdateInput.TabIndex = 6;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(146, 461);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(125, 27);
            nameInput.TabIndex = 7;
            // 
            // surnameInput
            // 
            surnameInput.Location = new Point(277, 461);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(125, 27);
            surnameInput.TabIndex = 8;
            // 
            // patronymicInput
            // 
            patronymicInput.Location = new Point(408, 461);
            patronymicInput.Name = "patronymicInput";
            patronymicInput.Size = new Size(125, 27);
            patronymicInput.TabIndex = 9;
            // 
            // addButton
            // 
            addButton.Location = new Point(786, 461);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(242, 27);
            addButton.TabIndex = 10;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_click;
            // 
            // documentInput
            // 
            documentInput.Location = new Point(15, 461);
            documentInput.Name = "documentInput";
            documentInput.Size = new Size(125, 27);
            documentInput.TabIndex = 11;
            // 
            // documentLabel
            // 
            documentLabel.AutoSize = true;
            documentLabel.Location = new Point(15, 438);
            documentLabel.Name = "documentLabel";
            documentLabel.Size = new Size(76, 20);
            documentLabel.TabIndex = 12;
            documentLabel.Text = "Документ";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(146, 438);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 20);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Имя";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(277, 438);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(73, 20);
            surnameLabel.TabIndex = 14;
            surnameLabel.Text = "Фамилия";
            // 
            // patronomycLabel
            // 
            patronomycLabel.AutoSize = true;
            patronomycLabel.Location = new Point(408, 438);
            patronomycLabel.Name = "patronomycLabel";
            patronomycLabel.Size = new Size(72, 20);
            patronomycLabel.TabIndex = 15;
            patronomycLabel.Text = "Отчество";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Location = new Point(539, 438);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new Size(116, 20);
            birthdateLabel.TabIndex = 16;
            birthdateLabel.Text = "Дата рождения";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 497);
            Controls.Add(birthdateLabel);
            Controls.Add(patronomycLabel);
            Controls.Add(surnameLabel);
            Controls.Add(nameLabel);
            Controls.Add(documentLabel);
            Controls.Add(documentInput);
            Controls.Add(addButton);
            Controls.Add(patronymicInput);
            Controls.Add(surnameInput);
            Controls.Add(nameInput);
            Controls.Add(birthdateInput);
            Controls.Add(deleteButton);
            Controls.Add(listViewClients);
            Margin = new Padding(3, 4, 3, 4);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Моя клиника";
            Load += mainForm_Update;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewClients;
        private Button btnUpdate;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderSurName;
        private ColumnHeader columnHeaderFirstName;
        private ColumnHeader columnHeaderPatronymic;
        private Button btnDelete;
        private Button deleteButton;
        private ColumnHeader columnBirthDate;
        private System.Diagnostics.Process process1;
        private TextBox surnameInput;
        private TextBox nameInput;
        private DateTimePicker birthdateInput;
        private TextBox patronymicInput;
        private Button addButton;
        private Label documentLabel;
        private TextBox documentInput;
        private Label nameLabel;
        private Label birthdateLabel;
        private Label patronomycLabel;
        private Label surnameLabel;
    }
}