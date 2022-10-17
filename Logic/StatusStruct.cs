namespace Logic
{
    public struct StatusStruct
    {
        /// <summary>
        /// Status code of the operation.<br></br><br></br>
        /// <b>0</b> = OK.<br></br>
        /// <b>1</b> (and above) = Fail
        /// </summary>
        public int Code { get; private set; }

        /// <summary>
        /// FRIENDLY (to the user) error message displayed in the GUI, if applicable.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Create new Status response without a message.
        /// </summary>
        /// <param name="code">Error code. 0 = OK.</param>
        public StatusStruct(int code)
        {
            Code = code;
            Message = "";
        }

        /// <summary>
        /// Create new Status response with a message.
        /// </summary>
        /// <param name="code">Error code. 0 = OK.</param>
        /// <param name="message">Friendly message displayed in GUI.</param>
        public StatusStruct(int code, string message)
        {
            Code = code; 
            Message = message;
        }
    }
}
