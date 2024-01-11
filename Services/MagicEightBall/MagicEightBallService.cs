namespace MC_EightToTenEndpoints.Services.MagicEightBall;
public class MagicEightBallService : IMagicEightBallService
{
    public string AnswerMachine(string question)
    {
        Random generator = new();
        int randNum = generator.Next(8);

        string[] answers = {"Yes", "No", "Maybe", "Looks likely", "Seems unlikely", "Not sure. Ask again later", "It is certain","Definitely NOT"};

        if(question == "Does Joseph look handsome?"){
            return "Yes";
        }

        return answers[randNum];
    }
}
