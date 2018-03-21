using System.Drawing;
using System.Linq;
using BenchmarkDotNet.Attributes;
using ColorThiefDotNet;

namespace SpeedTest
{
    public class TestClass
    {
        [Benchmark]
        public void Image1()
        {
            var colorThief = new ColorThief();
            var bitmap = (Bitmap)Image.FromFile("test1.jpg");
            var result = colorThief.GetColor(bitmap);
        }

        [Benchmark]
        public void Image2()
        {
            var colorThief = new ColorThief();
            var bitmap = (Bitmap)Image.FromFile("test2.jpg");
            var result = colorThief.GetColor(bitmap);
        }

        [Benchmark]
        public void Image3()
        {
            var colorThief = new ColorThief();
            var bitmap = (Bitmap)Image.FromFile("test3.jpg");
            var result = colorThief.GetPalette(bitmap, 5, 1, true).OrderByDescending(a=>a.Population);
        }
    }
}