using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelArtToCommitHistory.Helpers
{
    public static class CommitHelper
    {
        public static async Task StartCommit(
            string imagePath,
            string folderPath,
            DateTime startDate,
            DateTime endDate
        )
        {
            Bitmap pixelArt = new Bitmap(imagePath);

            int width = pixelArt.Width;
            int height = pixelArt.Height;

            if (width != 51 || height != 7)
                throw new Exception("Image size is too big. Max size is 7x51");

            string[,] colors = new string[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixelColor = pixelArt.GetPixel(x, y);
                    char colorChar = ConvertPixel(pixelColor);
                    colors[x, y] = colorChar.ToString();
                }
            }
            await buildPixelArt(colors, folderPath, startDate, endDate);
        }

        private static char ConvertPixel(Color color)
        {
            if (color.R is 0 && color.G is 0 && color.B is 0)
                return ' ';
            else
                return '*';
        }

        private static Task buildPixelArt(
            string[,] pixels,
            string folderPath,
            DateTime startDate,
            DateTime endDate
        )
        {
            int width = pixels.GetLength(0);
            int height = pixels.GetLength(1);

            var allDates = DateHelper.getDates(startDate, endDate);
            var datesOnGraph = new List<DateTime>();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (pixels[x, y] == "*")
                    {
                        datesOnGraph.Add(allDates[x, y]);
                    }
                }
            }

            foreach (var date in datesOnGraph)
            {
                string formattedDate = DateHelper.FormatCustomDateTime(date);

                string command =
                    $"git commit --allow-empty --date=\"{formattedDate}\" -m \"{date.ToString("dd:mm:yyyy")}\"";

                CMDHelper.runCMD(command, folderPath);
            }
            return Task.CompletedTask;
        }
    }
}
