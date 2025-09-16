using UnityEngine;

public class Hero : Character
{
    public void Init(string newName, int newHp, int newAttackPower)
    {
        base.Init(newName, newHp, newAttackPower);
        Gold = 0;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Hero Gold : {Gold}");
    }

    public void EarnGold(int amount)

    {
        if (amount > 0)
        {
            Gold += amount;
        }
    }

}
