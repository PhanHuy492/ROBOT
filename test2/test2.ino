#define led 11
#define in_1 4//định nghĩa chân IN_1 của động cơ A
#define in_2 5//định nghĩa chân IN_2 của động cơ A
#define in_3 6//định nghĩa chân IN_3 của động cơ B
#define in_4 7//định nghĩa chân IN_4 của động cơ B

byte bluetoothByte =0;   // for incoming serial data
byte inR1;
byte inR2;
byte inL1;
byte inL2;
byte action;
int status=0;


void setup() {
  pinMode(led, OUTPUT);
  pinMode(in_1, OUTPUT);
  pinMode(in_2, OUTPUT);
  pinMode(in_3, OUTPUT);
  pinMode(in_4, OUTPUT);//set chân in3 của dc B là output
  Serial.begin(9600);   //open serial port, set data rate to 9600 dps
}

void loop() {
  //digitalWrite(led, HIGH);   // turn the LED on (HIGH is the voltage level)
  //delay(1000);                       // wait for a second
  //digitalWrite(led, LOW);    // turn the LED off by making the voltage LOW
  //delay(1000);  
  // put your main code here, to run repeatedly:&&status==
  //BluetoothByte = Serial.read();
  // send data only when you receive data:
        if (Serial.available() > 0) {
                // read the bluetooth byte:
                //bluetoothByte = Serial.read();
                
                robotMover(in_1, in_2, in_3, in_4,Serial.read());
            
        }
    
}



void robotMover (byte inR1, byte inR2, byte inL1, byte inL2, byte action)
{
  /*  
  inR1 inR2 là 2 chân tín hiệu động cơ bên PHẢI (dc B)
  inL1 inL2 là 2 chân tín hiệu động cơ bên TRÁI (dc A)
  action= 0 đứng yên
  action =1 đi thẳng
  action =2 lùi lại
  action =3 quay trái
  action =4 quay phải
  */
  switch (action)
  {
    case '0':// không di chuyển
      motorControlNoSpeed(inR1, inR2, 0);//động cơ PHẢI dừng
      motorControlNoSpeed(inL1, inL2, 0);//động cơ TRÁI dừng
      break;
    case '1'://đi thẳng
      motorControlNoSpeed(inR1, inR2, 1);//động cơ PHẢI tiến
      motorControlNoSpeed(inL1, inL2, 1);//động cơ TRÁI tiến
      break;
      
    case '2':// lùi lại
      motorControlNoSpeed(inR1, inR2, 2);//động cơ PHẢI lùi
      motorControlNoSpeed(inL1, inL2, 2);//động cơ TRÁI lùi
      break;
      
    case '3':// quay trái
      motorControlNoSpeed(inR1, inR2, 2);//động cơ PHẢI tiến
      motorControlNoSpeed(inL1, inL2, 1);//động cơ TRÁI lùi
      break;
    case '4':// quay phải
      motorControlNoSpeed(inR1, inR2, 1);//động cơ PHẢI lùi
      motorControlNoSpeed(inL1, inL2, 2);//động cơ TRÁI tiến
      break;
      
    case '5':// bật đèn
      digitalWrite(led,HIGH);
      break;
    case '6':// tắt đèn
      digitalWrite(led,LOW);  
      break;
      
  }
}


void motorControlNoSpeed (byte in1,byte in2, byte direct)
{
// hướng xoay của động cơ:
//    0:dừng
//    1:tiến
//    2:lùi
switch (direct) 
  {
    case 0:// Dừng không quay
      digitalWrite(in1,LOW);
      digitalWrite(in2,LOW);
      break;
    case 1:// Quay chiều thứ 1
      digitalWrite(in1,HIGH);
      digitalWrite(in2,LOW);
      break;    
    case 2:// Quay chiều thứ 2
      digitalWrite(in1,LOW);
      digitalWrite(in2,HIGH);
      break;
    //default: 
  }
} 
