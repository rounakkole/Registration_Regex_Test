using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registration_Regex_Test;

namespace Registration_Test
{

    [TestClass]
    public class Testing
    {
        RegistrationPattern registrationPattern = new RegistrationPattern();

        [TestMethod]
        public void GivenRight_FirstName_ReturnTrue()
        {
            string actual = registrationPattern.ValidateFirstName("Rahul");
            string expected = "valid firstName";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenWrong_FirstName_ReturnFalse()
        {
           try
            {
                string actual = registrationPattern.ValidateFirstName("raj");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("invalid firstName", ex.Message);
            }
        }


        [TestMethod]
        public void GivenRight_LastName_ReturnTrue()
        {
            string actual = registrationPattern.ValidateLastName("Kohli");
            string expected = "valid lastName";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenWrong_LastName_ReturnFalse()
        {
            try
            {
                string actual = registrationPattern.ValidateLastName("Li");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("invalid lastName", ex.Message);
            }

        }

        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenRight_Email_ReturnTrue(string EmialId)
        {
            string actual = registrationPattern.ValidateEmail(EmialId);
            string expected = "valid email";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("abc@.com.my")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void GivenWrong_Email_ReturnFalse(string EmialId)
        {
            try
            {
                string actual = registrationPattern.ValidateEmail(EmialId);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("invalid email", ex.Message);
            }
        }


        [TestMethod]
        public void GivenRight_mobileNo_ReturnTrue()
        {
            string actual = registrationPattern.ValidateMobileNo("91 9876543210");
            string expected = "valid mobileNo";

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GivenWrong_mobileNo_ReturnFalse()
        {
            try
            {
                string actual = registrationPattern.ValidateMobileNo("987654321");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("invalid mobileNo", ex.Message);
            }
        }



        [TestMethod]
        public void GivenRight_Password_ReturnTrue()
        {
            string actual = registrationPattern.ValidatePassword("abcDE#1234");
            string expected = "valid password";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenWrong_Password_ReturnFalse()
        {
            try
            {
                string actual = registrationPattern.ValidatePassword("abCD12");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("invalid password", ex.Message);
            }
        }
    }
}