namespace UTILTSMaker;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        inputBox = new System.Windows.Forms.TextBox();
        uniqueIdTextBox = new System.Windows.Forms.TextBox();
        dateFromPicker = new System.Windows.Forms.DateTimePicker();
        uniqueIdLabel = new System.Windows.Forms.Label();
        dateFromLabel = new System.Windows.Forms.Label();
        dateToLabel = new System.Windows.Forms.Label();
        dateToPicker = new System.Windows.Forms.DateTimePicker();
        timeSeries1 = new System.Windows.Forms.CheckBox();
        timeSeries15 = new System.Windows.Forms.CheckBox();
        consumtionAp = new System.Windows.Forms.CheckBox();
        productionAp = new System.Windows.Forms.CheckBox();
        netOwnerLabel = new System.Windows.Forms.Label();
        netIdTextBox = new System.Windows.Forms.TextBox();
        netAreaTextBox = new System.Windows.Forms.TextBox();
        netAreaLabel = new System.Windows.Forms.Label();
        createFileButton = new System.Windows.Forms.Button();
        outputPathLabel = new System.Windows.Forms.Label();
        outputPathTextBox = new System.Windows.Forms.TextBox();
        outputPathButton = new System.Windows.Forms.Button();
        saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
        accountingPointTextBox = new System.Windows.Forms.TextBox();
        accountPointIdLabel = new System.Windows.Forms.Label();
        documentTimeFromNetTextBox = new System.Windows.Forms.TextBox();
        timeFromNetLabel = new System.Windows.Forms.Label();
        meteringLabel = new System.Windows.Forms.Label();
        meteringTo = new System.Windows.Forms.TextBox();
        meteringFrom = new System.Windows.Forms.TextBox();
        meteringTotalBox = new System.Windows.Forms.TextBox();
        kvartsvarden_Checkbox = new System.Windows.Forms.CheckBox();
        SuspendLayout();
        // 
        // inputBox
        // 
        inputBox.Location = new System.Drawing.Point(21, 22);
        inputBox.Multiline = true;
        inputBox.Name = "inputBox";
        inputBox.PlaceholderText = "Input values..";
        inputBox.Size = new System.Drawing.Size(336, 656);
        inputBox.TabIndex = 0;
        // 
        // uniqueIdTextBox
        // 
        uniqueIdTextBox.Location = new System.Drawing.Point(363, 42);
        uniqueIdTextBox.Name = "uniqueIdTextBox";
        uniqueIdTextBox.ReadOnly = true;
        uniqueIdTextBox.Size = new System.Drawing.Size(404, 23);
        uniqueIdTextBox.TabIndex = 2;
        uniqueIdTextBox.TextChanged += uniqueIdTextBox_TextChanged;
        // 
        // dateFromPicker
        // 
        dateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dateFromPicker.Location = new System.Drawing.Point(363, 94);
        dateFromPicker.Name = "dateFromPicker";
        dateFromPicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
        dateFromPicker.Size = new System.Drawing.Size(404, 23);
        dateFromPicker.TabIndex = 3;
        // 
        // uniqueIdLabel
        // 
        uniqueIdLabel.Location = new System.Drawing.Point(363, 19);
        uniqueIdLabel.Name = "uniqueIdLabel";
        uniqueIdLabel.Size = new System.Drawing.Size(404, 23);
        uniqueIdLabel.TabIndex = 4;
        uniqueIdLabel.Text = "Unique ID:";
        // 
        // dateFromLabel
        // 
        dateFromLabel.Location = new System.Drawing.Point(363, 68);
        dateFromLabel.Name = "dateFromLabel";
        dateFromLabel.Size = new System.Drawing.Size(404, 23);
        dateFromLabel.TabIndex = 5;
        dateFromLabel.Text = "Datum från:";
        // 
        // dateToLabel
        // 
        dateToLabel.Location = new System.Drawing.Point(363, 120);
        dateToLabel.Name = "dateToLabel";
        dateToLabel.Size = new System.Drawing.Size(404, 23);
        dateToLabel.TabIndex = 6;
        dateToLabel.Text = "Datum till:";
        // 
        // dateToPicker
        // 
        dateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dateToPicker.Location = new System.Drawing.Point(363, 146);
        dateToPicker.Name = "dateToPicker";
        dateToPicker.Size = new System.Drawing.Size(404, 23);
        dateToPicker.TabIndex = 7;
        // 
        // timeSeries1
        // 
        timeSeries1.Location = new System.Drawing.Point(363, 175);
        timeSeries1.Name = "timeSeries1";
        timeSeries1.Size = new System.Drawing.Size(206, 21);
        timeSeries1.TabIndex = 10;
        timeSeries1.Text = "Månadsavläst (1)";
        timeSeries1.UseVisualStyleBackColor = true;
        timeSeries1.CheckedChanged += timeSeries1_CheckedChanged;
        // 
        // timeSeries15
        // 
        timeSeries15.Location = new System.Drawing.Point(363, 202);
        timeSeries15.Name = "timeSeries15";
        timeSeries15.Size = new System.Drawing.Size(100, 21);
        timeSeries15.TabIndex = 11;
        timeSeries15.Text = "Timvärden";
        timeSeries15.UseVisualStyleBackColor = true;
        timeSeries15.CheckedChanged += timeSeries15_CheckedChanged;
        // 
        // consumtionAp
        // 
        consumtionAp.Location = new System.Drawing.Point(575, 175);
        consumtionAp.Name = "consumtionAp";
        consumtionAp.Size = new System.Drawing.Size(192, 21);
        consumtionAp.TabIndex = 13;
        consumtionAp.Text = "Konsumtion";
        consumtionAp.UseVisualStyleBackColor = true;
        consumtionAp.CheckedChanged += consumtionAp_CheckedChanged;
        // 
        // productionAp
        // 
        productionAp.Location = new System.Drawing.Point(575, 202);
        productionAp.Name = "productionAp";
        productionAp.Size = new System.Drawing.Size(192, 21);
        productionAp.TabIndex = 14;
        productionAp.Text = "Produktion";
        productionAp.UseVisualStyleBackColor = true;
        productionAp.CheckedChanged += productionAp_CheckedChanged;
        // 
        // netOwnerLabel
        // 
        netOwnerLabel.Location = new System.Drawing.Point(363, 226);
        netOwnerLabel.Name = "netOwnerLabel";
        netOwnerLabel.Size = new System.Drawing.Size(404, 23);
        netOwnerLabel.TabIndex = 15;
        netOwnerLabel.Text = "Nätägare:";
        // 
        // netIdTextBox
        // 
        netIdTextBox.Location = new System.Drawing.Point(363, 254);
        netIdTextBox.Name = "netIdTextBox";
        netIdTextBox.PlaceholderText = "e.g. \"49100\"";
        netIdTextBox.Size = new System.Drawing.Size(403, 23);
        netIdTextBox.TabIndex = 15;
        // 
        // netAreaTextBox
        // 
        netAreaTextBox.Location = new System.Drawing.Point(363, 308);
        netAreaTextBox.Name = "netAreaTextBox";
        netAreaTextBox.PlaceholderText = "e.g. \"UMO\"";
        netAreaTextBox.Size = new System.Drawing.Size(403, 23);
        netAreaTextBox.TabIndex = 16;
        // 
        // netAreaLabel
        // 
        netAreaLabel.Location = new System.Drawing.Point(363, 280);
        netAreaLabel.Name = "netAreaLabel";
        netAreaLabel.Size = new System.Drawing.Size(404, 23);
        netAreaLabel.TabIndex = 17;
        netAreaLabel.Text = "Nätområde:";
        // 
        // createFileButton
        // 
        createFileButton.Location = new System.Drawing.Point(363, 604);
        createFileButton.Name = "createFileButton";
        createFileButton.Size = new System.Drawing.Size(403, 74);
        createFileButton.TabIndex = 23;
        createFileButton.Text = "Skapa";
        createFileButton.UseVisualStyleBackColor = true;
        createFileButton.Click += createFileButton_Click;
        // 
        // outputPathLabel
        // 
        outputPathLabel.Location = new System.Drawing.Point(363, 551);
        outputPathLabel.Name = "outputPathLabel";
        outputPathLabel.Size = new System.Drawing.Size(403, 23);
        outputPathLabel.TabIndex = 20;
        outputPathLabel.Text = "Output-katalog:";
        // 
        // outputPathTextBox
        // 
        outputPathTextBox.Location = new System.Drawing.Point(363, 575);
        outputPathTextBox.Name = "outputPathTextBox";
        outputPathTextBox.Size = new System.Drawing.Size(328, 23);
        outputPathTextBox.TabIndex = 21;
        // 
        // outputPathButton
        // 
        outputPathButton.Location = new System.Drawing.Point(697, 575);
        outputPathButton.Name = "outputPathButton";
        outputPathButton.Size = new System.Drawing.Size(69, 23);
        outputPathButton.TabIndex = 22;
        outputPathButton.Text = "Bläddra";
        outputPathButton.UseVisualStyleBackColor = true;
        outputPathButton.Click += outputPathButton_Click;
        // 
        // accountingPointTextBox
        // 
        accountingPointTextBox.Location = new System.Drawing.Point(363, 362);
        accountingPointTextBox.Name = "accountingPointTextBox";
        accountingPointTextBox.PlaceholderText = "e.g. \"735999111222333444\"";
        accountingPointTextBox.Size = new System.Drawing.Size(403, 23);
        accountingPointTextBox.TabIndex = 17;
        // 
        // accountPointIdLabel
        // 
        accountPointIdLabel.Location = new System.Drawing.Point(363, 334);
        accountPointIdLabel.Name = "accountPointIdLabel";
        accountPointIdLabel.Size = new System.Drawing.Size(404, 23);
        accountPointIdLabel.TabIndex = 24;
        accountPointIdLabel.Text = "Anläggnings-ID:";
        // 
        // documentTimeFromNetTextBox
        // 
        documentTimeFromNetTextBox.Location = new System.Drawing.Point(363, 416);
        documentTimeFromNetTextBox.Name = "documentTimeFromNetTextBox";
        documentTimeFromNetTextBox.PlaceholderText = "e.g. \"202605250945\" (yyyyMMddHHmm)";
        documentTimeFromNetTextBox.Size = new System.Drawing.Size(403, 23);
        documentTimeFromNetTextBox.TabIndex = 18;
        // 
        // timeFromNetLabel
        // 
        timeFromNetLabel.Location = new System.Drawing.Point(363, 388);
        timeFromNetLabel.Name = "timeFromNetLabel";
        timeFromNetLabel.Size = new System.Drawing.Size(404, 23);
        timeFromNetLabel.TabIndex = 26;
        timeFromNetLabel.Text = "Skapande-tid (från nät):";
        // 
        // meteringLabel
        // 
        meteringLabel.Location = new System.Drawing.Point(363, 442);
        meteringLabel.Name = "meteringLabel";
        meteringLabel.Size = new System.Drawing.Size(404, 23);
        meteringLabel.TabIndex = 30;
        meteringLabel.Text = "Mätarställning:";
        meteringLabel.Visible = false;
        // 
        // meteringTo
        // 
        meteringTo.Location = new System.Drawing.Point(575, 470);
        meteringTo.Name = "meteringTo";
        meteringTo.PlaceholderText = "mätarställning slut";
        meteringTo.Size = new System.Drawing.Size(191, 23);
        meteringTo.TabIndex = 20;
        meteringTo.Visible = false;
        meteringTo.TextChanged += meteringTo_TextChanged;
        // 
        // meteringFrom
        // 
        meteringFrom.Location = new System.Drawing.Point(363, 470);
        meteringFrom.Name = "meteringFrom";
        meteringFrom.PlaceholderText = "mätarställning start";
        meteringFrom.Size = new System.Drawing.Size(191, 23);
        meteringFrom.TabIndex = 19;
        meteringFrom.Visible = false;
        meteringFrom.TextChanged += meteringFrom_TextChanged;
        // 
        // meteringTotalBox
        // 
        meteringTotalBox.Location = new System.Drawing.Point(363, 499);
        meteringTotalBox.Name = "meteringTotalBox";
        meteringTotalBox.PlaceholderText = "total förbrukning";
        meteringTotalBox.ReadOnly = true;
        meteringTotalBox.Size = new System.Drawing.Size(403, 23);
        meteringTotalBox.TabIndex = 31;
        meteringTotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        meteringTotalBox.Visible = false;
        // 
        // kvartsvarden_Checkbox
        // 
        kvartsvarden_Checkbox.Location = new System.Drawing.Point(469, 202);
        kvartsvarden_Checkbox.Name = "kvartsvarden_Checkbox";
        kvartsvarden_Checkbox.Size = new System.Drawing.Size(100, 21);
        kvartsvarden_Checkbox.TabIndex = 12;
        kvartsvarden_Checkbox.Text = "Kvartsvärden";
        kvartsvarden_Checkbox.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        ClientSize = new System.Drawing.Size(794, 704);
        Controls.Add(kvartsvarden_Checkbox);
        Controls.Add(meteringTotalBox);
        Controls.Add(meteringFrom);
        Controls.Add(meteringTo);
        Controls.Add(meteringLabel);
        Controls.Add(documentTimeFromNetTextBox);
        Controls.Add(timeFromNetLabel);
        Controls.Add(accountingPointTextBox);
        Controls.Add(accountPointIdLabel);
        Controls.Add(outputPathButton);
        Controls.Add(outputPathTextBox);
        Controls.Add(outputPathLabel);
        Controls.Add(createFileButton);
        Controls.Add(netAreaTextBox);
        Controls.Add(netAreaLabel);
        Controls.Add(netIdTextBox);
        Controls.Add(netOwnerLabel);
        Controls.Add(productionAp);
        Controls.Add(consumtionAp);
        Controls.Add(timeSeries15);
        Controls.Add(timeSeries1);
        Controls.Add(dateToPicker);
        Controls.Add(dateToLabel);
        Controls.Add(dateFromLabel);
        Controls.Add(uniqueIdLabel);
        Controls.Add(dateFromPicker);
        Controls.Add(uniqueIdTextBox);
        Controls.Add(inputBox);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        MaximizeBox = false;
        ShowIcon = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.CheckBox kvartsvarden_Checkbox;

    private System.Windows.Forms.TextBox meteringTotalBox;

    private System.Windows.Forms.Label meteringLabel;
    private System.Windows.Forms.TextBox meteringTo;
    private System.Windows.Forms.TextBox meteringFrom;

    private System.Windows.Forms.TextBox documentTimeFromNetTextBox;
    private System.Windows.Forms.Label timeFromNetLabel;

    private System.Windows.Forms.TextBox accountingPointTextBox;
    private System.Windows.Forms.Label accountPointIdLabel;

    private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    private System.Windows.Forms.Button createFileButton;
    private System.Windows.Forms.Label outputPathLabel;
    private System.Windows.Forms.TextBox outputPathTextBox;
    private System.Windows.Forms.Button outputPathButton;

    private System.Windows.Forms.TextBox netAreaTextBox;
    private System.Windows.Forms.Label netAreaLabel;

    private System.Windows.Forms.TextBox netIdTextBox;

    private System.Windows.Forms.Label netOwnerLabel;

    private System.Windows.Forms.CheckBox timeSeries1;
    private System.Windows.Forms.CheckBox timeSeries15;
    private System.Windows.Forms.CheckBox consumtionAp;

    private System.Windows.Forms.CheckBox productionAp;

    private System.Windows.Forms.Label dateToLabel;
    private System.Windows.Forms.DateTimePicker dateToPicker;

    private System.Windows.Forms.DateTimePicker dateFromPicker;
    private System.Windows.Forms.Label uniqueIdLabel;
    private System.Windows.Forms.Label dateFromLabel;

    private System.Windows.Forms.TextBox inputBox;

    private System.Windows.Forms.TextBox uniqueIdTextBox;

    #endregion
}