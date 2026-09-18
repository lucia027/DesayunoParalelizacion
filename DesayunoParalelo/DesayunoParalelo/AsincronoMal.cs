namespace DesayunoParalelo;

public class AsincronoMal {
    
    async Task PrepararCafe() {
        await Task.Delay(3000);
    }
    
    async Task CalentarSarten() {
        await Task.Delay(3000);
    }
    
    async Task FreirHuevo() {
        await Task.Delay(4000);
    }
    
    async Task FreirBacon() {
        await Task.Delay(3000);
    }
    
    async Task TostarPan() {
        await Task.Delay(3000);
    }
    
    async Task HuntarMermelada() {
        await Task.Delay(1000);
    }
    
    async Task PrepararZumo() {
        await Task.Delay(2000);
    }
}