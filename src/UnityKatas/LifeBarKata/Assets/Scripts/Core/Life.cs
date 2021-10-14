using System;
public class Life
{
    public double CurrentValue { get; set; } = 100;
    private bool Shield = false;
    private bool Poisoned = false;

    public void ReceiveDamage(int amount)
    {
        if (!Shield)
        {
            CurrentValue = Math.Max(0, Poisoned ? CurrentValue -= 2 * amount : CurrentValue -= amount);
        }

        Shield = false;
    }

    public void ReceivesHealing(int amount)
    {
        IncrementLife(amount);
    }

    public void ReceiveShield()
    {
        Poisoned = Poisoned ? false : Poisoned;
        Shield = Poisoned ? false : true;
    }

    public void receiveDamage(int amount)
    {
        throw new NotImplementedException();
    }

    public void ReceiveMagicPotion(int potionCount = 1)
    {
        IncrementLife(potionCount * 50, true);
    }

    private void IncrementLife(int amount, bool isPotion = false)
    {
        if (!isPotion)
        {
            CurrentValue = CurrentValue > 100 ? CurrentValue : Math.Min(100, CurrentValue += amount);
        }
        else
        {
            CurrentValue += amount;
        }
    }

    public void ReceivePoison() => Poisoned = true;
}
