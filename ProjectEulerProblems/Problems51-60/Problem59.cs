namespace ProjectEulerProblems
{
    //Finds the Sum of the original Ascii Characters in an encryted message list of intergers.
    //Runs in around 34 Ms.
    class Problem59
    {
        public static void XORDecryption()
        {
            int[] asciiList = {};
            var lines = File.ReadAllLines(@"../../../../cipher.txt");

            for (int i = 0; i < lines.Length; i++) //Sorts text file into array.
            {

                asciiList = lines[i].Split(',').Select(int.Parse).ToArray();
            }

            int[] key = FindKey(3, asciiList);

            int[] encryptedList = Encrypt(asciiList, key);
            for(int i=0; i<encryptedList.Length; i++)
            {
                Console.Write(Convert.ToChar(encryptedList[i]));
            }

            Console.WriteLine("\n" + encryptedList.Sum());
            

        }

        public static int[] Encrypt(int[] list, int[] key) //XOR encryption.
        {
            int[] encryptedList = new int[list.Length];

            for(int i=0; i<list.Length; i++)
            {
                encryptedList[i] = list[i] ^ key[i%key.Length];
            }

            return encryptedList;
        }
        public static int[] FindKey(int keylength, int[] list) //Fix this tomorrow
        {
            int[,] aList = new int[keylength,list.Max()+1];

            int[] key = new int[keylength];


            for(int i= 0; i<list.Length; i++)
            {
                aList[i % keylength, list[i]]++; //increases the count occurance of the number in the list.

                if(aList[i % keylength, list[i]] > aList[i % keylength, key[i % keylength]]) //Checks whether the occurance is higher than the previously changed key[i].
                {
                    key[i%keylength] = list[i];
                }
            } 

            int spaceAscii = 32;

            for(int i=0; i<keylength; i++) // Space is the most common 'letter' so we find the most common of each list and XOR it with space.
            {
                key[i] = key[i] ^ spaceAscii;
            }

            return key;
        }
    }
}