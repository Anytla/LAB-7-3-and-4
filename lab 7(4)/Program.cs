using System;
using System.Linq;

namespace Telephony
{
    public interface IBrowser
    {
        string Browse(string url);
    }

    public interface ICaller
    {
        string Call(string number);
    }

}
