using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioClip cardFlipClip;
    [SerializeField] private AudioClip matchSuccessClip;
    [SerializeField] private AudioClip matchFailClip;
    [SerializeField] private AudioClip gameOverClip;
    private AudioSource player;

    private void Start()
    {
        player = GetComponent<AudioSource>();
    }

    public void Play(AudioType type)
    {
        if (player.isPlaying) player.Stop();

        switch (type)
        {
            case AudioType.CardFlipClip:
                player.clip = cardFlipClip;
                break;
            case AudioType.MatchSuccessClip:
                player.clip = matchSuccessClip;
                break;
            case AudioType.MatchFailClip:
                player.clip = matchFailClip;
                break;
            case AudioType.GameOverClip:
                player.clip = gameOverClip;
                break;
        }

        player.Play();
    }
}

public enum AudioType
{
    CardFlipClip,
    MatchSuccessClip,
    MatchFailClip,
    GameOverClip
}