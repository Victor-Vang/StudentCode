namespace Exercises.Classes
{
    public class HomeworkAssignment
    {
        public HomeworkAssignment()
        {

        }
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            this.PossibleMarks = possibleMarks;
            this.SubmitterName = submitterName;
        }

        // HomeworkAssignment assignment = new HomeworkAssignment();

        public int EarnedMarks { get; set; }
        public int PossibleMarks { get; private set; }
        public string SubmitterName { get; private set; }
        public string LetterGrade { get; }


    }
}
