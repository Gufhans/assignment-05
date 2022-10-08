namespace GildedRose
{
    public class BackstagePassItem : IUpdatable
    {
        public void UpdateItem(Item item) 
        {
            item.SellIn--;
            if (QualityBelow50(item))
            {
                item.Quality++;
            }
            if (item.SellIn < 10 && QualityBelow50(item))
            {
                item.Quality++;
            }
            if (item.SellIn < 5 && QualityBelow50(item))
            {
                item.Quality++;
            }
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }

        bool QualityBelow50(Item item)
        {
            if (item.Quality < 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}