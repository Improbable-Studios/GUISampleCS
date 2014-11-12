using UnityEngine;
using System.Collections;

public class TestController : MonoBehaviour {

	public Transform InputDialogPrefab;
	
    public Transform currentDialog;
	
	public DialogController currentController;

	// Use this for initialization
	void Start () {
		//currentDialog = Instantiate(InputDialogPrefab);
		currentDialog.gameObject.SetActive(true);
		
		currentDialog.localScale = new Vector3(0.5f, 0.5f, 1.0f);
		
		currentController = currentDialog.gameObject.GetComponent<DialogController>();  
		
		Transform rc = GameObject.Find("/ScreenCanvas").transform;
		
		Debug.Log("rc: " + rc.name );
		
		if (rc != null)
		{
			Debug.Log("Root canvas found!");
			//currentDialog.SetParent(rc);
		} else {
			Debug.Log("Root canvas not found!");    
		}	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ShowDialog() {
		Debug.Log("Dialog Show!");
		
		currentDialog.localScale = new Vector3(0.5f, 0.5f, 1.0f);
		
		currentController.setPosition(new Vector2(50,0));
		currentController.setDimension(new Vector2(550,400));
		
		currentController.show();  
	}
	
	void HideDialog() {
		Debug.Log("Dialog Hide!");  
		currentController.hide();
	}
	
	void setEnglish() {
		Debug.Log("Dialog English");
		
		//currentController.setPosition(Vector2(100,90));
		currentController.setDimension(new Vector2(550,400));
		
		currentController.setTitle("Input Answer");
		currentController.setText("This can be an instruction or a question.<color=#24C1E0>Emphasis</color> can also be applied. e.g. Input the name of the <color=#24C1E0>most handsome</color> DI in MET.");          
	}
	
	void setGerman() {
		Debug.Log("Dialog Deusch");
		
		//currentController.setPosition(Vector2(100,55));
		currentController.setDimension(new Vector2(550,500));
		
		currentController.setTitle("Antwort eingeben");
		currentController.setText("Dieser Text könnte Anweisung oder eine Frage sein. Es kann auch <color=#24C1E0>Texthervorhebung</color> verwendet werden z.B. Gib den Namen des <color=#24C1E0>bestaussehendsten</color> DI in MET");
		
	}
	
	void setRussian() {
		Debug.Log("Dialog русский");
		
		//currentController.setPosition(Vector2(100,90));
		currentController.setDimension(new Vector2(550,400));
		
		currentController.setTitle("Ввод ответа");
		currentController.setText("Это может быть инструкция или вопрос.\n<color=#24C1E0>Упор</color> может быть применен.\nнапример Введите имя <color=#24C1E0>самый красивый</color> DI в MET.");       
	}
	
	void setChinese() {
		Debug.Log("Dialog 中国");    
		
		//currentController.setPosition(Vector2(100,90));
		currentController.setDimension(new Vector2(550,400));
		
		currentController.setTitle("输入答案");
		currentController.setText("这可以是一个指令或问题。\n<color=#24C1E0>重点</color>也可以应用。\n例如输入遇到的<color=#24C1E0>最帅</color>的DI的名字。");       
	}
	
	void setKorean() {
		Debug.Log("Dialog 한국어");    
		
		//currentController.setPosition(Vector2(100,90));
		currentController.setDimension(new Vector2(550,400));
		
		currentController.setTitle("입력 응답");
		currentController.setText("이 지시하거나 질문 할 수 있습니다.\n<color=#24C1E0>강조</color>도 적용 할 수있다.\n예를 들어, 입력 MET<color=#24C1E0>에서 가장 잘 생긴</color> DI의 이름입니다.");       
	}
	
	void setGaelic() {
		Debug.Log("Dialog Gaeilge");    
		
		//currentController.setPosition(Vector2(100,90));
		currentController.setDimension(new Vector2(550,400));
		
		currentController.setTitle("Ionchur Freagra");
		currentController.setText("Is féidir a bheith ina threoir nó ceist.\nIs féidir <color=#24C1E0>béim</color> a chur i bhfeidhm freisin.\nm.sh. Ionchur an t-ainm ar an DI <color=#24C1E0>is dathúil</color> sa MET.");       
	}
	
	void setArabic() {
		Debug.Log("Dialog العربية");  
		
		//currentController.setPosition(Vector2(100,90));
		currentController.setDimension(new Vector2(550,400));
		
		currentController.setTitle("إدخال الإجابة");
		currentController.setText("هذا يمكن أن يكون التدريس أو سؤال.\n<color=#24C1E0>التركيز</color>يمكن أن تطبق أيضا");       
	}
	
	void setTurkish() {
		Debug.Log("Dialog türk");
		
		currentController.setDimension(new Vector2(550,400));
		
		currentController.setTitle("giriş cevap");
		currentController.setText("Bu bir talimat veya soru olabilir.\n<color=#24C1E0>Vurgu</color> de uygulanabilir.\nörneğin Giriş MET <color=#24C1E0>en yakışıklı</color> DI ismi.");                
	}
	
	//Input Answer
	//This can be an instruction or a question. 
	//Emphasis can also be applied. 
	//e.g. Input the name of the most handsome DI in MET.   
	
	//<color=#24C1E0>Emphasis</color> can also be applied. 
	//e.g. Input the name of the <b><color=#24C1E0>most handsome</color></b> DI in MET.");          

}
