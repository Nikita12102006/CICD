
using CICD;
using Xunit;
namespace UnitTest
{
    namespace CICD.Tests
    {
        public class Class1Tests
        {
            // ������������ ������ ����������
            [Fact]
            public void Factorial_Test()
            {
                // Arrange
                double input = 5;
                double expectedOutput = 120;

                // Act
                double actualOutput = Class1.Factorial(input);

                // Assert
                Assert.Equal(expectedOutput, actualOutput);
            }
            // ������������ ��������� ���������� ArgumentOutOfRangeException ��� �������� �������������� ���������
    
            // ������������ ������ ����������� �������� �����
            [Fact]
            public void IsProst_Test()
            {
                // Arrange
                double input = 7;

                // Act
                bool actualOutput = Class1.IsProst(input);

                // Assert
                Assert.True(actualOutput);
            }
            // ������������ ������ ����������� ���������� �����
            [Fact]
            public void IsProst_Sostavnoe()
            {
                // Arrange
                double input = 6;
                bool expectedOutput = false;

                // Act
                bool actualOutput = Class1.IsProst(input);

                // Assert
                Assert.Equal(expectedOutput, actualOutput);
            }
            // ������������ ������ ����������� �������� ����� 1
            [Fact]
            public void IsProst_One()
            {
                // Arrange
                double input = 1;
                bool expectedOutput = false;

                // Act
                bool actualOutput = Class1.IsProst(input);

                // Assert
                Assert.Equal(expectedOutput, actualOutput);
            }
            // ������������ ������ ����������� �������� ����
           
            // ������������ ������ �������������� ���������� � ������������� ������ ������
            [Fact]
            public void Progressiv_Test()
            {
                // Arrange
                int n = 5;
                double a1 = 2;
                double d = 3;
                double expectedOutput = 14;

                // Act
                double actualOutput = Class1.ArithmeticProgressiv(n, a1, d);

                // Assert
                Assert.Equal(expectedOutput, actualOutput);
            }
            // ������������ ������ �������������� ���������� � ������������� ������ ������
            [Fact]
            public void Progressiv_Test_otric()
            {
                // Arrange
                int n = 5;
                double a1 = -1;
                double d = 3;
                double expectedOutput = 11;

                // Act
                double actualOutput = Class1.ArithmeticProgressiv(n, a1, d);

                // Assert
                Assert.Equal(expectedOutput, actualOutput);
            }
            // ������������ ������ �������������� ���������� � ������� ��������
          
        }
    }
}
