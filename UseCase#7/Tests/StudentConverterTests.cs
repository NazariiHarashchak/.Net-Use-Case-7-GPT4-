using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Collections.Generic;
using UseCase_7;

namespace Tests
{

    public class StudentConverterTest
    {
        [Fact]
        public void ConvertStudents_StudentIsExceptional_ReturnsTrue()
        {
            // Arrange
            var studentConverter = new StudentConverter();
            var students = new List<Student>
        {
            new Student { Name = "John Doe", Age = 20, Grade = 95 }
        };

            // Act
            var result = studentConverter.ConvertStudents(students);

            // Assert
            Assert.True(result[0].Exceptional);
        }

        [Fact]
        public void ConvertStudents_StudentIsHonorRoll_ReturnsTrue()
        {
            // Arrange
            var studentConverter = new StudentConverter();
            var students = new List<Student>
        {
            new Student { Name = "Jane Doe", Age = 21, Grade = 95 }
        };

            // Act
            var result = studentConverter.ConvertStudents(students);

            // Assert
            Assert.True(result[0].HonorRoll);
        }

        [Fact]
        public void ConvertStudents_StudentPassed_ReturnsTrue()
        {
            // Arrange
            var studentConverter = new StudentConverter();
            var students = new List<Student>
        {
            new Student { Name = "John Smith", Age = 22, Grade = 75 }
        };

            // Act
            var result = studentConverter.ConvertStudents(students);

            // Assert
            Assert.True(result[0].Passed);
        }

        [Fact]
        public void ConvertStudents_StudentFailed_ReturnsFalse()
        {
            // Arrange
            var studentConverter = new StudentConverter();
            var students = new List<Student>
        {
            new Student { Name = "Jane Smith", Age = 22, Grade = 65 }
        };

            // Act
            var result = studentConverter.ConvertStudents(students);

            // Assert
            Assert.False(result[0].Passed);
        }
    }

}
