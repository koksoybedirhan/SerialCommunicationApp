namespace SerialCommunication
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxRTS = new System.Windows.Forms.CheckBox();
            this.checkBoxDTR = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBAUDRATE = new System.Windows.Forms.ComboBox();
            this.comboBoxDATABITS = new System.Windows.Forms.ComboBox();
            this.comboBoxSTOPBITS = new System.Windows.Forms.ComboBox();
            this.comboBoxPARITYBITS = new System.Windows.Forms.ComboBox();
            this.comboBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.labelCOMSTATUS = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ISCLOSE = new System.Windows.Forms.Button();
            this.ISOPEN = new System.Windows.Forms.Button();
            this.SENDDATA = new System.Windows.Forms.Button();
            this.textBoxDATA = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.labelDATAOUTLENGHT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBoxWRITE = new System.Windows.Forms.CheckBox();
            this.checkBoxWRITELINE = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxUSINGENTER = new System.Windows.Forms.CheckBox();
            this.checkBoxUSINGBUTTON = new System.Windows.Forms.CheckBox();
            this.buttonCLEARDATA = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.labelDATAINLENGHT = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.checkBoxADDTOOLDDATA = new System.Windows.Forms.CheckBox();
            this.checkBoxALWAYSUPDATE = new System.Windows.Forms.CheckBox();
            this.buttonCLEARDATAIN = new System.Windows.Forms.Button();
            this.textBoxDATAIN = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_AppendOrOverwriteText = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox_WriteLineOrWrite = new System.Windows.Forms.ToolStripComboBox();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxRTS);
            this.groupBox1.Controls.Add(this.checkBoxDTR);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxBAUDRATE);
            this.groupBox1.Controls.Add(this.comboBoxDATABITS);
            this.groupBox1.Controls.Add(this.comboBoxSTOPBITS);
            this.groupBox1.Controls.Add(this.comboBoxPARITYBITS);
            this.groupBox1.Controls.Add(this.comboBoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PORT CONTROL";
            // 
            // checkBoxRTS
            // 
            this.checkBoxRTS.AutoSize = true;
            this.checkBoxRTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxRTS.Location = new System.Drawing.Point(156, 185);
            this.checkBoxRTS.Name = "checkBoxRTS";
            this.checkBoxRTS.Size = new System.Drawing.Size(60, 22);
            this.checkBoxRTS.TabIndex = 11;
            this.checkBoxRTS.Text = "RTS";
            this.checkBoxRTS.UseVisualStyleBackColor = true;
            this.checkBoxRTS.CheckedChanged += new System.EventHandler(this.checkBoxRTS_CheckedChanged);
            // 
            // checkBoxDTR
            // 
            this.checkBoxDTR.AutoSize = true;
            this.checkBoxDTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxDTR.Location = new System.Drawing.Point(30, 185);
            this.checkBoxDTR.Name = "checkBoxDTR";
            this.checkBoxDTR.Size = new System.Drawing.Size(61, 22);
            this.checkBoxDTR.TabIndex = 10;
            this.checkBoxDTR.Text = "DTR";
            this.checkBoxDTR.UseVisualStyleBackColor = true;
            this.checkBoxDTR.CheckedChanged += new System.EventHandler(this.checkBoxDTR_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM PORT";
            // 
            // comboBoxBAUDRATE
            // 
            this.comboBoxBAUDRATE.DisplayMember = "9600";
            this.comboBoxBAUDRATE.FormattingEnabled = true;
            this.comboBoxBAUDRATE.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200"});
            this.comboBoxBAUDRATE.Location = new System.Drawing.Point(125, 60);
            this.comboBoxBAUDRATE.Name = "comboBoxBAUDRATE";
            this.comboBoxBAUDRATE.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBAUDRATE.TabIndex = 4;
            this.comboBoxBAUDRATE.Tag = "";
            this.comboBoxBAUDRATE.Text = "9600";
            // 
            // comboBoxDATABITS
            // 
            this.comboBoxDATABITS.FormattingEnabled = true;
            this.comboBoxDATABITS.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.comboBoxDATABITS.Location = new System.Drawing.Point(125, 90);
            this.comboBoxDATABITS.Name = "comboBoxDATABITS";
            this.comboBoxDATABITS.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDATABITS.TabIndex = 3;
            this.comboBoxDATABITS.Text = "8";
            // 
            // comboBoxSTOPBITS
            // 
            this.comboBoxSTOPBITS.FormattingEnabled = true;
            this.comboBoxSTOPBITS.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxSTOPBITS.Location = new System.Drawing.Point(125, 120);
            this.comboBoxSTOPBITS.Name = "comboBoxSTOPBITS";
            this.comboBoxSTOPBITS.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSTOPBITS.TabIndex = 2;
            this.comboBoxSTOPBITS.Text = "1";
            // 
            // comboBoxPARITYBITS
            // 
            this.comboBoxPARITYBITS.FormattingEnabled = true;
            this.comboBoxPARITYBITS.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.comboBoxPARITYBITS.Location = new System.Drawing.Point(125, 150);
            this.comboBoxPARITYBITS.Name = "comboBoxPARITYBITS";
            this.comboBoxPARITYBITS.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPARITYBITS.TabIndex = 1;
            this.comboBoxPARITYBITS.Text = "None";
            // 
            // comboBoxCOMPORT
            // 
            this.comboBoxCOMPORT.FormattingEnabled = true;
            this.comboBoxCOMPORT.Location = new System.Drawing.Point(125, 30);
            this.comboBoxCOMPORT.Name = "comboBoxCOMPORT";
            this.comboBoxCOMPORT.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCOMPORT.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.ISCLOSE);
            this.groupBox2.Controls.Add(this.ISOPEN);
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.labelCOMSTATUS);
            this.groupBox8.Location = new System.Drawing.Point(87, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(159, 90);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "COM PORT STATUS";
            // 
            // labelCOMSTATUS
            // 
            this.labelCOMSTATUS.AutoSize = true;
            this.labelCOMSTATUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCOMSTATUS.Location = new System.Drawing.Point(43, 39);
            this.labelCOMSTATUS.Name = "labelCOMSTATUS";
            this.labelCOMSTATUS.Size = new System.Drawing.Size(62, 29);
            this.labelCOMSTATUS.TabIndex = 4;
            this.labelCOMSTATUS.Text = "OFF";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 108);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(240, 25);
            this.progressBar1.TabIndex = 2;
            // 
            // ISCLOSE
            // 
            this.ISCLOSE.Location = new System.Drawing.Point(6, 61);
            this.ISCLOSE.Name = "ISCLOSE";
            this.ISCLOSE.Size = new System.Drawing.Size(75, 43);
            this.ISCLOSE.TabIndex = 1;
            this.ISCLOSE.Text = "CLOSE";
            this.ISCLOSE.UseVisualStyleBackColor = true;
            this.ISCLOSE.Click += new System.EventHandler(this.ISCLOSE_Click);
            // 
            // ISOPEN
            // 
            this.ISOPEN.Location = new System.Drawing.Point(6, 12);
            this.ISOPEN.Name = "ISOPEN";
            this.ISOPEN.Size = new System.Drawing.Size(75, 43);
            this.ISOPEN.TabIndex = 0;
            this.ISOPEN.Text = "OPEN";
            this.ISOPEN.UseVisualStyleBackColor = true;
            this.ISOPEN.Click += new System.EventHandler(this.ISOPEN_Click);
            // 
            // SENDDATA
            // 
            this.SENDDATA.Location = new System.Drawing.Point(6, 21);
            this.SENDDATA.Name = "SENDDATA";
            this.SENDDATA.Size = new System.Drawing.Size(106, 24);
            this.SENDDATA.TabIndex = 2;
            this.SENDDATA.Text = "Send Data";
            this.SENDDATA.UseVisualStyleBackColor = true;
            this.SENDDATA.Click += new System.EventHandler(this.SENDDATA_Click);
            // 
            // textBoxDATA
            // 
            this.textBoxDATA.Font = new System.Drawing.Font("Microsoft JhengHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDATA.Location = new System.Drawing.Point(6, 21);
            this.textBoxDATA.Multiline = true;
            this.textBoxDATA.Name = "textBoxDATA";
            this.textBoxDATA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDATA.Size = new System.Drawing.Size(346, 206);
            this.textBoxDATA.TabIndex = 2;
            this.textBoxDATA.WordWrap = false;
            this.textBoxDATA.TextChanged += new System.EventHandler(this.textBoxDATA_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.textBoxDATA);
            this.groupBox3.Location = new System.Drawing.Point(276, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 388);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmitter Control";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.buttonCLEARDATA);
            this.groupBox4.Controls.Add(this.SENDDATA);
            this.groupBox4.Location = new System.Drawing.Point(6, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 151);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.labelDATAOUTLENGHT);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Location = new System.Drawing.Point(6, 103);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(322, 42);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            // 
            // labelDATAOUTLENGHT
            // 
            this.labelDATAOUTLENGHT.AutoSize = true;
            this.labelDATAOUTLENGHT.Location = new System.Drawing.Point(202, 18);
            this.labelDATAOUTLENGHT.Name = "labelDATAOUTLENGHT";
            this.labelDATAOUTLENGHT.Size = new System.Drawing.Size(21, 16);
            this.labelDATAOUTLENGHT.TabIndex = 5;
            this.labelDATAOUTLENGHT.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "DATA OUT LENGHT:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBoxWRITE);
            this.groupBox6.Controls.Add(this.checkBoxWRITELINE);
            this.groupBox6.Location = new System.Drawing.Point(234, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(112, 76);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // checkBoxWRITE
            // 
            this.checkBoxWRITE.AutoSize = true;
            this.checkBoxWRITE.Location = new System.Drawing.Point(6, 47);
            this.checkBoxWRITE.Name = "checkBoxWRITE";
            this.checkBoxWRITE.Size = new System.Drawing.Size(60, 20);
            this.checkBoxWRITE.TabIndex = 1;
            this.checkBoxWRITE.Text = "Write";
            this.checkBoxWRITE.UseVisualStyleBackColor = true;
            this.checkBoxWRITE.CheckedChanged += new System.EventHandler(this.checkBoxWRITE_CheckedChanged);
            // 
            // checkBoxWRITELINE
            // 
            this.checkBoxWRITELINE.AutoSize = true;
            this.checkBoxWRITELINE.Location = new System.Drawing.Point(6, 21);
            this.checkBoxWRITELINE.Name = "checkBoxWRITELINE";
            this.checkBoxWRITELINE.Size = new System.Drawing.Size(88, 20);
            this.checkBoxWRITELINE.TabIndex = 0;
            this.checkBoxWRITELINE.Text = "Write Line";
            this.checkBoxWRITELINE.UseVisualStyleBackColor = true;
            this.checkBoxWRITELINE.CheckedChanged += new System.EventHandler(this.checkBoxWRITELINE_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxUSINGENTER);
            this.groupBox5.Controls.Add(this.checkBoxUSINGBUTTON);
            this.groupBox5.Location = new System.Drawing.Point(112, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(116, 76);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // checkBoxUSINGENTER
            // 
            this.checkBoxUSINGENTER.AutoSize = true;
            this.checkBoxUSINGENTER.Location = new System.Drawing.Point(6, 47);
            this.checkBoxUSINGENTER.Name = "checkBoxUSINGENTER";
            this.checkBoxUSINGENTER.Size = new System.Drawing.Size(98, 20);
            this.checkBoxUSINGENTER.TabIndex = 1;
            this.checkBoxUSINGENTER.Text = "Using Enter";
            this.checkBoxUSINGENTER.UseVisualStyleBackColor = true;
            // 
            // checkBoxUSINGBUTTON
            // 
            this.checkBoxUSINGBUTTON.AutoSize = true;
            this.checkBoxUSINGBUTTON.Location = new System.Drawing.Point(6, 21);
            this.checkBoxUSINGBUTTON.Name = "checkBoxUSINGBUTTON";
            this.checkBoxUSINGBUTTON.Size = new System.Drawing.Size(104, 20);
            this.checkBoxUSINGBUTTON.TabIndex = 0;
            this.checkBoxUSINGBUTTON.Text = "Using Button";
            this.checkBoxUSINGBUTTON.UseVisualStyleBackColor = true;
            this.checkBoxUSINGBUTTON.CheckedChanged += new System.EventHandler(this.checkBoxUSINGBUTTON_CheckedChanged);
            // 
            // buttonCLEARDATA
            // 
            this.buttonCLEARDATA.Location = new System.Drawing.Point(6, 51);
            this.buttonCLEARDATA.Name = "buttonCLEARDATA";
            this.buttonCLEARDATA.Size = new System.Drawing.Size(100, 46);
            this.buttonCLEARDATA.TabIndex = 3;
            this.buttonCLEARDATA.Text = "Clear Data Out";
            this.buttonCLEARDATA.UseVisualStyleBackColor = true;
            this.buttonCLEARDATA.Click += new System.EventHandler(this.buttonCLEARDATA_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.Controls.Add(this.textBoxDATAIN);
            this.groupBox9.Location = new System.Drawing.Point(650, 14);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(365, 388);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Receiver Control";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Controls.Add(this.groupBox13);
            this.groupBox10.Controls.Add(this.buttonCLEARDATAIN);
            this.groupBox10.Location = new System.Drawing.Point(6, 233);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(352, 151);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.labelDATAINLENGHT);
            this.groupBox11.Controls.Add(this.label8);
            this.groupBox11.Location = new System.Drawing.Point(6, 103);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(322, 42);
            this.groupBox11.TabIndex = 5;
            this.groupBox11.TabStop = false;
            // 
            // labelDATAINLENGHT
            // 
            this.labelDATAINLENGHT.AutoSize = true;
            this.labelDATAINLENGHT.Location = new System.Drawing.Point(202, 18);
            this.labelDATAINLENGHT.Name = "labelDATAINLENGHT";
            this.labelDATAINLENGHT.Size = new System.Drawing.Size(21, 16);
            this.labelDATAINLENGHT.TabIndex = 5;
            this.labelDATAINLENGHT.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "DATA OUT LENGHT:";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.checkBoxADDTOOLDDATA);
            this.groupBox13.Controls.Add(this.checkBoxALWAYSUPDATE);
            this.groupBox13.Location = new System.Drawing.Point(180, 21);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(130, 81);
            this.groupBox13.TabIndex = 4;
            this.groupBox13.TabStop = false;
            // 
            // checkBoxADDTOOLDDATA
            // 
            this.checkBoxADDTOOLDDATA.AutoSize = true;
            this.checkBoxADDTOOLDDATA.Location = new System.Drawing.Point(6, 47);
            this.checkBoxADDTOOLDDATA.Name = "checkBoxADDTOOLDDATA";
            this.checkBoxADDTOOLDDATA.Size = new System.Drawing.Size(124, 20);
            this.checkBoxADDTOOLDDATA.TabIndex = 1;
            this.checkBoxADDTOOLDDATA.Text = "Add to Old Data";
            this.checkBoxADDTOOLDDATA.UseVisualStyleBackColor = true;
            this.checkBoxADDTOOLDDATA.CheckedChanged += new System.EventHandler(this.checkBoxADDTOOLDDATA_CheckedChanged);
            // 
            // checkBoxALWAYSUPDATE
            // 
            this.checkBoxALWAYSUPDATE.AutoSize = true;
            this.checkBoxALWAYSUPDATE.Location = new System.Drawing.Point(6, 21);
            this.checkBoxALWAYSUPDATE.Name = "checkBoxALWAYSUPDATE";
            this.checkBoxALWAYSUPDATE.Size = new System.Drawing.Size(120, 20);
            this.checkBoxALWAYSUPDATE.TabIndex = 0;
            this.checkBoxALWAYSUPDATE.Text = "Always Update";
            this.checkBoxALWAYSUPDATE.UseVisualStyleBackColor = true;
            this.checkBoxALWAYSUPDATE.CheckedChanged += new System.EventHandler(this.checkBoxALWAYSUPDATE_CheckedChanged);
            // 
            // buttonCLEARDATAIN
            // 
            this.buttonCLEARDATAIN.Location = new System.Drawing.Point(58, 21);
            this.buttonCLEARDATAIN.Name = "buttonCLEARDATAIN";
            this.buttonCLEARDATAIN.Size = new System.Drawing.Size(100, 81);
            this.buttonCLEARDATAIN.TabIndex = 3;
            this.buttonCLEARDATAIN.Text = "Clear Data In";
            this.buttonCLEARDATAIN.UseVisualStyleBackColor = true;
            this.buttonCLEARDATAIN.Click += new System.EventHandler(this.buttonCLEARDATAIN_Click);
            // 
            // textBoxDATAIN
            // 
            this.textBoxDATAIN.Font = new System.Drawing.Font("Microsoft JhengHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDATAIN.Location = new System.Drawing.Point(6, 21);
            this.textBoxDATAIN.Multiline = true;
            this.textBoxDATAIN.Name = "textBoxDATAIN";
            this.textBoxDATAIN.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDATAIN.Size = new System.Drawing.Size(346, 206);
            this.textBoxDATAIN.TabIndex = 4;
            this.textBoxDATAIN.WordWrap = false;
            this.textBoxDATAIN.TextChanged += new System.EventHandler(this.textBoxDATAIN_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.excelToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_AppendOrOverwriteText,
            this.toolStripComboBox_WriteLineOrWrite});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.fileToolStripMenuItem.Text = "Text";
            // 
            // toolStripComboBox_AppendOrOverwriteText
            // 
            this.toolStripComboBox_AppendOrOverwriteText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_AppendOrOverwriteText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_AppendOrOverwriteText.Items.AddRange(new object[] {
            "Append Text",
            "Overwrite Text"});
            this.toolStripComboBox_AppendOrOverwriteText.Name = "toolStripComboBox_AppendOrOverwriteText";
            this.toolStripComboBox_AppendOrOverwriteText.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox_AppendOrOverwriteText.DropDownClosed += new System.EventHandler(this.toolStripComboBox_AppendOrOverwriteText_DropDownClosed);
            // 
            // toolStripComboBox_WriteLineOrWrite
            // 
            this.toolStripComboBox_WriteLineOrWrite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_WriteLineOrWrite.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_WriteLineOrWrite.Items.AddRange(new object[] {
            "Write Line",
            "Write"});
            this.toolStripComboBox_WriteLineOrWrite.Name = "toolStripComboBox_WriteLineOrWrite";
            this.toolStripComboBox_WriteLineOrWrite.Size = new System.Drawing.Size(121, 28);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveExcelToolStripMenuItem});
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // saveExcelToolStripMenuItem
            // 
            this.saveExcelToolStripMenuItem.Name = "saveExcelToolStripMenuItem";
            this.saveExcelToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.saveExcelToolStripMenuItem.Text = "Save in Excel File";
            this.saveExcelToolStripMenuItem.Click += new System.EventHandler(this.saveExcelToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox9);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 409);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1043, 484);
            this.MinimumSize = new System.Drawing.Size(1043, 484);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SB-APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxBAUDRATE;
        private System.Windows.Forms.ComboBox comboBoxDATABITS;
        private System.Windows.Forms.ComboBox comboBoxSTOPBITS;
        private System.Windows.Forms.ComboBox comboBoxPARITYBITS;
        private System.Windows.Forms.ComboBox comboBoxCOMPORT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button SENDDATA;
        private System.Windows.Forms.Button ISCLOSE;
        private System.Windows.Forms.Button ISOPEN;
        private System.Windows.Forms.TextBox textBoxDATA;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox checkBoxRTS;
        private System.Windows.Forms.CheckBox checkBoxDTR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonCLEARDATA;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBoxUSINGENTER;
        private System.Windows.Forms.CheckBox checkBoxUSINGBUTTON;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBoxWRITE;
        private System.Windows.Forms.CheckBox checkBoxWRITELINE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDATAOUTLENGHT;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label labelCOMSTATUS;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label labelDATAINLENGHT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.CheckBox checkBoxADDTOOLDDATA;
        private System.Windows.Forms.CheckBox checkBoxALWAYSUPDATE;
        private System.Windows.Forms.Button buttonCLEARDATAIN;
        private System.Windows.Forms.TextBox textBoxDATAIN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_AppendOrOverwriteText;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_WriteLineOrWrite;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveExcelToolStripMenuItem;
    }
}

