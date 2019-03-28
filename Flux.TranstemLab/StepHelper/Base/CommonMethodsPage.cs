using System;
using System.IO;
using System.Globalization;
using Flux.Web;
using OpenQA.Selenium;

namespace Flux.TranstemLab.StepHelper.Pages
{
    public class CommonMethodsPage : WebPageBase
    {

        private int step = 1;
        //This Method is for getting the FutureDate
        public string GetFutureDate(int noOfDays)
        {
            DateTime today = DateTime.Now;
            DateTime futureDate = today.AddDays(noOfDays);
            string strDate = futureDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Date is " + strDate);
            return strDate;
        }

        //This Method is for getting the Random Number
        public int GetRandomNumber(int startSeries, int EndSeries)
        {
            Random rnd = new Random();
            int month = rnd.Next(startSeries, EndSeries);
            Console.WriteLine("Random Number is " + month);
            return month;
        }

        public bool[] GetRandomBooleanValues(uint num)
        {
            bool[] results = new bool[num];
            Random rnd = new Random();

            for (int i = 0; i < num; i++)
            {
                if (rnd.Next() % 2 == 0)
                {
                    results[i] = false;
                }
                else
                {
                    results[i] = true;
                }
            }
            return results;
        }

        //This Method is for generating the random Names
        public string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }
            return Name;
        }

        //This method is for generating the phone numbers kind of digit
        public int GeneratePhoneNumbers()
        {
            Random rand = new Random(100);
            int numbers = rand.Next(000000000, 999999999);
            return numbers;
        }

        //this method is to create a directory under logger for screenshots
        public void GenerateDirectory()
        {
            DateTime today = DateTime.Now;
            string date = today.ToString("_yyyy-MM-dd_HH-mm-ss", CultureInfo.InvariantCulture);
            string basePath = WebEnvironment.AppSettings["logFolderPath"];
            string path = basePath + "\\TestScreenShot" + date;
            Console.WriteLine("Path is " + path);
            DirectoryInfo di = Directory.CreateDirectory(path);
            Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));
            Console.WriteLine("Path is " + path);
            if (!basePath.Contains("TestScreenShot"))
            {
                WebEnvironment.AppSettings["logFolderPath"] = path;
            }
        }

        //this method is used for screenshot
        public void TakeScreenShot()
        {
            Actions.TakeScreenshot(ScreenshotImageFormat.Jpeg, WebEnvironment.AppSettings["logFolderPath"], step.ToString() + ".jpg");
            step++;
            Waits.WaitForPageLoad();
        }

        //this method used to generate our H7L message
        public void GenerateHL7(string productId, string productCode, string fileName)
        {
            Console.WriteLine("==================================================================================");
            Console.WriteLine(productId + " and " + productCode);
            string filePath = AppContext.BaseDirectory;
            filePath = filePath.Replace(@"\Flux.TranstemLab\bin\Debug\", "\\Attachment\\" + fileName);
            string basePath = WebEnvironment.AppSettings["logFolderPath"];
            string destenation = basePath + "\\" + productId + "_NotRepeatedHL7.txt";
            string lines = File.ReadAllText(filePath);
            lines = lines.Replace("O_SampleNo", productId);
            lines = lines.Replace("O_SampleAttribute", productCode);
            Console.WriteLine(lines);
            File.WriteAllText(destenation, lines);
            /*
            foreach (string line in lines)
            {
                line.Replace("SampleNo", productId);
                line.Replace("SampleAttribute", productCode);
                Console.WriteLine(line);
            }
            StreamWriter file = new StreamWriter(AppContext.BaseDirectory + "\\Attachment\\" + productId + "_NotRepeated.txt");
            foreach(string line in lines)
            {
                file.WriteLine(line);
            }
            */
        }
    }
}
