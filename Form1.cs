using System.Text.Json;
using TextBuster.Coding;
using TextBuster.Coding.FileBuster;
using TextBuster.Steganography.Audio;
using TextBuster.Steganography.Image;

namespace TextBuster
{
    public partial class HideNSeekWord : Form
    {
        public HideNSeekWord()
        {
            InitializeComponent();
        }

        private void createDicoBtn_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(this.panelDictionnary);
        }

        private void btnFileTxt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Tous les fichiers (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileTxtInput.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnFileOutputBrowserTxt_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                // Optionnel : Définir le dossier racine (par défaut : Bureau)
                folderBrowser.RootFolder = Environment.SpecialFolder.Desktop;

                // Optionnel : Définir la description
                folderBrowser.Description = "Veuillez sélectionner un dossier.";

                // Optionnel : Permettre la création de nouveaux dossiers
                folderBrowser.ShowNewFolderButton = true;

                // Affiche la boîte de dialogue et récupère le résultat
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    browserOutputTxtName.Text = folderBrowser.SelectedPath;
                }
                else
                {
                    Console.WriteLine("Aucun dossier sélectionné.");
                }
            }
        }

        private void createFileDicoBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            TextEncoder textEncoder = new TextEncoder(fileTxtInput.Text);
            textEncoder.GiveKey(browserOutputTxtName.Text + "\\" + outputFileTxtName.Text + ".json");
            Cursor = Cursors.Default;
        }

        private void btnFilePng_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Tous les fichiers (*.png)|*.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePngInput.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowserPng_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                // Optionnel : Définir le dossier racine (par défaut : Bureau)
                folderBrowser.RootFolder = Environment.SpecialFolder.Desktop;

                // Optionnel : Définir la description
                folderBrowser.Description = "Veuillez sélectionner un dossier.";

                // Optionnel : Permettre la création de nouveaux dossiers
                folderBrowser.ShowNewFolderButton = true;

                // Affiche la boîte de dialogue et récupère le résultat
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    outputPngBrowser.Text = folderBrowser.SelectedPath;
                }
                else
                {
                    Console.WriteLine("Aucun dossier sélectionné.");
                }
            }
        }

        private void encodeBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ImageEncoder imageEncoder = new ImageEncoder(filePngInput.Text, messagePngInput.Text);
            imageEncoder.EncodeAndSaveTo(outputPngBrowser.Text + "\\" + pngEncodeFileNameInput.Text + ".png");
            imageEncoder.GiveKey(outputPngBrowser.Text + "\\" + pngEncodeFileNameInput.Text + "_key.json");
            Cursor = Cursors.Default;
        }

        private void imageBtn_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(imagePanel);
        }

        private void btnDecodeInputPng_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Tous les fichiers (*.png)|*.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pngFileInputDecode.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowserOutput_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                // Optionnel : Définir le dossier racine (par défaut : Bureau)
                folderBrowser.RootFolder = Environment.SpecialFolder.Desktop;

                // Optionnel : Définir la description
                folderBrowser.Description = "Veuillez sélectionner un dossier.";

                // Optionnel : Permettre la création de nouveaux dossiers
                folderBrowser.ShowNewFolderButton = true;

                // Affiche la boîte de dialogue et récupère le résultat
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    pngOutputDecodeBrowser.Text = folderBrowser.SelectedPath;
                }
                else
                {
                    Console.WriteLine("Aucun dossier sélectionné.");
                }
            }
        }

        private void btnFilePngKey_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Tous les fichiers (*.json)|*.json";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePngKeyJsonInput.Text = openFileDialog.FileName;
                }
            }
        }

        private void decodePngBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ImageDecoder imageDecoder = new ImageDecoder(pngFileInputDecode.Text, filePngKeyJsonInput.Text);
            imageDecoder.DecodeAndSaveTo(pngOutputDecodeBrowser.Text + "\\" + outputPngDecoderFileName.Text + ".txt");
            Cursor = Cursors.Default;
        }

        private void btnInputWav_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Tous les fichiers (*.wav)|*.wav";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileInputWav.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnOutputBrowser_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                // Optionnel : Définir le dossier racine (par défaut : Bureau)
                folderBrowser.RootFolder = Environment.SpecialFolder.Desktop;

                // Optionnel : Définir la description
                folderBrowser.Description = "Veuillez sélectionner un dossier.";

                // Optionnel : Permettre la création de nouveaux dossiers
                folderBrowser.ShowNewFolderButton = true;

                // Affiche la boîte de dialogue et récupère le résultat
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    outputWavBrowser.Text = folderBrowser.SelectedPath;
                }
                else
                {
                    Console.WriteLine("Aucun dossier sélectionné.");
                }
            }
        }

        private void encodeWavBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AudioEncoder audioEncoder = new AudioEncoder(fileInputWav.Text, messageAudio.Text);
            audioEncoder.EncodeAndSaveTo(outputWavBrowser.Text + "\\" + outputWavName.Text + ".wav");
            audioEncoder.GiveKey(outputWavBrowser.Text + "\\" + outputWavName.Text + "_key.json");
            Cursor = Cursors.Default;
        }

        private void btnInputDecode_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Tous les fichiers (*.wav)|*.wav";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputDecodeWav.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnWavKeyDecode_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Tous les fichiers (*.json)|*.json";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileDecodeKeyInput.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnOutputBrowserWav_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                // Optionnel : Définir le dossier racine (par défaut : Bureau)
                folderBrowser.RootFolder = Environment.SpecialFolder.Desktop;

                // Optionnel : Définir la description
                folderBrowser.Description = "Veuillez sélectionner un dossier.";

                // Optionnel : Permettre la création de nouveaux dossiers
                folderBrowser.ShowNewFolderButton = true;

                // Affiche la boîte de dialogue et récupère le résultat
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    outputDecodeBrowserWav.Text = folderBrowser.SelectedPath;
                }
                else
                {
                    Console.WriteLine("Aucun dossier sélectionné.");
                }
            }
        }

        private void btnDecodeWav_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AudioDecoder audioDecoder = new AudioDecoder(inputDecodeWav.Text, fileDecodeKeyInput.Text);
            audioDecoder.DecodeAndSaveTo(outputDecodeBrowserWav.Text + "\\" + outputNameWavDecoded.Text + ".txt");
            Cursor = Cursors.Default;
        }

        private void audioBtn_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(audioPanel);
        }

        private void languageAnalyzerfileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Tous les fichiers (*.json)|*.json";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileKeyNameTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void isItALanguageBtn_Click(object sender, EventArgs e)
        {
            KeyDecoder keyDecoder = JsonSerializer.Deserialize<KeyDecoder>(File.ReadAllText(fileKeyNameTextBox.Text));
            labelIsALanguage.Text = "It is not a language";
            panelIsALanguage.BackColor = Color.Red;
            if (keyDecoder.IsALanguage())
            {
                panelIsALanguage.BackColor = Color.Green;
                labelIsALanguage.Text = "This is a language";
            }
        }
    }
}
