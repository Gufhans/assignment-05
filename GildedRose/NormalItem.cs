namespace GildedRose
{
    public class NormalItem : IUpdatable
    {
        public void UpdateItem(Item item)
        {
            item.SellIn--;
            if (item.Quality > 0)
            {
                item.Quality--;
            }
            if (item.Quality > 0 && item.SellIn < 0)
            {
                item.Quality--;
            }
        }
    }
}