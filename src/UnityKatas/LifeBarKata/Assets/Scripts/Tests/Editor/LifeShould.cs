using NUnit.Framework;

public class LifeShould
{
    private Life _life;

    [SetUp]
    public void Setup()
    {
        _life = new Life();
    }

    [Test]
    public void DecrementWhenReceiveDamage()
    {
        // Act
        _life.ReceiveDamage(10);

        // Assert
        Assert.AreEqual(90, _life.CurrentValue);
    }

    [Test]
    public void NotHaveNegativeValues()
    {
        // Act
        _life.ReceiveDamage(150);

        // Assert
        Assert.AreEqual(0, _life.CurrentValue);
    }


    [Test]
    public void IncrementWhenReceiveHealing()
    {
        // Arrange

        _life.ReceiveDamage(10);

        // Act
        _life.ReceivesHealing(10);

        // Assert
        Assert.AreEqual(100, _life.CurrentValue);
    }

    [Test]
    public void NotDecrementWhenReceiveDamageAndHasShield()
    {
        // Arrange
        _life.ReceiveShield();

        // Act
        _life.ReceiveDamage(40);

        // Assert
        Assert.AreEqual(100, _life.CurrentValue);
    }

    [Test]
    public void IncreaseAbove100PercentWhenDrinkMagicPotion()
    {
        // Act
        _life.ReceiveMagicPotion();

        // Assert
        Assert.AreEqual(150, _life.CurrentValue);

        _life.ReceiveMagicPotion(3);

        Assert.AreEqual(300, _life.CurrentValue);
    }

    [Test]
    public void DontIncreaseWhenCurrentValueIsAboveOf100Percent()
    {
        // Act
        _life.ReceiveMagicPotion();

        // Assert
        Assert.AreEqual(150, _life.CurrentValue);

        _life.ReceivesHealing(30);

        Assert.AreEqual(150, _life.CurrentValue);
    }

    [Test]
    public void DoubleDecrementWhenReceiveDamageAndIsPoisoned()
    {
        // Act
        _life.ReceivePoison();

        _life.ReceiveDamage(40);

        // Assert
        Assert.AreEqual(20, _life.CurrentValue);

    }
}
