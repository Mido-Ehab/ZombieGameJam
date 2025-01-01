using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class DamageDealer : MonoBehaviour
{

    bool canDealDamage;
    List<GameObject> hasDealDamage;

    [SerializeField] float handLength;
    [SerializeField] float Damage;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canDealDamage = false;
        hasDealDamage = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canDealDamage)
        {
            RaycastHit hit;

            int layerMask = 1 << 9;
        
            if(Physics.Raycast(transform.position,-transform.up,out hit, handLength, layerMask))
            {
                if (hit.transform.TryGetComponent(out Enemy enemy)&& !hasDealDamage.Contains(hit.transform.gameObject))
                {
                    print("Damage");
                    enemy.TakeDamage(Damage);
                    hasDealDamage.Add(hit.transform.gameObject);
                }
            }
        }

    }
    public void StartDealDamage()
    {
        canDealDamage=true;
        hasDealDamage.Clear();
    }
    public void EndDealDamage()
    {
        canDealDamage = false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position -  transform.up * handLength);
    }

}
