//Kenneth Fujimura
//10-18-2022
//Mini Challenge # 3 - Asking Questions
//Console program greets the user, asks the user two questions, stores those answers as strings, and then display the answers in a single sentence back to the user.
//Peer Review by:

Console.Clear();

Console.WriteLine("Hello! I have some questions for you. Please indulge me.");

bool playAgain = true;

//play again while loop
while (playAgain == true) {
    //user inputs
    Console.WriteLine("What is your name? Please enter on the keyboard and press enter when you are finished: ");
    string userName = Console.ReadLine();

    Console.WriteLine("Very good. Now, please tell me what time you woke up today? ");
    string wakeUpTime = Console.ReadLine();

    //program output
    Console.WriteLine("So you're telling me that your name is \"" + userName + "\", and that you woke up at \"" + wakeUpTime + "\"? Cool beans!");

    //play again prompt with input validation
    Console.WriteLine("Would you like to answer my questions again? Y/N");
    bool answerCheck = true;
    while (answerCheck == true) {
        string playAgainInput = Console.ReadLine();
        if (playAgainInput == "y" || playAgainInput == "Y") {
            answerCheck = false;
            continue;
        } else if (playAgainInput == "n" || playAgainInput == "N"){
            playAgain = false;
            answerCheck = false;
        } else {
            Console.WriteLine("I do not understand. Please answer with 'Y' for yes, or 'N' for no.");
            answerCheck = true;
        }
    }
}
Console.WriteLine("Arigato!");