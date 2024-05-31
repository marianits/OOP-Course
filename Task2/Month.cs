namespace Curso_OOP_Tarea_2
{
    public struct Month
    {
        public int MonthD;
        public const int MinValue = 1;
        public const int MaxValue = 12;

        public Month()
        {
            this.MonthD = MinValue;
        }
        public Month(int month)
        {
            if (month < MinValue || month > MaxValue) throw new ArgumentOutOfRangeException(nameof(month));
            this.MonthD = month;
        }

        public static implicit operator Month(int value)
        {
            return new Month(value);
        }

        public override string ToString()
        {
            return ((Months)this.MonthD).ToString();
        }
    }

    public enum Months
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }
}
