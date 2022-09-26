namespace NumbersGame2
{
    internal class Program
    {
      
            static void Main(string[] args)
            {
                checkAge();
                Console.ReadKey();
            }

            // Start menu to check the users age.
            // This game hase a 18 years age limit. So if the users age is under 18 then they may not participate.
            public static void checkAge()
            {
                Console.Clear();
                Console.WriteLine("Spelet Gissa talet har en åldersverifering. Så ange nu din ålder!");
                int age = checkNumber();
                if (age >= 18)
                {
                    startMenu();
                }
                else
                {
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("Tyvärr, men det här spelet har en åldersgräns på 18 år \n" +
                                      "Så jag hänvisar dig till denna sida istället https://www.youtube.com/");
                    Console.WriteLine("Tack och hejdå");
                }

            }
            // Start menu. a user menu for rules,prizes and start the game.
            public static void startMenu()
            {
                Console.Clear();
                int input;
                Console.WriteLine("Välkommen till gissa talet spelet. Gör nu ditt val");
                Console.WriteLine("1. Läsa reglerna.");
                Console.WriteLine("2. Se priserna för dom olika nivåer");
                Console.WriteLine("3. Spela Spelet.");
                input = checkNumber();
                switch (input)
                {
                    case 1:
                        rules();
                        break;
                    case 2:
                        prizes();
                        break;
                    case 3:
                        menu();
                        break;
                    default:
                        if (input < 1 || input > 3)
                        {
                            startMenu();
                        }
                        break;
                }
            }

            // Method for The competions rules
            public static void rules()
            {
                Console.Clear();
                Console.WriteLine("Reglerna är enkla. Du väljer som användare vilken svårighetsgrad du vill försöka på. \n" +
                                  "När du valt nivå på ditt spel så kommer du få information om hur många försök du har på dig och hur många nummer du har att välja på. \n" +
                                  "Svår nivå betyder väldigt fina priser medans lättare nivå blir priserna enklare. Så lycka till med tävlandet. \n" +
                                  "OBS !! 18 års åldersgräns !!!");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Tryck på Enter för att fortsätta.");
                Console.ReadLine();
                startMenu();

            }//Method for The competions prize
            public static void prizes()
            {
                Console.Clear();
                Console.WriteLine("Nivå - Super enkelt");
                Console.WriteLine("1 Pris - Hotell Weekend i Tallinn \n" +
                                  "2 Pris - Hotell Weekend i Stockholm \n" +
                                  "3 Pris - 5 st Biobiljetter \n" +
                                  "4 Pris - 2 st Brandvaranare \n" +
                                  "5 Pris - Gummianka");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Nivå - Lätt");
                Console.WriteLine("1 Pris - Presentkort ving 3000 kr \n" +
                                  "2 Pris - Presentkort Stadium 1000 kr \n" +
                                  "3 Pris - 1 års premunation på tidningen Land \n" +
                                  "4 Pris - 4 st Biobiljetter \n" +
                                  "5 Pris - 2 st Triss Lotter \n" +
                                  "6 Pris - 2 st Aftonbladet");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Nivå - Medel");
                Console.WriteLine("1 Pris - 1 vecka på Mallorca för 4 personer \n" +
                                  "2 Pris - Weekend på gotlan i sommar \n" +
                                  "3 Pris - Presentkort Hasses Maskin 3000 kr \n" +
                                  "4 Pris - Lyxmiddag på Plaza Stockholm för 2 personer \n" +
                                  "5 Pris - Presentkort McDonalds 100 kr");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Nivå - Svår");
                Console.WriteLine("1 Pris - 2 Veckor på Maldiverna för 6 personer \n" +
                                  "2 Pris - 50 000 kr kontant \n" +
                                  "3 Pris - Presentkort 10 000 hos Ving \n" +
                                  "4 Pris - Gräsklippare från Husqvarna värde av 5000 kr \n" +
                                  "5 Pris - Grästrimmer från Husqvarna värde av 1500 kr");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Nivå- Extrem");
                Console.WriteLine("1 Pris - Volvo V90 värde av 799 000 kr \n" +
                                  "2 Pris - 250 000 kr kontant \n" +
                                  "3 Pris - 2 Veckor 5* hotell i Mexiko för 4 personer \n" +
                                  "4 Pris - 2 Veckor 5 * Hotell på Grand Canaria för 4 personer \n" +
                                  "5 Pris - 25 000 kr kontant");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Tryck på Enter för att återvända till start menyn");
                Console.ReadLine();
                startMenu();

            }

            // Start Menu for the user to select which level user want to compete on.
            // Player have 5 levels to choose from.
            public static void menu()
            {
                Console.Clear();
                Console.WriteLine("Välkommen till gissa heltalet. \n" +
                                  "Så nu är det upp till dig att gisa på heltalet. \n" +
                                  "Men först, vilken svårighetsgrad vill du ha på tävlingen ? \n" +
                                  "Ju högre svårighetsgrad du väljer så blir belöningen bättre");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("1. super enkelt \n" +
                                  "2. Enkelt \n" +
                                  "3. Medel \n" +
                                  "4. Svår \n" +
                                  "5. Omöjligt");
                Console.WriteLine("");
                Console.Write("Vänligen ange siffran för ditt val : ");
                int input = checkNumber();

                switch (input)
                {
                    case 1:
                        superEasy();
                        break;
                    case 2:
                        easy();
                        break;
                    case 3:
                        medium();
                        break;
                    case 4:
                        hard();
                        break;
                    case 5:
                        extreme();
                        break;
                    default:
                        if (input < 1 || input > 5)
                        {
                            Console.Clear();
                            menu();
                        }
                        break;
                }



            }
            // Method if the user wants to play again.
            public static void playAgain()
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Vill du spela igen ?");
                Console.WriteLine("Tryck 1: Ja");
                Console.WriteLine("Tryck 2: Nej");
                int playAgain = checkNumber();
                if (playAgain == 1)
                {
                    Console.Clear();
                    menu();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Tack för att du spelade.");
                    Console.WriteLine("Och välkommen åter.");
                }

            }
            /* Users Method depend which level they want to compet on.
             * There are 5 levels of varying difficulty.
             * Every levels have there own local variables.
             * And in every level there are if statment who want to check if the number is too high or too low.
             * And a while loop that controll and checks max number of guesses.
             * If they succeed they will get a prize. And then question about play again? or quit.
             * If they dont success the user will have a option to continue play or quit playing.
             */

            public static void superEasy()
            {
                Console.Clear();
                Random veryEasy = new Random();
                int randomNumber = veryEasy.Next(1, 21);
                int input;
                bool gameOver = false;
                int maxGuesses = 5;


                Console.WriteLine("Hej och välkommen till den lättaste tävlingen. Du kommer att få gissa på ett heltal mellan 1-20. \n" +
                    "Där du kommer att få 5 försök att hitta rätt på talet. Så lycka till nu kör vi.");
                Console.WriteLine("Välj nu ditt tal mellan 1-20 : ");
                Console.WriteLine("-----------------------------------------------------------------");

                while (gameOver == false)
                {
                    input = checkNumber2();
                    maxGuesses--;
                    if (maxGuesses == 0 && input != randomNumber)
                    {
                        Console.Clear();
                        Console.WriteLine("Tyvärr, men med facit i hand. Du misslyckades ganska kraftigt!!!!");
                        Console.WriteLine("5 st förök och du föll platt som en pannkaka. " + randomNumber + " var talet du letade efter!");
                        gameOver = true;
                    }

                    else if (input < randomNumber)
                    {
                        Console.WriteLine("Din gissning är för låg");
                    }
                    else if (input > randomNumber)
                    {
                        Console.WriteLine("Din gissning är för hög");

                    }
                    else if (input == randomNumber)
                    {
                        Console.WriteLine("Stort grattis, du gissade rätt på talet " + randomNumber + " och du hade " + maxGuesses + " försök kvar.");
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                        if (maxGuesses == 4)
                        {
                            Console.WriteLine("Grattis du har vunnit en hotell weekend i Tallinn. Stort Grattis.");
                        }
                        else if (maxGuesses == 3)
                        {
                            Console.WriteLine("Grattis du har vunnit en Hotell weekend i Stockholm. Stort Grattis.");
                        }
                        else if (maxGuesses == 2)
                        {
                            Console.WriteLine("Grattis du har vunnit 5 biobiljetter.");
                        }
                        else if (maxGuesses == 1)
                        {
                            Console.WriteLine("Grattis du har vunnit 2 skitbilliga brandvarnare från Biltema.");
                        }
                        else if (maxGuesses == 0)
                        {
                            Console.WriteLine("Grattis du har vunnit en gummianka");
                        }
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                        gameOver = true;
                    }

                }
                playAgain();

            }

            public static void easy()
            {
                Console.Clear();
                Random veryEasy = new Random();
                int randomNumber = veryEasy.Next(1, 31);
                int input;
                bool gameOver = false;
                int maxGuesses = 6;


                Console.WriteLine("Hej och välkommen till en lättare del i tävlingen. Du kommer att få gissa på ett heltal mellan 1-30. \n" +
                    "Där du kommer att få 6 försök att hitta rätt på talet. Så lycka till nu kör vi.");
                Console.WriteLine("Välj nu ditt tal mellan 1-30 : ");
                Console.WriteLine("-----------------------------------------------------------------");

                while (gameOver == false)
                {
                    input = checkNumber2();
                    maxGuesses--;
                    if (maxGuesses == 0 && input != randomNumber)
                    {
                        Console.Clear();
                        Console.WriteLine("Tyvärr, men med facit i hand. Du misslyckades ganska kraftigt!!!!");
                        Console.WriteLine("6 st förök och du föll platt som en pannkaka. " + randomNumber + " var talet du letade efter!");
                        gameOver = true;
                    }

                    else if (input < randomNumber)
                    {
                        Console.WriteLine("Din gissning är för låg");
                    }
                    else if (input > randomNumber)
                    {
                        Console.WriteLine("Din gissning är för hög");

                    }
                    else if (input == randomNumber)
                    {
                        Console.WriteLine("Stort grattis, du gissade rätt på talet " + randomNumber + " och du hade " + maxGuesses + " försök kvar.");
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                        if (maxGuesses == 5)
                        {
                            Console.WriteLine("Grattis Du har vunnit pressentkort hos Ving på 3000 kr.");
                        }
                        else if (maxGuesses == 4)
                        {
                            Console.WriteLine("Grattis du har vunnit 1000 kr presentkort på Stadium.");
                        }
                        else if (maxGuesses == 3)
                        {
                            Console.WriteLine("grattis du har vunnit 1 års premunation på tidningen Land.");
                        }
                        else if (maxGuesses == 2)
                        {
                            Console.WriteLine("Grattis 4 st biobiljetter är dina.");
                        }
                        else if (maxGuesses == 1)
                        {
                            Console.WriteLine("Grattis 2 st trisslotter är dina.");
                        }
                        else if (maxGuesses == 0)
                        {
                            Console.WriteLine("Grattis du har vunnit 2 st Aftonbladet");
                        }
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                        gameOver = true;
                    }

                }
                playAgain();

            }

            public static void medium()
            {
                Console.Clear();
                Random veryEasy = new Random();
                int randomNumber = veryEasy.Next(1, 41);
                int input;
                bool gameOver = false;
                int maxGuesses = 5;


                Console.WriteLine("Hej och välkommen till en lite svårare tävling. Du kommer att få gissa på ett heltal mellan 1-40. \n" +
                    "Där du kommer att få 5 försök att hitta rätt på talet. Nu när det blir svårare så blir priserna också bättre \n" +
                    "Så lycka till, nu kör vi.");
                Console.WriteLine("Välj nu ditt tal mellan 1-40 : ");
                Console.WriteLine("-----------------------------------------------------------------");

                while (gameOver == false)
                {
                    input = checkNumber2();
                    maxGuesses--;
                    if (maxGuesses == 0 && input != randomNumber)
                    {
                        Console.Clear();
                        Console.WriteLine("Tyvärr, men med facit i hand. Du misslyckades ganska kraftigt!!!!");
                        Console.WriteLine("5 st förök och du föll platt som en pannkaka. " + randomNumber + " var talet du letade efter!");
                        gameOver = true;
                    }

                    else if (input < randomNumber)
                    {
                        Console.WriteLine("Din gissning är för låg");
                    }
                    else if (input > randomNumber)
                    {
                        Console.WriteLine("Din gissning är för hög");

                    }
                    else if (input == randomNumber)
                    {
                        Console.WriteLine("Stort grattis, du gissade rätt på talet " + randomNumber + " och du hade " + maxGuesses + " försök kvar.");
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                        if (maxGuesses == 4)
                        {
                            Console.WriteLine("Grattis du har vunnit 1 vecka på Mallorca på 5* Hotell för 4 personer.");
                        }
                        else if (maxGuesses == 3)
                        {
                            Console.WriteLine("Grattis du har vunnit en weekend i sommar på Gotland..");
                        }
                        else if (maxGuesses == 2)
                        {
                            Console.WriteLine("Grattis du har vunnit ett presentkort hos Hasses maskin på 3000 kr.");
                        }
                        else if (maxGuesses == 1)
                        {
                            Console.WriteLine("Grattis du har precis vunnit en lyxmiddag på flotta restaurangen Plaza i Stockholm för 2 personer.");
                        }
                        else if (maxGuesses == 0)
                        {
                            Console.WriteLine("Grattis du har vunnit presentkort på McDonalds värde 100 kr");
                        }

                        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                        gameOver = true;
                    }

                }
                playAgain();
            }

            public static void hard()
            {
                Console.Clear();
                Random veryEasy = new Random();
                int randomNumber = veryEasy.Next(1, 51);
                int input;
                bool gameOver = false;
                int maxGuesses = 5;


                Console.WriteLine("Hej. Nu börjar tävlingen bli riktigt svår. Du kommer att få gissa på ett heltal mellan 1-50. \n" +
                    "Där du kommer att få 5 försök att hitta rätt på talet. Nu när det blir svårare så blir priserna också bättre \n" +
                    "Så lycka till, nu kör vi.");
                Console.WriteLine("Välj nu ditt tal mellan 1-50 : ");
                Console.WriteLine("-----------------------------------------------------------------");

                while (gameOver == false)
                {
                    input = checkNumber2();
                    maxGuesses--;
                    if (maxGuesses == 0 && input != randomNumber)
                    {
                        Console.Clear();
                        Console.WriteLine("Tyvärr, men med facit i hand. Du misslyckades ganska kraftigt!!!!");
                        Console.WriteLine("5 st förök och du föll platt som en pannkaka. " + randomNumber + " var talet du letade efter!");
                        gameOver = true;
                    }

                    else if (input < randomNumber)
                    {
                        Console.WriteLine("Din gissning är för låg");
                    }
                    else if (input > randomNumber)
                    {
                        Console.WriteLine("Din gissning är för hög");

                    }
                    else if (input == randomNumber)
                    {
                        Console.WriteLine("Stort grattis, du gissade rätt på talet " + randomNumber + " och du hade " + maxGuesses + " försök kvar.");
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                        if (maxGuesses == 4)
                        {
                            Console.WriteLine("Grattis du har vunnit 2 veckor på Maldiverna för 6 personer..");
                        }
                        else if (maxGuesses == 3)
                        {
                            Console.WriteLine("Grattis till vinsten, du har vunnit 50 000 kr.");
                        }
                        else if (maxGuesses == 2)
                        {
                            Console.WriteLine("Grattis DU har precis vunnit resepresentkort för 10 000 kr hos ving.");
                        }
                        else if (maxGuesses == 1)
                        {
                            Console.WriteLine("Grattis du vann en ny gräsklippare från Husqvarna till ett värde av 5000 kr.");
                        }
                        else if (maxGuesses == 0)
                        {
                            Console.WriteLine("Grattis du har vunnit en ny grästrimmer från husqvarna till ett värde av 1500 kr");
                        }

                        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                        gameOver = true;
                    }

                }
                playAgain();
            }

            public static void extreme()
            {
                Console.Clear();
                Random veryEasy = new Random();
                int randomNumber = veryEasy.Next(1, 101);
                int input;
                bool gameOver = false;
                int maxGuesses = 5;


                Console.WriteLine("Hej och välkommen till den svåraste nivån i våra tävlingar. Du kommer att få gissa på ett heltal mellan 1-100. \n" +
                    "Där du kommer att få 5 försök att hitta rätt på talet. Nu när det nästa omöjligt så blir priserna också bättre \n" +
                    "Så lycka till att försöka vinna bilen, nu kör vi.");
                Console.WriteLine("Välj nu ditt tal mellan 1-100 : ");
                Console.WriteLine("-----------------------------------------------------------------");

                while (gameOver == false)
                {
                    input = checkNumber2();
                    maxGuesses--;
                    if (maxGuesses == 0 && input != randomNumber)
                    {
                        Console.Clear();
                        Console.WriteLine("Tyvärr, du siktade högt. Men du lyckades inte denna gång!!!!");
                        Console.WriteLine("5 st förök hade du men det ville sig inte. " + randomNumber + " var talet du letade efter!");
                        gameOver = true;
                    }

                    else if (input < randomNumber)
                    {
                        Console.WriteLine("Din gissning är för låg");
                    }
                    else if (input > randomNumber)
                    {
                        Console.WriteLine("Din gissning är för hög");

                    }
                    else if (input == randomNumber)
                    {
                        Console.WriteLine("Stort grattis, du gissade rätt på talet " + randomNumber + " och du hade " + maxGuesses + " försök kvar.");
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                        if (maxGuesses == 4)
                        {
                            Console.WriteLine("STORT GRATTIS!! Du har vunnit en sprillans ny Volvo V90 till ett värde av 799 000 kr.");
                        }
                        else if (maxGuesses == 3)
                        {
                            Console.WriteLine("Stort Grattis Du har precis vunnit 250 000 kr.");
                        }
                        else if (maxGuesses == 2)
                        {
                            Console.WriteLine("Grattis DU har precis vunnit 2 veckor på 5* hotell i Mexiko för 4 personer.");
                        }
                        else if (maxGuesses == 1)
                        {
                            Console.WriteLine("Grattis du har vunnit 2 veckor på 5* hotell på Grand Canaria för 4 personer.");
                        }
                        else if (maxGuesses == 0)
                        {
                            Console.WriteLine("Grattis du har vunnit 25 000 kr");
                        }

                        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                        gameOver = true;
                    }

                }
                playAgain();
            }
            // Here there are 2 versions of tryparse to check that the user really input an integer and no other symbol or letters
            public static int checkNumber()
            {
                int rightNr;
                int fault = 0;
                while (!int.TryParse(Console.ReadLine(), out rightNr))
                {
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Vänligen försök igen och använd bara matematiska tal.");
                    fault++;
                    if (fault == 2)
                    {
                        Console.WriteLine("Vänligen respektera. använd bara siffror");
                        Console.WriteLine("Med tanke på att spelet har en åldersgräns på 18 år, så bör du kunna skilja på bokstäver och siffror!");
                    }
                    else if (fault == 3)
                    {
                        Console.Clear();
                        checkAge();
                    }
                }

                return rightNr;
            }
            public static int checkNumber2()
            {
                int rightNr;
                int fault = 0;
                while (!int.TryParse(Console.ReadLine(), out rightNr))
                {
                    fault++;
                    if (fault != 4)
                    {
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine("Vänligen försök igen och använd bara matematiska tal.");
                    }
                    else if (fault == 4)
                    {
                        Console.WriteLine("Du har tydligen svårt att följa regler!!");
                        Console.WriteLine("Tyvärr kommer alla dom här överträdelserna resultera i att du är diskad från tävlingen!!!");
                        Console.WriteLine("Och du kommer nu att återvända till start menyn");
                        Console.WriteLine("Tryck nu på Enter");
                        Console.ReadLine();
                        Console.Clear();
                        menu();
                    }

                }
                return rightNr;
            }

        }
    }

    
