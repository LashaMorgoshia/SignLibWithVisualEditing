namespace PDFSigner
{
    partial class FormPDFSigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPDFSigner));
            this.inputBox = new System.Windows.Forms.TextBox();
            this.buttonSelectSource = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.buttonSelectDestination = new System.Windows.Forms.Button();
            this.labelSigningReason = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.checkBoxShowSignature = new System.Windows.Forms.CheckBox();
            this.comboBoxBasicSignaturePage = new System.Windows.Forms.ComboBox();
            this.comboBoxBasicSignaturePosition = new System.Windows.Forms.ComboBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelSource = new System.Windows.Forms.Label();
            this.locationText = new System.Windows.Forms.TextBox();
            this.labelSigningLocation = new System.Windows.Forms.Label();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.labelTimestampingServer = new System.Windows.Forms.Label();
            this.comboBoxTimestampingServer = new System.Windows.Forms.ComboBox();
            this.checkBoxTimestampDocument = new System.Windows.Forms.CheckBox();
            this.reasonText = new System.Windows.Forms.ComboBox();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.buttonSign = new System.Windows.Forms.Button();
            this.groupBoxSignaturePosition = new System.Windows.Forms.GroupBox();
            this.btnSetCustomPosition = new System.Windows.Forms.Button();
            this.textBoxAdvancedHeight = new System.Windows.Forms.TextBox();
            this.textBoxAdvancedWidth = new System.Windows.Forms.TextBox();
            this.textBoxAdvancedYCoord = new System.Windows.Forms.TextBox();
            this.labelAdvancedHeight = new System.Windows.Forms.Label();
            this.textBoxAdvancedXCoord = new System.Windows.Forms.TextBox();
            this.labelAdvancedWidth = new System.Windows.Forms.Label();
            this.labelAdvancedTopRight = new System.Windows.Forms.Label();
            this.labelAdvancedTopLeft = new System.Windows.Forms.Label();
            this.radioButtonAdvancedSignature = new System.Windows.Forms.RadioButton();
            this.radioButtonBasicSignature = new System.Windows.Forms.RadioButton();
            this.labelBasicPage = new System.Windows.Forms.Label();
            this.groupBoxSignatureOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxIncludeImage = new System.Windows.Forms.CheckBox();
            this.groupBoxSignatureImage = new System.Windows.Forms.GroupBox();
            this.radioButtonImageNoText = new System.Windows.Forms.RadioButton();
            this.radioButtonImageAndText = new System.Windows.Forms.RadioButton();
            this.radioButtonImageAsBackgorund = new System.Windows.Forms.RadioButton();
            this.textBoxImageFile = new System.Windows.Forms.TextBox();
            this.buttonSelectImage = new System.Windows.Forms.Button();
            this.groupBoxOptions.SuspendLayout();
            this.groupBoxPath.SuspendLayout();
            this.groupBoxSignaturePosition.SuspendLayout();
            this.groupBoxSignatureOptions.SuspendLayout();
            this.groupBoxSignatureImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(66, 49);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(548, 26);
            this.inputBox.TabIndex = 3;
            // 
            // buttonSelectSource
            // 
            this.buttonSelectSource.Location = new System.Drawing.Point(9, 49);
            this.buttonSelectSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSelectSource.Name = "buttonSelectSource";
            this.buttonSelectSource.Size = new System.Drawing.Size(48, 31);
            this.buttonSelectSource.TabIndex = 2;
            this.buttonSelectSource.Text = "...";
            this.buttonSelectSource.UseVisualStyleBackColor = true;
            this.buttonSelectSource.Click += new System.EventHandler(this.buttonSource_Click);
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(66, 123);
            this.outputBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(548, 26);
            this.outputBox.TabIndex = 5;
            // 
            // buttonSelectDestination
            // 
            this.buttonSelectDestination.Location = new System.Drawing.Point(9, 123);
            this.buttonSelectDestination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSelectDestination.Name = "buttonSelectDestination";
            this.buttonSelectDestination.Size = new System.Drawing.Size(48, 31);
            this.buttonSelectDestination.TabIndex = 4;
            this.buttonSelectDestination.Text = "...";
            this.buttonSelectDestination.UseVisualStyleBackColor = true;
            this.buttonSelectDestination.Click += new System.EventHandler(this.buttonDestination_Click);
            // 
            // labelSigningReason
            // 
            this.labelSigningReason.AutoSize = true;
            this.labelSigningReason.Location = new System.Drawing.Point(9, 34);
            this.labelSigningReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSigningReason.Name = "labelSigningReason";
            this.labelSigningReason.Size = new System.Drawing.Size(119, 20);
            this.labelSigningReason.TabIndex = 29;
            this.labelSigningReason.Text = "Signing reason:";
            // 
            // buttonQuit
            // 
            this.buttonQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonQuit.Location = new System.Drawing.Point(530, 682);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(112, 35);
            this.buttonQuit.TabIndex = 7;
            this.buttonQuit.Text = "&Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // checkBoxShowSignature
            // 
            this.checkBoxShowSignature.AutoSize = true;
            this.checkBoxShowSignature.Checked = true;
            this.checkBoxShowSignature.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowSignature.Location = new System.Drawing.Point(14, 183);
            this.checkBoxShowSignature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxShowSignature.Name = "checkBoxShowSignature";
            this.checkBoxShowSignature.Size = new System.Drawing.Size(269, 24);
            this.checkBoxShowSignature.TabIndex = 0;
            this.checkBoxShowSignature.Text = "Show signature on the document";
            this.checkBoxShowSignature.UseVisualStyleBackColor = true;
            this.checkBoxShowSignature.CheckedChanged += new System.EventHandler(this.checkBoxVisible_CheckedChanged);
            // 
            // comboBoxBasicSignaturePage
            // 
            this.comboBoxBasicSignaturePage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBasicSignaturePage.FormattingEnabled = true;
            this.comboBoxBasicSignaturePage.Items.AddRange(new object[] {
            "First Page",
            "Last Page"});
            this.comboBoxBasicSignaturePage.Location = new System.Drawing.Point(94, 32);
            this.comboBoxBasicSignaturePage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxBasicSignaturePage.Name = "comboBoxBasicSignaturePage";
            this.comboBoxBasicSignaturePage.Size = new System.Drawing.Size(139, 28);
            this.comboBoxBasicSignaturePage.TabIndex = 0;
            // 
            // comboBoxBasicSignaturePosition
            // 
            this.comboBoxBasicSignaturePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBasicSignaturePosition.FormattingEnabled = true;
            this.comboBoxBasicSignaturePosition.Items.AddRange(new object[] {
            "Top Right",
            "Top Left",
            "Bottom Right",
            "Bottom Left"});
            this.comboBoxBasicSignaturePosition.Location = new System.Drawing.Point(94, 82);
            this.comboBoxBasicSignaturePosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxBasicSignaturePosition.Name = "comboBoxBasicSignaturePosition";
            this.comboBoxBasicSignaturePosition.Size = new System.Drawing.Size(139, 28);
            this.comboBoxBasicSignaturePosition.TabIndex = 3;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(9, 97);
            this.labelDestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(94, 20);
            this.labelDestination.TabIndex = 29;
            this.labelDestination.Text = "Destination:";
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(9, 25);
            this.labelSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(64, 20);
            this.labelSource.TabIndex = 29;
            this.labelSource.Text = "Source:";
            // 
            // locationText
            // 
            this.locationText.Location = new System.Drawing.Point(14, 128);
            this.locationText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size(332, 26);
            this.locationText.TabIndex = 1;
            // 
            // labelSigningLocation
            // 
            this.labelSigningLocation.AutoSize = true;
            this.labelSigningLocation.Location = new System.Drawing.Point(9, 103);
            this.labelSigningLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSigningLocation.Name = "labelSigningLocation";
            this.labelSigningLocation.Size = new System.Drawing.Size(125, 20);
            this.labelSigningLocation.TabIndex = 29;
            this.labelSigningLocation.Text = "Signing location:";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.labelTimestampingServer);
            this.groupBoxOptions.Controls.Add(this.comboBoxTimestampingServer);
            this.groupBoxOptions.Controls.Add(this.checkBoxTimestampDocument);
            this.groupBoxOptions.Location = new System.Drawing.Point(18, 594);
            this.groupBoxOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOptions.Size = new System.Drawing.Size(634, 78);
            this.groupBoxOptions.TabIndex = 4;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Time stamping options";
            // 
            // labelTimestampingServer
            // 
            this.labelTimestampingServer.AutoSize = true;
            this.labelTimestampingServer.Location = new System.Drawing.Point(228, 35);
            this.labelTimestampingServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimestampingServer.Name = "labelTimestampingServer";
            this.labelTimestampingServer.Size = new System.Drawing.Size(94, 20);
            this.labelTimestampingServer.TabIndex = 1;
            this.labelTimestampingServer.Text = "Time server:";
            // 
            // comboBoxTimestampingServer
            // 
            this.comboBoxTimestampingServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimestampingServer.Enabled = false;
            this.comboBoxTimestampingServer.FormattingEnabled = true;
            this.comboBoxTimestampingServer.Items.AddRange(new object[] {
            "http://ca.signfiles.com/TSAServer.aspx"});
            this.comboBoxTimestampingServer.Location = new System.Drawing.Point(334, 29);
            this.comboBoxTimestampingServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTimestampingServer.Name = "comboBoxTimestampingServer";
            this.comboBoxTimestampingServer.Size = new System.Drawing.Size(289, 28);
            this.comboBoxTimestampingServer.TabIndex = 2;
            // 
            // checkBoxTimestampDocument
            // 
            this.checkBoxTimestampDocument.AutoSize = true;
            this.checkBoxTimestampDocument.Location = new System.Drawing.Point(20, 34);
            this.checkBoxTimestampDocument.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxTimestampDocument.Name = "checkBoxTimestampDocument";
            this.checkBoxTimestampDocument.Size = new System.Drawing.Size(192, 24);
            this.checkBoxTimestampDocument.TabIndex = 0;
            this.checkBoxTimestampDocument.Text = "Time stamp document";
            this.checkBoxTimestampDocument.UseVisualStyleBackColor = true;
            this.checkBoxTimestampDocument.CheckedChanged += new System.EventHandler(this.checkBoxTSA_CheckedChanged);
            // 
            // reasonText
            // 
            this.reasonText.FormattingEnabled = true;
            this.reasonText.Items.AddRange(new object[] {
            "I am the author of this document",
            "I have reviewed this document",
            "I am approving this document",
            "I agree to specified portions of this document"});
            this.reasonText.Location = new System.Drawing.Point(14, 60);
            this.reasonText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reasonText.Name = "reasonText";
            this.reasonText.Size = new System.Drawing.Size(332, 28);
            this.reasonText.TabIndex = 0;
            // 
            // groupBoxPath
            // 
            this.groupBoxPath.Controls.Add(this.buttonSelectDestination);
            this.groupBoxPath.Controls.Add(this.labelDestination);
            this.groupBoxPath.Controls.Add(this.outputBox);
            this.groupBoxPath.Controls.Add(this.labelSource);
            this.groupBoxPath.Controls.Add(this.buttonSelectSource);
            this.groupBoxPath.Controls.Add(this.inputBox);
            this.groupBoxPath.Location = new System.Drawing.Point(18, 12);
            this.groupBoxPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPath.Size = new System.Drawing.Size(634, 166);
            this.groupBoxPath.TabIndex = 0;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "Path";
            // 
            // buttonSign
            // 
            this.buttonSign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSign.Location = new System.Drawing.Point(32, 682);
            this.buttonSign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(201, 35);
            this.buttonSign.TabIndex = 5;
            this.buttonSign.Text = "Apply Digital Signature";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // groupBoxSignaturePosition
            // 
            this.groupBoxSignaturePosition.Controls.Add(this.btnSetCustomPosition);
            this.groupBoxSignaturePosition.Controls.Add(this.textBoxAdvancedHeight);
            this.groupBoxSignaturePosition.Controls.Add(this.textBoxAdvancedWidth);
            this.groupBoxSignaturePosition.Controls.Add(this.textBoxAdvancedYCoord);
            this.groupBoxSignaturePosition.Controls.Add(this.labelAdvancedHeight);
            this.groupBoxSignaturePosition.Controls.Add(this.textBoxAdvancedXCoord);
            this.groupBoxSignaturePosition.Controls.Add(this.labelAdvancedWidth);
            this.groupBoxSignaturePosition.Controls.Add(this.labelAdvancedTopRight);
            this.groupBoxSignaturePosition.Controls.Add(this.labelAdvancedTopLeft);
            this.groupBoxSignaturePosition.Controls.Add(this.radioButtonAdvancedSignature);
            this.groupBoxSignaturePosition.Controls.Add(this.comboBoxBasicSignaturePage);
            this.groupBoxSignaturePosition.Controls.Add(this.radioButtonBasicSignature);
            this.groupBoxSignaturePosition.Controls.Add(this.comboBoxBasicSignaturePosition);
            this.groupBoxSignaturePosition.Controls.Add(this.labelBasicPage);
            this.groupBoxSignaturePosition.Location = new System.Drawing.Point(393, 188);
            this.groupBoxSignaturePosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSignaturePosition.Name = "groupBoxSignaturePosition";
            this.groupBoxSignaturePosition.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSignaturePosition.Size = new System.Drawing.Size(260, 272);
            this.groupBoxSignaturePosition.TabIndex = 3;
            this.groupBoxSignaturePosition.TabStop = false;
            this.groupBoxSignaturePosition.Text = "Signature position";
            // 
            // btnSetCustomPosition
            // 
            this.btnSetCustomPosition.Enabled = false;
            this.btnSetCustomPosition.Location = new System.Drawing.Point(139, 135);
            this.btnSetCustomPosition.Name = "btnSetCustomPosition";
            this.btnSetCustomPosition.Size = new System.Drawing.Size(113, 31);
            this.btnSetCustomPosition.TabIndex = 5;
            this.btnSetCustomPosition.Text = "Custom";
            this.btnSetCustomPosition.UseVisualStyleBackColor = true;
            this.btnSetCustomPosition.Click += new System.EventHandler(this.btnSetCustomPosition_Click);
            // 
            // textBoxAdvancedHeight
            // 
            this.textBoxAdvancedHeight.Enabled = false;
            this.textBoxAdvancedHeight.Location = new System.Drawing.Point(201, 225);
            this.textBoxAdvancedHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAdvancedHeight.MaxLength = 4;
            this.textBoxAdvancedHeight.Name = "textBoxAdvancedHeight";
            this.textBoxAdvancedHeight.Size = new System.Drawing.Size(46, 26);
            this.textBoxAdvancedHeight.TabIndex = 7;
            // 
            // textBoxAdvancedWidth
            // 
            this.textBoxAdvancedWidth.Enabled = false;
            this.textBoxAdvancedWidth.Location = new System.Drawing.Point(201, 182);
            this.textBoxAdvancedWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAdvancedWidth.MaxLength = 4;
            this.textBoxAdvancedWidth.Name = "textBoxAdvancedWidth";
            this.textBoxAdvancedWidth.Size = new System.Drawing.Size(46, 26);
            this.textBoxAdvancedWidth.TabIndex = 6;
            // 
            // textBoxAdvancedYCoord
            // 
            this.textBoxAdvancedYCoord.Enabled = false;
            this.textBoxAdvancedYCoord.Location = new System.Drawing.Point(68, 225);
            this.textBoxAdvancedYCoord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAdvancedYCoord.MaxLength = 4;
            this.textBoxAdvancedYCoord.Name = "textBoxAdvancedYCoord";
            this.textBoxAdvancedYCoord.Size = new System.Drawing.Size(46, 26);
            this.textBoxAdvancedYCoord.TabIndex = 5;
            // 
            // labelAdvancedHeight
            // 
            this.labelAdvancedHeight.AutoSize = true;
            this.labelAdvancedHeight.Enabled = false;
            this.labelAdvancedHeight.Location = new System.Drawing.Point(130, 229);
            this.labelAdvancedHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdvancedHeight.Name = "labelAdvancedHeight";
            this.labelAdvancedHeight.Size = new System.Drawing.Size(60, 20);
            this.labelAdvancedHeight.TabIndex = 11;
            this.labelAdvancedHeight.Text = "Height:";
            // 
            // textBoxAdvancedXCoord
            // 
            this.textBoxAdvancedXCoord.Enabled = false;
            this.textBoxAdvancedXCoord.Location = new System.Drawing.Point(68, 182);
            this.textBoxAdvancedXCoord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAdvancedXCoord.MaxLength = 4;
            this.textBoxAdvancedXCoord.Name = "textBoxAdvancedXCoord";
            this.textBoxAdvancedXCoord.Size = new System.Drawing.Size(46, 26);
            this.textBoxAdvancedXCoord.TabIndex = 4;
            // 
            // labelAdvancedWidth
            // 
            this.labelAdvancedWidth.AutoSize = true;
            this.labelAdvancedWidth.Enabled = false;
            this.labelAdvancedWidth.Location = new System.Drawing.Point(135, 186);
            this.labelAdvancedWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdvancedWidth.Name = "labelAdvancedWidth";
            this.labelAdvancedWidth.Size = new System.Drawing.Size(54, 20);
            this.labelAdvancedWidth.TabIndex = 9;
            this.labelAdvancedWidth.Text = "Width:";
            // 
            // labelAdvancedTopRight
            // 
            this.labelAdvancedTopRight.AutoSize = true;
            this.labelAdvancedTopRight.Enabled = false;
            this.labelAdvancedTopRight.Location = new System.Drawing.Point(9, 229);
            this.labelAdvancedTopRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdvancedTopRight.Name = "labelAdvancedTopRight";
            this.labelAdvancedTopRight.Size = new System.Drawing.Size(56, 20);
            this.labelAdvancedTopRight.TabIndex = 7;
            this.labelAdvancedTopRight.Text = "Y-axis:";
            // 
            // labelAdvancedTopLeft
            // 
            this.labelAdvancedTopLeft.AutoSize = true;
            this.labelAdvancedTopLeft.Enabled = false;
            this.labelAdvancedTopLeft.Location = new System.Drawing.Point(9, 186);
            this.labelAdvancedTopLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdvancedTopLeft.Name = "labelAdvancedTopLeft";
            this.labelAdvancedTopLeft.Size = new System.Drawing.Size(56, 20);
            this.labelAdvancedTopLeft.TabIndex = 5;
            this.labelAdvancedTopLeft.Text = "X-axis:";
            // 
            // radioButtonAdvancedSignature
            // 
            this.radioButtonAdvancedSignature.AutoSize = true;
            this.radioButtonAdvancedSignature.Location = new System.Drawing.Point(9, 138);
            this.radioButtonAdvancedSignature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonAdvancedSignature.Name = "radioButtonAdvancedSignature";
            this.radioButtonAdvancedSignature.Size = new System.Drawing.Size(105, 24);
            this.radioButtonAdvancedSignature.TabIndex = 2;
            this.radioButtonAdvancedSignature.TabStop = true;
            this.radioButtonAdvancedSignature.Text = "Advanced";
            this.radioButtonAdvancedSignature.UseVisualStyleBackColor = true;
            this.radioButtonAdvancedSignature.CheckedChanged += new System.EventHandler(this.radioButtonAdvancedSignature_CheckedChanged);
            // 
            // radioButtonBasicSignature
            // 
            this.radioButtonBasicSignature.AutoSize = true;
            this.radioButtonBasicSignature.Checked = true;
            this.radioButtonBasicSignature.Location = new System.Drawing.Point(9, 83);
            this.radioButtonBasicSignature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonBasicSignature.Name = "radioButtonBasicSignature";
            this.radioButtonBasicSignature.Size = new System.Drawing.Size(73, 24);
            this.radioButtonBasicSignature.TabIndex = 1;
            this.radioButtonBasicSignature.TabStop = true;
            this.radioButtonBasicSignature.Text = "Basic";
            this.radioButtonBasicSignature.UseVisualStyleBackColor = true;
            this.radioButtonBasicSignature.CheckedChanged += new System.EventHandler(this.radioButtonBasicSignature_CheckedChanged);
            // 
            // labelBasicPage
            // 
            this.labelBasicPage.AutoSize = true;
            this.labelBasicPage.Location = new System.Drawing.Point(30, 38);
            this.labelBasicPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBasicPage.Name = "labelBasicPage";
            this.labelBasicPage.Size = new System.Drawing.Size(50, 20);
            this.labelBasicPage.TabIndex = 0;
            this.labelBasicPage.Text = "Page:";
            // 
            // groupBoxSignatureOptions
            // 
            this.groupBoxSignatureOptions.Controls.Add(this.checkBoxIncludeImage);
            this.groupBoxSignatureOptions.Controls.Add(this.checkBoxShowSignature);
            this.groupBoxSignatureOptions.Controls.Add(this.labelSigningReason);
            this.groupBoxSignatureOptions.Controls.Add(this.reasonText);
            this.groupBoxSignatureOptions.Controls.Add(this.labelSigningLocation);
            this.groupBoxSignatureOptions.Controls.Add(this.locationText);
            this.groupBoxSignatureOptions.Location = new System.Drawing.Point(18, 188);
            this.groupBoxSignatureOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSignatureOptions.Name = "groupBoxSignatureOptions";
            this.groupBoxSignatureOptions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSignatureOptions.Size = new System.Drawing.Size(366, 272);
            this.groupBoxSignatureOptions.TabIndex = 1;
            this.groupBoxSignatureOptions.TabStop = false;
            this.groupBoxSignatureOptions.Text = "Signature options";
            // 
            // checkBoxIncludeImage
            // 
            this.checkBoxIncludeImage.AutoSize = true;
            this.checkBoxIncludeImage.Location = new System.Drawing.Point(14, 225);
            this.checkBoxIncludeImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxIncludeImage.Name = "checkBoxIncludeImage";
            this.checkBoxIncludeImage.Size = new System.Drawing.Size(275, 24);
            this.checkBoxIncludeImage.TabIndex = 0;
            this.checkBoxIncludeImage.Text = "Include an image on the signature";
            this.checkBoxIncludeImage.UseVisualStyleBackColor = true;
            this.checkBoxIncludeImage.CheckedChanged += new System.EventHandler(this.checkBoxIncludeImage_CheckedChanged);
            // 
            // groupBoxSignatureImage
            // 
            this.groupBoxSignatureImage.Controls.Add(this.radioButtonImageNoText);
            this.groupBoxSignatureImage.Controls.Add(this.radioButtonImageAndText);
            this.groupBoxSignatureImage.Controls.Add(this.radioButtonImageAsBackgorund);
            this.groupBoxSignatureImage.Controls.Add(this.textBoxImageFile);
            this.groupBoxSignatureImage.Controls.Add(this.buttonSelectImage);
            this.groupBoxSignatureImage.Enabled = false;
            this.groupBoxSignatureImage.Location = new System.Drawing.Point(18, 469);
            this.groupBoxSignatureImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSignatureImage.Name = "groupBoxSignatureImage";
            this.groupBoxSignatureImage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSignatureImage.Size = new System.Drawing.Size(634, 115);
            this.groupBoxSignatureImage.TabIndex = 10;
            this.groupBoxSignatureImage.TabStop = false;
            this.groupBoxSignatureImage.Text = "Signature image";
            // 
            // radioButtonImageNoText
            // 
            this.radioButtonImageNoText.AutoSize = true;
            this.radioButtonImageNoText.Location = new System.Drawing.Point(447, 75);
            this.radioButtonImageNoText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonImageNoText.Name = "radioButtonImageNoText";
            this.radioButtonImageNoText.Size = new System.Drawing.Size(163, 24);
            this.radioButtonImageNoText.TabIndex = 4;
            this.radioButtonImageNoText.Text = "Image with no text";
            this.radioButtonImageNoText.UseVisualStyleBackColor = true;
            // 
            // radioButtonImageAndText
            // 
            this.radioButtonImageAndText.AutoSize = true;
            this.radioButtonImageAndText.Checked = true;
            this.radioButtonImageAndText.Location = new System.Drawing.Point(14, 75);
            this.radioButtonImageAndText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonImageAndText.Name = "radioButtonImageAndText";
            this.radioButtonImageAndText.Size = new System.Drawing.Size(140, 24);
            this.radioButtonImageAndText.TabIndex = 4;
            this.radioButtonImageAndText.TabStop = true;
            this.radioButtonImageAndText.Text = "Image and text";
            this.radioButtonImageAndText.UseVisualStyleBackColor = true;
            // 
            // radioButtonImageAsBackgorund
            // 
            this.radioButtonImageAsBackgorund.AutoSize = true;
            this.radioButtonImageAsBackgorund.Location = new System.Drawing.Point(204, 75);
            this.radioButtonImageAsBackgorund.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonImageAsBackgorund.Name = "radioButtonImageAsBackgorund";
            this.radioButtonImageAsBackgorund.Size = new System.Drawing.Size(188, 24);
            this.radioButtonImageAsBackgorund.TabIndex = 4;
            this.radioButtonImageAsBackgorund.Text = "Image as background";
            this.radioButtonImageAsBackgorund.UseVisualStyleBackColor = true;
            // 
            // textBoxImageFile
            // 
            this.textBoxImageFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImageFile.Location = new System.Drawing.Point(66, 32);
            this.textBoxImageFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxImageFile.Name = "textBoxImageFile";
            this.textBoxImageFile.Size = new System.Drawing.Size(556, 26);
            this.textBoxImageFile.TabIndex = 3;
            // 
            // buttonSelectImage
            // 
            this.buttonSelectImage.Location = new System.Drawing.Point(9, 32);
            this.buttonSelectImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSelectImage.Name = "buttonSelectImage";
            this.buttonSelectImage.Size = new System.Drawing.Size(48, 31);
            this.buttonSelectImage.TabIndex = 2;
            this.buttonSelectImage.Text = "...";
            this.buttonSelectImage.UseVisualStyleBackColor = true;
            this.buttonSelectImage.Click += new System.EventHandler(this.buttonSelectImage_Click);
            // 
            // FormPDFSigner
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.buttonQuit;
            this.ClientSize = new System.Drawing.Size(669, 740);
            this.Controls.Add(this.groupBoxSignatureImage);
            this.Controls.Add(this.groupBoxSignatureOptions);
            this.Controls.Add(this.groupBoxSignaturePosition);
            this.Controls.Add(this.groupBoxPath);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.buttonQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormPDFSigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Signer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPDFSigner_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormPDFSigner_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormPDFSigner_DragEnter);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.groupBoxPath.ResumeLayout(false);
            this.groupBoxPath.PerformLayout();
            this.groupBoxSignaturePosition.ResumeLayout(false);
            this.groupBoxSignaturePosition.PerformLayout();
            this.groupBoxSignatureOptions.ResumeLayout(false);
            this.groupBoxSignatureOptions.PerformLayout();
            this.groupBoxSignatureImage.ResumeLayout(false);
            this.groupBoxSignatureImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button buttonSelectSource;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button buttonSelectDestination;
        private System.Windows.Forms.Label labelSigningReason;
        //private System.Windows.Forms.TextBox reasonText;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.ComboBox comboBoxBasicSignaturePosition;
        private System.Windows.Forms.ComboBox comboBoxBasicSignaturePage;
        private System.Windows.Forms.CheckBox checkBoxShowSignature;
        private System.Windows.Forms.Label labelSigningLocation;
        private System.Windows.Forms.TextBox locationText;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private System.Windows.Forms.ComboBox comboBoxTimestampingServer;
        private System.Windows.Forms.CheckBox checkBoxTimestampDocument;
        private System.Windows.Forms.ComboBox reasonText;
        private System.Windows.Forms.Label labelTimestampingServer;
        private System.Windows.Forms.GroupBox groupBoxSignaturePosition;
        private System.Windows.Forms.Label labelBasicPage;
        private System.Windows.Forms.GroupBox groupBoxSignatureOptions;
        private System.Windows.Forms.GroupBox groupBoxSignatureImage;
        private System.Windows.Forms.RadioButton radioButtonImageAndText;
        private System.Windows.Forms.TextBox textBoxImageFile;
        private System.Windows.Forms.Button buttonSelectImage;
        private System.Windows.Forms.RadioButton radioButtonImageNoText;
        private System.Windows.Forms.CheckBox checkBoxIncludeImage;
        private System.Windows.Forms.RadioButton radioButtonImageAsBackgorund;
        private System.Windows.Forms.TextBox textBoxAdvancedHeight;
        private System.Windows.Forms.TextBox textBoxAdvancedWidth;
        private System.Windows.Forms.TextBox textBoxAdvancedYCoord;
        private System.Windows.Forms.Label labelAdvancedHeight;
        private System.Windows.Forms.TextBox textBoxAdvancedXCoord;
        private System.Windows.Forms.Label labelAdvancedWidth;
        private System.Windows.Forms.Label labelAdvancedTopRight;
        private System.Windows.Forms.Label labelAdvancedTopLeft;
        private System.Windows.Forms.RadioButton radioButtonAdvancedSignature;
        private System.Windows.Forms.RadioButton radioButtonBasicSignature;
        private System.Windows.Forms.Button btnSetCustomPosition;
    }
}

