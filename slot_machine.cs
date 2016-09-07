using UnityEngine;
using System.Collections;

public class slot_machine : MonoBehaviour {
    //public static Session_Monitor mon;
    
	public static int[] tbl;
	public int[] ptbl; // For the rates below!!!!!
	public bool isBusy		= false;
	public int Base_Payout		= 10; // Important in the math
	
	public int no_win_r 	= 25;		
	public int one_r 		= 25+5;
	public int two_r 		= 30+5;
	public int three_r 		= 35+5;
	public int four_r 		= 40+5;
	public int five_r 		= 45+5;
	// 50 total
	public int six_r 		= 50+5;
	public int seven_r 		= 55+5;
	public int eight_r 		= 60+5;
	public int nine_r 		= 65+5;
	public int ten_r 		= 70+5;
	public int elev_r 		= 75+5;
	
	int face1				= 0;
	int face2				= 0;
	int face3				= 0;
	
	public int inventory	= 500; //  coins
	
	void Start () {
	// Fill prob table
	ptbl[0] = no_win_r;
	ptbl[1] = one_r;
	ptbl[0] = two_r ;
	ptbl[0] = three_r ;
	ptbl[0] = four_r ;
	ptbl[0] = five_r ;
	ptbl[0] = six_r ;
	ptbl[7] = seven_r ;
	ptbl[8] = eight_r;
	ptbl[9] = nine_r;
	ptbl[10] = ten_r;
	ptbl[11] = elev_r;
	
	// Fill tbl
        if (tbl == null){
			int i = 0;
			tbl = new int[100];
			
			
			
			// Fill the table with results
			// 12 symbols, 8.3 each
			
			for (;i < 100; i++){
				int ans = -1;
				
				if (i <= no_win_r){ // 25
					ans = 0;
				}else if (i <= one_r){ // 12
					ans = 1;
				}else if (i <= two_r){//5
					ans = 2;
				}else if (i <= three_r){
					ans = 3;
				}else if (i <= four_r){
					ans = 4;
				}else if (i <= five_r){
					ans = 5;
				}else if (i <= six_r){
					ans = 6;
				}else if (i <= seven_r){
					ans = 7;
				}else if (i <= eight_r){
					ans = 8;
				}else if (i <= nine_r){
					ans = 9; button press
				}else if (i <= ten_r){
					ans = 10;
				}else if (i <= elev_r){
					ans = 11;
				}
				// Fill area
				tbl[i] = ans;
			}
        }
        
	}
	
	// Update is called once per frame
	void Update () {
	    
    
	}
	
	void OnMouseUp() {
        Debug.Log("Starting a spin");
        this.Use();
    }
	
	bool Use(){
		int x 		= (int)Random.value*100;
	    int y 		= (int)Random.value*100;
	    int z 		= (int)Random.value*100;
	    int amt 		= -1; // Set at -1 for debuging reasons
	    
	    face1 = tbl[x];
	    face2 = tbl[y];
	    face3 = tbl[z];
	    
	    amt = CheckForWin() // Face variables assumed to be set!!
	    
	    if ( amt > 0 ){
	    	// WINNER
	    	Debug.Log("Winner stub @@@WINNER");
	    }else{
	    	Debug.Log("Better luck next time!");
	    }
	    
	    Debug.Log("Spin Results: " + x + y + z + "   PAYOUT: $" + amt);
	}

	int CheckForWin(){
		bool ans = (face1 == face2 && face1==face3);
		
		if (ans){
			// Winner
			// (Rate Numerator) * (face number) * BasePay
			int val = this.GetRateChange(face1) * (face1) * this.Base_Payout;
			
			return val
		}else{
			// Not Winner
			return 0;
		}
	}

	int GetRateChange(int n){
		// Simple subtraction
		if ( n == 0 ){
			return 0;
		}
		
		if ( n == 1 ){
			// Just whatever number
			return ptbl[1];
		}
		return ptbl[n]-ptbl[n-1];
	}
	
    void OnTriggerEnter2D(Collider2D coll)
    {
        
    }

}
