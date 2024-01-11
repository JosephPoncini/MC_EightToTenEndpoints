namespace MC_EightToTenEndpoints.Services.GuessIt;
public class GuessItService : IGuessItService
{
    public string GuessItMachineEasy(string guess)
    {
        if (int.TryParse(guess, out int num))
        {
            Random generator = new();
            int randNum = generator.Next(1, 11);
            string response = "";

            if (num > randNum)
            {
                response = $"The number you chose, {num}, is greater than the random number picked, {randNum}.";
            }
            else if (num < randNum)
            {
                response = $"The number you chose, {num}, is less than the random number picked, {randNum}.";
            }
            else
            {
                response = $"The number you chose, {num}, is EQUAL TO the random number picked, {randNum}!!!!";
            }
            return response;
        }
        return "Invalid input. Try Again";
    }

    public string GuessItMachineHard(string guess)
    {
        if (int.TryParse(guess, out int num))
        {
            Random generator = new();
            int randNum = generator.Next(1, 101);
            string response = "";

            if (num > randNum)
            {
                response = $"The number you chose, {num}, is greater than the random number picked, {randNum}.";
            }
            else if (num < randNum)
            {
                response = $"The number you chose, {num}, is less than the random number picked, {randNum}.";
            }
            else
            {
                response = $"The number you chose, {num}, is EQUAL TO the random number picked, {randNum}!!!!";
            }
            return response;
        }
        return "Invalid input. Try Again";
    }

    public string GuessItMachineMedium(string guess)
    {
        if (int.TryParse(guess, out int num))
        {
            Random generator = new();
            int randNum = generator.Next(1, 51);
            string response = "";

            if (num > randNum)
            {
                response = $"The number you chose, {num}, is greater than the random number picked, {randNum}.";
            }
            else if (num < randNum)
            {
                response = $"The number you chose, {num}, is less than the random number picked, {randNum}.";
            }
            else
            {
                response = $"The number you chose, {num}, is EQUAL TO the random number picked, {randNum}!!!!";
            }
            return response;
        }
        return "Invalid input. Try Again";
    }
}
