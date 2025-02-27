using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    public float gapFire = 0.5f;
    public GameObject player;
    public PlayerHealth playerHealth;
    public float timer;
    public int op;
    public Animator anim;
    public float opTimer;
    public float temp = 2f;

    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        anim = GetComponent<Animator>();
        player = PlayerController.Instance.gameObject;
    }

    void Update()
    {
        /*float distance = Vector2.Distance(transform.position, playerPosition);
        if (distance < 5)   //Zombie Shooting Range setup
        {
            timer += Time.deltaTime;
            if (timer > 2)
            {
                timer = 0;
                anim.SetTrigger("Fire");
                Shoot();
            }
        }
        if (distance >= 12f)   //Zombie Shooting Range setup
            return;
        timer += Time.deltaTime;
        if (timer > gapFire)
        {
            timer = 0;
            anim.SetTrigger("Fire");
            //Raining();
            switch (op)
            {
                case 0:
                    Shoot();
                    gapFire = 0.5f;
                    break;
                case 1:
                    ShotgunShot();
                    gapFire = 0.5f;
                    break;
                case 2:
                    Pentagram();
                    gapFire = 0.25f;
                    break;
                case 3:
                    WrongFuckingShoot();
                    gapFire = 0.125f;
                    break;
                case 4:
                    LerpShot();
                    gapFire = 1f;
                    break;
                case 5:
                    TripperTake();
                    gapFire = 0.5f;
                    break;

            }
        }
        opTimer += Time.deltaTime;
        if (opTimer > temp)
        {
            opTimer = 0;
            op = (op + 1) % 6;
        }*/
    }

    public Vector3 playerPosition => PlayerController.Instance.Position;
    public Vector2 playerDirection => playerPosition - transform.position;
    public float playerAngle => Mathf.Atan2(playerDirection.y, playerDirection.x) * Mathf.Rad2Deg;
    public GameObject AngleFix(float angle)
    {
        GameObject bulletFive = Instantiate(bullet, bulletPos.position, Quaternion.identity);
        Vector2 angleWay = new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad)).normalized;
        bulletFive.GetComponent<EnemybulletScript>().way = angleWay;
        return bulletFive;
    }

    public void Shoot()        //1 to 1
    {
        AngleFix(playerAngle);
        GameManager.Instance.audioManager.Play(4, "seEnemyShoot", false);
    }

    public void ShotgunShot()  //1 to 3
    {
        for (int i = -1; i <= 1; i++)
        {
            GameObject bulletSS = AngleFix(playerAngle + i * 2.5f);
            bulletSS.GetComponent<EnemybulletScript>().reCallTime = 3F;
        }
        GameManager.Instance.audioManager.Play(4, "seEnemyShoot", false);
    }

    public void Pentagram()    //0 to 5
    {
        float angleAim = playerAngle;
        for (int m = 0; m <= 5; m++)
        {
            GameObject bulletFive = AngleFix(angleAim);
            angleAim += 72;
        }
        GameManager.Instance.audioManager.Play(4, "seEnemyShoot", false);
    }

    public void WrongFuckingShoot()    //0 to 5
    {
        GameObject bulletShit = AngleFix(Mathf.Atan2(playerDirection.x, playerDirection.y) * Mathf.Rad2Deg);
        GameManager.Instance.audioManager.Play(4, "seEnemyShoot", false);
    }

    public void LerpShot()     //lerp 1 to 1
    {
        GameObject bulletLerp = Instantiate(bullet, bulletPos.position, Quaternion.identity);
        bulletLerp.GetComponent<EnemybulletScript>().way = playerDirection;
        bulletLerp.GetComponent<EnemybulletScript>().lerping = true;
        GameManager.Instance.audioManager.Play(4, "seEnemyShoot", false);
    }

    //捲捲面

    public Vector2 Calculation(int i)
    {
        Vector2 newPosition = new(0f, -0.675f * i);
        GameManager.Instance.audioManager.Play(4, "seEnemyShoot", false);
        return newPosition;
    }
    public void TripperTake()      //3 to 1
    {
        for (int n = -1; n <= 1; n++)
        {
            Vector3 newPosition = Calculation(n);
            GameObject bulletTTO = Instantiate(bullet, bulletPos.position + newPosition, Quaternion.identity);
            Vector2 direction = playerPosition - bulletTTO.transform.position;
            bulletTTO.GetComponent<EnemybulletScript>().way = direction;
        }
        GameManager.Instance.audioManager.Play(4, "seEnemyShoot", false);
    }

    public void Raining()      //  _|_
    {
        float middlePoint = (playerPosition.x + bulletPos.transform.position.x) / 2;
        GameObject bulletRain = Instantiate(bullet, new(middlePoint, (2 * bulletPos.position.y)), Quaternion.identity);
        //bulletRain.GetComponent<EnemybulletScript>().way = -(transform.up);
        bulletRain.GetComponent<EnemybulletScript>().splits = 2;
        GameManager.Instance.audioManager.Play(4, "seEnemyShoot", false);
    }
}