namespace DesayunoParalelo;

public class Asincrono {
    public async Task<string> PrepararCafe() {
        await Task.Delay(3000);
        return "Terminado";
    }
    
    public async Task<string> CalentarSarten() {
        await Task.Delay(3000);
        return "Terminado";
    }
    
    public async Task<string> FreirHuevo() {
        await Task.Delay(4000);
        return "Terminado";
    }
    
    public async Task<string> FreirBacon() {
        await Task.Delay(3000);
        return "Terminado";
    }
    
    public async Task<string> TostarPan() {
        await Task.Delay(3000);
        return "Terminado";
    }
    
    public async Task<string> UntarMermelada() {
        await Task.Delay(1000);
        return "Terminado";
    }
    
    public async Task<string> PrepararZumo() {
        await Task.Delay(2000);
        return "Terminado";
    }
}