namespace AirlineReservations
{
    partial class frmReservations
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
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboSeatRow = new System.Windows.Forms.ComboBox();
            this.grbSeatButtons = new System.Windows.Forms.GroupBox();
            this.radD = new System.Windows.Forms.RadioButton();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radB = new System.Windows.Forms.RadioButton();
            this.radA = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShowPassengers = new System.Windows.Forms.Button();
            this.btnSearchPassenger = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbSeatButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerBindingSource, "PassengerName", true));
            this.txtName.Location = new System.Drawing.Point(88, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 22);
            this.txtName.TabIndex = 0;
            // 
            // cboSeatRow
            // 
            this.cboSeatRow.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seatBindingSource, "SeatRow", true));
            this.cboSeatRow.FormattingEnabled = true;
            this.cboSeatRow.Location = new System.Drawing.Point(88, 74);
            this.cboSeatRow.Name = "cboSeatRow";
            this.cboSeatRow.Size = new System.Drawing.Size(121, 24);
            this.cboSeatRow.TabIndex = 1;
            // 
            // grbSeatButtons
            // 
            this.grbSeatButtons.Controls.Add(this.radD);
            this.grbSeatButtons.Controls.Add(this.radC);
            this.grbSeatButtons.Controls.Add(this.radB);
            this.grbSeatButtons.Controls.Add(this.radA);
            this.grbSeatButtons.Location = new System.Drawing.Point(88, 109);
            this.grbSeatButtons.Name = "grbSeatButtons";
            this.grbSeatButtons.Size = new System.Drawing.Size(121, 113);
            this.grbSeatButtons.TabIndex = 2;
            this.grbSeatButtons.TabStop = false;
            // 
            // radD
            // 
            this.radD.AutoSize = true;
            this.radD.Location = new System.Drawing.Point(68, 71);
            this.radD.Name = "radD";
            this.radD.Size = new System.Drawing.Size(39, 21);
            this.radD.TabIndex = 3;
            this.radD.TabStop = true;
            this.radD.Text = "D";
            this.radD.UseVisualStyleBackColor = true;
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.Location = new System.Drawing.Point(16, 71);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(38, 21);
            this.radC.TabIndex = 2;
            this.radC.TabStop = true;
            this.radC.Text = "C";
            this.radC.UseVisualStyleBackColor = true;
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.Location = new System.Drawing.Point(68, 27);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(38, 21);
            this.radB.TabIndex = 1;
            this.radB.TabStop = true;
            this.radB.Text = "B";
            this.radB.UseVisualStyleBackColor = true;
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.Location = new System.Drawing.Point(16, 27);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(38, 21);
            this.radA.TabIndex = 0;
            this.radA.TabStop = true;
            this.radA.Text = "A";
            this.radA.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(88, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Passenger";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShowPassengers
            // 
            this.btnShowPassengers.Location = new System.Drawing.Point(88, 319);
            this.btnShowPassengers.Name = "btnShowPassengers";
            this.btnShowPassengers.Size = new System.Drawing.Size(151, 34);
            this.btnShowPassengers.TabIndex = 4;
            this.btnShowPassengers.Text = "Show Passengers";
            this.btnShowPassengers.UseVisualStyleBackColor = true;
            this.btnShowPassengers.Click += new System.EventHandler(this.btnShowPassengers_Click);
            // 
            // btnSearchPassenger
            // 
            this.btnSearchPassenger.Location = new System.Drawing.Point(88, 392);
            this.btnSearchPassenger.Name = "btnSearchPassenger";
            this.btnSearchPassenger.Size = new System.Drawing.Size(151, 34);
            this.btnSearchPassenger.TabIndex = 5;
            this.btnSearchPassenger.Text = "Search Passangers";
            this.btnSearchPassenger.UseVisualStyleBackColor = true;
            this.btnSearchPassenger.Click += new System.EventHandler(this.btnSearchPassenger_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(88, 465);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 34);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Quit";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 16;
            this.lstOutput.Location = new System.Drawing.Point(303, 37);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(349, 468);
            this.lstOutput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seat:";
            // 
            // seatBindingSource
            // 
            this.seatBindingSource.DataSource = typeof(AirlineReservations.Seat);
            // 
            // passengerBindingSource
            // 
            this.passengerBindingSource.DataSource = typeof(AirlineReservations.Passenger);
            // 
            // frmReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSearchPassenger);
            this.Controls.Add(this.btnShowPassengers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbSeatButtons);
            this.Controls.Add(this.cboSeatRow);
            this.Controls.Add(this.txtName);
            this.Name = "frmReservations";
            this.Text = "Airline Reservations";
            this.Load += new System.EventHandler(this.frmReservations_Load);
            this.grbSeatButtons.ResumeLayout(false);
            this.grbSeatButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboSeatRow;
        private System.Windows.Forms.GroupBox grbSeatButtons;
        private System.Windows.Forms.RadioButton radD;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShowPassengers;
        private System.Windows.Forms.Button btnSearchPassenger;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource passengerBindingSource;
        private System.Windows.Forms.BindingSource seatBindingSource;
    }
}

