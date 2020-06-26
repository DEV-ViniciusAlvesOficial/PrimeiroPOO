namespace Atividade3_PrimeiroPOO
{
    public class heroi
    {
        public string nome;
        public string equipamento;

        //Float = Variável que mostra números "quebrados" Ex: 3,5 11,7
        //int = Variável que mostra números inteiros
        public float Atacar(float mana, float estamina){
            return mana * estamina;
        }

        public string Defender(){
            return "o herói ativou sua ultimate R";
        }
    }
}