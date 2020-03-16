namespace Problems.Interfaces
{
    public interface IProblem
    {
        string Name();
        string Description();
        AnswerDTO Run();
        int Number();
    }
}