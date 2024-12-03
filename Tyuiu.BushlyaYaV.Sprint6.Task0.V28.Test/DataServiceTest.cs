
using Tyuiu.BushlyaYaV.Sprint6.Task0.V28.Lib;
namespace Tyuiu.BushlyaYaV.Sprint6.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VallidCalc()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 169.89;
            Assert.AreEqual(wait, res);
        }
    }
}
