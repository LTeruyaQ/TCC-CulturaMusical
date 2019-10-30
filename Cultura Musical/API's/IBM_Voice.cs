using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.API_s
{
    class IBM_Voice
    {
    //    // Esse plugin usa o NuGET Stannieman.AudioPlayer e NAudio

    //    AudioPlayer player;

    //    public void Falar(string mensagem)
    //    {
    //        // Credenciais da IBM
    //        string url = "https://stream.watsonplatform.net/text-to-speech/api/v1/synthesize?voice=pt-BR_IsabelaVoice";
    //        string usuario = "b869da1d-e167-42ab-a92c-38fd95048f85";
    //        string senha = "a88tRoCXbs0p";

    //        // Cria cliente para conectar na API da IBM
    //        HttpClient cliente = new HttpClient();
    //        cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes(usuario + ":" + senha)));
    //        cliente.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("audio/wav"));

    //        // Cria o conteúdo da solicitação
    //        StringContent conteudo = new StringContent("{\"text\": \"" + mensagem + "\"}", Encoding.UTF8, "application/json");

    //        // Executa chamada POST para Api da IBM
    //        var respostaApi = cliente.PostAsync(url, conteudo).Result;
    //        ExecutarAudio(respostaApi);
    //    }

    //    private void ExecutarAudio(HttpResponseMessage respostaApi)
    //    {
    //        // Converte resposta em Bytes
    //        Stream ibmVoz = respostaApi.Content.ReadAsStreamAsync().Result;
    //        string arquivo = "voz.wav";

    //        // Se arquivo do áudio existir, deleta
    //        if (File.Exists(arquivo))
    //            File.Delete(arquivo);

    //        // Salva arquivo de áudio
    //        using (FileStream fs = new FileStream(arquivo, FileMode.OpenOrCreate, FileAccess.ReadWrite))
    //        {
    //            ibmVoz.CopyTo(fs);
    //        }

    //        if (player == null)
    //            player = new AudioPlayer();

    //        // Executa o áudio
    //        player.SetFileAsync(arquivo, arquivo).RunSynchronously();
    //        player.PlayAsync().RunSynchronously();
    //    }

    //    public void IniciarOuvir()
    //    {
    //        // Para player de áudio
    //        if (player != null)
    //        {
    //            player.Dispose();
    //            player = null;
    //        }

    //        // Inicia a gravação do áudio pelo microfone
    //        mciSendString("open new Type waveaudio alias meuaudio", null, 0, IntPtr.Zero);
    //        mciSendString("record meuaudio", null, 0, IntPtr.Zero);
    //    }

    //    public string PararOuvir()
    //    {
    //        // Apaga arquivo gravado existente
    //        string arquivo = "meusom.wav";
    //        if (File.Exists(arquivo))
    //            File.Delete(arquivo);

    //        // Salva novo arquivo de audio
    //        mciSendString("save meuaudio " + arquivo, null, 0, IntPtr.Zero);
    //        mciSendString("close meuaudio", null, 0, IntPtr.Zero);

    //        // Configura credenciais Api da IBM
    //        string url = "https://stream.watsonplatform.net/speech-to-text/api/v1/recognize?model=pt-BR_NarrowbandModel";
    //        string usuario = "c4e43837-e1d6-42df-9788-7af41e14b949";
    //        string senha = "na2ABajmkmGp";

    //        // Cria cliente para conectar na Api da IBM
    //        HttpClient client = new HttpClient();
    //        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes(usuario + ":" + senha)));
    //        client.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

    //        // Cria conteúdo do cliente
    //        StreamContent content = new StreamContent(new FileStream(arquivo, FileMode.Open, FileAccess.Read));

    //        // Executa chamada POST na Api (resposta em Json)
    //        var ibmTexto = client.PostAsync(url, content).Result.Content.ReadAsStringAsync().Result;

    //        // Converte Json para Classe
    //        IbmVoiceResult obj = JsonConvert.DeserializeObject<IbmVoiceResult>(ibmTexto);

    //        // Retorna o texto
    //        string texto = obj.results[0].alternatives[0].transcript;
    //        return texto;
    //    }

    //    [DllImport("winmm.dll")]
    //    private static extern long mciSendString(string comando, StringBuilder sb, int length, IntPtr cb);
    }
}

