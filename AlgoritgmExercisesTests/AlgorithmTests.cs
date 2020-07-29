using AlgorithmExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Resources;

namespace AlgoritgmExercisesTests
{
    [TestClass]
    public class AlgorithmTests
    {
        [TestMethod]
        public void First()
        {
            int tmp1, tmp2, tmp3;
            tmp1 = Algorithms.First(1, 2);
            tmp2 = Algorithms.First(3, 2);
            tmp3 = Algorithms.First(2, 2);

            Assert.AreEqual(tmp1, 3, 0.001, "Values are not equal");
            Assert.AreEqual(tmp2, 5, 0.001, "Values are not equal");
            Assert.AreEqual(tmp3, 12, 0.001, "Values are not equal");
        }
        [TestMethod]
        public void Second()
        {
            int tmp1, tmp2, tmp3;
            tmp1 = Algorithms.Second(53);
            tmp2 = Algorithms.Second(30);
            tmp3 = Algorithms.Second(51);

            Assert.AreEqual(tmp1, 6, 0.001, "Values are not equal");
            Assert.AreEqual(tmp2, 21, 0.001, "Values are not equal");
            Assert.AreEqual(tmp3, 0, 0.001, "Values are not equal");
        }

        [TestMethod]
        public void Third()
        {
            Assert.IsTrue(Algorithms.Third(30, 0), "expression returns false");
            Assert.IsTrue(Algorithms.Third(25, 5), "expression returns false");
            Assert.IsTrue(Algorithms.Third(20, 30), "expression returns false");
            Assert.IsFalse(Algorithms.Third(20, 25), "expression returns true");
        }

        [TestMethod]
        public void Fourth()
        {
            Assert.IsTrue(Algorithms.Fourth(103), "expression returns false");
            Assert.IsTrue(Algorithms.Fourth(90), "expression returns false");
            Assert.IsFalse(Algorithms.Fourth(89), "expression returns true");
            Assert.IsTrue(Algorithms.Fourth(205), "expression returns false");
            Assert.IsTrue(Algorithms.Fourth(199), "expression returns false");
        }

        [TestMethod]
        public void Fifth()
        {
            string tmp1 = "if else", tmp2 = "else";
            tmp1 = Algorithms.Fifth(tmp1);
            tmp2 = Algorithms.Fifth(tmp2);
            Assert.AreEqual(tmp1, "if else", "Values are not equal");
            Assert.AreEqual(tmp2, "if else", "Values are not equal");
        }

        [TestMethod]
        public void Sixth()
        {
            string str = "Python";
            int tmp1 = 1;
            int tmp2 = 0;
            int tmp3 = 4;

            Assert.AreEqual(Algorithms.Sixth(str, tmp1), "Pthon", "Values are not equal");
            Assert.AreEqual(Algorithms.Sixth(str, tmp2), "ython", "Values are not equal");
            Assert.AreEqual(Algorithms.Sixth(str, tmp3), "Pythn", "Values are not equal");
        }

        [TestMethod]
        public void Seventh()
        {
            string str1 = "abcd";
            string str2 = "a";
            string str3 = "xy";


            Assert.AreEqual(Algorithms.Seventh(str1), "dbca", "Values are not equal");
            Assert.AreEqual(Algorithms.Seventh(str2), "a", "Values are not equal");
            Assert.AreEqual(Algorithms.Seventh(str3), "yx", "Values are not equal");
        }

        [TestMethod]
        public void Eighth()
        {
            string str1 = "C Sharp";
            string str2 = "JS";
            string str3 = "a";


            Assert.AreEqual(Algorithms.Eighth(str1), "C C C C ", "Values are not equal");
            Assert.AreEqual(Algorithms.Eighth(str2), "JSJSJSJS", "Values are not equal");
            Assert.AreEqual(Algorithms.Eighth(str3), "a", "Values are not equal");
        }

        [TestMethod]
        public void Ninth()
        {
            string str1 = "Red";
            string str2 = "Green";
            string str3 = "1";


            Assert.AreEqual(Algorithms.Ninth(str1), "dRedd", "Values are not equal");
            Assert.AreEqual(Algorithms.Ninth(str2), "nGreenn", "Values are not equal");
            Assert.AreEqual(Algorithms.Ninth(str3), "111", "Values are not equal");
        }

        [TestMethod]
        public void Tenth()
        {
            int tmp1 = 3;
            int tmp2 = 14;
            int tmp3 = 12;
            int tmp4 = 37;


            Assert.IsTrue(Algorithms.Tenth(tmp1), "expression returns false");
            Assert.IsTrue(Algorithms.Tenth(tmp2), "expression returns false");
            Assert.IsTrue(Algorithms.Tenth(tmp3), "expression returns false");
            Assert.IsFalse(Algorithms.Tenth(tmp4), "expression returns true");
        }

        [TestMethod]
        public void Eleventh()
        {
            string str1 = "Python";
            string str2 = "JS";
            string str3 = "Code";

            Assert.AreEqual(Algorithms.Eleventh(str1), "PytPythonPyt", "Expresions are not equal");
            Assert.AreEqual(Algorithms.Eleventh(str2), "JSJSJS", "Expresions are not equal");
            Assert.AreEqual(Algorithms.Eleventh(str3), "CodCodeCod", "Expresions are not equal");
        }

        [TestMethod]
        public void Twelfth()
        {
            string str1 = "C# Sharp";
            string str2 = "C#";
            string str3 = "C++";

            Assert.IsTrue(Algorithms.Twelfth(str1), "Expresions returns false");
            Assert.IsTrue(Algorithms.Twelfth(str2), "Expresions returns false");
            Assert.IsFalse(Algorithms.Twelfth(str3), "Expresions returns true");
        }

        [TestMethod]
        public void Thirteenth()
        {
            int tmp1 = 120;
            int tmp2 = -1;
            int tmp3 = 2;

            Assert.IsTrue(Algorithms.Thirteenth(tmp1, tmp2), "Expresions returns false");
            Assert.IsTrue(Algorithms.Thirteenth(tmp2, tmp1), "Expresions returns false");
            Assert.IsFalse(Algorithms.Thirteenth(tmp3, tmp1), "Expresions returns true");
        }

        [TestMethod]
        public void Fourteenth()
        {
            Assert.IsTrue(Algorithms.Fourteenth(100, 199), "Expresions returns false");
            Assert.IsFalse(Algorithms.Fourteenth(250, 300), "Expresions returns true");
            Assert.IsTrue(Algorithms.Fourteenth(105, 190), "Expresions returns false");
        }

        [TestMethod]
        public void Fifteenth()
        {
            Assert.IsTrue(Algorithms.Fifteenth(11, 20, 12), "Expresions returns false");
            Assert.IsTrue(Algorithms.Fifteenth(30, 30, 17), "Expresions returns false");
            Assert.IsTrue(Algorithms.Fifteenth(25, 35, 50), "Expresions returns false");
            Assert.IsFalse(Algorithms.Fifteenth(15, 12, 8), "Expresions returns true");
        }

        [TestMethod]
        public void HundredFortySeventh()
        {
            List<string> str = new List<string>();
            str.Add("Abc");
            str.Add("cdef");
            str.Add("js");
            str.Add("php");

            List<string> answear = new List<string>();
            answear.Add("ABC");
            answear.Add("CDEF");
            answear.Add("JS");
            answear.Add("PHP");

            Assert.IsTrue(Algorithms.HundredFortySeventh(str).SequenceEqual(answear),
                "Expresions returns false");
        }

        [TestMethod]
        public void HundredFortyEighth()
        {
            List<string> str = new List<string>();
            str.Add("abc");
            str.Add("cdaef");
            str.Add("js");
            str.Add("php");

            List<string> answear = new List<string>();
            answear.Add("bc");
            answear.Add("cdef");
            answear.Add("js");
            answear.Add("php");

            Assert.IsTrue(Algorithms.HundredFortyEighth(str).SequenceEqual(answear),
                "Expresions returns false");
        }

        [TestMethod]
        public void HundredFifth()
        {
            int[] tmp = { 10, 22, 35, 47, 53, 67 };
            List<int> answear = new List<int>();
            answear.Add(10);
            answear.Add(22);
            answear.Add(35);
            answear.Add(53);

            Assert.IsTrue(Algorithms.HundredFifth(tmp).SequenceEqual(answear),
                "Expresions returns false");
        }
    }
}
