#define PinA 2 //外部中断0
#define PinZ 3 //外部中断1
#define PinB 8 //编码器的OUT_B信号连接到数字端口8
#define T 50    //定义采集时间周期单位ms
unsigned long time1 = 0; // 时间标记
volatile long PulSum_CW = 0;   //定义长整型不可修改脉冲数
volatile long PulSum_CCW = 0;   


long PulSum_CW_t0 = 0;         //定义记录顺时针方向 t0 时刻脉冲数变量
long PulSum_CW_t0_T = 0;       //定义记录顺时针方向 t0+T 时刻脉冲数变量


float Rad_CW_Speed = 0.000;    //定义顺时针角速度
float Rad_CCW_Speed = 0.000;    //定义逆时针角速度


long PulSum_CCW_t0 = 0;        //定义记录逆时针方向 t0 时刻脉冲数变量
long PulSum_CCW_t0_T = 0;      //定义记录逆时针方向 t0+T 时刻脉冲数变量


int Array_CW[10];


void setup()


{
    pinMode(PinA, INPUT_PULLUP);//因为编码器信号为欧姆龙E6B2-CWZ6C，为开漏输出，因此需要上拉电阻，此处采用arduino的内部上拉输入模式，置高
    pinMode(PinB, INPUT_PULLUP);//同上
    attachInterrupt(0, Encode, FALLING);//脉冲中断函数：捕捉A相信号，并判断A、B相先后顺序
    Serial.begin (9600);
}


void loop()
{
  PulSum_CW_t0   = PulSum_CW;  PulSum_CCW_t0   = PulSum_CCW;    //采集t0时刻的脉冲数
  delay(T);                                                  //等待一个T时间
  PulSum_CW_t0_T = PulSum_CW;  PulSum_CCW_t0_T = PulSum_CCW;    //采集t0+T时刻的脉冲数
  delay(T);                                                  //等待一个T时间
  if (PulSum_CW_t0_T - PulSum_CW_t0 != 0){
    Serial.println(PulSum_CW_t0_T - PulSum_CW_t0);  //
    Rad_CW_Speed = (PulSum_CW_t0_T - PulSum_CW_t0);   //
    Serial.println(Rad_CW_Speed);               //打印出来速度
    }  
    
  if (PulSum_CCW_t0_T - PulSum_CCW_t0 != 0){
    Rad_CCW_Speed = (PulSum_CCW_t0 - PulSum_CCW_t0_T);
    Serial.println(Rad_CCW_Speed);
    }

  // 角度计算程序
  Rad = (PulSum_CW - PulSum_CCW)/6.944; 
  Serial.print("Rad---");
  Serial.println(Rad);
}
void Encode()
{//当编码器码盘的OUTA脉冲信号下跳沿每中断一次，
  //if ((millis() - time1) > 5)
  //{
    if ((digitalRead(PinA) == LOW) && (digitalRead(PinB) == HIGH))
    {PulSum_CW ++;}
    else
    {PulSum_CCW ++;}
  //}
    //time1 == millis();
}
