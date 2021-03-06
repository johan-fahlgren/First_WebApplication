namespace WebApplicationEmpty.Models
{
    public class Birthday
    {

        public string Person { get; set; }
        public DateTime BornIn { get; set; }

        public DateTime ThisYear(DateTime? today)
        {

            return new DateTime(
                DateTime.Today.Year,
                BornIn.Month,
                BornIn.Day);

        }

    }
}
