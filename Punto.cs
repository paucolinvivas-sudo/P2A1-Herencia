using System;
class Punto {

    private double x;
    private double y;

    public Punto(double x, double y){
        this.x = x;
        this.y = y;
    }

    public double X {
        get {return this.x; }
        set {this.x = value;}
    }

    public double Y {
        get {return this.y; }
        set {this.y = value;}
    }

    public override string ToString(){
        return "(" + this.x + ", " + this.y + ")";
    }
}