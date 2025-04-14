using TextBuster.Coding.FileBuster;
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
                // Optionnel : D�finir le dossier racine (par d�faut : Bureau)
                folderBrowser.RootFolder = Environment.SpecialFolder.Desktop;

                // Optionnel : D�finir la description
                folderBrowser.Description = "Veuillez s�lectionner un dossier.";

                // Optionnel : Permettre la cr�ation de nouveaux dossiers
                folderBrowser.ShowNewFolderButton = true;

                // Affiche la bo�te de dialogue et r�cup�re le r�sultat
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    browserOutputTxtName.Text = folderBrowser.SelectedPath;
                }
                else
                {
                    Console.WriteLine("Aucun dossier s�lectionn�.");
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
                // Optionnel : D�finir le dossier racine (par d�faut : Bureau)
                folderBrowser.RootFolder = Environment.SpecialFolder.Desktop;

                // Optionnel : D�finir la description
                folderBrowser.Description = "Veuillez s�lectionner un dossier.";

                // Optionnel : Permettre la cr�ation de nouveaux dossiers
                folderBrowser.ShowNewFolderButton = true;

                // Affiche la bo�te de dialogue et r�cup�re le r�sultat
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    outputPngBrowser.Text = folderBrowser.SelectedPath;
                }
                else
                {
                    Console.WriteLine("Aucun dossier s�lectionn�.");
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
                // Optionnel : D�finir le dossier racine (par d�faut : Bureau)
                folderBrowser.RootFolder = Environment.SpecialFolder.Desktop;

                // Optionnel : D�finir la description
                folderBrowser.Description = "Veuillez s�lectionner un dossier.";

                // Optionnel : Permettre la cr�ation de nouveaux dossiers
                folderBrowser.ShowNewFolderButton = true;

                // Affiche la bo�te de dialogue et r�cup�re le r�sultat
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    pngOutputDecodeBrowser.Text = folderBrowser.SelectedPath;
                }
                else
                {
                    Console.WriteLine("Aucun dossier s�lectionn�.");
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
            imageDecoder.DecodeAndSaveTo(pngOutputDecodeBrowser.Text+ "\\" + outputPngDecoderFileName.Text +".txt");
            Cursor = Cursors.Default;
        }
    }
}
