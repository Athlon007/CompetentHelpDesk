namespace Logic
{
    public struct StatusStruct
    {
        public int Code { get; private set; } // 0 = OK. 1 == Exception.
        public string Message { get; private set; }

        public StatusStruct(int code)
        {
            Code = code;
            Message = "";
        }

        public StatusStruct(int code, string message)
        {
            this.Code = code; 
            this.Message = message;
        }
    }
}
