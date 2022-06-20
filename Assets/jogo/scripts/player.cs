using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public bool sentado;
    public Animator anim;
    public bool sentar;
    public float speed;
    public Rigidbody rig;
    public float rot;
    private float rotSpeed;
    private Vector3 moveDirection;
    public bool dados;

    public Vector3 pos;

    public dice codigododice;
    public cancela codigodacancela;
   
    public int numerocadeira;

    public bool isGrounded;
    public bool cancela;

    public int tele;

    // cena do espaço
    public bool astro;
    public GameObject astronauta;
    public GameObject ape;

 
    //cena do carro
    public bool carro;
    public bool nocarro;
    public GameObject carroobj;
    public Vector3 posnocarro;
    public carmove scriptdocarro;
    public GameObject cameradocarro;
    public GameObject cameradopersonagem;
    public CapsuleCollider colliderdopersonagem;
    

    //cena casino
    public float ajusterot;
    public Transform posbunda;
    public Vector3 valorposbunda;
    public bool olevantar;
    public GameObject cam;

    



    //animação do peso
    public GameObject pesos;
    public GameObject pesosreal;
    public GameObject mao;
    public CapsuleCollider pesocolider;
    public bool pegarpeso;
    public bool zonadopeso;

    

    public bool animexterna;

    public int direcao;
    public bool pausa;

    public GameObject canvas;
    public GameObject canvasmenu;


    public AudioSource pasos;
    void Start()
    {
        rotSpeed = 100;
        if(!animexterna){anim = GetComponent<Animator>();}
        pasos = GetComponent<AudioSource>();
        rig = GetComponent<Rigidbody>();
         anim.Play("parado");
    }

    // Update is called once per frame
    void Update()

    {
       if(pausa){
        canvas.SetActive(false);
        canvasmenu.SetActive(true);
        Time.timeScale =0;
       }
       else{
        canvas.SetActive(true);
        canvasmenu.SetActive(false);
        Time.timeScale =1;
       }
        if(zonadopeso){
            if(Input.GetKeyDown(KeyCode.Return))
            {
                botaoy();
            }
        }
        if(pegarpeso)
        {
            
            pesos.transform.position = mao.transform.position;
            zonadopeso=false;
            pesos.SetActive(true);
            pesosreal.SetActive(false);
            if(Input.GetKeyDown(KeyCode.Return))
            {
                botaoy();
               
            }
        }
       
        if(Input.GetKeyDown(KeyCode.Return))
        {
            botaoy();
        }
        if(nocarro)
        {
            pasos.Stop();
            anim.Play("sentar");
            scriptdocarro.enabled = true;
            cameradocarro.SetActive(true);
            cameradopersonagem.SetActive(false);
            colliderdopersonagem.enabled = false;
            transform.localPosition = new Vector3(0.40f,1.90f,0.22f);
            transform.localRotation =  Quaternion.Euler(0, 88, 0);

            if(Input.GetKeyDown(KeyCode.Space))
            {
                botaob();
            }

          
        }
        if(carro && !nocarro)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                botaob();
                
               
            }
        }
        if(cancela)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            { botaob(); }
        }
         if(dados)
         {
            if(Input.GetKeyDown(KeyCode.Space))
            { 
                
                botaob();
            }

            if(Input.GetKeyDown(KeyCode.Y))
            { 
                botaoy();
            }
         }    


       // 
        if(sentado)
        {
            pasos.Stop();
            rig.velocity = new Vector3(0, 0, 0);
             if(pegarpeso)
            {
                if(Input.GetKeyDown(KeyCode.Y))
                {
                    botaoy();
                    
                }
                
            }

            if(Input.GetKeyDown(KeyCode.Space))
            {
               botaob();
                   
            }
        }
        if(sentar){
             if(Input.GetKey(KeyCode.Space))
            {
                  botaob();
            }    
        }
        
       
       
       
    }
    
    private void FixedUpdate() {
          Move();
          Poscadeira();
        if(Input.GetKeyDown(KeyCode.P))
        {
            botaoa();
        }
       
    }
    void Poscadeira()
    {
        if(sentado)
        {
            valorposbunda= new Vector3(
                    transform.position.x-posbunda.position.x,
                    transform.position.y-posbunda.position.y,
                    transform.position.z-posbunda.position.z
                    );
            
            if(numerocadeira==0){
                transform.position = new Vector3(pos.x+valorposbunda.x,pos.y+valorposbunda.y,pos.z+valorposbunda.z);
                transform.eulerAngles = new Vector3(0, -87.66f, 0);
            }
            if(numerocadeira==1){
                transform.position = new Vector3(pos.x+valorposbunda.x,pos.y+valorposbunda.y,pos.z+valorposbunda.z);
                transform.eulerAngles = new Vector3(0, 3.75f, 0);
                
            }
             if(numerocadeira==2){
                transform.position = new Vector3(pos.x+valorposbunda.x,pos.y+valorposbunda.y,pos.z+valorposbunda.z);
                transform.eulerAngles = new Vector3(0, -175.36f, 0);
            }
             if(numerocadeira==3){
                transform.position = new Vector3(pos.x+valorposbunda.x,pos.y+valorposbunda.y,pos.z+valorposbunda.z);
                transform.eulerAngles = new Vector3(0, 99.72f, 0);
               
            }
             if(numerocadeira==4){
                transform.position = new Vector3(pos.x+valorposbunda.x,pos.y+valorposbunda.y,pos.z+valorposbunda.z);
                transform.eulerAngles = new Vector3(0, -175.36f, 0);
            }
             if(numerocadeira==5){
                transform.position = new Vector3(pos.x+valorposbunda.x,pos.y+valorposbunda.y,pos.z+valorposbunda.z);
                transform.eulerAngles = new Vector3(0, 99.72f, 0);
            }
            //cadeiras da academia
            if(numerocadeira==6){
                transform.position = new Vector3(pos.x+1.3f,pos.y+1.95f,pos.z+1.3f);
               transform.eulerAngles = new Vector3(0, 103.1f, 0);
            }
            if(numerocadeira==7){
                transform.position = new Vector3(pos.x+1.0f,pos.y+1.95f,pos.z-1.3f);
                transform.eulerAngles = new Vector3(0, 195.28f, 0);
            }
            if(numerocadeira==8){
                transform.position = new Vector3(pos.x+1.1f,pos.y+1.95f,pos.z-1.3f);
                transform.eulerAngles = new Vector3(0, 200f, 0);
            }
             if(numerocadeira==9){
                transform.position = new Vector3(pos.x-1.1f,pos.y+1.95f,pos.z+1.3f);
                transform.eulerAngles = new Vector3(0, 17.34f, 0);
            }
            if(numerocadeira==10){
                transform.position = new Vector3(pos.x-1.1f,pos.y+1.95f,pos.z+1.1f);
                transform.eulerAngles = new Vector3(0, 9f, 0);
            }
            if(numerocadeira==11){
                transform.position = new Vector3(pos.x-1.6f,pos.y+1.95f,pos.z-0.8f);
                transform.eulerAngles = new Vector3(0, 294.43f, 0);
            }
            if(numerocadeira==12){
                transform.position = new Vector3(pos.x+0f,pos.y+1.95f,pos.z-1.7f);
                transform.eulerAngles = new Vector3(0, 230.90f, 0);
            }
             if(numerocadeira==13){
                transform.position = new Vector3(pos.x-0.6f,pos.y+2.3f,pos.z+0.7f);
                transform.eulerAngles = new Vector3(0, -3.22f, 0);
            }
            if(numerocadeira==14){
                transform.position = new Vector3(pos.x+0.6f,pos.y+2.3f,pos.z-0.7f);
                transform.eulerAngles = new Vector3(0, 173.63f, 0);
            }
            
        }

    }
    void Move()
    {
        if(direcao==0){}
        if(direcao==1){transform.Translate(-speed,0,0);}
        if(direcao==2){rot +=1 * rotSpeed * Time.deltaTime;transform.eulerAngles=  new Vector3(0,rot,0);}
        if(direcao==3){rot +=-1 * rotSpeed * Time.deltaTime;transform.eulerAngles=  new Vector3(0,rot,0);}
        if(Input.GetKey(KeyCode.UpArrow))
        {
            andarprafrente();       
        }

        if(Input.GetKeyUp(KeyCode.UpArrow)&&!sentado&& !nocarro)
        {
            Fparar();
        }
        
        if(!sentado&&!nocarro)
        {
             if(Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.LeftArrow))
            {
                virar(Input.GetAxis("Horizontal"));
            }

             if(Input.GetKeyUp(KeyCode.RightArrow)||Input.GetKeyUp(KeyCode.LeftArrow))
            {
                Fparar();
            }
            
        }
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="dice"){
            dados=true;
            codigododice =  other.gameObject.GetComponent<dice>();
        }
         if(other.gameObject.tag=="cancela"){
            cancela = true;
            
        }
        if(other.gameObject.tag=="cadeira"){
            sentar = true;
            if(!sentado)
            {
                pos= new Vector3
                (other.gameObject.transform.position.x,
                other.gameObject.transform.position.y,
                other.gameObject.transform.position.z);

               numerocadeira = other.gameObject.GetComponent<posicaodesentar>().numero;
            }
        }
        if(other.gameObject.tag=="tele1"){
            tele = 1;
        }
        if(other.gameObject.tag=="tele2"){
            tele = 2;
        }
        if(other.gameObject.tag=="tele3"){
            tele = 3;
        }
        if(other.gameObject.tag=="tele4"){
            tele = 4;
        }
        if(other.gameObject.tag=="tele5"){
            tele = 5;
        }
        if(other.gameObject.tag=="tele6"){
            tele = 6;
        }
         if(other.gameObject.tag=="tele7"){
            tele = 7;
        }
         if(other.gameObject.tag=="tele8"){
            tele = 8;
        }


        if(other.gameObject.tag=="astro"){
            astro = true;
        }

        if(other.gameObject.tag=="carro"){
            carro = true;
        }
        if(other.gameObject.tag=="peso"){
            zonadopeso = true;
        }


       
       
        
    }
  
    private void OnTriggerStay(Collider other) {
       
        if(other.gameObject.tag=="cadeira"){
            sentar = true;
            
        }
        if(other.gameObject.tag=="cancela"){
            cancela = true;
            codigodacancela =  other.gameObject.GetComponent<cancela>();
            
        }
               if(other.gameObject.tag=="dice"){
            dados=true;
             codigododice =  other.gameObject.GetComponent<dice>();
        }

        if(other.gameObject.tag=="tele1"){
            tele = 1;
        }
        if(other.gameObject.tag=="tele2"){
            tele = 2;
        }
        if(other.gameObject.tag=="tele3"){
            tele = 3;
        }
        if(other.gameObject.tag=="tele4"){
            tele = 4;
        }
        if(other.gameObject.tag=="tele5"){
            tele = 5;
        }
        if(other.gameObject.tag=="tele6"){
            tele = 6;
        }
         if(other.gameObject.tag=="tele7"){
            tele = 7;
        }
        if(other.gameObject.tag=="tele8"){
            tele = 8;
        }

        if(other.gameObject.tag=="astro"){
            astro = true;
        }
         if(other.gameObject.tag=="carro"){
            carro = true;
        }
        if(other.gameObject.tag=="peso"){
            zonadopeso = true;
        }
        
    }
     private void OnTriggerExit(Collider other) {
       
        if(other.gameObject.tag=="cadeira"){
            sentar = false;
            
        }
        if(other.gameObject.tag=="cancela"){
            cancela = false;
            
        }
        if(other.gameObject.tag=="dice"){
            dados=false;
        }
         if(other.gameObject.tag=="tele1"){
            tele = 0;
        }
        if(other.gameObject.tag=="tele2"){
            tele = 0;
        }
        if(other.gameObject.tag=="tele3"){
            tele = 0;
        }
        if(other.gameObject.tag=="tele4"){
            tele = 0;
        }
        if(other.gameObject.tag=="tele5"){
            tele = 0;
        }
        if(other.gameObject.tag=="tele6"){
            tele = 0;
        }
         if(other.gameObject.tag=="tele7"){
            tele = 0;
        }
        if(other.gameObject.tag=="tele8"){
            tele = 0;
        }
        

        if(other.gameObject.tag=="astro"){
            astro = false;
        }
         if(other.gameObject.tag=="carro"){
            carro = false;
        }
         if(other.gameObject.tag=="peso"){
            zonadopeso = false;
        }
        
    }
     private void OnCollisionEnter(Collision other) {
       rig.velocity = new Vector3(0, 0, 0);
        if(other.gameObject.tag=="cadeira"){
            rig.velocity = new Vector3(0, 0, 0);
        }
        if(other.gameObject.tag=="dice"){
             rig.velocity = new Vector3(0, 0, 0);
        }
       
        
    }



     private void OnCollisionExit(Collision other) {
       rig.velocity = new Vector3(0, 0, 0);
        if(other.gameObject.tag=="cadeira"){
            rig.velocity = new Vector3(0, 0, 0);
        }
        if(other.gameObject.tag=="dice"){
             rig.velocity = new Vector3(0, 0, 0);
            
        }
       
        
    }
    public void pausar(){
        pausa=!pausa;
    }
    public void menu(){
        SceneManager.LoadScene("casino");
    }
    //Funções de movimentação
    public void andarprafrente()
    {
        if(!sentado&& !nocarro&&isGrounded){
            if(!pegarpeso){anim.Play("andar");}
            else{anim.Play("andarsegurando");}
            if(!pasos.isPlaying){pasos.Play();}
            direcao=1;
            //transform.Translate(-speed,0,0);
        }
    }
    public void Fparar()
    {
        anim.Play("parado");
        pasos.Stop();
        direcao=0;
      //  rig.velocity = new Vector3(0, 0, 0);

    }
    public void virar(float a)
    {
        
        if(a>0){direcao=2;}
        if(a<0){direcao=3;}
        if(!pegarpeso){anim.Play("andar");}
        else{anim.Play("andarsegurando");}
        if(!pasos.isPlaying){pasos.Play();}     
    }


    // botões de input

    //A
    public void botaoa(){
         if(isGrounded)
        {
            isGrounded=false; 
            rig.AddForce(0,4000,0);
            StartCoroutine(pular());
        }
    }
    //B
    public void botaob(){
        if(sentado)
        {
            StartCoroutine(levantar());
            olevantar=true;
        }
        if(sentar)
        {
            if(!olevantar){StartCoroutine(ativadordesentado());}
        }
        if(dados)
        {
            if(codigododice.aberto){codigododice.fechar();}
            else{codigododice.abrir();}
        }
        if(cancela)
        {
            codigodacancela.aberto=!codigodacancela.aberto;
            codigodacancela.som.Play();
        }
        if(nocarro)
        {
            StartCoroutine(levantardocarro());
        }
        if(carro && !nocarro)
        {
            nocarro = true;
        }
        



    }
    //Y
     public void botaoy(){
         if(pegarpeso){
            anim.Play("exercicio");
            pesos.transform.localRotation = Quaternion.Euler(90, 0, 189);
         }
         if(dados)
         {
            codigododice.sortearnumero();
         }
        if(tele == 1){SceneManager.LoadScene("casino");}
        if(tele == 2){SceneManager.LoadScene("car chase");}
        if(tele == 3){SceneManager.LoadScene("space");}
        if(tele == 4){SceneManager.LoadScene("academia");}
        if(tele == 5){SceneManager.LoadScene("snupdog");}
        if(tele == 6){SceneManager.LoadScene("video1");}
        if(tele == 7){SceneManager.LoadScene("danca");}
        if(tele == 8){SceneManager.LoadScene("car");}
        if(astro){ape.SetActive(false);astronauta.SetActive(true);}
        
        if(zonadopeso){           
            pegarpeso=true;
            StartCoroutine(pegopeso());
        }
     }
     public void setabaixo(){
        if(pegarpeso)
        {
                pegarpeso=false;
                pesos.SetActive(false);
                pesosreal.SetActive(true);
        }
     }








    // IEnumerators
    IEnumerator pegopeso() 
     { 
        yield return new WaitForSeconds(0.2f);
        pegarpeso=true;
        pesos.transform.localRotation = Quaternion.Euler(90, 0, 90);
        
         
     }
     IEnumerator pular() 
     { 
         yield return new WaitForSeconds(1.0f);
         isGrounded=true;
         
     }
     IEnumerator levantardocarro() 
     {
            yield return new WaitForSeconds(0.01f);
            nocarro = false;
            transform.localPosition = new Vector3(0.26f,2.14f,-3.89f);
            anim.Play("parado");
            scriptdocarro.rig.velocity = new Vector3(0, 0, 0);
            scriptdocarro.enabled = false;
            cameradocarro.SetActive(false);
            cameradopersonagem.SetActive(true);
            colliderdopersonagem.enabled = true;
             carro = false;
     }
    IEnumerator ativadordesentado() {
    
    
              

                yield return new WaitForSeconds(0.2f);
                sentado=true;
                anim.Play("sentar");
    }

    IEnumerator levantar() {
      
               
               
    yield return new WaitForSeconds(0.1f);
                //posição ao levantar
                if(numerocadeira==0){
                     transform.position = new Vector3(pos.x-1.38f,pos.y+4.53f,pos.z+4.2f);
                }
                if(numerocadeira==1){
                     transform.position = new Vector3(pos.x+2.3f,pos.y+4.53f,pos.z+1.43f);
                }
                 if(numerocadeira==2){
                      transform.position = new Vector3(pos.x-2.3f,pos.y+4.53f,pos.z-1.43f);
                }
                 if(numerocadeira==3){
                     transform.position = new Vector3(pos.x+1.38f,pos.y+4.53f,pos.z-1.43f);
                }
                anim.Play("parado");
                sentar = false;
                sentado=false;
                olevantar=false;
  
    }



}
