namespace Recuperatorio
{
    public class Zombie : Personaje
    {


        public override bool Vive()
        {
            return false;
        }

        public override string Come()
        {
            return "Come Cerebros Humanos!";
        }    
        public override string Camina()
        {
            return "Camina... lentoo, muy lento!";
        }
        public override string Habla()
        {
            return "Aggggggh!!!";
        }


    }
}