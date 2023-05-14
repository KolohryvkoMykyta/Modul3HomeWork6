namespace Modul3HomeWork6
{
    public static class Starter
    {
        public static async Task RunAsync()
        {
            var messageBox = new MessageBox();

            for (int i = 0; i < 20; i++)
            {
                messageBox.Open();
            }

            await Task.Delay(4000);
        }
    }
}
