using LibraryUniformity;

namespace UniformityCase
{
    public class UnitTestUniformity
    {
        [Fact]
        public void ปริมาณทั้งหมด_852_ตัว_ปริมาณ_Uniformity_ลบ_1_บันทึกไม่ได้()
        {
            //3A tipple A
            //arrange
            int qtyAll = 852;
            int qtyUniformity = -1;
            bool expected = false;
            CheckUniformity checkUniformity = new CheckUniformity();

            //act
            bool actual = checkUniformity.CheckValue(qtyAll, qtyUniformity);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}