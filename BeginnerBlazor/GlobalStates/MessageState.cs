namespace BeginnerBlazor.GlobalStates
{
    public class MessageState
    {
        public string Message { get; set; } 
        public void SetMsg(string imgMsg)
        {
            Message = imgMsg;
        }
        public void ClearMsg()
        {
            Message = "";
        }
    }
}
