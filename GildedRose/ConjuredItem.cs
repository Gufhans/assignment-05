namespace GildedRose
{
    public class ConjuredItem : IUpdatable
    {
        public void UpdateItem(Item item)
        {
            item.SellIn--;
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 2;
            }
            if (item.Quality > 0 && item.SellIn < 0)
            {
                item.Quality = item.Quality - 2;
            }
        }
    }
}