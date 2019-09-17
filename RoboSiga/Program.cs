using RoboSiga.Process;

namespace RoboSiga
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessManager manager = new ProcessManager();
            manager.Start(3600);
        }
    }
}
