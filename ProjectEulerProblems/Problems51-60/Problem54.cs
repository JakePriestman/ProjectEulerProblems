namespace ProjectEulerProblems
{
    //Finds out how many times player 1 and 2 wins out of 100 poker hands in poker.txt.
    //Runs in around 28 Ms.
    class Problem54
    {
        public static void PokerHands()
        {
            string[][] pokerHandsList = new string[1000][];
            var lines = File.ReadAllLines(@"../../../../poker.txt");

            string[][] player1Hands = new string[1000][];
            string[][] player2Hands = new string[1000][];

            int player1Wins = 0; 
            int player2Wins = 0;
        
            for (int i = 0; i < lines.Length; i++) //Sorts text file into array.
            {

                pokerHandsList[i] = lines[i].Split(' ');

                player1Hands[i] = new string[5]; //Initialize the hand length.
                player2Hands[i] = new string[5];
            }

            for(int i=0; i<pokerHandsList.Length;i++) //Initializes player 1 and 2's hands
            {
                
                for(int j=0; j<10; j++)
                {
                    if(j<5) //Player 1 hands
                    {
                        player1Hands[i][j] = pokerHandsList[i][j];
                    }
                    if(j>=5) //Player 2 hands
                    {
                        player2Hands[i][j-5] = pokerHandsList[i][j];
                    }
                }

            }

            for(int i=0; i<player1Hands.Length; i++) //Counts the rounds won by each player
            {
                if(RoundWinner(player1Hands[i], player2Hands[i]) == 1)
                {
                    player1Wins++;
                }
                if(RoundWinner(player1Hands[i], player2Hands[i]) == 2)
                {
                    player2Wins++;
                }
                
            }
            Console.WriteLine("Player 1 won " + player1Wins + " hands");
            Console.WriteLine("Player 2 won " + player2Wins + " hands");
        }


    public static int RoundWinner(string[] players1Cards, string[] players2Cards) //Checks who wins the round and returns the integar corresponding to the player. 
        {
            //RoyalFlush Checks
            if(RoyalFlush(players1Cards))
            {
                return 1;
            }

            if(RoyalFlush(players2Cards))
            {
                return 2;
            }

            //Straight Flush checks
            if(StraightFlush(players1Cards).Item1 && !StraightFlush(players2Cards).Item1)
            {
                return 1;
            }
            if(!StraightFlush(players1Cards).Item1 && StraightFlush(players2Cards).Item1)
            {
                return 2;
            }

            if(StraightFlush(players1Cards).Item1 && StraightFlush(players2Cards).Item1)
            {
                if(CardRanking(StraightFlush(players1Cards).Item2) > CardRanking(StraightFlush(players2Cards).Item2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

            //Four of a kind checks
            if(FourOfAKind(players1Cards).Item1 && !FourOfAKind(players2Cards).Item1)
            {
                return 1;
            }
            if(!FourOfAKind(players1Cards).Item1 && FourOfAKind(players2Cards).Item1)
            {
                return 2;
            }
            if(FourOfAKind(players1Cards).Item1 && FourOfAKind(players2Cards).Item1)
            {
                if(CardRanking(FourOfAKind(players1Cards).Item2) > CardRanking(FourOfAKind(players2Cards).Item2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

            //Full House Checks
            if(FullHouse(players1Cards).Item1 && !FullHouse(players2Cards).Item1)
            {
                return 1;
            }
            if(!FullHouse(players1Cards).Item1 && FullHouse(players2Cards).Item1)
            {
                return 2;
            }
            if(FullHouse(players1Cards).Item1 && FullHouse(players2Cards).Item1)
            {
                if(CardRanking(FullHouse(players1Cards).Item2) > CardRanking(FullHouse(players2Cards).Item2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

            //Flush Checks
            if(Flush(players1Cards).Item1 && !Flush(players2Cards).Item1)
            {
                return 1;
            }
            if(!Flush(players1Cards).Item1 && Flush(players2Cards).Item1)
            {
                return 2;
            }
            if(Flush(players1Cards).Item1 && Flush(players2Cards).Item1)
            {
                return HighCard(players1Cards, players2Cards);
            }

            //Straight Checks
            if(Straight(players1Cards).Item1 && !Straight(players2Cards).Item1)
            {
                return 1;
            }
            if(!Straight(players1Cards).Item1 && Straight(players2Cards).Item1)
            {
                return 2;
            }
            if(Straight(players1Cards).Item1 && Straight(players2Cards).Item1)
            {
                if(CardRanking(Straight(players1Cards).Item2) > CardRanking(Straight(players2Cards).Item2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

            //Three of a kind Checks
            if(ThreeOfAKind(players1Cards).Item1 && !ThreeOfAKind(players2Cards).Item1)
            {
                return 1;
            }
            if(!ThreeOfAKind(players1Cards).Item1 && ThreeOfAKind(players2Cards).Item1)
            {
                return 2;
            }
            if(ThreeOfAKind(players1Cards).Item1 && ThreeOfAKind(players2Cards).Item1)
            {
                if(CardRanking(ThreeOfAKind(players1Cards).Item2) > CardRanking(ThreeOfAKind(players2Cards).Item2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

            //Two Pairs Checks
            if(TwoPairs(players1Cards).Item1 && !TwoPairs(players2Cards).Item1)
            {
                return 1;
            }
            if(!TwoPairs(players1Cards).Item1 && TwoPairs(players2Cards).Item1)
            {
                return 2;
            }
            if(TwoPairs(players1Cards).Item1 && TwoPairs(players2Cards).Item1)
            {
                if(Math.Max(CardRanking(TwoPairs(players1Cards).Item2), CardRanking(TwoPairs(players1Cards).Item3)) > Math.Max(CardRanking(TwoPairs(players2Cards).Item2), CardRanking(TwoPairs(players2Cards).Item3)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

            //One pair Checks
            if(OnePair(players1Cards).Item1 && !OnePair(players2Cards).Item1)
            {
                return 1;
            }
            if(!OnePair(players1Cards).Item1 && OnePair(players2Cards).Item1)
            {
                return 2;
            }
            if(OnePair(players1Cards).Item1 && OnePair(players2Cards).Item1)
            {
                if(CardRanking(OnePair(players1Cards).Item2) > CardRanking(OnePair(players2Cards).Item2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

            return HighCard(players1Cards, players2Cards);


        }
        public static bool RoyalFlush(string[] playersCards) //Checks hand for Royal Flush
        {
            if(Flush(playersCards).Item1)
            {
                string str  = "";
                for(int i=0; i<playersCards.Length;i++)
                {
                    str += playersCards[i][0];
                }
                if(Problem32.SortString(str) == "AJKQT")
                {
                    return true;
                }
            }
            return false;
        }
        public static (bool, char, char) StraightFlush(string[] playersCards) //Checks hand for striaght flush
        {
            if(Flush(playersCards).Item1 && Straight(playersCards).Item1)
            {
                return(true, Straight(playersCards).Item2, Flush(playersCards).Item2);
            }
            return (false,'0', '0');
        }
        public static (bool,char) FourOfAKind(string[] playersCards) //Checks hand for four of a kind
        {
            for(int i=0; i<playersCards.Length; i++)
            {
                for(int j=i+1; j<playersCards.Length; j++)
                {
                    for(int k = j+1; k<playersCards.Length; k++)
                    {
                        for(int l=k+1; l<playersCards.Length; l++)
                        {
                            if(playersCards[i][0] == playersCards[j][0] && playersCards[i][0] == playersCards[k][0] && playersCards[i][0] == playersCards[l][0])
                        {
                            return (true, playersCards[i][0]);
                        }
                        }
                    }
                }
            }
            return (false,'0');
        }
        public static (bool, char, char) FullHouse(string[] playersCards) //Checks hand for full house.
        {
            if(ThreeOfAKind(playersCards).Item1)
            {
                for(int i=0; i<playersCards.Length; i++)
                {
                    for(int j=i+1; j<playersCards.Length; j++)
                    {
                        if(playersCards[i][0] == playersCards[j][0] && playersCards[i][0] != ThreeOfAKind(playersCards).Item2)
                        {
                            return (true, ThreeOfAKind(playersCards).Item2, playersCards[i][0]);
                        }
                    }
                    
                }
            }
            return (false,'0','0');
        }
        public static (bool,char) Flush(string[] playersCards) //Checks hand for flush
        {
            string str ="";
            for(int i=0; i<playersCards.Length;i++)
            {
                str += playersCards[i][1];
            }
            if(str == "HHHHH" || str == "CCCCC" || str == "SSSSS" || str == "DDDDD")
            {
                return (true, playersCards[0][1]);
            }
            return (false,'0');
        }
        public static (bool, char) Straight(string[] playersCards) //Checks hand for a straight
        {
            string str = "";
            for(int i=0; i<playersCards.Length ;i++)
            {
                str += playersCards[i][0];
            }
            if(Problem32.SortString(str) == "23456" || Problem32.SortString(str) == "34567" || Problem32.SortString(str) == "45678" ||
                Problem32.SortString(str) == "56789" || Problem32.SortString(str) == "6789T" || Problem32.SortString(str) == "789JT" ||
                Problem32.SortString(str) == "89JQT" || Problem32.SortString(str) == "9JKQT")
                {
                    return (true, Problem32.SortString(str)[0]);
                }
                if(Problem32.SortString(str) == "AJKQT")
                {
                    return (true, 'T');
                }
            return (false,'0');
        }
        public static (bool, char) ThreeOfAKind(string[] playersCards) //Checks hand for three of a kind
        {
            
            for(int i=0; i<playersCards.Length; i++)
            {
                for(int j=i+1; j<playersCards.Length; j++)
                {
                    for(int k = j+1; k<playersCards.Length; k++)
                    {
                        if(playersCards[i][0] == playersCards[j][0] && playersCards[i][0] == playersCards[k][0])
                        {
                            return (true, playersCards[i][0]);
                        }
                    }
                }
            }
            return (false,'0');
        }
        public static (bool, char, char) TwoPairs(string[] playersCards) //Checks hand for two pairs.
        {
            if(OnePair(playersCards).Item1)
            {
                for(int i=0; i<playersCards.Length; i++)
                {
                    for(int j=i+1; j<playersCards.Length; j++)
                    {
                        if(playersCards[i][0] == playersCards[j][0] && playersCards[i][0] != OnePair(playersCards).Item2)
                        {
                            return (true, OnePair(playersCards).Item2 ,playersCards[i][0]);
                        }
                    }
                    
                }
            }
            return (false,'0','0');
        }
        public static (bool, char) OnePair(string[] playersCards) //Checks for a pair assuming that player doesnt have 3 of a kind or 4 of a kind.
        {
            for(int i=0; i<playersCards.Length; i++)
            {
                for(int j=i+1; j<playersCards.Length; j++)
                {
                    if(playersCards[i][0] == playersCards[j][0])
                    {
                        return (true, playersCards[i][0]);
                    }
                }
            }
            return (false,'0');
        }
        public static int HighCard(string[] players1Cards, string[] players2Cards) //Checks the high card between the two players. gives the integer corresponding to the play with the higher card.
        {
            char maxCard = '0';
            int playerMax = 0;

            for(int i = 0; i < players1Cards.Length; i++)
            {
                char currentMax;
                int currentPlayer;
                if(CardRanking(players1Cards[i][0]) > CardRanking(players2Cards[i][0]))
                {
                    currentMax = players1Cards[i][0];
                    currentPlayer = 1;
                }
                else
                {
                    currentMax = players2Cards[i][0];
                    currentPlayer = 2;
                }

                if(CardRanking(currentMax) > CardRanking(maxCard))
                {
                    maxCard = currentMax;
                    playerMax = currentPlayer;
                }
            }
            return playerMax;
        }

        public static int CardRanking(char num) //Return number ranking of card.
        {
            switch(num)
            {
                case '2':
                return 2;

                case '3':
                return 3;

                case '4':
                return 4;

                case '5':
                return 5;

                case '6':
                return 6;

                case '7':
                return 7;

                case '8':
                return 8;

                case '9':
                return 9;

                case 'T':
                return 10;

                case 'J':
                return 11;

                case 'Q':
                return 12;

                case 'K':
                return 13;

                case 'A':
                return 14;
            }
            return 0;
        }
    }
}