using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Threading
{
    public interface IPlcSyncDriver
    {
        ConnectionStates ConnectionState { get; }

        void Connect();

        void Disconnect();

        List<Tag> ReadItems(List<Tag> itemList);

        void ReadClass(object sourceClass, int db);

        void WriteClass(object sourceClass, int db);

        void WriteItems(List<Tag> itemList);
    }
}
