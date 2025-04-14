using TextBuster.Coding;
using TextBuster.Coding.FileBuster;
using TextBuster.Coding.Tree;
using TextBuster.Steganography.Audio;
using TextBuster.Steganography.Image;
using Random = TextBuster.Steganography.Random;

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

            // TextEncoder fileEncoder = new TextEncoder("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\test_buster.txt");
            // fileEncoder.EncodeAndSaveTo("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\test_buster_compressed.bin");
            // fileEncoder.GiveKey("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\test_buster_keys.json");
            //
            // TextDecoder fileDecoder = new TextDecoder("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\test_buster_compressed.bin","C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\test_buster_keys.json");
            // fileDecoder.DecodeAndSaveTo("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\test_buster_decompressed.txt");
            // Console.WriteLine("VITA");

            // ImageEncoder imageEncoder = new ImageEncoder("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\rose.png","How would you feel? If i told you i love you. It's just something i want to do. Taking my time spending my life, Falling deeper in love with you. Tell me that you love me too");
            // imageEncoder.EncodeAndSaveTo("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\rose_encoded.png");
            // imageEncoder.GiveKey("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\rose_key.json");
            //
            // ImageDecoder imageDecoder = new ImageDecoder("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\rose_encoded.png","C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\rose_key.json");
            // imageDecoder.DecodeAndSaveTo("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\rose_encoded.txt");

            // AudioEncoder audioEncoder = new AudioEncoder("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\PinkPanther30.wav","My one and only love i've been lonely long enough will i find you when the night is over");
            // audioEncoder.EncodeAndSaveTo("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\Pink_encoded.wav");
            // audioEncoder.GiveKey("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\Pink_key.json");

            // AudioDecoder audioDecoder = new AudioDecoder("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\Pink_encoded.wav","C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\Pink_key.json");
            // audioDecoder.DecodeAndSaveTo("C:\\Users\\ryrab\\Desktop\\Ryan\\Etudes\\S6\\steganographie\\Pink.txt");

            global::System.Windows.Forms.Application.EnableVisualStyles();
            global::System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            global::System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.Run(new HideNSeekWord());
        }
    }
}