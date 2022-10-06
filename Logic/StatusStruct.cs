namespace Logic
{
    public struct StatusStruct
    {
        public int Code;
        public string Message;

        public StatusStruct(int code)
        {
            Code = code;
            Message = "";
        }

        public StatusStruct(int code, string message)
        {
            this.Code = code; this.Message = message;
        }
    }
}
