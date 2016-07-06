using Xunit;

namespace StringReplacer.Objects
{
  public class ReplacerTests
  {
    [Fact]
    public void FindAndReplace_userInputWorld_ReturnUniverse()
    {
      //Arrange
      string expectedResult = "Hello universe";

      //Act
      Replacer replacer = new Replacer();
      string result = replacer.FindAndReplace("Hello world", "world", "universe");
    }
    [Fact]
    public void FindAndReplace_userInputCat_ReturnDoghedral()
    {
      //Arrange
      string expectedResult = "I am walking my dog to the doghedral";

      //Act
      Replacer replacer = new Replacer();
      string result = replacer.FindAndReplace("I am walking my cat to the cathedral", "cat", "dog");
    }
    [Fact]
    public void FindAndReplace_userInputCat_Returndoghedral()
    {
      //Arrange
      string expectedResult = "I am walking my dog to the doghedral";

      //Act
      Replacer replacer = new Replacer();
      string result = replacer.FindAndReplace("I am walking my Cat to the cathedral", "cat", "dog");
    }
  }
}
