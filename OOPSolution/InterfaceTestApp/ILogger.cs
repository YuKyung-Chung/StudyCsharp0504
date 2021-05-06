namespace InterfaceTestApp
{   //약속이다. 이 ILogger를 구현(상속)하게되면 아래의 액션을 무조건(!) 구현 해야 함
    interface ILogger
    {
        void WriteLog(string message); //하나의 메시지를 받아서 처리할 것
        void WriteError(string error);
    }
}
