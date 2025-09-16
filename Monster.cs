using UnityEngine;

public class Monster : Character
{
    private int lootReward;
    public int LootReward
    {
        get => lootReward;
        set => lootReward = value < 0 ? 0 : value;
    }

    public void Init(string newName, int newHp, int newAttackPower, int newLootReward)
    {
        base.Init(newName, newHp, newAttackPower);
        LootReward = newLootReward;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Monster Reward: {LootReward}");
    }
}
