using LibraryUniformity;

namespace UniformityCase
{
    public class UniformityTest
    {
        [Fact]
        public void ����ҳ������_852_���_����ҳ_Uniformity_ź_1_�ѹ�֡�����()
        {
            //3A tipple A
            //arrange ����� variable ���� ���Ѿ������ҤҴ��ѧ
            int qtyAll = 852;
            int qtyUniformity = -1;
            bool expected = false;
            Uniformity uniformity = new Uniformity();

            //act action
            bool actual = uniformity.IsValid(qtyAll, qtyUniformity);


            //assert ���º��º���
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ����ҳ������_852_���_����ҳ_Uniformity_1_�ѹ�֡��()
        {
            //3A tipple A
            //arrange ����� variable ���� ���Ѿ������ҤҴ��ѧ
            int qtyAll = 852;
            int qtyUniformity = 1;
            bool expected = true;
            Uniformity uniformity = new Uniformity();

            //act action
            bool actual = uniformity.IsValid(qtyAll, qtyUniformity);


            //assert ���º��º���
            Assert.Equal(expected, actual);
        }
    }
}