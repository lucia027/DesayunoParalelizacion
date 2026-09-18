namespace DesayunoParalelo;

public class AsincronoToken {
    public async Task<string> PrepararCafe(CancellationToken token) {
        await Task.Delay(200, token);
        return "Terminado";
    }
    
    public async Task<string> CalentarSarten(CancellationToken token) {
        await Task.Delay(200, token);
        return "Terminado";
    }
    
    public async Task<string> FreirHuevo(CancellationToken token) {
        await Task.Delay(300, token);
        return "Terminado";
    }
    
    public async Task<string> FreirBacon(CancellationToken token) {
        await Task.Delay(300, token);
        return "Terminado";
    }
    
    public async Task<string> TostarPan(CancellationToken token) {
        await Task.Delay(200, token);
        return "Terminado";
    }
    
    public async Task<string> UntarMermelada(CancellationToken token) {
        await Task.Delay(100, token);
        return "Terminado";
    }
    
    public async Task<string> PrepararZumo(CancellationToken token) {
        await Task.Delay(200, token);
        return "Terminado";
    }
}