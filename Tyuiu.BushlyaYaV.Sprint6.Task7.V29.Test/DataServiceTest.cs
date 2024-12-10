using Tyuiu.BushlyaYaV.Sprint6.Task7.V29.Lib;
namespace Tyuiu.BushlyaYaV.Sprint6.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask7V29.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
