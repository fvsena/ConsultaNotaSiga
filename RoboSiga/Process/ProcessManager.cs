using System;
using System.Threading;

namespace RoboSiga.Process
{
    public class ProcessManager
    {
        public void Start(int delay)
        {
            while (true)
            {
                ExecuteProcess();
                Console.WriteLine($" | Próxima execução: {DateTime.Now.AddSeconds(delay).ToString("dd/MM/yyyy hh:mm:ss")}");
                Thread.Sleep(delay * 1000);
            }
        }

        private void ExecuteProcess()
        {
            Console.Write(new SigaProcess().Start().Message);
        }
    }
}
