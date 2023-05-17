using Modul3HomeWork6.Enums;

namespace Modul3HomeWork6
{
    public class MessageBox
    {
        public MessageBox()
        {
            ListStateHandler += GetState;
        }

        public delegate void StateHandlel(State state);

        public event StateHandlel ListStateHandler;

        public async void Open()
        {
            Console.WriteLine("Window is open");
            await Task.Delay(3000);
            Console.WriteLine("The window was closed by the user");
            ListStateHandler((State)new Random().Next(2));
        }

        private void GetState(State state)
        {
            if (state == State.OK)
            {
                Console.WriteLine("The operation was confirmed");
            }

            if (state == State.Cancel)
            {
                Console.WriteLine("The operation was rejected");
            }
        }
    }
}
