using WorkFinderQu;

namespace WordFinderQu.Test
{
    public class UnitTestValidateMatrix
    {
        [Fact]
        public void ValidateMatrix_MustReturnTrue_IsValid()
        {
            // Arrange
            var values = new List<string>
                {
                    "ABCDE",
                    "FGHIJ",
                    "KLMNO"
                };
            var validator = new ValidateMatrix(64, 64);

            // Act
            var resultado = validator.isValid(values);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void ValidateMatrix_MustReturnFalse_IsEmpty()
        {
            // Arrange
            var validator = new ValidateMatrix(10, 10);
            var values = new List<string>();

            // Act
            var resultado = validator.isValid(values);

            // Assert
            Assert.False(resultado);
        }

        [Fact]
        public void ValidateMatrix_MustReturnFalse_ExceededRowsAllow()
        {
            // Arrange
            var validator = new ValidateMatrix(4, 6);
            var values = new List<string>
        {
            "ABCDE",
            "FGHIJ",
            "KLMNO",
            "PQRST",
            "UVWXY",
            "Z1234" 
        };

            // Act
            var resultado = validator.isValid(values);

            // Assert
            Assert.False(resultado);
        }
    }
}