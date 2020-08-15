using Diziler.Common;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Diziler.Tests
{
    public class Tests
    {
        [Test]
        public void EmptyIntegerArrayHasValuesWithOnlyZero()
        {
            var ds = new DataSupplier();
            var numbers = ds.GetEmptyIntegerArray();
            Assert.True(numbers.Length == 3);
            Assert.True(numbers[0] == 0);
            Assert.True(numbers[1] == 0);
            Assert.True(numbers[2] == 0);
        }

        [Test]
        public void FilledIntegerArrayHasValuesOnEachIndices()
        {
            var ds = new DataSupplier();
            var numbers = ds.GetIntegerArray();
            Assert.AreEqual(3, numbers.Length);
            Assert.AreEqual(1, numbers[0]);
            Assert.AreEqual(3, numbers[1]);
            Assert.AreEqual(5, numbers[2]);
        }

        [Test]
        public void FilledPersonsArrayHasProperValues()
        {
            var ds = new DataSupplier();
            var people = ds.GetPeople();
            Assert.AreEqual(32, people[0].age);
            Assert.AreEqual(23, people[1].age);
            Assert.AreEqual(24, people[2].age);
        }

        [Test]
        public void NumberArrayTests()
        {
            var ds = new DataSupplier();
            var numbers = ds.GetNumbers();
            var sum = GetSum(numbers.ToArray());
            var sum2 = GetSumV2(numbers.ToArray());
            Assert.AreEqual(45, sum); // (n * (n + 1)) / 2
            Assert.AreEqual(45, sum2);
        }

        [Test]
        public void AritmeticOperatorMakesUsConfused()
        {
            var i = 7;
            var b = i++; // b = i = i + 1
            var c = ++i; // c = (i = i + 1)

            var d = i--;
            var e = --i;

            Assert.AreEqual(7, b); 
            Assert.AreEqual(9, c); 
            Assert.AreEqual(9, d);
            Assert.AreEqual(7, e);
            Assert.AreEqual(7, i);
        }

        [Test]
        public void LyricOfSongHasCharacters()
        {
            var ds = new DataSupplier();
            var lyric = ds.GetLyric();
            Assert.IsTrue(lyric.Length == 64);
        }

        [Test]
        public void LyricOfSongCharacterCount()
        {
            var ds = new DataSupplier();
            var th = new TextHelper();
            var lyric = ds.GetLyric();
            var numberOfA = th.GetNumberOfLetters(lyric, 'a');
            var numberOfE = th.GetNumberOfLetters(lyric, 'e');
            Assert.AreEqual(4, numberOfA);
            Assert.AreEqual(6, numberOfE);
        }

        //TODO: Bu iki method baþka helper a alýnýp console dan çaðýrýlacak
        private int GetSum(int[] numbers)
        {
            var s = 0;
            for(var i = 0; i < numbers.Length; i++)
            {
                s = s + numbers[i];
            }
            return s;
        }

        private int GetSumV2(IEnumerable<int> numbers)
        {
            var s = 0;
            foreach(var i in numbers)
            {
                s += i;
            }
            return s;
        }
    }
}

/*
 i = 5;
 i++        ====> 6
 i += 3     ====> 9
 i--        ====> 8
 i-= 2      ====> 6
 i = i + 4  ====> 10
 i = i - 3  ====> 7
 ++i        ====> 8
 --i        ====> 7
 */