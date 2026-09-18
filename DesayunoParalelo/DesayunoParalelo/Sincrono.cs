namespace DesayunoParalelo;

public class Sincrono {
    public void PrepararCafe() {
        Thread.Sleep(3000);
    }
    
    public void CalentarSarten() {
        Thread.Sleep(3000);
    }
    
    public void FreirHuevo() {
        Thread.Sleep(4000);
    }
    
    public void FreirBacon() {
        Thread.Sleep(3000);
    }
    
    public void TostarPan() {
        Thread.Sleep(3000);
    }
    
    public void UntarMermelada() {
        Thread.Sleep(1000);
    }
    
    public void PrepararZumo() {
        Thread.Sleep(2000);
    }
}