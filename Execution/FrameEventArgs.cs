using System;
using Jay.VTS.Structures;

namespace Jay.VTS.Execution
{
    public class FrameEventArgs : EventArgs 
    {
        public enum Exits { EOF = -2, ReturnValue = -1, Return = 0, InternalException = 1, CodeException = 2 }
        public Exits ExitCode;
        public VTSException Error;
        public string InternalError;
        public VTSVariable ReturnValue;
        public StackFrame Frame;

        public FrameEventArgs() { }

        public FrameEventArgs SetExitCode(Exits Code) { 
            ExitCode = Code;
            return this;
        }

        public FrameEventArgs SetError(VTSException Error) {
            this.Error = Error;
            return this;
        }

        public FrameEventArgs SetInternal(string Internal) {
            this.InternalError = Internal;
            return this;
        }
    }
}