using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelArtToCommitHistory.Helpers
{
    public static class GithubGraphDateOfYears
    {
        public static List<GitDateOfYearsModel> Dates = new List<GitDateOfYearsModel>()
        {
            new GitDateOfYearsModel("2024", new DateTime(2024, 1, 7), new DateTime(2024, 12, 28)),
            new GitDateOfYearsModel("2023", new DateTime(2023, 1, 1), new DateTime(2023, 12, 30)),
            new GitDateOfYearsModel("2022", new DateTime(2022, 1, 2), new DateTime(2022, 12, 31)),
            new GitDateOfYearsModel("2021", new DateTime(2021, 1, 3), new DateTime(2021, 12, 25)),
            new GitDateOfYearsModel("2020", new DateTime(2020, 1, 5), new DateTime(2020, 12, 26)),
            new GitDateOfYearsModel("2019", new DateTime(2019, 1, 6), new DateTime(2019, 12, 28)),
            new GitDateOfYearsModel("2018", new DateTime(2018, 1, 7), new DateTime(2018, 12, 29)),
            new GitDateOfYearsModel("2017", new DateTime(2017, 1, 1), new DateTime(2017, 12, 30)),
            new GitDateOfYearsModel("2016", new DateTime(2016, 1, 3), new DateTime(2016, 12, 31)),
            new GitDateOfYearsModel("2015", new DateTime(2015, 1, 4), new DateTime(2015, 12, 26)),
            new GitDateOfYearsModel("2014", new DateTime(2014, 1, 5), new DateTime(2014, 12, 27)),
            new GitDateOfYearsModel("2013", new DateTime(2013, 1, 6), new DateTime(2013, 12, 28)),
            new GitDateOfYearsModel("2012", new DateTime(2012, 1, 1), new DateTime(2012, 12, 29)),
            new GitDateOfYearsModel("2011", new DateTime(2011, 1, 2), new DateTime(2011, 12, 31)),
            new GitDateOfYearsModel("2010", new DateTime(2010, 1, 3), new DateTime(2010, 12, 25)),
            new GitDateOfYearsModel("2009", new DateTime(2009, 1, 4), new DateTime(2009, 12, 26)),
            new GitDateOfYearsModel("2008", new DateTime(2008, 1, 6), new DateTime(2008, 12, 27)),
            new GitDateOfYearsModel("2007", new DateTime(2007, 1, 7), new DateTime(2007, 12, 29)),
            new GitDateOfYearsModel("2006", new DateTime(2006, 1, 1), new DateTime(2006, 12, 30)),
            new GitDateOfYearsModel("2005", new DateTime(2005, 1, 2), new DateTime(2005, 12, 31)),
            new GitDateOfYearsModel("2004", new DateTime(2004, 1, 4), new DateTime(2004, 12, 25)),
            new GitDateOfYearsModel("2003", new DateTime(2003, 1, 5), new DateTime(2003, 12, 27)),
            new GitDateOfYearsModel("2002", new DateTime(2002, 1, 6), new DateTime(2002, 12, 28)),
            new GitDateOfYearsModel("2001", new DateTime(2001, 1, 7), new DateTime(2001, 12, 29)),
        };
    }

    public class GitDateOfYearsModel
    {
        public string Year { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public GitDateOfYearsModel(string year, DateTime startDate, DateTime endDate)
        {
            Year = year;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
