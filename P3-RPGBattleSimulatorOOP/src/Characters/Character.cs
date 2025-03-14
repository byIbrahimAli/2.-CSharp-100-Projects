namespace P3_RPGBattleSimulatorOOP.Characters;

public abstract class Character
{
    public string Name { get; protected set; }
    public int Health { get; protected set; }
    public int AttackPower  { get; protected set; }
    public int DefencePower  { get; protected set; }

    public Character(string name, int health, int attackPower, int defencePower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
        DefencePower = defencePower;
    }
    
}