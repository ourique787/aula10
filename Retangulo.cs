public class Retangulo{
    double largura;
    double altura;

    public Retangulo(){
        altura = 0;
        largura = 0;
    }

    public Retangulo(double valor){
        altura = valor;
        largura = valor;
    }
    public Retangulo(double altura, double largura){
        this.altura = altura;
        this.largura = largura;
    }
    public double CalcularArea(){
        return largura * altura;
    }
    public double CalcularPerimetro(){
        return 2 * (altura + largura);
    }
    public void Redimensionar(){

    }
    public void Redimensionar(double fator){
        altura *= fator;
        largura *= fator;
    }
    public void Redimensionar(double altura, double largura){
        this.altura = altura;
        this.largura = largura;
    }
    

}