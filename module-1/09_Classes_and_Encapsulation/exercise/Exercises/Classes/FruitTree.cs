namespace Exercises.Classes
{
    public class FruitTree
    {

        public FruitTree()
        {

        }

        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            this.TypeOfFruit = typeOfFruit;
            this.PiecesOfFruitLeft = startingPiecesOfFruit;
        }

        public string TypeOfFruit { get; private set; }

        public int PiecesOfFruitLeft { get; private set; }

        public bool PickFruit(int numberOfPiecesToRemove)
        {
            if (PiecesOfFruitLeft >= numberOfPiecesToRemove)
            {
                PiecesOfFruitLeft = PiecesOfFruitLeft - numberOfPiecesToRemove;
                return true;
            }
            return false;
        }
            
      
    }
}
