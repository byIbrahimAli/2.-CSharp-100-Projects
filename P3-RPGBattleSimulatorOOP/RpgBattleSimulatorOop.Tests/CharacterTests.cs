

using P3_RPGBattleSimulatorOOP.BattleSystem;
using P3_RPGBattleSimulatorOOP.Characters;
using P3_RPGBattleSimulatorOOP.Characters.Monsters;
using P3_RPGBattleSimulatorOOP.Characters.PlayableCharacters;

namespace RpgBattleSimulatorOop.Tests;

[TestFixture]
public class CharacterTests
{
    [Test]
    public void Selecting_Character_Returns_PlayableCharacter()
    {
        
        var availableCharacters = new List<Character>
        {
            new RedRanger(),
            new PinkRanger(),
            new KawasakiNinjaH2R()
        };
        
        // simulating user choice
        string characterName = "Red Ranger";
        
        // expected character attributes
        int expectedHealth = 150;
        int expectedAttackPower = 35;
        int expectedDefencePower = 30;
        
        // is this character selectable?
        var selectedCharacter = availableCharacters.FirstOrDefault(c => c.Name == characterName);
        
        // has it been instantiated correctly with the correct attributes?
        Assert.That(selectedCharacter, Is.Not.Null, "Character selection should return a valid character.");
        Assert.That(selectedCharacter, Is.InstanceOf<Character>(),  "Character should be playable.");
        Assert.That(selectedCharacter!.Name, Is.EqualTo(characterName), "Character name should match selection.");
        Assert.That(selectedCharacter.Health, Is.EqualTo(expectedHealth), "Character health should match expected health.");
        Assert.That(selectedCharacter.AttackPower, Is.EqualTo(expectedAttackPower), "Character attack power should match expected attack power.");
        Assert.That(selectedCharacter.DefencePower,  Is.EqualTo(expectedDefencePower),  "Character defence power should match expected defence power.");
        
    }

    [Test]
    public void Generating_Monster_Returns_Monster_Character()
    {
        var availableMonsters = new List<Monster>
        {
            new MumsTomahawkSlipper(),
        };

        // generate monster
        var battleManager = new BattleManager(availableMonsters);
        var generatedMonster = battleManager.GetRandomMonster();
        
        // expected character attributes
        string expectedName = "Mums Tomahawk Slipper";
        int expectedHealth = 500;
        int expectedAttackPower = 100;
        int expectedDefencePower = 0;
        int expectedRechargeRateInRounds = 2; // 2 round buff after attack

        // has the beast been instantiated with the correct attributes?
        Assert.That(generatedMonster, Is.Not.Null, "Random-generated-monster should return a valid character.");
        Assert.That(generatedMonster, Is.InstanceOf<Monster>(),  "Character generated should be a Monster.");
        Assert.That(availableMonsters.Contains(generatedMonster), Is.True, "Generated monster should be from expected list..");
        Assert.That(generatedMonster!.Name, Is.EqualTo(expectedName), "Monster name should match selection.");
        Assert.That(generatedMonster.Health, Is.EqualTo(expectedHealth), "Monster health should match expected health.");
        Assert.That(generatedMonster.AttackPower, Is.EqualTo(expectedAttackPower), "Monster attack power should match expected attack power.");
        Assert.That(generatedMonster.DefencePower,  Is.EqualTo(expectedDefencePower),  "Monster defence power should match expected defence power.");
        Assert.That(generatedMonster.RechargeRateInRounds,  Is.EqualTo(expectedRechargeRateInRounds),  "Monster attack-recharge-rate should match expected attack-recharge-rate.");
    }
}