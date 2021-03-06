#include <stdio.h>
#include <stdlib.h>
#include <stddef.h>
#include <stdbool.h>
#include <string.h>
#include "adc.h"
#include "lcd.h"
#include "timer_1ms.h"
#include "rtcc.h"
#include "p33CK256MP508.h"
#define FCY 8000000UL
#include <xc.h>
#include <libpic30.h>
/**
  Section: Included Files
*/
#include "mcc_generated_files/system.h"
#include "mcc_generated_files/examples/uart_example.h"

/*
                         Main application
 */
// *****************************************************************************
// *****************************************************************************
// Section: File Scope Variables and Functions
// *****************************************************************************
// *****************************************************************************
extern void SYSTEM_Initialize( void ) ;
//static void ScreenUpdateEventHandler( void );

static RTCC_DATETIME time;
static RTCC_DATETIME lastTime = {0};
static volatile bool toggleBlinkAlive = false;
//static volatile bool allowScreenUpdate = true;

#define MEMCMP_VALUES_IDENTICAL 0

// *****************************************************************************
// *****************************************************************************
// Section: Main Entry Point
// *****************************************************************************
// *****************************************************************************

/* Configure the IO pins to be OUTPUT or INPUT*/
void IOPorts(){
    PORTE = 0x00;   //Clear Port E
    //TRISEbits.TRISE5 = 0; // Set RE5 pin as output, connected to RED multiplexer 
    //TRISEbits.TRISE6 = 0; // Set RE6 pin as output, connected to GREEN multiplexer
    //TRISEbits.TRISE7 = 0; // Set RE7 pin as output, connected to BLUE multiplexer
}

int main ( void )
{
    uint16_t RedADCResult, GreenADCResult, BlueADCResult;//,RedVolt;   //Variables for storing current ADC result
    uint16_t PrevRADCres, PrevGADCres, PrevBADCres;         //Variables for storing previous ADC result
    
    float RedVolt, GreenVolt, BlueVolt, RGBVolt;
   
    int LED_ON = 0;           // 0 = No LED is On, 1 = LED is On
    PrevRADCres = 0xFFFF;     // Initialize variable for storing Previous ADC result of red sensor channel
    PrevGADCres = 0xFFFF;     // Initialize variable for storing Previous ADC result of green sensor channel
    PrevBADCres = 0xFFFF;     // Initialize variable for storing Previous ADC result of blue sensor channel
        
    /* Call the System Initialize routine*/
    SYSTEM_Initialize();

    /*Call function to configure data flow direction*/
    IOPorts();
    
    /* Get a timer event once every 100ms for the blink alive. */
    TIMER_SetConfiguration ( TIMER_CONFIGURATION_1MS );
    //TIMER_RequestTick( &BlinkAliveEventHandler, 500 );
    //TIMER_RequestTick( &ScreenUpdateEventHandler, 170 );
    
    /* The TIMER_1MS configuration should come before the RTCC initialization as
     * there are some processor modules that require the TIMER_1MS module to be
     * configured before the RTCC module, as the RTCC module is emulated using
     * the TIMER_1MS module. */
    time.bcdFormat = false;
    lastTime.bcdFormat = false;
    RTCC_BuildTimeGet( &time );
    RTCC_Initialize( &time );
    memset(&lastTime,0,sizeof(lastTime)); 

    ADC_SetConfiguration ( ADC_CONFIGURATION_DEFAULT );
    
   /*Select Channels to be analog*/ 
   ADC_ChannelEnable(RedADCInput);
   ADC_ChannelEnable(GreenADCInput);
   ADC_ChannelEnable(BlueADCInput);
    
    while ( 1 )
    {
        
        /*Sensor ADC Result*/
        /*Take one ADC result*/
        //RedADCResult = ADC_Read12bit(RedADCInput);
        //GreenADCResult = ADC_Read12bit(GreenADCInput);
        //BlueADCResult = ADC_Read12bit(BlueADCInput);
        
        /*Sensor ADC Result*/
        /*Take 1000 ADC samples*/
        RedADCResult = ADC_Read12bitAverage(RedADCInput,1000);
        GreenADCResult = ADC_Read12bitAverage(GreenADCInput,1000);
        BlueADCResult = ADC_Read12bitAverage(BlueADCInput,1000);
        
        //Convert ADC Result to "Voltage"
        RedVolt = (RedADCResult * 3.3) / 4096;
        GreenVolt = (GreenADCResult * 3.3) / 4096;
        BlueVolt = (BlueADCResult * 3.3) / 4096;
        
        //Default OFF threshold is 0.50V
        if(RedVolt + GreenVolt + BlueVolt <0.50){
            //No LED on (Dark)
            LED_ON = 0;
        }
        else{    
            if(RedVolt > GreenVolt && GreenVolt > BlueVolt){ //RGB
                //Case 1:Red LED ON
                LED_ON = 1;
            }
            else if(GreenVolt > RedVolt && RedVolt > BlueVolt){
                //Case 2:Green LED ON
                LED_ON = 2;
            }
            else if(GreenVolt > BlueVolt && BlueVolt > RedVolt){
             //Case 3: Blue LED ON
                LED_ON = 3;
            }
        }
    
     
        RTCC_TimeGet( &time );
        
            if((RedADCResult != PrevRADCres) || (GreenADCResult != PrevGADCres) || (BlueADCResult != PrevBADCres) ||
                (memcmp(&time, &lastTime, sizeof(time)) != MEMCMP_VALUES_IDENTICAL) )
            {                  

                printf("%f %f %f %d\r\n", 
                        RedVolt,
                        GreenVolt,
                        BlueVolt,
                        LED_ON
                        );
               
                PrevRADCres = RedADCResult;
                PrevGADCres = GreenADCResult;
                PrevBADCres = BlueADCResult;
                
                memcpy(&lastTime, &time, sizeof(time));
            }
    }
}