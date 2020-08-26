namespace Recuperatorio
{
    public class NoInfectado : Personaje
    {

        public override bool Vive()
        {
            return true;
        }

        public override string Come()
        {

            return "Come de todo, excepto carne humana claro.";
        }
        public override string Camina()
        {
            return "Corre, Camina y hasta Salta!";
        }
        public override string Habla()
        {
            return "Debemos detener a los Zombies y salvar a la humanidad!";
        }

    }
}