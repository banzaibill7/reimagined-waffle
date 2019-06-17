using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    //Character settings
    public float speed = 15f;
    public Rigidbody2D rb;

    //Weapons settings
    public GameObject bulletPrefab = null;
    public bool canShoot = true;
    public float shootInterval = 1f;

    IEnumerator Start() {
        StartCoroutine(Shoot());
        yield return null;
    }

    void Update() {
        rb.MovePosition(rb.position +
             (Vector2.up * speed * Time.deltaTime * Input.GetAxis("Vertical")) + 
             (Vector2.right * speed * Time.deltaTime * Input.GetAxis("Horizontal")));

        LookAtMouse();
    }

    IEnumerator Shoot() { 
        while(canShoot) {
            if (Input.GetKey(KeyCode.Space)) {
                CreateShot();
            }
            yield return new WaitForSeconds(shootInterval);
        }

        yield return null;
    }

    private void CreateShot() {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

    private void LookAtMouse() {

        Vector3 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 lookAt = mouseScreenPosition;

        //float AngleRad = Mathf.Atan2(lookAt.y - this.transform.position.y, lookAt.x - this.transform.position.x);
        float AngleRad = Mathf.Atan2(lookAt.x - this.transform.position.x, lookAt.y - this.transform.position.y) * -1;

        float AngleDeg = (180 / Mathf.PI) * AngleRad;

        this.transform.rotation = Quaternion.Euler(0, 0, AngleDeg);
    }
}
