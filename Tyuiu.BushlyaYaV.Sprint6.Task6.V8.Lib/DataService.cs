
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BushlyaYaV.Sprint6.Task6.V8.Lib
{
    public class DataService : ISprint6Task6V8
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    string[] words = line.Split(' ');

                    foreach (string word in words)
                    {
                        if (word.Contains('z'))
                        {
                            resStr += word + " ";
                        }

                    }
                }
            }
            return resStr;
        }
    }
}
