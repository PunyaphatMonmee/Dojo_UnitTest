using LibraryUniformity;

namespace UniformityCase
{
    public class UnitTestUniformity
    {
        [Fact]
        public void ปริมาณทั้งหมด_852_ตัว_ปริมาณ_Uniformity_ลบ_1_บันทึกไม่ได้()
        {
            //3A tipple A
            //arrange เตรียม variable เเละ ผลลัพท์ที่เราคาดหวัง
            int qtyAll = 852;
            int qtyUniformity = -1;
            bool expected = false;
            CheckUniformity checkUniformity = new CheckUniformity();

            //act action
            bool actual = checkUniformity.CheckValue(qtyAll, qtyUniformity);

            //assert เปรียบเทียบค่า
            Assert.Equal(expected, actual);
        }
    }
}