using System;
using System.Collections.Generic;
using System.Text;

namespace Looking_for_bananas
{
    public class FindMaxBananas
    {
        public int[,] array { get; set; }

        public int maxBananas { get; set; }

        public List<string> paths { get; set; }

        public FindMaxBananas(int[,] array)
        {
            int lengthy = array.GetLength(0);
            int lengthx = array.GetLength(1);

            this.array = array;
            this.maxBananas = 0;
            this.paths = new List<string>();
        }

        public void findMaxBananas()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                percorrerPossiveisCaminhos(i, 0, array, 0, "");
            }            
        }

        private void percorrerPossiveisCaminhos(int positionI, int positionX, int[,] array, int sum, string path)
        {
            if(path == "")
            {
                path += $"({positionI},{positionX})";
            }
            else
            {
                path += $"->({positionI},{positionX})";
            }
            
            sum += array[positionI, positionX];

            int lengthy = array.GetLength(0);
            int lengthx = array.GetLength(1);

            if (positionX == lengthx - 1)
            {
                finalizarSomaFimDoMovimento(sum, path);
                return;
            }

            List<int> possiveisMovimentosY = new List<int>();
            int nextPositionX = positionX;

            if (positionI - 1 >= 0)
            {
                possiveisMovimentosY.Add(positionI - 1);
            }

            possiveisMovimentosY.Add(positionI);

            if (positionI + 1 <= (lengthy - 1))
            {
                possiveisMovimentosY.Add(positionI + 1);
            }

            if (positionX + 1 <= lengthx)
            {
                nextPositionX++;
            }

            if (nextPositionX <= lengthx - 1)
            {
                for (int i = 0; i < possiveisMovimentosY.Count; i++)
                {
                    percorrerPossiveisCaminhos(possiveisMovimentosY[i], nextPositionX, array, sum, path);
                }
            }
        }

        private void finalizarSomaFimDoMovimento(int soma, string path)
        {
            if (soma > maxBananas)
            {
                maxBananas = soma;
                paths = new List<string>();
                paths.Add(path);
            }
            else if (soma == maxBananas)
            {
                paths.Add(path);
            }
        }
    }
}
