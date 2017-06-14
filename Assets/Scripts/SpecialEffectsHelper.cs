using UnityEngine;

public class SpecialEffectsHelper : MonoBehaviour
{
  public static SpecialEffectsHelper Instance;

  	public ParticleSystem detroyEffect1;
  	public ParticleSystem detroyEffect2;
  	public ParticleSystem detroyEffect3;
  	public ParticleSystem detroyEffect4;
	public ParticleSystem detroyEffect5;
  	public ParticleSystem fireEffect;

    void Awake()
    {
    if (Instance != null)
    {
        Debug.LogError("Multiple instances of SpecialEffectsHelper!");
    }
        Instance = this;
    }

    public void Explosion(Vector3 position)
    {
    instantiate(detroyEffect1, position);
    instantiate(detroyEffect2, position);
    instantiate(detroyEffect3, position);
    instantiate(detroyEffect4, position);
    }

    public void ExplosionFire(Vector3 position)
    {
        instantiate(fireEffect, position);
    }
	public void ExplosionSingle(Vector3 position)
	{
		instantiate(detroyEffect5, position);
	}

    private ParticleSystem instantiate(ParticleSystem prefab, Vector3 position)
  {
    ParticleSystem newParticleSystem = Instantiate(prefab, position, Quaternion.identity) as ParticleSystem;

    Destroy(newParticleSystem.gameObject, newParticleSystem.startLifetime);

    return newParticleSystem;
  }
}