using RoboSiga.Models;

namespace RoboSiga.Process
{
    public interface IProcess
    {
        BaseResult Start();
        void Error();
        void Success();
    }
}
