using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    [SerializeField] private ArrowController arrowPrefab;
    private float span = .5f;
    private float delta = 0;

    private void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab.gameObject) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
