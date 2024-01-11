namespace MC_EightToTenEndpoints.Services.GuessIt;
public interface IGuessItService
{
    string GuessItMachineEasy(string guess);

    string GuessItMachineMedium(string guess);

    string GuessItMachineHard(string guess);
}
