using DateClass;
using HCF;
using IntToString;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace YakshaEvaluation_Test.TestCases
{
   public class FunctionalTests
    {
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        private readonly ITestOutputHelper _output;
        private static string type = "Functional";

        #region HCF 
        /// <summary>
        /// Test to find HCF of 2 numbers - result is returned as expected
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFindHCF_ExpectedValue()
        {
            //Arrange
            bool res = false;
            int expected = 5;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int n1 = 5, n2 = 10;
            try
            {
                HCFCalculation hCFCalculation = new HCFCalculation();
                //Act
                int result = hCFCalculation.FindHCF(n1, n2);

                //Assertion
                if (result == expected)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                //final result save in text file if exception raised
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //final result save in text file, Call rest API to save test result
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }
        #endregion

        #region DateClass
        /// <summary>
        /// Test to check MonthPart of Date, is in the range (1-12)
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckMonthRange_ExpectedValue()
        {
            ////Arrange
           bool res=false, expected = true;
           string strDateTime = DateTime.Today.ToString();
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                DateClassOperations dateClassOperations
                    = new DateClassOperations();

                //Act
                res = dateClassOperations.CheckMonthRange(strDateTime);

                //Assertion
                if (res == expected)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                //final result save in text file if exception raised
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //final result save in text file, Call rest API to save test result
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        /// <summary>
        /// Test to check Given Date is in the range 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckDayRange_ExpectedValue()
        {
            ////Arrange
            bool res=false, expected = true;
            string strDateTime = DateTime.Today.ToString();
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                DateClassOperations dateClassOperations
                    = new DateClassOperations();

                //Act
                res = dateClassOperations.CheckDayRange(strDateTime);

                //Assertion
                if (res == expected)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                //final result save in text file if exception raised
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //final result save in text file, Call rest API to save test result
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        /// <summary>
        /// Test to Find Week Day for the provided date is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_GetWeekDay_ExpectedValue()
        {
            ////Arrange
            bool res = false;
            string expected = DateTime.Today.DayOfWeek.ToString();
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                DateClassOperations dateClassOperations
                    = new DateClassOperations();

                //Act
                string result = dateClassOperations.GetWeekDayOfDate(DateTime.Today.ToString());

                //Assertion
                if (expected == result)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                //final result save in text file if exception raised
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //final result save in text file, Call rest API to save test result
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }
        #endregion

        #region IntToString

        /// <summary>
        /// Test to Write Int To String - result is returned as expected
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestWriteIntToString_ExpectedValue()
        {
            //Arrange
            bool res = false;
            string expexted = "Five Zero Zero";
            int number = 500;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                ConvertIntToString convertIntToString = new ConvertIntToString();
                //Act
                string result = convertIntToString.WriteIntToString(number);

                //Assertion
                if (result == expexted)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                //final result save in text file if exception raised
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //final result save in text file, Call rest API to save test result
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        #endregion
    }
}
