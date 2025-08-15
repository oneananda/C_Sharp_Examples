namespace Error_Handling_Deep_Dive._04_Enterprise_Patterns
{
    internal class ProblemDetails
    {
        public int Status { get; set; }
        public object Title { get; set; }
        public object Detail { get; set; }
        public object Instance { get; set; }
    }
}