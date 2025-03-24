namespace P3_RPGBattleSimulatorOOP.Characters.Monsters;

public abstract class Monster : Character
{
    public int RechargeRateInRounds { get; protected set; }

    public Monster(string name, int health, int attackPower, int defencePower, int rechargeRateInRounds = 0)
        : base(name, health, attackPower, defencePower)
    {
        RechargeRateInRounds = rechargeRateInRounds;
    }
}