using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; //Activating IO.Ports library
using System.IO;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace SerialCommunication
{
    public partial class Form1 : Form
    {
        string dataOut; //Transmitting data
        string sendWith;
        string dataIn;
        string messageInExcel;
        string messageOutExcel;
        

        StreamWriter objStreamWriter;
        string pathFile = @"C:\Users\Lenovo\source\repos\SerialCommunication\SerialCommunication\mySourceFile\SerialData.txt";

        bool state_AppendText = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Activating COM PORT
            string[] ports = SerialPort.GetPortNames(); 
            comboBoxCOMPORT.Items.AddRange(ports);

            ISOPEN.Enabled = true;
            ISCLOSE.Enabled = false;

            checkBoxDTR.Checked = false;
            serialPort1.DtrEnable = false;
            checkBoxRTS.Checked = false;
            serialPort1.RtsEnable = false;
            SENDDATA.Enabled = false;
            checkBoxUSINGBUTTON.Checked = true;
            checkBoxUSINGENTER.Checked = false;
            checkBoxWRITE.Checked = true;
            checkBoxWRITELINE.Checked = false;
            sendWith = "Write";

            checkBoxADDTOOLDDATA.Checked = true;
            checkBoxALWAYSUPDATE.Checked = false;

            toolStripComboBox_AppendOrOverwriteText.Text = "Append Text";
            toolStripComboBox_WriteLineOrWrite.Text = "Write Line";
        }


        private void ISOPEN_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxCOMPORT.Text; //It's for open COMPORT
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBAUDRATE.Text); //It's for choose BAUD RATE
                serialPort1.DataBits = Convert.ToInt32(comboBoxDATABITS.Text); //It's for choose DATA BITS
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxSTOPBITS.Text); //It's for select stop bits
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxPARITYBITS.Text); //It's for select parity bits
                
                serialPort1.Open(); //Open the Serial port
                progressBar1.Value = 100; //If progress barr open, the bar will be 100%

                ISOPEN.Enabled = false;
                ISCLOSE.Enabled = true;
                labelCOMSTATUS.Text = "ON";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //If we get error, it will show the error
                ISOPEN.Enabled = true;
                ISCLOSE.Enabled = false;
                labelCOMSTATUS.Text = "OFF";
            }
        }

        private void ISCLOSE_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close(); //when we click the close button, it will close the Serial port
                progressBar1.Value = 0; //Progress bar will show the 0%
                ISOPEN.Enabled = true;
                ISCLOSE.Enabled = false;
                labelCOMSTATUS.Text = "OFF";
            }
        }

        private void SENDDATA_Click(object sender, EventArgs e)
        {
            messageOutExcel += dataOut;

            //When we open the serial port, if we click the send data, then it will send the data which we write in the text bar
            if (serialPort1.IsOpen)
            {
                dataOut = textBoxDATA.Text;
                if (sendWith == "Write")
                {
                    serialPort1.Write(dataOut);
                }
                if(sendWith == "WriteLine")
                {
                    serialPort1.WriteLine(dataOut);
                }
            }

            try
            {
                objStreamWriter = new StreamWriter(pathFile, state_AppendText);
                if(toolStripComboBox_WriteLineOrWrite.Text == "Write Line")
                {
                    objStreamWriter.WriteLine(dataOut);
                }
                else
                {
                    objStreamWriter.Write(dataOut + " ");
                }
                
                objStreamWriter.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void checkBoxDTR_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxDTR.Checked)
            {
                serialPort1.DtrEnable = true;
                MessageBox.Show("DTR Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void checkBoxRTS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRTS.Checked)
            {
                serialPort1.RtsEnable = true;
                MessageBox.Show("RTS Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                serialPort1.RtsEnable = false;
            }
        }

        private void buttonCLEARDATA_Click(object sender, EventArgs e)
        {
            if(textBoxDATA.Text != "")
            {
                textBoxDATA.Text = "";
            }
        }

        private void textBoxDATA_TextChanged(object sender, EventArgs e)
        {
            int dataOUTLENGHT = textBoxDATA.TextLength;
            labelDATAOUTLENGHT.Text = string.Format("{0:00}", dataOUTLENGHT);
            if(checkBoxUSINGENTER.Checked)
            {
                textBoxDATA.Text = textBoxDATA.Text.Replace(Environment.NewLine, "");
            }
        }

        private void checkBoxUSINGBUTTON_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxUSINGBUTTON.Checked)
            {
                SENDDATA.Enabled = true;
            }
            else
            {
                SENDDATA.Enabled = false;
            }
        }

        private void textBoxDATA_KeyDown(object sender, KeyEventArgs e)
        {
            if(checkBoxUSINGENTER.Checked)
            {
                if(e.KeyCode == Keys.Enter)
                {
                    if (serialPort1.IsOpen)
                    {
                        if (serialPort1.IsOpen)
                        {
                            dataOut = textBoxDATA.Text;
                            if (sendWith == "Write")
                            {
                                serialPort1.Write(dataOut);
                            }
                            if (sendWith == "WriteLine")
                            {
                                serialPort1.WriteLine(dataOut);
                            }
                        }
                    }
                }
            }
        }

        private void checkBoxWRITELINE_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxWRITELINE.Checked)
            {
                sendWith = "WriteLine";
                checkBoxWRITE.Checked = false;
                checkBoxWRITELINE.Checked = true;
            }
        }

        private void checkBoxWRITE_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWRITE.Checked)
            {
                sendWith = "Write";
                checkBoxWRITE.Checked = true;
                checkBoxWRITELINE.Checked = false;
            }
        }


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            messageInExcel += dataIn;

            int dataInLenght = dataIn.Length;
            labelDATAINLENGHT.Text = string.Format("{0:00}", dataInLenght);
            if (checkBoxALWAYSUPDATE.Checked)
            {
                textBoxDATAIN.Text = (DateTime.Now.ToString("MM:dd:hh:mm:ss:"));
                textBoxDATAIN.Text = dataIn;
            }
            else
            {
                textBoxDATAIN.Text += (DateTime.Now.ToString("MM:dd:hh:mm:ss:"));
                textBoxDATAIN.Text += dataIn;
            }

            try
            {
                objStreamWriter = new StreamWriter(pathFile, state_AppendText);
                if (toolStripComboBox_WriteLineOrWrite.Text == "Write Line")
                {
                    objStreamWriter.Write(DateTime.Now.ToString("MM:dd:hh:mm:ss:"));
                    objStreamWriter.WriteLine(dataIn);
                }
                else
                {
                    objStreamWriter.Write(DateTime.Now.ToString("MM:dd:hh:mm:ss:"));
                    objStreamWriter.Write(dataIn + " ");
                }
                objStreamWriter.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void checkBoxALWAYSUPDATE_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxALWAYSUPDATE.Checked)
            {
                checkBoxALWAYSUPDATE.Checked = true;
                checkBoxADDTOOLDDATA.Checked = false;
            }
            else
            {
                checkBoxADDTOOLDDATA.Checked = true;
            }
        }

        private void checkBoxADDTOOLDDATA_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxADDTOOLDDATA.Checked)
            {
                checkBoxADDTOOLDDATA.Checked = true;
                checkBoxALWAYSUPDATE.Checked = false;
            }
            else
            {
                checkBoxALWAYSUPDATE.Checked = true;
            }
        }

        private void buttonCLEARDATAIN_Click(object sender, EventArgs e)
        {
            if(textBoxDATAIN.Text != "")
            {
                textBoxDATAIN.Text = "";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Bedirhan", "Creator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripComboBox_AppendOrOverwriteText_DropDownClosed(object sender, EventArgs e)
        {
            if(toolStripComboBox_AppendOrOverwriteText.Text == "Append Text")
            {
                state_AppendText = true;
            }
            else
            {
                state_AppendText = false;
            }
        }

        public void WriteData()
        {
            Excel excel = new Excel(@"SerialData.xlsx", 1);

            int k = 1, l = 1;

            excel.WriteCell(0, 0, "DataIn Line");
            excel.WriteCell(0, 1, "DataOut Line");
            excel.WriteCell(k, 0, messageInExcel);
            excel.WriteCell(l, 1, messageOutExcel);

            if(serialPort1.IsOpen)
            {
                k++;
                l++;
            }

            excel.Save();
            excel.SaveAs(@"Test2.xlsx");

            excel.Close();
        }

        private void saveExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteData();
        }
    }
}
