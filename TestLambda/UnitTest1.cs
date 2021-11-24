using Day_24_Assign_lambda;
using NUnit.Framework;

namespace TestLambda
{
    public class Tests
    {
        CheckPattern check;

        [SetUp]
        public void Setup()
        {
            check = new CheckPattern();
        }

        [Test]
        // Happy test case for first name
        public void First_Name_Happy_Test()
        {
            string resultFName = check.FirstNameValidation("Santoshi");
            Assert.AreEqual("True", resultFName);
        }

        [Test]
        // Happy test case for last name
        public void Last_Name_Happy_Test()
        {
            string resultLName = check.LastNameValidation("Nawkhare");
            Assert.AreEqual("True", resultLName);
        }

        [Test]
        // Happy test case for email
        public void Email_Happy_TestCase()
        {
            string resultEmail = check.EmailValidation("abc@bl.co");
            Assert.AreEqual("True", resultEmail);
        }

        [Test]
        // Happy test case for phone number
        public void Phone_Number_Happy_Test()
        {
            string resultPhone = check.PhoneNoValidation("91 7447880945");
            Assert.AreEqual("True", resultPhone);
        }

        [Test]
        // Happy test case for password
        public void UC_8_Password_Happy_TestCase()

        {
            string resultPasswd = check.UC_8_PasswordValidation("xyzB23@daeif");
            Assert.AreEqual("True", resultPasswd);
        }

        [Test]
        // Sad test case for first name
        public void FName_Sad_Test()
        {
            try
            {
                string resultFName = check.FirstNameValidation("Santoshi");
                Assert.AreEqual("Invalid First Name,First letter should be upper case", resultFName);
            }
            catch (CheckCustomExceptionPattern ex)
            {
                Assert.AreEqual("Invalid First Name,First letter should be upper case", ex.Message);
            }
        }

        [Test]
        // Sad test case last name
        public void LName_Sad_Test()
        {
            try
            {
                string resultLName = check.LastNameValidation("Nawkhare");
                Assert.AreEqual("Invalid Last Name,First letter should be upper case", resultLName);
            }
            catch (CheckCustomExceptionPattern ex)
            {
                Assert.AreEqual("Invalid Last Name,First letter should be upper case", ex.Message);

            }
        }

        [Test]
        // Sad test case for email
        public void Email_Sad_Test()
        {
            try
            {
                string resultEmail = check.EmailValidation("abc@bl.co");
                Assert.AreEqual("Invalid Email Address Format", resultEmail);
            }
            catch (CheckCustomExceptionPattern ex)
            {
                Assert.AreEqual("Invalid Email Address Format", ex.Message);
            }
        }

        [Test]
        // Sad test case for phone number
        public void PhoneNo_Sad_Test()
        {
            try
            {
                string resultPhone = check.PhoneNoValidation("91 7447880945");
                Assert.AreEqual("Invalid Phone Number", resultPhone);
            }
            catch (CheckCustomExceptionPattern ex)
            {
                Assert.AreEqual("Invalid Phone Number", ex.Message);
            }
        }

        [Test]
        // Sad test case for emai
        public void UC_8_Password_Sad_Test()
        {
            try
            {
                string resultPasswd = check.UC_8_PasswordValidation("xyzB23@daeif");
                Assert.AreEqual("Invalid Password", resultPasswd);
            }
            catch (CheckCustomExceptionPattern ex)
            {
                Assert.AreEqual("Invalid Password", ex.Message);
            }
        }

        [Test]
        public void AllEmailTest()
        {
            string resultEmail = check.allEmailValidation("abc+100@gmail.com");
            Assert.AreEqual("True", resultEmail);
        }

        // UC_11 NUnit Parameterised test to validate multiple entry for the email address
        [Test]
        [TestCase("abc@yahoo.com")]
        [TestCase("abc-100@yahoo.com")]
        [TestCase("abc.100@yahoo.com")]
        [TestCase("abc111@abc.com")]
        [TestCase("abc-100@abc.net")]
        [TestCase("abc.100@abc.com.au")]
        [TestCase("abc@1.com")]
        [TestCase("abc@gmail.com.com")]
        [TestCase("abc+100@gmail.com")]
        public void multipleEmailTest(string emailAddress)
        {
            string resultEmail = check.allEmailValidation(emailAddress);
            Assert.AreEqual("True", resultEmail);
        }
    }
}