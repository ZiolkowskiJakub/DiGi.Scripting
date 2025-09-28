namespace DiGi.Scripting.Classes
{
    public class Input : Variable
    {
        public Input(string? name, double value)
            :base(name, typeof(double), value)
        {

        }
    }
}
