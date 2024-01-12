internal class Program
{
    private static void Main(string[] args)
    {
        
    }
}
public interface IDamage
{
public void Health();
public void Death();
}
public interface Attack
{
public void Fire();
public void Slash();
}
public abstract class Animal
{
    public abstract void Eat();
    public abstract void Sleep();
}
public class Cat :  Animal,IDamage,Attack 
{
    public override void Eat()
    {

    }
    public override void Sleep()
    {

    }
    public void Health()
    {

    }
    public void Death()
    {

    }
    
    public  void Fire()
    {
        
    }
    public  void Slash()
    {
        
    }

}
public class Dog :  Animal,IDamage,Attack 
{
    public override void Eat()
    {

    }
    public override void Sleep()
    {

    }
    public void Health()
    {

    }
    public void Death()
    {

    }
    
    public  void Fire()
    {
        
    }
    public  void Slash()
    {
        
    }

}

public class Tiger: IDamage
{
    int health=1000;
    bool isDead=false;
    public void Death()
    {
        if(health<0)
        {
            isDead=true;
        }
    }
    public void Health()
    {
        health-=1;
    }
}

public class Chicken: IDamage
{
    int health=200;
    bool isStar=true;
    bool isDead=false;
    public void Death()
    {
        health-=10;
    }

    public void Health()
    {
        if(health<0 && !isStar)
        {
            isDead=true;
        }
    }
}

public class Bullet(int other)
{
    //other.Health();
}
public interface Effect
{
    void Effect();
}
public class Water : Effect
{
    public void Effect()
    {
        Console.WriteLine("Ban nuoc len");
    }
}
public class Steel:Effect
{
    public void Effect()
    {
        Console.WriteLine("Sinh ra tia lua dien");
    }
}
public class Wood: Effect
{
    public void Effect()
    {
        Console.WriteLine("Tao ra lo tren go");
    }
}
public class GunBullet(string other)
{
    if(other.equals"Water")
    {
        Console.WriteLine("Ban nuoc len");
    }
    else (other.equals"Steel")
    {
        Console.WriteLine("Sinh ra tia lua dien");
    }
    else (other.equals"Wood")
    {
        Console.WriteLine("Tao ra lo tren go");
    }
}