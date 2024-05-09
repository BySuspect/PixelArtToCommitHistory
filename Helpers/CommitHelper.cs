using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using PixelArtToCommitHistory.Pages;

namespace PixelArtToCommitHistory.Helpers
{
    public static class CommitHelper
    {
        private static ProgressPage pPage;

        public static async Task StartCommit(string imagePath, string folderPath, int year)
        {
            Bitmap pixelArt = new Bitmap(imagePath);

            int width = pixelArt.Width;
            int height = pixelArt.Height;

            if (width != 53 || height != 7)
                throw new Exception("Image size is too big. Max size is 7x51");

            pPage = new ProgressPage();
            pPage.pbar.Value = 0;

            pPage.Show();
            var dates = new List<DateTime>();
            var graph = DateHelper.GetDateGraphByYear(year);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixelColor = pixelArt.GetPixel(x, y);
                    char colorChar = ConvertPixel(pixelColor);
                    if (colorChar == '*')
                        dates.Add(graph[x, y]);
                }
                pPage.pbar.Value = MathC.TransformNumber(x, 0, width, 0, 10);
            }
            await buildPixelArt(dates, folderPath);

            pPage.pbar.Value = 100;
            pPage.Close();
        }

        private static char ConvertPixel(Color color)
        {
            if (color.R is 0 && color.G is 0 && color.B is 0)
                return ' ';
            else if (color.A is 0)
                return ' ';
            else
                return '*';
        }

        private static Task buildPixelArt(List<DateTime> dates, string folderPath)
        {
            foreach (var date in dates)
            {
                string formattedDate = DateHelper.FormatCustomDateTime(date);
                string command =
                    $"git commit --allow-empty --date=\"{formattedDate}\" -m \"{date.ToString("dd:mm:yyyy")}\"";

                CMDHelper.runCMD(command, folderPath);
                pPage.pbar.Value = MathC.TransformNumber(
                    dates.IndexOf(date),
                    0,
                    dates.Count,
                    30,
                    100
                );
            }
            return Task.CompletedTask;
        }
    }
}
