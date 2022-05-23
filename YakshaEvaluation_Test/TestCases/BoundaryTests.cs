using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

using Xunit.Abstractions;
using IntToString;
using DateClass;
using HCF;

namespace YakshaEvaluation_Test.TestCases
{
    public class BoundaryTests
    {
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        private readonly ITestOutputHelper _output;
        private static string type = "Boundary";
        #region HCF

        /// <summary>
        /// Test to find HCF for zero value is return 0 or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFindHCF_ForZeroValues()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int n1 = 0 , n2 = 0, expected=0;
            try
            {
                HCFCalculation hCF = new HCFCalculation();
                int result = hCF.FindHCF(n1, n2);

                //Act
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

        /// <summary>
        /// Test to find find HCF for maximum boundary value is return
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFindHCFFor_MaxValues()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int n1 = 2147483647, n2 = 2147483646, expected = 1;
            try
            {
                HCFCalculation hCF = new HCFCalculation();

                //Act
                int result = hCF.FindHCF(n1, n2);

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
        /// Test to check Month range - For Minimal value 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckMonthRange_ForMinimalValue()
        {
            //Arrange
            bool res = false, expected = true;
            string strDateTime = DateTime.MinValue.ToString();
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                DateClassOperations dateClassOperations
                    = new DateClassOperations();

                //Act
                bool result = dateClassOperations.CheckMonthRange(strDateTime);

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

        /// <summary>
        /// Test to check Month range - For Max value 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckMonthRange_ForMaxValue()
        {
            ////Arrange
            bool res=false, expected = true;
            string strDateTime = DateTime.MaxValue.ToString();
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
        /// Test to check Date range - For Minimal value 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckDayRange_ForMinimalValue()
        {
            //Arrange
            bool res = false, expected = true;
            string strDateTime = DateTime.MinValue.ToString();
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                DateClassOperations dateClassOperations
                    = new DateClassOperations();

                //Act
                bool result = dateClassOperations.CheckDayRange(strDateTime);

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

        /// <summary>
        /// Test to check Date range - For Max value 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckDayRange_ForMaxValue()
        {
            ////Arrange
            bool res = false, expected = true;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            string strDateTime = DateTime.MaxValue.ToString();
            try
            {
                DateClassOperations dateClassOperations
                    = new DateClassOperations();

                //Act
                bool result = dateClassOperations.CheckDayRange(strDateTime);

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

        /// <summary>
        /// Test to Find weekDay for the Minimum Date Value
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_GetWeekDay_ForMinimalValue()
        {
            //Arrange
            string expected = DateTime.MinValue.DayOfWeek.ToString();
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            string minDate = DateTime.MinValue.ToString();
            try
            {
                DateClassOperations dateClassOperations
                    = new DateClassOperations();

                //Act
                string result = dateClassOperations.GetWeekDayOfDate(minDate);

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

        /// <summary>
        /// Test to Find WeekDay for the Maximum Date Value
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_GetWeekDay_ForMaxValue()
        {
            ////Arrange
            string expected = DateTime.MaxValue.DayOfWeek.ToString();
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            string maxDate = DateTime.MaxValue.ToString();

            try
            {
                DateClassOperations dateClassOperations
                    = new DateClassOperations();

                //Act
                string result = dateClassOperations.GetWeekDayOfDate(maxDate);

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

        #region NumberToString
        /// <summary>
        /// Test to Write Int To String for Zero value 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestWriteIntToString_ForZeroValue()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                ConvertIntToString convertIntToString = new ConvertIntToString();
                //Act
                string result = convertIntToString.WriteIntToString(0);

                //Assertion
                if (result == "Zero")
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
