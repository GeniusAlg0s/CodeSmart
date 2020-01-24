namespace abstractclasses
{
    // public class Shape
    public  abstract class Shape
    {
        public int Width { get; set; }
        public int Height{ get; set; }

        /* public virtual void Draw()
             {

             }*/
        public abstract void Draw();
        public  void Copy()
        {
            System.Console.WriteLine("Copy into clip board");
        }
        public void Select()
        {
            System.Console.WriteLine("Select shape");
        }
    }
}
