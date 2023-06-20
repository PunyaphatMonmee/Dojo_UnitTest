using LibraryUniformity;

namespace UniformityCase
{
    public class UniformityTest
    {
        [Fact]
        public void ปริมาณทั้งหมด_852_ตัว_ปริมาณ_Uniformity_ลบ_1_บันทึกไม่ได้()
        {
            //3A tipple A
            //arrange เตรียม variable เเละ ผลลัพท์ที่เราคาดหวัง
            int qtyAll = 852;
            int qtyUniformity = -1;
            bool expected = false;
            Uniformity uniformity = new Uniformity();

            //act action
            bool actual = uniformity.IsValid(qtyAll, qtyUniformity);


            //assert เปรียบเทียบค่า
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ปริมาณทั้งหมด_852_ตัว_ปริมาณ_Uniformity_1_บันทึกได้()
        {
            //3A tipple A
            //arrange เตรียม variable เเละ ผลลัพท์ที่เราคาดหวัง
            int qtyAll = 852;
            int qtyUniformity = 1;
            bool expected = true;
            Uniformity uniformity = new Uniformity();

            //act action
            bool actual = uniformity.IsValid(qtyAll, qtyUniformity);


            //assert เปรียบเทียบค่า
            Assert.Equal(expected, actual);
        }
    }
}