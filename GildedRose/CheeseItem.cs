namespace GildedRose
{
    public class CheeseItem : IUpdatable
    {
        public void UpdateItem(Item item)
        {
            item.SellIn--;
            if (item.Quality < 50)
            {
                item.Quality++;
            }
        }
    }
}