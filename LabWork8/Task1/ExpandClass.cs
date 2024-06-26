namespace Task1
{
    public class ExpandClass : Random
    {
        public static string GetString(int stringLength)
        {
            char[] signes = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            Random rand = new Random();

            string randomSignes = "";

            for (int i = 0; i < stringLength; i++)
            {
                int signes_num = rand.Next(0, signes.Length - 1);
                randomSignes += signes[signes_num];
            }

            return randomSignes;
        }
    }
}
