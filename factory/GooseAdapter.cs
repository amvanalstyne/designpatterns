namespace factory
{
    public class GooseAdapter : IQuackable
    {
        Goose goose;
        public GooseAdapter(Goose goose){
            this.goose = goose;
        }
        public void Quack(){
            goose.Honk();
        }
    }
}