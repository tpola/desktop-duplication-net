using SharpDX.DXGI;
using SharpDX.Mathematics.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopDuplication
{
    internal class PointerInfo
    {
        public byte[] PtrShapeBuffer;
        public OutputDuplicatePointerShapeInformation ShapeInfo;
        public RawPoint Position;
        public bool Visible;
        public int BufferSize;
        public int WhoUpdatedPositionLast;
        public long LastTimeStamp;
    }
}
