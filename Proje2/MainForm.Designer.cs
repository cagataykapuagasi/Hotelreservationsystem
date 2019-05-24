namespace Proje2
{
    partial class MainForm
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
            this.listHotel = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.listReserve = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.listRooms = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.goBack = new System.Windows.Forms.Button();
            this.buttonGoHotel = new System.Windows.Forms.Button();
            this.panelReserve = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.labelJakuzi = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelNo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.buttonMakeReserve = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelHotelInfo = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.labelHotelStar = new System.Windows.Forms.Label();
            this.labelHotelFullness = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panelInfo.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panelReserve.SuspendLayout();
            this.panelHotelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listHotel
            // 
            this.listHotel.FormattingEnabled = true;
            this.listHotel.ItemHeight = 16;
            this.listHotel.Location = new System.Drawing.Point(107, 31);
            this.listHotel.Margin = new System.Windows.Forms.Padding(4);
            this.listHotel.Name = "listHotel";
            this.listHotel.Size = new System.Drawing.Size(323, 484);
            this.listHotel.TabIndex = 0;
            this.listHotel.SelectedIndexChanged += new System.EventHandler(this.listHotel_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 143);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Rezervasyon İptal ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(47, 218);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(176, 28);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "Bilgileri Güncelle";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(248, 11);
            this.labelText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(50, 17);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "Oteller";
            // 
            // listReserve
            // 
            this.listReserve.FormattingEnabled = true;
            this.listReserve.HorizontalScrollbar = true;
            this.listReserve.ItemHeight = 16;
            this.listReserve.Location = new System.Drawing.Point(719, 31);
            this.listReserve.Margin = new System.Windows.Forms.Padding(4);
            this.listReserve.Name = "listReserve";
            this.listReserve.Size = new System.Drawing.Size(606, 484);
            this.listReserve.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(817, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rezervasyonlarım";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "<-";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(101, 60);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(132, 22);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(101, 116);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(132, 22);
            this.textBoxSurname.TabIndex = 10;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(101, 171);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(132, 22);
            this.textBoxPhone.TabIndex = 11;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(97, 14);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(73, 17);
            this.labelUsername.TabIndex = 12;
            this.labelUsername.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Surname: ";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelInfo.Controls.Add(this.textBoxSurname);
            this.panelInfo.Controls.Add(this.label7);
            this.panelInfo.Controls.Add(this.textBoxName);
            this.panelInfo.Controls.Add(this.label6);
            this.panelInfo.Controls.Add(this.textBoxPhone);
            this.panelInfo.Controls.Add(this.label5);
            this.panelInfo.Controls.Add(this.buttonInfo);
            this.panelInfo.Controls.Add(this.labelUsername);
            this.panelInfo.Location = new System.Drawing.Point(1465, 28);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(267, 268);
            this.panelInfo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(684, 228);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "->";
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.listRooms);
            this.panelUser.Controls.Add(this.label14);
            this.panelUser.Controls.Add(this.goBack);
            this.panelUser.Controls.Add(this.buttonGoHotel);
            this.panelUser.Controls.Add(this.panelReserve);
            this.panelUser.Controls.Add(this.label9);
            this.panelUser.Controls.Add(this.panelHotelInfo);
            this.panelUser.Controls.Add(this.listReserve);
            this.panelUser.Controls.Add(this.listHotel);
            this.panelUser.Controls.Add(this.label3);
            this.panelUser.Controls.Add(this.button2);
            this.panelUser.Controls.Add(this.label2);
            this.panelUser.Controls.Add(this.labelText);
            this.panelUser.Location = new System.Drawing.Point(57, 28);
            this.panelUser.Margin = new System.Windows.Forms.Padding(4);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(1400, 602);
            this.panelUser.TabIndex = 18;
            this.panelUser.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUser_Paint);
            // 
            // listRooms
            // 
            this.listRooms.FormattingEnabled = true;
            this.listRooms.ItemHeight = 16;
            this.listRooms.Location = new System.Drawing.Point(107, 31);
            this.listRooms.Margin = new System.Windows.Forms.Padding(4);
            this.listRooms.Name = "listRooms";
            this.listRooms.Size = new System.Drawing.Size(323, 484);
            this.listRooms.TabIndex = 25;
            this.listRooms.Visible = false;
            this.listRooms.SelectedIndexChanged += new System.EventHandler(this.listRooms_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(448, 37);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "<-";
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(475, 31);
            this.goBack.Margin = new System.Windows.Forms.Padding(4);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(100, 28);
            this.goBack.TabIndex = 23;
            this.goBack.Text = "Geri";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Visible = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // buttonGoHotel
            // 
            this.buttonGoHotel.Location = new System.Drawing.Point(477, 86);
            this.buttonGoHotel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGoHotel.Name = "buttonGoHotel";
            this.buttonGoHotel.Size = new System.Drawing.Size(204, 28);
            this.buttonGoHotel.TabIndex = 21;
            this.buttonGoHotel.Text = "Otele Git";
            this.buttonGoHotel.UseVisualStyleBackColor = true;
            this.buttonGoHotel.Click += new System.EventHandler(this.buttonGoHotel_Click);
            // 
            // panelReserve
            // 
            this.panelReserve.Controls.Add(this.radioButton3);
            this.panelReserve.Controls.Add(this.radioButton2);
            this.panelReserve.Controls.Add(this.radioButton1);
            this.panelReserve.Controls.Add(this.label19);
            this.panelReserve.Controls.Add(this.labelJakuzi);
            this.panelReserve.Controls.Add(this.labelPrice);
            this.panelReserve.Controls.Add(this.label22);
            this.panelReserve.Controls.Add(this.label15);
            this.panelReserve.Controls.Add(this.label12);
            this.panelReserve.Controls.Add(this.labelNo);
            this.panelReserve.Controls.Add(this.label11);
            this.panelReserve.Controls.Add(this.labelFloor);
            this.panelReserve.Controls.Add(this.buttonMakeReserve);
            this.panelReserve.Controls.Add(this.label18);
            this.panelReserve.Controls.Add(this.textBoxEnd);
            this.panelReserve.Controls.Add(this.textBoxStart);
            this.panelReserve.Location = new System.Drawing.Point(443, 276);
            this.panelReserve.Margin = new System.Windows.Forms.Padding(4);
            this.panelReserve.Name = "panelReserve";
            this.panelReserve.Size = new System.Drawing.Size(267, 304);
            this.panelReserve.TabIndex = 19;
            this.panelReserve.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(152, 165);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 17);
            this.label19.TabIndex = 26;
            this.label19.Text = "Jakuzi:";
            // 
            // labelJakuzi
            // 
            this.labelJakuzi.AutoSize = true;
            this.labelJakuzi.Location = new System.Drawing.Point(207, 165);
            this.labelJakuzi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJakuzi.Name = "labelJakuzi";
            this.labelJakuzi.Size = new System.Drawing.Size(41, 17);
            this.labelJakuzi.TabIndex = 25;
            this.labelJakuzi.Text = "Hayır";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(192, 133);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(16, 17);
            this.labelPrice.TabIndex = 24;
            this.labelPrice.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(152, 133);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 17);
            this.label22.TabIndex = 23;
            this.label22.Text = "Ücret:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 165);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "No:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 91);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Bitiş Tarihi:";
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.Location = new System.Drawing.Point(81, 165);
            this.labelNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(16, 17);
            this.labelNo.TabIndex = 7;
            this.labelNo.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Başlangıç Tarihi:";
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Location = new System.Drawing.Point(81, 133);
            this.labelFloor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(16, 17);
            this.labelFloor.TabIndex = 6;
            this.labelFloor.Text = "0";
            // 
            // buttonMakeReserve
            // 
            this.buttonMakeReserve.Location = new System.Drawing.Point(34, 252);
            this.buttonMakeReserve.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMakeReserve.Name = "buttonMakeReserve";
            this.buttonMakeReserve.Size = new System.Drawing.Size(204, 28);
            this.buttonMakeReserve.TabIndex = 21;
            this.buttonMakeReserve.Text = "Rezervasyon Yap";
            this.buttonMakeReserve.UseVisualStyleBackColor = true;
            this.buttonMakeReserve.Click += new System.EventHandler(this.buttonMakeReserve_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 133);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 17);
            this.label18.TabIndex = 5;
            this.label18.Text = "Kat:";
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(128, 87);
            this.textBoxEnd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(132, 22);
            this.textBoxEnd.TabIndex = 1;
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(128, 33);
            this.textBoxStart.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(132, 22);
            this.textBoxStart.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(689, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "->";
            // 
            // panelHotelInfo
            // 
            this.panelHotelInfo.Controls.Add(this.label10);
            this.panelHotelInfo.Controls.Add(this.labelHotelStar);
            this.panelHotelInfo.Controls.Add(this.labelHotelFullness);
            this.panelHotelInfo.Controls.Add(this.label4);
            this.panelHotelInfo.Location = new System.Drawing.Point(488, 192);
            this.panelHotelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelHotelInfo.Name = "panelHotelInfo";
            this.panelHotelInfo.Size = new System.Drawing.Size(179, 76);
            this.panelHotelInfo.TabIndex = 19;
            this.panelHotelInfo.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 47);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Yıldız:";
            // 
            // labelHotelStar
            // 
            this.labelHotelStar.AutoSize = true;
            this.labelHotelStar.Location = new System.Drawing.Point(107, 47);
            this.labelHotelStar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHotelStar.Name = "labelHotelStar";
            this.labelHotelStar.Size = new System.Drawing.Size(16, 17);
            this.labelHotelStar.TabIndex = 3;
            this.labelHotelStar.Text = "0";
            // 
            // labelHotelFullness
            // 
            this.labelHotelFullness.AutoSize = true;
            this.labelHotelFullness.Location = new System.Drawing.Point(107, 15);
            this.labelHotelFullness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHotelFullness.Name = "labelHotelFullness";
            this.labelHotelFullness.Size = new System.Drawing.Size(16, 17);
            this.labelHotelFullness.TabIndex = 1;
            this.labelHotelFullness.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doluluk: ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 218);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 21);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tekli";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(107, 218);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 21);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.Text = "İkili";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(181, 218);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 21);
            this.radioButton3.TabIndex = 29;
            this.radioButton3.Text = "Üçlü";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 767);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelReserve.ResumeLayout(false);
            this.panelReserve.PerformLayout();
            this.panelHotelInfo.ResumeLayout(false);
            this.panelHotelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listHotel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.ListBox listReserve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelHotelInfo;
        private System.Windows.Forms.Label labelHotelStar;
        private System.Windows.Forms.Label labelHotelFullness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelReserve;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonMakeReserve;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Button buttonGoHotel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelJakuzi;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox listRooms;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}