using LibraryUniformity;

namespace UniformityCase
{
    public class UnitTestUniformity
    {
        [Fact]
        public void ����ҳ������_852_���_����ҳ_Uniformity_ź_1_�ѹ�֡�����()
        {
            //3A tipple A
            //arrange ����� variable ���� ���Ѿ������ҤҴ��ѧ
            int qtyAll = 852;
            int qtyUniformity = -1;
            bool expected = false;
            CheckUniformity checkUniformity = new CheckUniformity();

            //act action
            bool actual = checkUniformity.CheckValue(qtyAll, qtyUniformity);

            //assert ���º��º���
            Assert.Equal(expected, actual);
        }
    }
}