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
            mainPanel.Controls.Add(panelDictionnary);
            mainPanel.Location = new Point(0, 63);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(964, 311);
            mainPanel.TabIndex = 3;
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
            createFileDicoBtn.Text = "Créer";
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
    }
}
