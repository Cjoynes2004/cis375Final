using Microsoft.VisualStudio.TestTools.UnitTesting;
using CIS375Final;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS375Final.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void CheckReusableTest()
        {
            List<CheckBox> testcheckboxes = new List<CheckBox>();
            Form1 testForm = new Form1();

            CheckBox test1 = new CheckBox();
            CheckBox test2 = new CheckBox();
            CheckBox test3 = new CheckBox();
            CheckBox test4 = new CheckBox();
            CheckBox test5 = new CheckBox();
            CheckBox test6 = new CheckBox();
            CheckBox test7 = new CheckBox();
            CheckBox test8 = new CheckBox();
            CheckBox test9 = new CheckBox();
            CheckBox test10 = new CheckBox();
            CheckBox test11 = new CheckBox();
            CheckBox test12 = new CheckBox();
            CheckBox test13 = new CheckBox();
            CheckBox test14 = new CheckBox();
            CheckBox test15 = new CheckBox();
            testcheckboxes.Add(test1);
            testcheckboxes.Add(test2);
            testcheckboxes.Add(test3);
            testcheckboxes.Add(test4);
            testcheckboxes.Add(test5);
            testcheckboxes.Add(test6);
            testcheckboxes.Add(test7);
            testcheckboxes.Add(test8);
            testcheckboxes.Add(test9);
            testcheckboxes.Add(test10);
            testcheckboxes.Add(test11);
            testcheckboxes.Add(test12);
            testcheckboxes.Add(test13);
            testcheckboxes.Add(test14);
            testcheckboxes.Add(test15);

            //Test Case 1: Every function is unchecked.
            //Assign
            foreach (var check in testcheckboxes)
            {
                check.Checked = false;
            }
            //Act
            bool test = testForm.CheckReusable(testcheckboxes);

            //Assert
            Assert.IsFalse(test);

            //Test Case 2: Every function is checked.
            //Assign
            foreach (var check in testcheckboxes)
            {
                check.Checked = true;
            }
            //Act
            test = testForm.CheckReusable(testcheckboxes);

            //Assert
            Assert.IsTrue(test);


            //Test Case 3: 1-5, 7-9, 11-14 are checked, rest aren't
            //Assign
            foreach (var check in testcheckboxes)
            {
                check.Checked = true;
            }
            testcheckboxes[5].Checked = false;
            testcheckboxes[9].Checked = false;
            testcheckboxes[14].Checked = false;

            //Act
            test = testForm.CheckReusable(testcheckboxes);

            //Assert
            Assert.IsTrue(test);

            //Test Case 4: 1-3, 8-11 are checked, rest aren't
            //Assign
            foreach (var check in testcheckboxes)
            {
                check.Checked = true;
            }
            for (int i = 3; i <= 6; ++i)
            {
                testcheckboxes[i].Checked = false;
            }
            for (int i = 11; i <= 14; ++i)
            {
                testcheckboxes[i].Checked = false;
            }

            //Act
            test = testForm.CheckReusable(testcheckboxes);

            //Assert
            Assert.IsFalse(test);

            //Test Case 5: 1 is unchecked, rest are
            //Assign
            foreach (var check in testcheckboxes)
            {
                check.Checked = true;
            }
            testcheckboxes[0].Checked = false;

            //Act
            test = testForm.CheckReusable(testcheckboxes);

            //Assert
            Assert.IsFalse(test);

            //Test Case 6: 8 is unchecked, rest are
            //Assign
            foreach (var check in testcheckboxes)
            {
                check.Checked = true;
            }
            testcheckboxes[7].Checked = false;

            //Act
            test = testForm.CheckReusable(testcheckboxes);

            //Assert
            Assert.IsFalse(test);

            //Test Case 7: 11 is unchecked, rest are
            //Assign
            foreach (var check in testcheckboxes)
            {
                check.Checked = true;
            }
            testcheckboxes[10].Checked = false;

            //Act
            test = testForm.CheckReusable(testcheckboxes);

            //Assert
            Assert.IsFalse(test);
        }
    }
}