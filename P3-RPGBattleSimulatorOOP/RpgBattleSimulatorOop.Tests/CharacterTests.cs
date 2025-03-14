

using P3_RPGBattleSimulatorOOP.Characters;
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
}