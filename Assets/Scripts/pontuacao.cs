using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;
public class pontuacao : MonoBehaviour {
    /// <summary>
    /// Pontuação do Player 1.
    /// </summary>
    public static int pontos1;
    /// <summary>
    /// Pontuação do Player 2.
    /// </summary>
    public static int pontos2;
    /// <summary>
    /// Constante com o valor de pontuação que determina o vencedor do jogo
    /// </summary>
    public const int PontuacaoMaxima = 5;

	public Text Score1;
	public Text Score2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    /// <summary>
    /// Atualização de pontuação
    /// </summary>
	void Update () {

        // Atualização do placar.
		Score1.text = pontos1.ToString();
		Score2.text = pontos2.ToString();

        // Verificação se o jogo terminou e quem venceu.
        if (JogadorVencedor(pontos1))
        {
            SceneManager.LoadScene("GameOver");
            pontos1=0;
        }
        if (JogadorVencedor(pontos2))
        {
            SceneManager.LoadScene("GameOver2");
            pontos2=0;
        }
    }

    /// <summary>
    /// Verifica se o jogador foi vencendor. Recebe o valor da pontuação como parâmetro.
    /// </summary>
    /// <param name="Pontuacao"> </param>
    /// <returns></returns>
    public static bool JogadorVencedor(int Pontuacao)
    {
        if (Pontuacao == PontuacaoMaxima)
        {
            return true;
        }
        return false;
    }
}
