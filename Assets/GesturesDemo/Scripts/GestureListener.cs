using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GestureListener : MonoBehaviour, KinectGestures.GestureListenerInterface
{
    // GUI Text to display the gesture messages.
    public GUIText GestureInfo;
    public int contador1;
    public int contador2;
    public int contador3;
    public int contador4;
    public int contador5;
    public int contador6;
    public int contador7;
    public int contador8;

    private bool Musibidachi;
    private bool Joe;
    private bool Zenkutsu;
    private bool Kokutsu;
    private bool Tsuki;
    private bool OiZuki;
    private bool Uke;
    private bool AgeUke;

    public GameObject move1;
    public GameObject move2;
    public GameObject move3;
    public GameObject move4;
    public GameObject move5;
    public GameObject move6;
    public GameObject move7;
    public GameObject move8;

    public Image mov1;
    public Image mov2;
    public Image mov3;
    public Image mov4;
    public Image mov5;
    public Image mov6;
    public Image mov7;
    public Image mov8;

    public Image cont0;
    public Image cont1;
    public Image cont2;
    public Image cont3;

    public Image subTutor1;
    public Image subTutor2;
    public Image subTutor3;
    public Image subTutor4;
    public Image subTutor5;
    public Image subTutor6;
    public Image subTutor7;
    public Image subTutor8;

    public AudioSource soundTutor1;
    public AudioSource soundTutor2;
    public AudioSource soundTutor3;
    public AudioSource soundTutor4;
    public AudioSource soundTutor5;
    public AudioSource soundTutor6;
    public AudioSource soundTutor7;
    public AudioSource soundTutor8;

    public int MovActual;
    private string usuarioTemp = LoginController.usuario;
    public static String modulo = "";

    private void Awake()
    {
            contador1 =0;
            contador2=0;
            contador3=0;
            contador4=0;
            contador5=0;
            contador6=0;
            contador7=0;
            contador8=0;
        SeleccionMovimiento();
        ActualizarContador();
    }


    void Start()
    {
        SeleccionMovimiento();
        Debug.Log("Mov Actual es :");
        Debug.Log(MovActual);
        if (MovActual != 0)
        {
            if (MovActual == 1)
            {
                mov1.enabled = true;
                mov2.enabled = false;
                mov3.enabled = false;
                mov4.enabled = false;
                mov5.enabled = false;
                mov6.enabled = false;
                mov7.enabled = false;
                mov8.enabled = false;
            }
            else if (MovActual == 2)
            {
                mov2.enabled = true;
                mov1.enabled = false;
                mov3.enabled = false;
                mov4.enabled = false;
                mov5.enabled = false;
                mov6.enabled = false;
                mov7.enabled = false;
                mov8.enabled = false;
            }
            else if (MovActual == 3)
            {
                mov3.enabled = true;
                mov1.enabled = false;
                mov2.enabled = false;
                mov4.enabled = false;
                mov5.enabled = false;
                mov6.enabled = false;
                mov7.enabled = false;
                mov8.enabled = false;
            }
            else if (MovActual == 4)
            {
                mov4.enabled = true;
                mov1.enabled = false;
                mov3.enabled = false;
                mov2.enabled = false;
                mov5.enabled = false;
                mov6.enabled = false;
                mov7.enabled = false;
                mov8.enabled = false;
            }
            else if (MovActual == 5)
            {
                mov5.enabled = true;
                mov1.enabled = false;
                mov3.enabled = false;
                mov4.enabled = false;
                mov2.enabled = false;
                mov6.enabled = false;
                mov7.enabled = false;
                mov8.enabled = false;
            }
            else if (MovActual == 6)
            {
                mov6.enabled = true;
                mov1.enabled = false;
                mov3.enabled = false;
                mov4.enabled = false;
                mov5.enabled = false;
                mov2.enabled = false;
                mov7.enabled = false;
                mov8.enabled = false;
            }
            else if (MovActual == 7)
            {
                mov7.enabled = true;
                mov1.enabled = false;
                mov3.enabled = false;
                mov4.enabled = false;
                mov5.enabled = false;
                mov6.enabled = false;
                mov2.enabled = false;
                mov8.enabled = false;
            }
            else if (MovActual == 8)
            {
                mov8.enabled = true;
                mov1.enabled = false;
                mov3.enabled = false;
                mov4.enabled = false;
                mov5.enabled = false;
                mov6.enabled = false;
                mov7.enabled = false;
                mov2.enabled = false;
            }

        }

        if (LoginController.mostrarSubs == 1)
        {
            if (MovActual == 1)
            {
                subTutor1.enabled = true;
                subTutor2.enabled = false;
                subTutor3.enabled = false;
                subTutor4.enabled = false;
                subTutor5.enabled = false;
                subTutor6.enabled = false;
                subTutor7.enabled = false;
                subTutor8.enabled = false;
            }
            else if (MovActual == 2)
            {
                subTutor2.enabled = true;
                subTutor1.enabled = false;
                subTutor3.enabled = false;
                subTutor4.enabled = false;
                subTutor5.enabled = false;
                subTutor6.enabled = false;
                subTutor7.enabled = false;
                subTutor8.enabled = false;
            }
            else if (MovActual == 3)
            {
                subTutor3.enabled = true;
                subTutor1.enabled = false;
                subTutor2.enabled = false;
                subTutor4.enabled = false;
                subTutor5.enabled = false;
                subTutor6.enabled = false;
                subTutor7.enabled = false;
                subTutor8.enabled = false;
            }
            else if (MovActual == 4)
            {
                subTutor4.enabled = true;
                subTutor1.enabled = false;
                subTutor3.enabled = false;
                subTutor2.enabled = false;
                subTutor5.enabled = false;
                subTutor6.enabled = false;
                subTutor7.enabled = false;
                subTutor8.enabled = false;
            }
            else if (MovActual == 5)
            {
                subTutor5.enabled = true;
                subTutor1.enabled = false;
                subTutor3.enabled = false;
                subTutor4.enabled = false;
                subTutor2.enabled = false;
                subTutor6.enabled = false;
                subTutor7.enabled = false;
                subTutor8.enabled = false;
            }
            else if (MovActual == 6)
            {
                subTutor6.enabled = true;
                subTutor1.enabled = false;
                subTutor3.enabled = false;
                subTutor4.enabled = false;
                subTutor5.enabled = false;
                subTutor2.enabled = false;
                subTutor7.enabled = false;
                subTutor8.enabled = false;
            }
            else if (MovActual == 7)
            {
                subTutor7.enabled = true;
                subTutor1.enabled = false;
                subTutor3.enabled = false;
                subTutor4.enabled = false;
                subTutor5.enabled = false;
                subTutor6.enabled = false;
                subTutor2.enabled = false;
                subTutor8.enabled = false;
            }
            else if (MovActual == 8)
            {
                subTutor8.enabled = true;
                subTutor1.enabled = false;
                subTutor3.enabled = false;
                subTutor4.enabled = false;
                subTutor5.enabled = false;
                subTutor6.enabled = false;
                subTutor7.enabled = false;
                subTutor2.enabled = false;
            }else
            {
                subTutor1.enabled = false;
                subTutor2.enabled = false;
                subTutor3.enabled = false;
                subTutor4.enabled = false;
                subTutor5.enabled = false;
                subTutor6.enabled = false;
                subTutor7.enabled = false;
                subTutor8.enabled = false;
            }
        }

        if (LoginController.reproducirVoz == 1)
        {
            if (MovActual == 1)
            {
                soundTutor1.Play();
                soundTutor2.Stop();
                soundTutor3.Stop();
                soundTutor4.Stop();
                soundTutor5.Stop();
                soundTutor6.Stop();
                soundTutor7.Stop();
                soundTutor8.Stop();
            }
            else if (MovActual == 2)
            {
                soundTutor2.Play();
                soundTutor1.Stop();
                soundTutor3.Stop();
                soundTutor4.Stop();
                soundTutor5.Stop();
                soundTutor6.Stop();
                soundTutor7.Stop();
                soundTutor8.Stop();
            }
            else if (MovActual == 3)
            {
                soundTutor3.Play();
                soundTutor1.Stop();
                soundTutor2.Stop();
                soundTutor4.Stop();
                soundTutor5.Stop();
                soundTutor6.Stop();
                soundTutor7.Stop();
                soundTutor8.Stop();
            }
            else if (MovActual == 4)
            {
                soundTutor4.Play();
                soundTutor1.Stop();
                soundTutor3.Stop();
                soundTutor2.Stop();
                soundTutor5.Stop();
                soundTutor6.Stop();
                soundTutor7.Stop();
                soundTutor8.Stop();
            }
            else if (MovActual == 5)
            {
                soundTutor5.Play();
                soundTutor1.Stop();
                soundTutor3.Stop();
                soundTutor4.Stop();
                soundTutor2.Stop();
                soundTutor6.Stop();
                soundTutor7.Stop();
                soundTutor8.Stop();
            }
            else if (MovActual == 6)
            {
                soundTutor6.Play();
                soundTutor1.Stop();
                soundTutor3.Stop();
                soundTutor4.Stop();
                soundTutor5.Stop();
                soundTutor2.Stop();
                soundTutor7.Stop();
                soundTutor8.Stop();
            }
            else if (MovActual == 7)
            {
                soundTutor7.Play();
                soundTutor1.Stop();
                soundTutor3.Stop();
                soundTutor4.Stop();
                soundTutor5.Stop();
                soundTutor6.Stop();
                soundTutor2.Stop();
                soundTutor8.Stop();
            }
            else if (MovActual == 8)
            {
                soundTutor8.Play();
                soundTutor1.Stop();
                soundTutor3.Stop();
                soundTutor4.Stop();
                soundTutor5.Stop();
                soundTutor6.Stop();
                soundTutor7.Stop();
                soundTutor2.Stop();
            }else
            {
                soundTutor1.Stop();
                soundTutor2.Stop();
                soundTutor3.Stop();
                soundTutor4.Stop();
                soundTutor5.Stop();
                soundTutor6.Stop();
                soundTutor7.Stop();
                soundTutor8.Stop();
            }
        }
    }

    public void SeleccionMovimiento()
    {
        MovActual = LoginController.Movimiento;

        if (MovActual == 1)
        {
            Musibidachi = true;
            
        }
        else if (MovActual == 2)
        {
            Joe = true;
            
        }
        else if (MovActual == 3)
        {
            Zenkutsu = true;
            
        }
        else if (MovActual == 4)
        {
            Kokutsu = true;
            
        }
        else if (MovActual == 5)
        {
            Tsuki = true;
            
        }
        else if (MovActual == 6)
        {
            OiZuki = true;
            
        }
        else if (MovActual == 7)
        {
            Uke = true;
            
        }
        else if (MovActual == 8)
        {
            AgeUke = true;
            
        }

    }

    public void extraerLockMovimiento(int movimiento)
    {
        string url = "http://localhost/PAK_Modulos/PAK_getLockMov.php?" + "UsuSobNom=" + LoginController.usuario + "&NumMov=" + movimiento;
        StartCoroutine(LockMov(url));
    }

    IEnumerator LockMov(string url)
    {
        Debug.Log(url);
        WWW conecction = new WWW(url);
        yield return (conecction);
        if (conecction.text.Contains("null"))
        {
            Debug.Log("No se encuentran datos");
        }
        else
        {
            if (conecction.text.Contains("1"))
            {
                MovActual += 1;
                Debug.Log(MovActual);
            }
        }
    }




    public bool EsMusibidachi()
    {
        if (Musibidachi)
        {
            Musibidachi = false;
            return true;
        }

        return false;
    }
    public bool EsJoe()
    {
        if (Joe)
        {
            Joe = false;
            return true;
        }

        return false;
    }

    public bool EsZenkutsu()
    {
        if (Zenkutsu)
        {
            Zenkutsu = false;
            return true;
        }

        return false;
    }

    public bool EsKokutsu()
    {
        if (Kokutsu)
        {
            Kokutsu = false;
            return true;
        }

        return false;
    }

    public bool EsOiZuki()
    {
        if (OiZuki)
        {
            OiZuki = false;
            return true;
        }

        return false;
    }

    public bool EsTsuki()
    {
        if (Tsuki)
        {
            Tsuki = false;
            return true;
        }

        return false;
    }

    public bool EsUke()
    {
        if (Uke)
        {
            Uke = false;
            return true;
        }

        return false;
    }

    public bool EsAgeUke()
    {
        if (AgeUke)
        {
            AgeUke = false;
            return true;
        }

        return false;
    }

    public void UserDetected(uint userId, int userIndex)
    {
        // detect these user specific gestures
        KinectManager manager = KinectManager.Instance;

        manager.DetectGesture(userId, KinectGestures.Gestures.Musibidachi);
        manager.DetectGesture(userId, KinectGestures.Gestures.Joe);
        manager.DetectGesture(userId, KinectGestures.Gestures.Zenkutsu);
        manager.DetectGesture(userId, KinectGestures.Gestures.Kokutsu);
        manager.DetectGesture(userId, KinectGestures.Gestures.OiZuki);
        manager.DetectGesture(userId, KinectGestures.Gestures.Tsuki);
        manager.DetectGesture(userId, KinectGestures.Gestures.Uke);
        manager.DetectGesture(userId, KinectGestures.Gestures.AgeUke);

        if (GestureInfo != null)
        {
            GestureInfo.GetComponent<GUIText>().text = "Realice golpes hacia el frente";
        }
    }

    public void UserLost(uint userId, int userIndex)
    {
        if (GestureInfo != null)
        {
            GestureInfo.GetComponent<GUIText>().text = string.Empty;
        }
    }

    public void GestureInProgress(uint userId, int userIndex, KinectGestures.Gestures gesture,
                                  float progress, KinectWrapper.NuiSkeletonPositionIndex joint, Vector3 screenPos)
    {
        // don't do anything here
    }

    public bool GestureCompleted(uint userId, int userIndex, KinectGestures.Gestures gesture,
                                  KinectWrapper.NuiSkeletonPositionIndex joint, Vector3 screenPos)
    {
        string sGestureText = gesture + " Detectado";
        if (GestureInfo != null)
        {
            GestureInfo.GetComponent<GUIText>().text = sGestureText;
        }

        if (gesture == KinectGestures.Gestures.Musibidachi)
        {
            Musibidachi = true;
            contador1++;
            Debug.Log(contador1);
            ActualizarContador();
        }
        else if (gesture == KinectGestures.Gestures.Joe)
        {
            Joe = true;
            contador2++;
            ActualizarContador();
        }
        else if (gesture == KinectGestures.Gestures.Zenkutsu)
        {
            Zenkutsu = true;
            contador3++;
            ActualizarContador();
        }
        else if (gesture == KinectGestures.Gestures.Kokutsu)
        {
            Kokutsu = true;
            contador4++;
            ActualizarContador();
        }
        else if (gesture == KinectGestures.Gestures.Tsuki)
        {
            Tsuki = true;
            contador5++;
            ActualizarContador();
        }
        else if (gesture == KinectGestures.Gestures.OiZuki)
        {
            OiZuki = true;
            contador6++;
            ActualizarContador();
        }
        else if (gesture == KinectGestures.Gestures.Uke)
        {
            Uke = true;
            contador7++;
            ActualizarContador();
        }
        else if (gesture == KinectGestures.Gestures.AgeUke)
        {
            AgeUke = true;
            contador8++;
            ActualizarContador();
        }

        if (MovActual == 1 && contador1 == 3)
        {
            Debug.Log("Musi Completo");
            LoginController.Movimiento = 2;
            ActualizarMovimiento(1);
            DestroyImmediate(Camera.main.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
 
        }
        else if (MovActual == 2 && contador2 == 3)
        {
            LoginController.Movimiento = 3;
            ActualizarMovimiento(2);
            DestroyImmediate(Camera.main.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (MovActual == 3 && contador3 == 3)
        {
            LoginController.Movimiento = 4;
            ActualizarMovimiento(3);
            DestroyImmediate(Camera.main.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (MovActual == 4 && contador4 == 3)
        {
            LoginController.Movimiento = 5;
            ActualizarMovimiento(4);
            DestroyImmediate(Camera.main.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (MovActual == 5 && contador5 == 3)
        {
            LoginController.Movimiento = 6;
            ActualizarMovimiento(5);
            DestroyImmediate(Camera.main.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (MovActual == 6 && contador6 == 3)
        {
            LoginController.Movimiento = 7;
            ActualizarMovimiento(6);
            DestroyImmediate(Camera.main.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (MovActual == 7 && contador7 == 3)
        {
            LoginController.Movimiento = 8;
            ActualizarMovimiento(7);
            DestroyImmediate(Camera.main.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (MovActual == 8 && contador8 == 3)
        {
            ActualizarMovimiento(8);
            DestroyImmediate(Camera.main.gameObject);
            SceneManager.LoadScene("ModulosEntrenamiento");
        }

        return true;

    }

    public void ActualizarMovimiento(int movimiento)
    {
        string url = "http://localhost/PAK_Modulos/PAK_setMov.php?" + "UsuSobNom=" + LoginController.usuario + "&NumMov=" + movimiento;
        StartCoroutine(Actualizar(url));
    }

    IEnumerator Actualizar(string url)
    {
        Debug.Log(url);
        WWW conecction = new WWW(url);
        yield return (conecction);
        if (conecction.text.Contains("null"))
        {
            Debug.Log("No se encuentran datos");
        }
        else
        {

        }
    }
    
    public bool GestureCancelled(uint userId, int userIndex, KinectGestures.Gestures gesture,
                                  KinectWrapper.NuiSkeletonPositionIndex joint)
    {
        // don't do anything here, just reset the gesture state
        return true;
    }


    public void ActualizarContador()
    {

        if (MovActual == 1)
        {
            if (contador1 == 0)
            {
                cont0.enabled = true;
                cont1.enabled = false;
                cont2.enabled = false;
                cont3.enabled = false;
            }
            else if (contador1 == 1)
            {
                cont0.enabled = false;
                cont1.enabled = true;
                cont2.enabled = false;
                cont3.enabled = false;
            }
            else if (contador1 == 2)
            {
                cont0.enabled = false;
                cont1.enabled = false;
                cont2.enabled = true;
                cont3.enabled = false;
            }
            else if (contador1 == 3)
            {
                cont0.enabled = false;
                cont1.enabled = false;
                cont2.enabled = false;
                cont3.enabled = true;
            }
        }
        if (MovActual == 2)
        {
            if (contador2 == 0)
            {
                cont0.enabled = true;
                cont1.enabled = false;
                cont2.enabled = false;
                cont3.enabled = false;
            }
            else if (contador2 == 1)
            {
                cont0.enabled = false;
                cont1.enabled = true;
                cont2.enabled = false;
                cont3.enabled = false;
            }
            else if (contador2 == 2)
            {
                cont0.enabled = false;
                cont1.enabled = false;
                cont2.enabled = true;
                cont3.enabled = false;
            }
            else if (contador2 == 3)
            {
                cont0.enabled = false;
                cont1.enabled = false;
                cont2.enabled = false;
                cont3.enabled = true;
            }
        }
        if (MovActual == 3)
        {
            if (contador3 == 0)
            {
                cont0.enabled = true;
                cont1.enabled = false;
                cont2.enabled = false;
                cont3.enabled = false;
            }
            else if (contador3 == 1)
            {
                cont0.enabled = false;
                cont1.enabled = true;
                cont2.enabled = false;
                cont3.enabled = false;
            }
            else if (contador3 == 2)
            {
                cont0.enabled = false;
                cont1.enabled = false;
                cont2.enabled = true;
                cont3.enabled = false;
            }
            else if (contador3 == 3)
            {
                cont0.enabled = false;
                cont1.enabled = false;
                cont2.enabled = false;
                cont3.enabled = true;
            }
        }
        if (MovActual == 4)
        {
            if (contador4 == 0)
            {
                cont0.enabled = true;
                cont1.enabled = false;
                cont2.enabled = false;
                cont3.enabled = false;
            }
            else if (contador4 == 1)
            {
                cont0.enabled = false;
                cont1.enabled = true;
                cont2.enabled = false;
                cont3.enabled = false;
            }
            else if (contador4 == 2)
            {
                cont0.enabled = false;
                cont1.enabled = false;
                cont2.enabled = true;
                cont3.enabled = false;
            }
            else if (contador4 == 3)
            {
                cont0.enabled = false;
                cont1.enabled = false;
                cont2.enabled = false;
                cont3.enabled = true;
            }
        }
        if (MovActual == 5)
        {
            if (contador5 == 0)
            {
                cont0.enabled = true;
                cont1.enabled = false;
                cont2.enabled = false;
                cont3.enabled = false;
            }
            else if (contador5 == 1)
            {
                cont0.enabled = false;
                cont1.enabled = true;
                cont2.enabled = false;
                cont3.enabled = false;
            }
            else if (contador5 == 2)
            {
                cont0.enabled = false;
                cont1.enabled = false;
                cont2.enabled = true;
                cont3.enabled = false;
            }
            else if (contador5 == 3)
            {
                cont0.enabled = false;
                cont1.enabled = false;
                cont2.enabled = false;
                cont3.enabled = true;
            }
        }
        if (MovActual == 6)
        {
            if (contador6 == 0)
            {
                cont0.enabled = true;
                cont1.enabled = false;
                cont2.enabled = false;
                cont3.enabled = false;
            }
            else if (contador6 == 1)
            {
                cont0.enabled = false;
                cont1.enabled = true;
                cont2.enabled = false;
                cont3.enabled = false;
            }
            else if (contador6 == 2)
            {
                cont0.enabled = false;
                cont1.enabled = false;
                cont2.enabled = true;
                cont3.enabled = false;
            }
            else if (contador6 == 3)
            {
                cont0.enabled = false;
                cont1.enabled = false;
                cont2.enabled = false;
                cont3.enabled = true;
            }
        }
        if (MovActual == 7)
        {
            if (contador7 == 0)
            {
                cont0.enabled = true;
                cont1.enabled = false;
                cont2.enabled = false;
                cont3.enabled = false;
            }
            else if (contador7 == 1)
            {
                cont0.enabled = false;
                cont1.enabled = true;
                cont2.enabled = false;
                cont3.enabled = false;
            }
            else if (contador7 == 2)
            {
                cont0.enabled = false;
                cont1.enabled = false;
                cont2.enabled = true;
                cont3.enabled = false;
            }
            else if (contador7 == 3)
            {
                cont0.enabled = false;
                cont1.enabled = false;
                cont2.enabled = false;
                cont3.enabled = true;
            }
        }
        if (MovActual == 8)
        {
            if (contador8 == 0)
            {
                cont0.enabled = true;
                cont1.enabled = false;
                cont2.enabled = false;
                cont3.enabled = false;
            }
            else if (contador8 == 1)
            {
                cont0.enabled = false;
                cont1.enabled = true;
                cont2.enabled = false;
                cont3.enabled = false;
            }
            else if (contador8 == 2)
            {
                cont0.enabled = false;
                cont1.enabled = false;
                cont2.enabled = true;
                cont3.enabled = false;
            }
            else if (contador8 == 3)
            {
                cont0.enabled = false;
                cont1.enabled = false;
                cont2.enabled = false;
                cont3.enabled = true;
            }
        }
    }




    public void Update()
    {
        SeleccionMovimiento();
        if (MovActual == 1)
        {
            Enable1();
            Disable2();
            Disable3();
            Disable4();
            Disable5();
            Disable6();
            Disable7();
            Disable8();
        }
        else if (MovActual == 2)
        {
            Enable2();
            Disable1();
            Disable3();
            Disable4();
            Disable5();
            Disable6();
            Disable7();
            Disable8();
        }
        else if (MovActual == 3)
        {
            Enable3();
            Disable1();
            Disable2();
            Disable4();
            Disable5();
            Disable6();
            Disable7();
            Disable8();
        }
        else if (MovActual == 4)
        {
            Enable4();
            Disable1();
            Disable2();
            Disable3();
            Disable5();
            Disable6();
            Disable7();
            Disable8();
        }
        else if (MovActual == 5)
        {
            Enable5();
            Disable1();
            Disable2();
            Disable3();
            Disable4();
            Disable6();
            Disable7();
            Disable8();
        }
        else if (MovActual == 6)
        {
            Enable6();
            Disable1();
            Disable2();
            Disable3();
            Disable4();
            Disable5();
            Disable7();
            Disable8();
        }
        else if (MovActual == 7)
        {
            Enable7();
            Disable1();
            Disable2();
            Disable3();
            Disable4();
            Disable5();
            Disable6();
            Disable8();
        }
        else if (MovActual == 8)
        {
            Enable8();
            Disable1();
            Disable2();
            Disable3();
            Disable4();
            Disable5();
            Disable6();
            Disable7();
        }

        if (MovActual == 1)
        {
            //soundTutor1.Play();
            soundTutor2.Stop();
            soundTutor3.Stop();
            soundTutor4.Stop();
            soundTutor5.Stop();
            soundTutor6.Stop();
            soundTutor7.Stop();
            soundTutor8.Stop();
        }
        else if (MovActual == 2)
        {
            //soundTutor2.Play();
            soundTutor1.Stop();
            soundTutor3.Stop();
            soundTutor4.Stop();
            soundTutor5.Stop();
            soundTutor6.Stop();
            soundTutor7.Stop();
            soundTutor8.Stop();
        }
        else if (MovActual == 3)
        {
            //soundTutor3.Play();
            soundTutor1.Stop();
            soundTutor2.Stop();
            soundTutor4.Stop();
            soundTutor5.Stop();
            soundTutor6.Stop();
            soundTutor7.Stop();
            soundTutor8.Stop();
        }
        else if (MovActual == 4)
        {
           // soundTutor4.Play();
            soundTutor1.Stop();
            soundTutor3.Stop();
            soundTutor2.Stop();
            soundTutor5.Stop();
            soundTutor6.Stop();
            soundTutor7.Stop();
            soundTutor8.Stop();
        }
        else if (MovActual == 5)
        {
         //   soundTutor5.Play();
            soundTutor1.Stop();
            soundTutor3.Stop();
            soundTutor4.Stop();
            soundTutor2.Stop();
            soundTutor6.Stop();
            soundTutor7.Stop();
            soundTutor8.Stop();
        }
        else if (MovActual == 6)
        {
       //     soundTutor6.Play();
            soundTutor1.Stop();
            soundTutor3.Stop();
            soundTutor4.Stop();
            soundTutor5.Stop();
            soundTutor2.Stop();
            soundTutor7.Stop();
            soundTutor8.Stop();
        }
        else if (MovActual == 7)
        {
           // soundTutor7.Play();
            soundTutor1.Stop();
            soundTutor3.Stop();
            soundTutor4.Stop();
            soundTutor5.Stop();
            soundTutor6.Stop();
            soundTutor2.Stop();
            soundTutor8.Stop();
        }
        else if (MovActual == 8)
        {
         //   soundTutor8.Play();
            soundTutor1.Stop();
            soundTutor3.Stop();
            soundTutor4.Stop();
            soundTutor5.Stop();
            soundTutor6.Stop();
            soundTutor7.Stop();
            soundTutor2.Stop();
        }
        else
        {
            soundTutor1.Stop();
            soundTutor2.Stop();
            soundTutor3.Stop();
            soundTutor4.Stop();
            soundTutor5.Stop();
            soundTutor6.Stop();
            soundTutor7.Stop();
            soundTutor8.Stop();
        }
    }



    public void Enable1()
    {
        move1.SetActive(true);
    }

    public void Enable2()
    {
        move2.SetActive(true);
    }

    public void Enable3()
    {
        move3.SetActive(true);
    }

    public void Enable4()
    {
        move4.SetActive(true);
    }

    public void Enable5()
    {
        move5.SetActive(true);
    }

    public void Enable6()
    {
        move6.SetActive(true);
    }

    public void Enable7()
    {
        move7.SetActive(true);
    }

    public void Enable8()
    {
        move8.SetActive(true);
    }

    public void Disable1()
    {
        move1.SetActive(false);
    }

    public void Disable2()
    {
        move2.SetActive(false);
    }

    public void Disable3()
    {
        move3.SetActive(false);
    }

    public void Disable4()
    {
        move4.SetActive(false);
    }

    public void Disable5()
    {
        move5.SetActive(false);
    }

    public void Disable6()
    {
        move6.SetActive(false);
    }

    public void Disable7()
    {
        move7.SetActive(false);
    }

    public void Disable8()
    {
        move8.SetActive(false);
    }

}
