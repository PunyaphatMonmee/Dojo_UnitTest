namespace LibraryUniformity
{
    public class Uniformity
    {
        public bool IsValid(int qtyAll, int qtyUniformity)
        {
            if(qtyUniformity > 0)
            {
                return true;
            }

            return false;
        }
    }
}