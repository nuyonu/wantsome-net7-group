namespace Week7.ExceptionsAndLinq.WorkWithFiles
{
    public static class WorkWithFiles
    {
        public static void Run()
        {
            // "D:\Projects\GitHub\wantsome-net7-group\Week7.ExceptionsAndLinq\Week7.ExceptionsAndLinq\WorkWithFiles\demoFile.txt"

            string currentWorkingDirectory = Directory.GetCurrentDirectory();
            string fileName = "demoFile.txt";

            //string path = @"D:\Projects\GitHub\wantsome-net7-group\Week7.ExceptionsAndLinq\Week7.ExceptionsAndLinq\WorkWithFiles2\demoFile.txt";
            string path = Path.Combine(currentWorkingDirectory, fileName);

            //string text = File.ReadAllText(path);

            //Console.WriteLine(text);

            //string[] lines = File.ReadAllLines(path);

            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            //StreamReader streamReader = new StreamReader(path);

            //string line;

            //while((line = streamReader.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //}

            try
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(FileNotFoundException exception)
            {
                //Console.WriteLine(exception.Message);

                Console.WriteLine("Fisierul dat ca input nu exista.");
            }
            catch(DirectoryNotFoundException exception)
            {
                Console.WriteLine("Path-ul este gresit.");
            }
        }
    }
}
