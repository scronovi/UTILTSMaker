using System.Windows.Forms;
using System;
using System.IO;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.RegularExpressions;
namespace UTILTSMaker;

public partial class Form1 : Form
{
    string uniqueIdProperty => uniqueIdTextBox.Text;
    string netAreaProperty => netAreaTextBox.Text;
    string netOwnerProperty => netIdTextBox.Text;
    string accountPointIDProperty => accountingPointTextBox.Text;
    string dateToProperty => dateToPicker.Value.ToString("yyyyMMddHHmm");
    string dateFromProperty => dateFromPicker.Value.ToString("yyyyMMddHHmm");
    string timeNowProperty => DateTime.Now.ToString("yyyyMMddHHmm");
    string timeNowFormatProperty => DateTime.Now.ToString("yyyyMMdd:HHmm");
    string documentTimeProperty => documentTimeFromNetTextBox.Text;
    string meteringFromProperty => meteringFrom.Text;
    string meteringToProperty => meteringTo.Text;
    string meteringTotal => meteringTotalBox.Text;
    
    public Form1()
    {
        InitializeComponent();
        uniqueIdTextBox.Text = "SEAB" + DateTime.Now.ToString("yyyyMMdd");
        
        dateFromPicker.Format = DateTimePickerFormat.Custom;
        dateFromPicker.CustomFormat = "yyyy-MM-dd HH:mm";
        dateFromPicker.ShowUpDown = false;

        dateToPicker.Format = DateTimePickerFormat.Custom;
        dateToPicker.CustomFormat = "yyyy-MM-dd HH:mm";
        dateToPicker.ShowUpDown = false;

    }
   
    private void timeSeries1_CheckedChanged(object sender, EventArgs e)
    {
        timeSeries15.Checked = false;
        meteringTo.Visible = timeSeries1.Checked;
        meteringFrom.Visible = timeSeries1.Checked;
        meteringLabel.Visible = timeSeries1.Checked;
        meteringTotalBox.Visible = timeSeries1.Checked;
        inputBox.Enabled = !timeSeries1.Checked;
    }

    private void timeSeries15_CheckedChanged(object sender, EventArgs e)
    {
        timeSeries1.Checked = false;
    }

    private void consumtionAp_CheckedChanged(object sender, EventArgs e)
    {
        productionAp.Checked = false;
    }

    private void productionAp_CheckedChanged(object sender, EventArgs e)
    { 
        consumtionAp.Checked = false;
    }

    private void createFileButton_Click(object sender, EventArgs e)
    {
        string path = outputPathTextBox.Text;

        if (path == "")
        {
            MessageBox.Show("Välj en utdata-katalog");
        }
        else
        {
            createTextFile(uniqueIdProperty, netAreaProperty, netOwnerProperty, path, dateToProperty, dateFromProperty, accountPointIDProperty, timeNowProperty, documentTimeProperty, meteringToProperty, meteringFromProperty, meteringTotal, timeNowFormatProperty);
            MessageBox.Show("Filen har skapats!");
            outputPathTextBox.Text = "";
        }
    }

    private void outputPathButton_Click(object sender, EventArgs e)
    {

        saveFileDialog1.FileName = $"UTILTS-E66-{uniqueIdProperty}-{accountPointIDProperty}-{netAreaProperty}-{netOwnerProperty}.uts";
        saveFileDialog1.DefaultExt = "uts";
        saveFileDialog1.AddExtension = true;
        
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            outputPathTextBox.Text = saveFileDialog1.FileName;
        }
    }

    private void uniqueIdTextBox_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void createTextFile(string uniqueId, string netArea, string netOwner, string path, string dateTo, string dateFrom, string accountPoint, string timeNow, string documentTime, string meteringTo, string meteringFrom, string meteringTotal, string timeNowFormat)
    {
        string metering = "";
        if (consumtionAp.Checked)
        {
            metering = "E17";
        }else if (productionAp.Checked)
        {
            metering = "E18";
        }

        string values = inputBox.Text.Trim();
        string[] valuesArray = values.Split(
            new[] { '\r', '\n', '\t'},
            StringSplitOptions.RemoveEmptyEntries
            );
        StringBuilder qtyLines = new StringBuilder();
        for (int i = 0; i < valuesArray.Length; i++)
        {
            int seq = i * 4;
            string value = valuesArray[i].Trim().Replace(',', '.');
            qtyLines.AppendLine($"SEQ++{seq}'");
            qtyLines.AppendLine($"QTY+136:{value}'");

            qtyLines.AppendLine($"SEQ++{seq + 1}'");
            qtyLines.AppendLine("QTY+136:0.00'");

            qtyLines.AppendLine($"SEQ++{seq + 2}'");
            qtyLines.AppendLine("QTY+136:0.00'");

            qtyLines.AppendLine($"SEQ++{seq + 3}'");
            qtyLines.AppendLine("QTY+136:0.00'");
        }

        if (documentTime == String.Empty)
        {
            documentTime = timeNow;
        }
        string content_timeSeries15 = $"""
                                       UNA:+.? '
                                       UNB+UNOC:3+{netOwner}:ZZ+49100:ZZ+{timeNowFormat}+{uniqueId}++23-DDQ-E66-T++1'
                                       UNH+1+UTILTS:D:02B:UN:E5SE5A'
                                       BGM+E66::260+{uniqueId}+9+AB'
                                       DTM+137:{timeNow}:203'
                                       DTM+735:?+0100:406'
                                       MKS+23+E02::260'
                                       NAD+MS+{netOwner}:SVK:260'
                                       NAD+MR+49100:SVK:260'
                                       NAD+DDQ'
                                       IDE+24+{uniqueId}U0001'
                                       LOC+172+{accountPoint}::9'
                                       LOC+239+{netArea}:SVK:260'
                                       LIN+++8716867000030:::9'
                                       DTM+324:{dateFrom}{dateTo}:719'
                                       DTM+597:{documentTime}:203'
                                       DTM+354:15:806'
                                       STS+7++E88::260'
                                       MEA+AAZ++KWH'
                                       CCI+++E12::260'
                                       CAV+{metering}::260'
                                       {qtyLines}
                                       """;
        string content_timeSeries1 = $"""
                                      UNA:+.? '
                                      UNB+UNOC:3+{netOwner}:ZZ+49100:ZZ+{timeNowFormat}+{uniqueId}++23-DDQ-E66-S++1'
                                      UNH+1+UTILTS:D:02B:UN:E5SE0A'
                                      BGM+E66::260+{uniqueId}+9+AB'
                                      DTM+137:{timeNow}:203'
                                      DTM+735:?+0100:406'
                                      MKS+23+E02::260'
                                      NAD+MR+49100:SVK:260'
                                      NAD+MS+{netOwner}:SVK:260'
                                      NAD+DDQ'
                                      IDE+24+{uniqueId}'
                                      LOC+172+{accountPoint}::9'
                                      LOC+239+{netArea}:SVK:260'
                                      LIN+++8716867000030:::9'
                                      DTM+324:{dateFrom}{dateTo}:719'
                                      DTM+597:{documentTime}:203'
                                      DTM+354:1:802'
                                      STS+7++E88::260'
                                      MEA+AAZ++KWH'
                                      CCI+++E12::260'
                                      CAV+E17::260'
                                      SEQ++1'
                                      RFF+AES:101'
                                      RFF+MG:697342847104340435'
                                      QTY+220:{meteringFrom}'
                                      DTM+597:{dateFrom}:203'
                                      CCI+++E22::260'
                                      CAV+E27::260'
                                      SEQ++2'
                                      RFF+AES:101'
                                      QTY+220:{meteringTo}'
                                      DTM+597:{dateTo}:203'
                                      CCI+++E22::260'
                                      CAV+E27::260'
                                      SEQ++3'
                                      QTY+136:{meteringTotal}'
                                      """;
        content_timeSeries15 = AddLineCountAsLastLine(content_timeSeries15, uniqueId);
        content_timeSeries1 = AddLineCountAsLastLine(content_timeSeries1, uniqueId);
        
        if (timeSeries15.Checked && !timeSeries1.Checked)
        {
            File.WriteAllText(path, content_timeSeries15);
        }else if (timeSeries1.Checked && !timeSeries15.Checked)
        {
            File.WriteAllText(path, content_timeSeries1);
        }
        else
        {
            MessageBox.Show("Välj en timserie");
        }
        
    }
    private string AddLineCountAsLastLine(string content, string uniqueId)
    {
        int lineCount = content
            .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
            .Length;

        return content + $"UNT+{lineCount - 1}+1'{Environment.NewLine}" + $"UNZ+1+{uniqueId}'";
    }
    private void UpdateMeteringTotal()
    {
        if (decimal.TryParse(meteringFrom.Text.Replace(',', '.'), out decimal from) &&
            decimal.TryParse(meteringTo.Text.Replace(',', '.'), out decimal to))
        {
            decimal total = to - from;
            meteringTotalBox.Text = total.ToString("0.##");
        }
        else
        {
            meteringTotalBox.Text = "";
        }

    }

    private void meteringFrom_TextChanged(object sender, EventArgs e)
    {
        UpdateMeteringTotal();
    }

    private void meteringTo_TextChanged(object sender, EventArgs e)
    {
        UpdateMeteringTotal();
    }
}