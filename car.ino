#include <SoftwareSerial.h>
SoftwareSerial frankenstein(0,1);

#define rbr 4 //sağ arka geri
#define rbd 5 //sağ arka ileri
#define lbr 6 //sol arka geri
#define lbd 7 // sol arka ileri

#define rfr 8 //sağ ön geri
#define rfd 9 //sağ ön ileri
#define lfr 10 //sol ön geri
#define lfd 11 //sol ön ileri
 
#define echoPin 2
#define trigPin 3

long duration, distance;

int maximumRange = 40;
int minimumRange = 0;
int randomNumber = 0;

void setup() 
{
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);  

  Serial.begin(9600);
  frankenstein.begin(9600);
  
  pinMode(rbr, OUTPUT);  //Tüm pinlerden güç çıkışı olacağı için OUTPUT olarak ayarladık.
  pinMode(rbd, OUTPUT);  
  pinMode(lbr, OUTPUT);
  pinMode(lbd, OUTPUT);
  pinMode(rfr, OUTPUT);  
  pinMode(rfd, OUTPUT);  
  pinMode(lfr, OUTPUT);
  pinMode(lfd, OUTPUT);

}

void loop() 
{
  digitalWrite(trigPin,LOW);
  delayMicroseconds(2);
  digitalWrite(trigPin,HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin,LOW);
  duration = pulseIn(echoPin, HIGH);
  distance = duration / 58.2;

  Serial.println(distance);
  
  if (distance <= 30 and distance>0)
  {
    geri();
    delay(350);
    randomNumber = random(3);
    if (randomNumber == 1)
    {
      sag();
      delay(350);
      dur();
    }
    else if (randomNumber == 2)
    {
      ters();
    }
    else
    {
      sol();
      delay(350);
      dur();
    }
    dur();
  }
  else
  {
    if (frankenstein.available())
    {
        char data = frankenstein.read();
        if(data=='1')
        {
          ileri(); 
          delay(500);
          dur();
          kontrol();
        }
        else if (data=='2')
        {
          geri();
          delay(500);
          dur();
        }
        else if (data=='3')
        {
          sol();
          delay(350);
          dur();
          kontrol();
        }
        else if (data=='4')
        {
          sag();
          delay(350);
          dur();
          kontrol();
        }
        else if (data=='5')
        {
          dur();
        }
        else if (data=='6')
        {
          ters();
        }
        else
        {
          dur();
        }
    }
  }
}


void kontrol()
{
  
  digitalWrite(trigPin,LOW);
  delayMicroseconds(2);
  digitalWrite(trigPin,HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin,LOW);
  duration = pulseIn(echoPin, HIGH);
  distance = duration / 58.2;
  
  Serial.println(distance);


  if (distance <= 30 and distance>0)
  {
    geri();
    delay(350);
    randomNumber = random(3);
    if (randomNumber == 1)
    {
      sag();
      delay(350);
      dur();
    }
    else if (randomNumber == 2)
    {
      ters();
    }
    else
    {
      sol();
      delay(350);
      dur();
    }
    dur();
  }
}


void ileri()
{
  // motor 1 arka sağ motor
  digitalWrite(rbr, LOW);
  digitalWrite(rbd,  HIGH);  
  // motor 2 arka sol motor
  digitalWrite(lbr, LOW);
  digitalWrite(lbd,  HIGH);
  // motor 3 ön sağ motor
  digitalWrite(rfr, LOW);
  digitalWrite(rfd,  HIGH);  
  // motor 4 ön sol motor
  digitalWrite(lfr, LOW);
  digitalWrite(lfd,  HIGH);  
}

void geri()
{
  // motor 1 arka sağ motor
  digitalWrite(rbr, HIGH);
  digitalWrite(rbd,  LOW);  
  // motor 2 arka sol motor
  digitalWrite(lbr, HIGH);
  digitalWrite(lbd,  LOW);
  // motor 3 ön sağ motor
  digitalWrite(rfr, HIGH);
  digitalWrite(rfd,  LOW);  
  // motor 4 ön sol motor
  digitalWrite(lfr, HIGH);
  digitalWrite(lfd,  LOW);
}

void sag()
{
  // motor 1 arka sağ motor
  digitalWrite(rbr, HIGH);
  digitalWrite(rbd,  LOW);  
  // motor 2 arka sol motor
  digitalWrite(lbr, LOW);
  digitalWrite(lbd,  HIGH);
  // motor 3 ön sağ motor
  digitalWrite(rfr, LOW);
  digitalWrite(rfd,  HIGH);  
  // motor 4 ön sol motor
  digitalWrite(lfr, HIGH);
  digitalWrite(lfd,  LOW);
}

void sol()
{
  // motor 1 arka sağ motor
  digitalWrite(rbr, LOW);
  digitalWrite(rbd,  HIGH);  
  // motor 2 arka sol motor
  digitalWrite(lbr, HIGH);
  digitalWrite(lbd,  LOW);
  // motor 3 ön sağ motor
  digitalWrite(rfr, HIGH);
  digitalWrite(rfd,  LOW);  
  // motor 4 ön sol motor
  digitalWrite(lfr, LOW);
  digitalWrite(lfd,  HIGH);
}

void dur()
{
  // motor 1 arka sağ motor
  digitalWrite(rbr, LOW);
  digitalWrite(rbd,  LOW);  
  // motor 2 arka sol motor
  digitalWrite(lbr, LOW);
  digitalWrite(lbd,  LOW);
  // motor 3 ön sağ motor
  digitalWrite(rfr, LOW);
  digitalWrite(rfd,  LOW);  
  // motor 4 ön sol motor
  digitalWrite(lfr, LOW);
  digitalWrite(lfd,  LOW);
}

void ters()
{
  sol();
  delay(600);
  dur();
}
