using LibraryUniformity;

namespace UniformityCase
{
    public class UnitTestUniformity
    {
        [Fact]
        public void ����ҳ������_852_���_����ҳ_Uniformity_ź_1_�ѹ�֡�����()
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