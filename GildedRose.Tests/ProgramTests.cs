namespace GildedRose.Tests;

public class ProgramTests
{
    // Arrange

    // Act

    // Assert
    Program program;
    public ProgramTests()
    {
        program = new Program();

        program.Items = new List<Item>();
    }
    

    

    [Fact]
    public void TestMain()
    {
        Program.Main(new string[0]); //If an exception is raised here, then this test will fail
        true.Should().BeTrue();
    }

    [Fact]
    public void DexterityVest_Quality_test()
    {
        program.Items.Add(new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20});
        program.Items[0].Quality.Should().Be(20);
    }

    [Fact]
    public void DexterityVest_Quality_test_After_1_Day()
    {
        program.Items.Add(new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20});
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(19);
    }
    [Fact]
    public void DexterityVest_Quality_test_After_11_Day()
    {
        program.Items.Add(new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20});
        for (int i = 0; i < 11; i++)
        {
            program.UpdateQuality();
        }
        program.Items[0].Quality.Should().Be(8);
    }

    [Fact]
    public void DexterityVest_Quality_test_After_15_Day()
    {
        program.Items.Add(new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20});
        for (int i = 0; i < 15; i++)
        {
            program.UpdateQuality();
        }
        program.Items[0].Quality.Should().Be(0);
    }
    [Fact]
    public void DexterityVest_Quality_test_After_20_Day()
    {
        program.Items.Add(new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20});
        for (int i = 0; i < 15; i++)
        {
            program.UpdateQuality();
        }
        program.Items[0].Quality.Should().Be(0);
    }

    [Fact]
    public void AgedBrie_test_After_1_Day()
    {
        program.Items.Add(new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 });
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(1);
    }
    [Fact]
    public void AgedBrie_test_After_10_Day()
    {
        program.Items.Add(new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 });
        for (int i = 0; i < 10; i++)
        {
            program.UpdateQuality();
        }
        program.Items[0].Quality.Should().Be(18);
    }
    [Fact]
    public void AgedBrie_test_After_100_Day()
    {
        program.Items.Add(new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 });
        for (int i = 0; i < 100; i++)
        {
            program.UpdateQuality();
        }
        program.Items[0].Quality.Should().Be(50);
    }
    [Fact]
    public void Sulfuras_Should_Stay_The_Same()
    {
        program.Items.Add(new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 });
        for (int i = 0; i < 10; i++)
        {
            program.UpdateQuality();
        }
        program.Items[0].Quality.Should().Be(80);
    }
    [Fact]
    public void BackstagePasses_Before_10_Days()
    {
        program.Items.Add(new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                });
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(21);
    }
    [Fact]
    public void BackstagePasses_10_Days_Or_Less()
    {
        program.Items.Add(new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 9,
                    Quality = 20
                });
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(22);
    }
    [Fact]
    public void BackstagePasses_5_Days_Or_Less()
    {
        program.Items.Add(new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 4,
                    Quality = 20
                });
        program.UpdateQuality();
        program.Items[0].Quality.Should().Be(23);
    }
    [Fact]
    public void BackstagePasses_Day_After_SellIn_Quality_Should_Be_0()
    {
        program.Items.Add(new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 4,
                    Quality = 20
                });
        for (int i = 0; i < 5; i++)
        {
            program.UpdateQuality();
        }
        program.Items[0].Quality.Should().Be(0);
    }
  
}