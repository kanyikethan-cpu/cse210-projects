public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < GetDuration())
        {
            int remainingSeconds = GetDuration() -
                (int)(DateTime.Now - startTime).TotalSeconds;

            if (remainingSeconds <= 0)
            {
                break;
            }

            int breathingTime = Math.Min(4, remainingSeconds);

            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            ShowCountDown(breathingTime);

            remainingSeconds = GetDuration() -
                (int)(DateTime.Now - startTime).TotalSeconds;

            if (remainingSeconds <= 0)
            {
                break;
            }

            breathingTime = Math.Min(4, remainingSeconds);

            Console.WriteLine();
            Console.WriteLine("Breathe out...");
            ShowCountDown(breathingTime);
        }

        DisplayEndingMessage();
    }
}