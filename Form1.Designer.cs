using TextBuster;

namespace TextBuster
{
    partial class HideNSeekWord
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
            createDicoBtn = new Button();
            imageBtn = new Button();
            audioBtn = new Button();
            mainPanel = new Panel();
            imagePanel = new Panel();
            btnFilePngKey = new Button();
            filePngKeyJsonInput = new TextBox();
            label12 = new Label();
            label11 = new Label();
            messagePngInput = new TextBox();
            label7 = new Label();
            outputPngDecoderFileName = new TextBox();
            label8 = new Label();
            btnBrowserOutput = new Button();
            pngOutputDecodeBrowser = new TextBox();
            btnDecodeInputPng = new Button();
            decodePngBtn = new Button();
            label9 = new Label();
            pngFileInputDecode = new TextBox();
            label10 = new Label();
            label3 = new Label();
            pngEncodeFileNameInput = new TextBox();
            label4 = new Label();
            btnBrowserPng = new Button();
            outputPngBrowser = new TextBox();
            btnFilePng = new Button();
            encodeBtn = new Button();
            label5 = new Label();
            filePngInput = new TextBox();
            label6 = new Label();
            panelDictionnary = new Panel();
            label2 = new Label();
            outputFileTxtName = new TextBox();
            label1 = new Label();
            btnFileOutputBrowserTxt = new Button();
            browserOutputTxtName = new TextBox();
            btnFileTxt = new Button();
            createFileDicoBtn = new Button();
            TitleDictionnary = new Label();
            fileTxtInput = new TextBox();
            labelFileTxt = new Label();
            mainPanel.SuspendLayout();
            imagePanel.SuspendLayout();
            panelDictionnary.SuspendLayout();
            SuspendLayout();
            // 
            // createDicoBtn
            // 
            createDicoBtn.FlatStyle = FlatStyle.Flat;
            createDicoBtn.Location = new Point(0, 0);
            createDicoBtn.Name = "createDicoBtn";
            createDicoBtn.Size = new Size(142, 29);
            createDicoBtn.TabIndex = 0;
            createDicoBtn.Text = "Create dictionnary";
            createDicoBtn.UseVisualStyleBackColor = true;
            createDicoBtn.Click += createDicoBtn_Click;
            // 
            // imageBtn
            // 
            imageBtn.FlatStyle = FlatStyle.Flat;
            imageBtn.Location = new Point(139, 0);
            imageBtn.Name = "imageBtn";
            imageBtn.Size = new Size(110, 29);
            imageBtn.TabIndex = 1;
            imageBtn.Text = "Image";
            imageBtn.UseVisualStyleBackColor = true;
            imageBtn.Click += imageBtn_Click;
            // 
            // audioBtn
            // 
            audioBtn.FlatStyle = FlatStyle.Flat;
            audioBtn.Location = new Point(246, 0);
            audioBtn.Name = "audioBtn";
            audioBtn.Size = new Size(94, 29);
            audioBtn.TabIndex = 2;
            audioBtn.Text = "Audio";
            audioBtn.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(imagePanel);
            mainPanel.Location = new Point(0, 63);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(964, 311);
            mainPanel.TabIndex = 3;
            // 
            // imagePanel
            // 
            imagePanel.Controls.Add(btnFilePngKey);
            imagePanel.Controls.Add(filePngKeyJsonInput);
            imagePanel.Controls.Add(label12);
            imagePanel.Controls.Add(label11);
            imagePanel.Controls.Add(messagePngInput);
            imagePanel.Controls.Add(label7);
            imagePanel.Controls.Add(outputPngDecoderFileName);
            imagePanel.Controls.Add(label8);
            imagePanel.Controls.Add(btnBrowserOutput);
            imagePanel.Controls.Add(pngOutputDecodeBrowser);
            imagePanel.Controls.Add(btnDecodeInputPng);
            imagePanel.Controls.Add(decodePngBtn);
            imagePanel.Controls.Add(label9);
            imagePanel.Controls.Add(pngFileInputDecode);
            imagePanel.Controls.Add(label10);
            imagePanel.Controls.Add(label3);
            imagePanel.Controls.Add(pngEncodeFileNameInput);
            imagePanel.Controls.Add(label4);
            imagePanel.Controls.Add(btnBrowserPng);
            imagePanel.Controls.Add(outputPngBrowser);
            imagePanel.Controls.Add(btnFilePng);
            imagePanel.Controls.Add(encodeBtn);
            imagePanel.Controls.Add(label5);
            imagePanel.Controls.Add(filePngInput);
            imagePanel.Controls.Add(label6);
            imagePanel.Location = new Point(0, 3);
            imagePanel.Name = "imagePanel";
            imagePanel.Size = new Size(961, 299);
            imagePanel.TabIndex = 0;
            // 
            // btnFilePngKey
            // 
            btnFilePngKey.Location = new Point(893, 106);
            btnFilePngKey.Name = "btnFilePngKey";
            btnFilePngKey.Size = new Size(41, 29);
            btnFilePngKey.TabIndex = 34;
            btnFilePngKey.Text = "🔗";
            btnFilePngKey.UseVisualStyleBackColor = true;
            btnFilePngKey.Click += btnFilePngKey_Click;
            // 
            // filePngKeyJsonInput
            // 
            filePngKeyJsonInput.Location = new Point(648, 108);
            filePngKeyJsonInput.Name = "filePngKeyJsonInput";
            filePngKeyJsonInput.Size = new Size(239, 27);
            filePngKeyJsonInput.TabIndex = 33;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(547, 111);
            label12.Name = "label12";
            label12.Size = new Size(95, 20);
            label12.TabIndex = 32;
            label12.Text = "File key .json:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(77, 60);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 31;
            label11.Text = "Message:";
            // 
            // messagePngInput
            // 
            messagePngInput.Location = new Point(154, 60);
            messagePngInput.Multiline = true;
            messagePngInput.Name = "messagePngInput";
            messagePngInput.Size = new Size(283, 88);
            messagePngInput.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(516, 177);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 29;
            label7.Text = "Output File name:";
            // 
            // outputPngDecoderFileName
            // 
            outputPngDecoderFileName.Location = new Point(648, 177);
            outputPngDecoderFileName.Name = "outputPngDecoderFileName";
            outputPngDecoderFileName.Size = new Size(239, 27);
            outputPngDecoderFileName.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(527, 144);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 27;
            label8.Text = "Output browser:";
            // 
            // btnBrowserOutput
            // 
            btnBrowserOutput.Location = new Point(893, 141);
            btnBrowserOutput.Name = "btnBrowserOutput";
            btnBrowserOutput.Size = new Size(41, 29);
            btnBrowserOutput.TabIndex = 26;
            btnBrowserOutput.Text = "🔗";
            btnBrowserOutput.UseVisualStyleBackColor = true;
            btnBrowserOutput.Click += btnBrowserOutput_Click;
            // 
            // pngOutputDecodeBrowser
            // 
            pngOutputDecodeBrowser.Location = new Point(648, 141);
            pngOutputDecodeBrowser.Name = "pngOutputDecodeBrowser";
            pngOutputDecodeBrowser.Size = new Size(239, 27);
            pngOutputDecodeBrowser.TabIndex = 25;
            // 
            // btnDecodeInputPng
            // 
            btnDecodeInputPng.Location = new Point(893, 74);
            btnDecodeInputPng.Name = "btnDecodeInputPng";
            btnDecodeInputPng.Size = new Size(41, 29);
            btnDecodeInputPng.TabIndex = 24;
            btnDecodeInputPng.Text = "🔗";
            btnDecodeInputPng.UseVisualStyleBackColor = true;
            btnDecodeInputPng.Click += btnDecodeInputPng_Click;
            // 
            // decodePngBtn
            // 
            decodePngBtn.Location = new Point(717, 225);
            decodePngBtn.Name = "decodePngBtn";
            decodePngBtn.Size = new Size(94, 29);
            decodePngBtn.TabIndex = 23;
            decodePngBtn.Text = "Decode";
            decodePngBtn.UseVisualStyleBackColor = true;
            decodePngBtn.Click += decodePngBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(697, 13);
            label9.Name = "label9";
            label9.Size = new Size(114, 38);
            label9.TabIndex = 22;
            label9.Text = "Decode";
            // 
            // pngFileInputDecode
            // 
            pngFileInputDecode.Location = new Point(648, 75);
            pngFileInputDecode.Name = "pngFileInputDecode";
            pngFileInputDecode.Size = new Size(239, 27);
            pngFileInputDecode.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(574, 78);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 21;
            label10.Text = "File .png:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 229);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 19;
            label3.Text = "Output File name:";
            // 
            // pngEncodeFileNameInput
            // 
            pngEncodeFileNameInput.Location = new Point(153, 229);
            pngEncodeFileNameInput.Name = "pngEncodeFileNameInput";
            pngEncodeFileNameInput.Size = new Size(239, 27);
            pngEncodeFileNameInput.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 196);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 17;
            label4.Text = "Output browser:";
            // 
            // btnBrowserPng
            // 
            btnBrowserPng.Location = new Point(398, 193);
            btnBrowserPng.Name = "btnBrowserPng";
            btnBrowserPng.Size = new Size(41, 29);
            btnBrowserPng.TabIndex = 16;
            btnBrowserPng.Text = "🔗";
            btnBrowserPng.UseVisualStyleBackColor = true;
            btnBrowserPng.Click += btnBrowserPng_Click;
            // 
            // outputPngBrowser
            // 
            outputPngBrowser.Location = new Point(153, 193);
            outputPngBrowser.Name = "outputPngBrowser";
            outputPngBrowser.Size = new Size(239, 27);
            outputPngBrowser.TabIndex = 15;
            // 
            // btnFilePng
            // 
            btnFilePng.Location = new Point(398, 154);
            btnFilePng.Name = "btnFilePng";
            btnFilePng.Size = new Size(41, 29);
            btnFilePng.TabIndex = 14;
            btnFilePng.Text = "🔗";
            btnFilePng.UseVisualStyleBackColor = true;
            btnFilePng.Click += btnFilePng_Click;
            // 
            // encodeBtn
            // 
            encodeBtn.Location = new Point(222, 264);
            encodeBtn.Name = "encodeBtn";
            encodeBtn.Size = new Size(94, 29);
            encodeBtn.TabIndex = 13;
            encodeBtn.Text = "Encode";
            encodeBtn.UseVisualStyleBackColor = true;
            encodeBtn.Click += encodeBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(209, 13);
            label5.Name = "label5";
            label5.Size = new Size(110, 38);
            label5.TabIndex = 12;
            label5.Text = "Encode";
            // 
            // filePngInput
            // 
            filePngInput.Location = new Point(153, 155);
            filePngInput.Name = "filePngInput";
            filePngInput.Size = new Size(239, 27);
            filePngInput.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 158);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 11;
            label6.Text = "File .png:";
            // 
            // panelDictionnary
            // 
            panelDictionnary.Controls.Add(label2);
            panelDictionnary.Controls.Add(outputFileTxtName);
            panelDictionnary.Controls.Add(label1);
            panelDictionnary.Controls.Add(btnFileOutputBrowserTxt);
            panelDictionnary.Controls.Add(browserOutputTxtName);
            panelDictionnary.Controls.Add(btnFileTxt);
            panelDictionnary.Controls.Add(createFileDicoBtn);
            panelDictionnary.Controls.Add(TitleDictionnary);
            panelDictionnary.Controls.Add(fileTxtInput);
            panelDictionnary.Controls.Add(labelFileTxt);
            panelDictionnary.Location = new Point(12, 19);
            panelDictionnary.Name = "panelDictionnary";
            panelDictionnary.Size = new Size(943, 270);
            panelDictionnary.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 168);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 9;
            label2.Text = "Output File name:";
            // 
            // outputFileTxtName
            // 
            outputFileTxtName.Location = new Point(322, 168);
            outputFileTxtName.Name = "outputFileTxtName";
            outputFileTxtName.Size = new Size(239, 27);
            outputFileTxtName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 135);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 7;
            label1.Text = "Output browser:";
            // 
            // btnFileOutputBrowserTxt
            // 
            btnFileOutputBrowserTxt.Location = new Point(567, 132);
            btnFileOutputBrowserTxt.Name = "btnFileOutputBrowserTxt";
            btnFileOutputBrowserTxt.Size = new Size(41, 29);
            btnFileOutputBrowserTxt.TabIndex = 6;
            btnFileOutputBrowserTxt.Text = "🔗";
            btnFileOutputBrowserTxt.UseVisualStyleBackColor = true;
            btnFileOutputBrowserTxt.Click += btnFileOutputBrowserTxt_Click;
            // 
            // browserOutputTxtName
            // 
            browserOutputTxtName.Location = new Point(322, 132);
            browserOutputTxtName.Name = "browserOutputTxtName";
            browserOutputTxtName.Size = new Size(239, 27);
            browserOutputTxtName.TabIndex = 5;
            // 
            // btnFileTxt
            // 
            btnFileTxt.Location = new Point(567, 93);
            btnFileTxt.Name = "btnFileTxt";
            btnFileTxt.Size = new Size(41, 29);
            btnFileTxt.TabIndex = 4;
            btnFileTxt.Text = "🔗";
            btnFileTxt.UseVisualStyleBackColor = true;
            btnFileTxt.Click += btnFileTxt_Click;
            // 
            // createFileDicoBtn
            // 
            createFileDicoBtn.Location = new Point(391, 203);
            createFileDicoBtn.Name = "createFileDicoBtn";
            createFileDicoBtn.Size = new Size(94, 29);
            createFileDicoBtn.TabIndex = 3;
            createFileDicoBtn.Text = "Create";
            createFileDicoBtn.UseVisualStyleBackColor = true;
            createFileDicoBtn.Click += createFileDicoBtn_Click;
            // 
            // TitleDictionnary
            // 
            TitleDictionnary.AutoSize = true;
            TitleDictionnary.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleDictionnary.Location = new Point(285, 32);
            TitleDictionnary.Name = "TitleDictionnary";
            TitleDictionnary.Size = new Size(323, 38);
            TitleDictionnary.TabIndex = 2;
            TitleDictionnary.Text = "Création du dictionnaire";
            // 
            // fileTxtInput
            // 
            fileTxtInput.Location = new Point(322, 94);
            fileTxtInput.Name = "fileTxtInput";
            fileTxtInput.Size = new Size(239, 27);
            fileTxtInput.TabIndex = 0;
            // 
            // labelFileTxt
            // 
            labelFileTxt.AutoSize = true;
            labelFileTxt.Location = new Point(257, 97);
            labelFileTxt.Name = "labelFileTxt";
            labelFileTxt.Size = new Size(59, 20);
            labelFileTxt.TabIndex = 1;
            labelFileTxt.Text = "File .txt:";
            // 
            // HideNSeekWord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 386);
            Controls.Add(mainPanel);
            Controls.Add(audioBtn);
            Controls.Add(imageBtn);
            Controls.Add(createDicoBtn);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "HideNSeekWord";
            Text = "HideNSeekWord";
            mainPanel.ResumeLayout(false);
            imagePanel.ResumeLayout(false);
            imagePanel.PerformLayout();
            panelDictionnary.ResumeLayout(false);
            panelDictionnary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button createDicoBtn;
        private Button imageBtn;
        private Button audioBtn;
        private Panel mainPanel;
        private Label labelFileTxt;
        private TextBox fileTxtInput;
        private Panel panelDictionnary;
        private Button createFileDicoBtn;
        private Label TitleDictionnary;
        private Button btnFileTxt;
        private Label label2;
        private TextBox outputFileTxtName;
        private Label label1;
        private Button btnFileOutputBrowserTxt;
        private TextBox browserOutputTxtName;
        private Panel imagePanel;
        private Label label7;
        private TextBox outputPngDecoderFileName;
        private Label label8;
        private Button btnBrowserOutput;
        private TextBox pngOutputDecodeBrowser;
        private Button btnDecodeInputPng;
        private Button decodePngBtn;
        private Label label9;
        private TextBox pngFileInputDecode;
        private Label label10;
        private Label label3;
        private TextBox pngEncodeFileNameInput;
        private Label label4;
        private Button btnBrowserPng;
        private TextBox outputPngBrowser;
        private Button btnFilePng;
        private Button encodeBtn;
        private Label label5;
        private TextBox filePngInput;
        private Label label6;
        private Label label11;
        private TextBox messagePngInput;
        private TextBox filePngKeyJsonInput;
        private Label label12;
        private Button btnFilePngKey;
    }
}
