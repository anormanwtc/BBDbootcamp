namespace CSharp
{
    public class ReadnWrite
    {
        public static void RnR() {
            string[] towrite = {"Hello","There"};
            string filePath = "C:/Users/bbdnet2196/Desktop/TestWrite/Test.txt";
            // worked
            //System.IO.File.Create(filePath);

            // System.IO.File.WriteAllLines(filePath, towrite);
            // System.IO.File.WriteAllText(filePath, towrite[0]);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath))
            {
                foreach (string line in towrite)
                {
                    file.WriteLine(line);
                }
            }
            string text = System.IO.File.ReadAllText(filePath);
            string[] lines = System.IO.File.ReadAllLines(filePath);

            System.IO.StreamReader fileRead = new System.IO.StreamReader(filePath);  
            string lineRead;
            while((lineRead = fileRead.ReadLine()) != null)  
            {  
                System.Console.WriteLine(lineRead);
            }
            fileRead.Close();
            //fileRead.Dispose(); //alternate more general disposal

        }
    }
}