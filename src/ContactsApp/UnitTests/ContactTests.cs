namespace UnitTests
{
    using System;
    using NUnit.Framework;
    using ContactsApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestFixture]
    public class ContactTests
    {
        [Test(Description = "Check for an incorrect value in the FullName field.")]
        public void FullName_SetIncorrectValue_ThrowsException()
        {
            // Arrange
            var wrongFullName =
                "Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-СмирновСмирнов" +
                "Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-СмирновСмирнов" +
                "Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-СмирновСмирнов";
            var contact = new Contact();

            // Assert
            NUnit.Framework.Assert.Throws<ArgumentException>(() =>
            {
                // Act
                contact.FullName = wrongFullName;
            },
            "The length of the Full Name field must not be more than 100 characters.");
        }

        [Test(Description = "Check the correct value in the FullName field.")]
        public void FullName_SetCorrectValue_ReturnsSameValue()
        {
            // Arrange
            var correctFullName = "Kazakov Nikita";
            var expected = correctFullName;
            var contact = new Contact();

            // Act
            contact.FullName = correctFullName;
            var actual = contact.FullName;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Check for an incorrect value in the Email field.")]
        public void EMail_SetIncorrectValue_ThrowsException()
        {
            // Arrange
            var wrongEMail =
                "E-mail-E-mail-E-mail-E-mail-E-mail-E-mail-E-mail" +
                "E-mail-E-mail-E-mail-E-mail-E-mail-E-mail-E-mail" +
                "E-mail-E-mail-E-mail-E-mail-E-mail-E-mail-E-mail" +
                "E-mail-E-mail-E-mail-E-mail-E-mail-E-mail-E-mail";
            var contact = new Contact();

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.ThrowsException<ArgumentException>(() =>
            {
                // Act
                contact.EMail = wrongEMail;
            },
            "The length of the E-mail field must not be greater than 100 characters.");
        }

        [Test(Description = "Check the correct value in the E-mail field.")]
        public void EMail_SetCorrectValue_ReturnsSameValue()
        {
            // Arrange
            var correctEMail = "Kazakov_Nikita@gmail.com";
            var expected = correctEMail;
            var contact = new Contact();

            // Act
            contact.EMail = correctEMail;
            var actual = contact.EMail;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Check for incorrect values in the Phone Number field.")]
        public void PhoneNumber_SetIncorrectValue_ThrowsException()
        {
            // Arrange
            var wrongPhoneNumber = "+1-2+43325";
            var contact = new Contact();

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.ThrowsException<ArgumentException>(() =>
            {
                // Act
                contact.PhoneNumber = wrongPhoneNumber;
            },
            "Phone Number can only contain numbers and signs ‘+’, ‘(’ ‘)’ ‘-’ ‘ ’." +
            " Number format: +7 (000) 000-00-00.");
        }

        [Test(Description = "Check the correct value in the Phone number field.")]
        public void PhoneNumber_SetCorrectValue_ReturnsSameValue()
        {
            // Arrange
            var correctPhoneNumber = "+7 (000) 000-00-00";
            var expected = correctPhoneNumber;
            var contact = new Contact();

            // Act
            contact.PhoneNumber = correctPhoneNumber;
            var actual = contact.PhoneNumber;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Checking for an invalid assignment in the Date Of Birth field.")]
        [TestCase("1700-05-24T00:00:00+07:00", "Should throw an exception, " +
            "if the date of birth is less than 1900, 1, 1",
            TestName = "Assigning 1700 as the date of birth")]
        [TestCase("2100-05-24T00:00:00+07:00", "An exception should be thrown, " +
            "if the date of birth is greater than the current date",
            TestName = "Assigning 2100 as a date of birth")]
        public void DateOfBirth_SetIncorrectValue_ThrowsException
            (string wrongDateOfBirth, string message)
        {
            // Arrange
            var contact = new Contact();

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.ThrowsException<ArgumentException>(() =>
            {
                // Act
                contact.DateOfBirth = Convert.ToDateTime(wrongDateOfBirth);
            },
            message);
        }

        [Test(Description = "Check the correct value in the DateOfBirth field.")]
        public void DateOfBirth_SetCorrectValue_ReturnsSameValue()
        {
            // Arrange
            var correctDateOfBirth = DateTime.Today;
            var expected = correctDateOfBirth;
            var contact = new Contact();

            // Act
            contact.DateOfBirth = correctDateOfBirth;
            var actual = contact.DateOfBirth;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Check the wrong value in the IdVK field.")]
        public void IdVK_SetIncorrectValue_ThrowsException()
        {
            // Arrange
            var wrongIdVK =
                "VK is the best messenger in the worldVK is the best messenger in the world" +
                "VK is the best messenger in the worldVK is the best messenger in the world" +
                "VK is the best messenger in the worldVK is the best messenger in the world";
            var contact = new Contact();

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.ThrowsException<ArgumentException>(() =>
            {
                // Act
                contact.IdVK = wrongIdVK;
            },
            "The length of the VK field should not be more than 50 characters.");
        }

        [Test(Description = "Check the correct value in the IdVK field.")]
        public void IdVK_SetCorrectValue_ReturnsSameValue()
        {
            // Arrange
            var correctIdVK = "325432";
            var expected = correctIdVK;
            var contact = new Contact();

            // Act
            contact.IdVK = correctIdVK;
            var actual = contact.IdVK;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Checking for an invalid assignment to the Contact constructor.")]
        public void Contact_PassingInvalidParameter_ThrowsException()
        {
            // Arrange
            var wrongFullName =
                 "Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-СмирновСмирнов" +
                 "Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-СмирновСмирнов" +
                 "Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-СмирновСмирнов";

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.ThrowsException<ArgumentException>(() =>
            {
                // Act
                new Contact(wrongFullName, "@gmail.com", "+7000000", new DateTime(2006, 1, 1), "4324");
            },
            "Assigning a negative value to the Contact constructor.");
        }

        [Test(Description = "Checking for correct values in the contact constructor.")]
        public void Contact_PassingCorrectParameter_ReturnsSameValue()
        {
            // Arrange
            var correctFullName = "Kazakov Nikita";
            var expectedFullName = correctFullName;

            var correctEMail = "mail.ru";
            var expectedEMail = correctEMail;

            var correctPhoneNumber = "+7 (000) 000-00-00";
            var expectedPhoneNumber = correctPhoneNumber;

            var correctDateOfBirth = new DateTime(2003, 12, 22);
            var expectedDateOfBirth = correctDateOfBirth;

            var correctIdVK = "325432";
            var expextedIdVK = correctIdVK;

            // Act
            var contact = new Contact(
                correctFullName,
                correctEMail,
                correctPhoneNumber,
                correctDateOfBirth,
                correctIdVK);

            var actualContact = contact;

            // Assert
            NUnit.Framework.Assert.Multiple(
                () =>
                {
                    Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedFullName, actualContact.FullName);
                    Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedEMail, actualContact.EMail);
                    Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedPhoneNumber, actualContact.PhoneNumber);
                    Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedDateOfBirth, actualContact.DateOfBirth);
                    Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expextedIdVK, actualContact.IdVK);
                }
                );
        }

        [Test(Description = "Checking for the correct value in the cloned contact.")]
        public void Clone_PassingCorrectParameter_ReturnsSameValue()
        {
            // Arrange
            var correctContact = new Contact(
                "Kazakov Nikita",
                "mail.ru",
                "+7 (000) 000-00-00",
                new DateTime(2000, 01, 18),
                "325432");

            var expectedContact = correctContact;

            // Act
            var contactClone = (Contact)correctContact.Clone();
            var actualContact = contactClone;

            // Assert
            NUnit.Framework.Assert.Multiple(
                () =>
                {
                    Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedContact.FullName, actualContact.FullName);
                    Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedContact.EMail, actualContact.EMail);
                    Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedContact.PhoneNumber, actualContact.PhoneNumber);
                    Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedContact.DateOfBirth, actualContact.DateOfBirth);
                    Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedContact.IdVK, actualContact.IdVK);
                }
                );
        }
    }
}