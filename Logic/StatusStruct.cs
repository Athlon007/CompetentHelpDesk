namespace Logic
{
    public struct StatusStruct
    {
        public int Code; // 0 = OK. 1 == Exception.
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
