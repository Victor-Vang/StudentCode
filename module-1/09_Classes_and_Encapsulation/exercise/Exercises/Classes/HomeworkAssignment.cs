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

        public int EarnedMarks { get; set; }
        public int PossibleMarks { get; private set; }
        public string SubmitterName { get; private set; }
        public string LetterGrade
        {
            get
            {
                double percent = ((double)EarnedMarks / (double)PossibleMarks) * 100;
                if (percent >= 90)
                {
                    return "A";
                }
                else if ((percent >= 80) && (percent < 90))
                {
                    return "B";
                }
                else if ((percent >= 70) && (percent < 80))
                {
                    return "C";
                }
                else if ((percent >= 60) && (percent < 70))
                {
                    return "D";
                }
                return "F";
            }
        }
    }
}
