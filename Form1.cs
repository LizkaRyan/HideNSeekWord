using TextBuster.Coding.FileBuster;

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
            TextEncoder textEncoder = new TextEncoder(fileTxtInput.Text);
            textEncoder.GiveKey(browserOutputTxtName.Text+"\\"+outputFileTxtName.Text+".json");
        }
    }
}
