using P3_RPGBattleSimulatorOOP.Characters.Monsters;

namespace P3_RPGBattleSimulatorOOP.BattleSystem;

public class BattleManager
{
    private readonly List<Monster> _availableMonsters;
    private readonly Random _random = new Random();

    public BattleManager(List<Monster> availableMonsters)
    {
        _availableMonsters = availableMonsters ?? throw new ArgumentNullException(nameof(availableMonsters));
    }

    public Monster GetRandomMonster()
    {
        if (_availableMonsters.Count == 0)
            throw new InvalidOperationException("No monster available.");
        
        int index = _random.Next(_availableMonsters.Count);
        return _availableMonsters[index];
    }
}