using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests.Types
{
    // control k + x for code snippet
    // type test and press tab to sort through test snippets
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades; 
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }


        [TestMethod]
        public void UppercaseString()
        {
            string name = "christopher";
            name =  name.ToUpper();

            Assert.AreEqual("CHRISTOPHER", name);

        }
        [TestMethod]
        public void addDaysToDateTime()
        {
            DateTime date = new DateTime(2018, 5, 25);
            date = date.AddDays(1);
            

            Assert.AreEqual(26, date.Day);
        }



        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            Increamentnumber(ref x); // coppied into number. but we never return it back to this... which is why its still correct
            // thus its obviously pass by value.
            Assert.AreEqual(47, x);

        }

        private void Increamentnumber(ref int number)
        {
            number += 1;
        }
        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A gradebook", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A gradebook";
        }
        
        [TestMethod]
        public void StringCOmparisons()
        {
            string name1 = "Scott";
            string name2 = "scott";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Chris's grade book";
            Assert.AreEqual(g1.Name, g2.Name);
            
        }


        
    }
}
