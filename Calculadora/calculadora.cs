namespace EspacioCalculadora;
public class Calculadora
{
    private double dato;
    //Constructor para que dato comience en 0
    public Calculadora(){
        dato=0;
    }
    public void sumar(double termino)
    {
        dato=dato+termino;
    }
    public void restar(double termino)
    {
         dato=dato-termino;
    }
    public void multiplicar(double termino)
    {
         dato=dato*termino;
    }
    public void dividir(double termino)
    {
         dato=dato/termino;
    }
    public void limpiar()
    {
        dato=0;
    }
    public double Resultado
    {
        get => dato;
    }
}