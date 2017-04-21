using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Log4netSample.Util
{
    public class Log4NetHelper
    {

        public string LogMsg(Message m, [Optional] string exceptionMsg, [CallerMemberName] string methodName = "")
        {
            string msg = $"{methodName} {m} {exceptionMsg}";
            return msg;
        }
        public enum Message
        {
            InitialGetRequestStart,
            InitialGetRequestStop,
            MethodStart,
            MethodStop,
            DbCallStart,
            DbCallEnd,
            Start,
            Stop,
            Info,
            Error
        }
    }
}
