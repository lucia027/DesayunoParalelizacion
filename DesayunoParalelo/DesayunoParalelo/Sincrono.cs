namespace DesayunoParalelo;

public class Sincrono {
    public void PrepararCafe() {
        Thread.Sleep(200);
    }
    
    public void CalentarSarten() {
        Thread.Sleep(200);
    }
    
    public void FreirHuevo() {
        Thread.Sleep(300);
    }
    
    public void FreirBacon() {
        Thread.Sleep(300);
    }
    
    public void TostarPan() {
        Thread.Sleep(200);
    }
    
    public void UntarMermelada() {
        Thread.Sleep(100);
    }
    
    public void PrepararZumo() {
        Thread.Sleep(200);
    }
}