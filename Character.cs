using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private string name;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknow Hero"; }
            else { name = value; }
        }
    }

    public int health;
    public int Health
    {
        get { return health; }
        set
        {
            if (value >= 0) health = value;
            else health = 0;
        }
    }

    private int gold;
    public int Gold
    {
        get { return gold; }
        set
        {
            if (value > 999) { gold = 999; }
            else if (value <= 0) { gold = 0; }
            else { gold = value; }
        }
    }

    public virtual void Init(string newName, int newHp, int newAttackPower)
    {
        Name = newName;
        Health = newHp;
        AttackPower = newAttackPower;
        Gold = 0;

    }

    public int AttackPower { get; set; }

    public virtual void ShowStat()
    {
        Debug.Log($"name: {Name} | Health: {Health} | gold: {Gold}");
    }

    public void TakeDamage(int damageValue)
    {
        Health -= damageValue;
    }

    public void Attack(Monster target)
    {
        Debug.Log($"{Name} attacks {target.Name} for {AttackPower} damage!");
        target.TakeDamage(AttackPower);
    }
    public bool IsAlive() { return Health > 0; }

    public void EarnGold(int amount)
    {
        if (amount > 0)
        {
            Gold += amount;
        }
    }

}
