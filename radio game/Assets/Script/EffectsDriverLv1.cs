using Unity.Burst;
using UnityEngine;
using UnityEngine.Audio;

public class EffectsDriverLv1 : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;

    public void UpdateEffects(float _tune)
    {
        Debug.Log(_tune);
        mixer.SetFloat("FlangeRate", (_tune / 1000f) * 10f);
    }
}
