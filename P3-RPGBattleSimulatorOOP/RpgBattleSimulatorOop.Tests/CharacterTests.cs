

namespace RpgBattleSimulatorOop.Tests;

[TestFixture]
public class CharacterTests
{
    [Test]
    public void Selecting_Character_Returns_PlayableCharacter()
    {
        
        var availableCharacters = new List<PlayableCharacter>
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
        int expectedDefencePower = 20;
        
        // is this character selectable?
        var selectedCharacter = availableCharacters.FirstOrDefault(c => c.Name == characterName);
        
        // 
        Assert.That(selectedCharacter, Is.Not.Null, "Character selection should return a valid character.");
        Assert.That(selectedCharacter, Is.InstanceOf<PlayableCharacter>(),  "Character should be playable.");
        Assert.That(selectedCharacter!.Name, Is.EqualTo(characterName), "Character name should match selection.");
        Assert.That(selectedCharacter.Health, Is.EqualTo(expectedHealth), "Character health should match expected health.");
        Assert.That(selectedCharacter.AttackPower, Is.EqualTo(expectedAttackPower), "Character attack power should match expected attack power.");
        Assert.That(selectedCharacter.DefencePower,  Is.EqualTo(expectedDefencePower),  "Character defence power should match expected defence power.");
        
    }
}