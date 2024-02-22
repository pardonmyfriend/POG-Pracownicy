namespace Pracownicy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataBirthDate = new System.Windows.Forms.DateTimePicker();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.dataSalary = new System.Windows.Forms.NumericUpDown();
            this.dataPosition = new System.Windows.Forms.ComboBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.employeesList = new System.Windows.Forms.ListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSalary)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(153, 75);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(235, 26);
            this.tbLastName.TabIndex = 0;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(153, 42);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(235, 26);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imię:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data urodzenia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pensja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stanowisko:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rodzaj umowy:";
            // 
            // dataBirthDate
            // 
            this.dataBirthDate.CustomFormat = "";
            this.dataBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataBirthDate.Location = new System.Drawing.Point(153, 110);
            this.dataBirthDate.Name = "dataBirthDate";
            this.dataBirthDate.Size = new System.Drawing.Size(235, 26);
            this.dataBirthDate.TabIndex = 8;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(153, 225);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(236, 24);
            this.rb1.TabIndex = 9;
            this.rb1.TabStop = true;
            this.rb1.Text = "umowa na czas nieokreślony";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(153, 253);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(215, 24);
            this.rb2.TabIndex = 10;
            this.rb2.Text = "umowa na czas określony";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(153, 283);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(147, 24);
            this.rb3.TabIndex = 11;
            this.rb3.Text = "umowa zlecenie";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // dataSalary
            // 
            this.dataSalary.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.dataSalary.Location = new System.Drawing.Point(153, 144);
            this.dataSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.dataSalary.Name = "dataSalary";
            this.dataSalary.Size = new System.Drawing.Size(120, 26);
            this.dataSalary.TabIndex = 12;
            this.dataSalary.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // dataPosition
            // 
            this.dataPosition.ForeColor = System.Drawing.Color.LightGray;
            this.dataPosition.FormattingEnabled = true;
            this.dataPosition.Items.AddRange(new object[] {
            "Tester",
            "Projektant",
            "Inżynier",
            "Młodszy programista",
            "Starszy programista"});
            this.dataPosition.Location = new System.Drawing.Point(152, 181);
            this.dataPosition.Name = "dataPosition";
            this.dataPosition.Size = new System.Drawing.Size(236, 28);
            this.dataPosition.TabIndex = 13;
            this.dataPosition.Text = "(wybierz stanowisko)";
            this.dataPosition.DropDown += new System.EventHandler(this.dataPosition_DropDown);
            this.dataPosition.DropDownClosed += new System.EventHandler(this.dataPosition_DropDownClosed);
            this.dataPosition.Validating += new System.ComponentModel.CancelEventHandler(this.dataPosition_Validating);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnAdd);
            this.groupBox.Controls.Add(this.tbLastName);
            this.groupBox.Controls.Add(this.rb3);
            this.groupBox.Controls.Add(this.dataPosition);
            this.groupBox.Controls.Add(this.rb2);
            this.groupBox.Controls.Add(this.tbFirstName);
            this.groupBox.Controls.Add(this.rb1);
            this.groupBox.Controls.Add(this.dataSalary);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.dataBirthDate);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(420, 386);
            this.groupBox.TabIndex = 15;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Dane pracownika";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(360, 35);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(41, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 35);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(226, 413);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(175, 35);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Wczytaj";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // employeesList
            // 
            this.employeesList.FormattingEnabled = true;
            this.employeesList.HorizontalScrollbar = true;
            this.employeesList.ItemHeight = 20;
            this.employeesList.Location = new System.Drawing.Point(451, 24);
            this.employeesList.Name = "employeesList";
            this.employeesList.Size = new System.Drawing.Size(563, 424);
            this.employeesList.TabIndex = 17;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 473);
            this.Controls.Add(this.employeesList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Pracownicy";
            ((System.ComponentModel.ISupportInitialize)(this.dataSalary)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dataBirthDate;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.NumericUpDown dataSalary;
        private System.Windows.Forms.ComboBox dataPosition;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox employeesList;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

