namespace Joguinho
{
    static class Global
    {
        private static int tentativas;
        public static int Tentativas { get => tentativas; set => tentativas = value; }

        private static int acerto;
        public static int Acerto { get => acerto; set => acerto = value; }
    }
}