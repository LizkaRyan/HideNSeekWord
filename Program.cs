using TextBuster.Coding;
using TextBuster.Coding.FileBuster;
using TextBuster.Coding.Tree;
using TextBuster.Steganography.Image;

namespace TextBuster
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // string content =
            //     "For any code that is biunique, meaning that the code is uniquely decodeable, the sum of the probability budgets across all symbols is always less than or equal to one. In this example, the sum is strictly equal to one; as a result, the code is termed a complete code. If this is not the case, one can always derive an equivalent code by adding extra symbols (with associated null probabilities), to make the code complete while keeping it biunique";


            // TextEncoder fileEncoder = new TextEncoder("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\test_buster.txt");
            // fileEncoder.EncodeAndSaveTo("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\test_buster_compressed.bin");
            // fileEncoder.GiveKey("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\test_buster_keys.json");
            //
            // TextDecoder fileDecoder = new TextDecoder("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\test_buster_compressed.bin","C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\test_buster_keys.json");
            // fileDecoder.DecodeAndSaveTo("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\test_buster_decompressed.txt");
            // Console.WriteLine("VITA");

            ImageEncoder imageEncoder = new ImageEncoder("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\rose.png","Il n'est pas fou il y croit c'est tout");
            imageEncoder.EncodeAndSaveTo("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\rose_encoded.png");
            imageEncoder.GiveKey("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\rose_key.json");

            // ImageDecoder imageDecoder = new ImageDecoder("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\rose_encoded.png","C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\rose_key.json");
            // imageDecoder.DecodeAndSaveTo("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\rose_encoded.txt");
            //
            // ApplicationConfiguration.Initialize();
            // Application.Run(new Form1());
        }
    }
}