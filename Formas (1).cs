using System;
class Forma {

     private string color;
     protected Punto centro;
     private string nombre;

     public Forma(string color, Punto centro, string nombre){
         this.color = color;
         this.centro = centro;
         this.nombre = nombre;
     }

     public string Color {
         get {return this.color; }
         set {this.color = value;}
     }

     public Punto Centro {
         get {return this.centro; }
         set {this.centro = value;}
     }

     public string Nombre {
         get {return this.nombre; }
         set {this.nombre = value;}
     }

     public override string ToString(){
         return "Nombre: " + this.nombre + "\nColor: " + this.color + "\nCentro: " + this.centro.ToString();
     }

     public void Mover(double nuevaX, double nuevaY){
         this.centro.X = nuevaX;
         this.centro.Y = nuevaY;
     }
}
//la clase Forma es la clase base y Rectangulo, Elipse, etc. son sus derivadas