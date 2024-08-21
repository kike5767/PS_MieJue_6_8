﻿Console.WriteLine("Hello, World!");

public abstract class AProductosBase
{
    // Variables
    protected int id = 0;
    protected string codigo = "";
    protected string nombre = "";
    protected double precio = 0.0;
    protected double cantidad = 0.0;


    // Propiedades
    public void SetId(int valor) { this.id = valor; }
    public int GetId() { return this.id; }
    public void SetCodigo(string valor) { this.codigo = valor; }
    public string GetCodigo() { return this.codigo; }
    public void SetNombre(string valor) { this.nombre = valor; }
    public string GetNombre() { return this.nombre; }
    public void SetPrecio(double valor) { this.precio = valor; }
    public double GetPrecio() { return this.precio; }
    public void SetCantidad(double valor) { this.cantidad = valor; }
    public double GetCantidad() { return this.cantidad; }

    public abstract void CalcularDescuento();
}

public interface IImpuestos
{
    void CalcularValor();
}

public class Productos : AProductosBase, IImpuestos
{
    // Constructor
    public Productos()
    {

    }

    // Metodos
    public void CalcularValor()
    {
        var calculo = (this.cantidad * this.precio) - 100;
    }

    public override void CalcularDescuento()
    {
        
    }
}


public class Productos1 : AProductosBase, IImpuestos
{
    // Variables
    protected double descuento = 0.0;

    // Constructor
    public Productos1()
    {

    }

    // Metodos
    public void CalcularValor()
    {
        var calculo = this.cantidad * this.precio;
    }

    public override void CalcularDescuento()
    {
        
    }
}