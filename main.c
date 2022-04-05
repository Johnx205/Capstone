
#include <stdio.h>
#include <stdlib.h>
#include <stddef.h>
#include <stdbool.h>
#include <string.h>

#include "bsp/adc.h"
#include "bsp/lcd.h"
#include "bsp/timer_1ms.h"
#include "bsp/buttons.h"
#include "bsp/leds.h"
#include "bsp/rtcc.h"
 
#include "io_mapping.h"
//#include "bsp/ambient.h"

#include "p33CK256MP508.h"
// *****************************************************************************
// *****************************************************************************
// Section: File Scope Variables and Functions
// *****************************************************************************
// *****************************************************************************
extern void SYS_Initialize ( void ) ;
static void ScreenUpdateEventHandler( void );

static RTCC_DATETIME time;
static RTCC_DATETIME lastTime = {0};
static volatile bool toggleBlinkAlive = false;
static volatile bool allowScreenUpdate = true;

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
    SYS_Initialize ( );
    
    /*Call function to configure data flow direction*/
    IOPorts();
    
    /* Get a timer event once every 100ms for the blink alive. */
    TIMER_SetConfiguration ( TIMER_CONFIGURATION_1MS );
    //TIMER_RequestTick( &BlinkAliveEventHandler, 500 );
    TIMER_RequestTick( &ScreenUpdateEventHandler, 170 );
    
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
    //Ambient Calibration
    // Tell User that current light will be considered " ambient"
    // For example RedADC - Ambient_R, etc

    
   /*Select Channels to be analog*/ 
   ADC_ChannelEnable(RedADCInput);
   ADC_ChannelEnable(GreenADCInput);
   ADC_ChannelEnable(BlueADCInput);
    
    /* Clear the screen */
    printf( "\f" );   
    
    while ( 1 )
    {
        
        //Sensor ADC Result
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
        
        //Calculate RGB Average
        RGBVolt = (RedVolt + GreenVolt + BlueVolt) / 3;
            
        if(RedVolt > RGBVolt && GreenVolt < RGBVolt && BlueVolt < RGBVolt && RedVolt > GreenVolt){
            //Case 1:Red LED ON
            LED_ON = 1;
        }
        else if(RedVolt < RGBVolt && GreenVolt > RGBVolt && BlueVolt < RGBVolt && BlueVolt < RedVolt/BlueVolt){
            //Case 2:Green LED ON
            LED_ON = 2;
        }
        else if(RedVolt < RGBVolt && GreenVolt > RGBVolt && BlueVolt < RGBVolt && BlueVolt > RedVolt/BlueVolt){
            //Case 3: Blue LED ON
            LED_ON = 3;
        }
        else{
            LED_ON = 0;
        }
    
     
        RTCC_TimeGet( &time );
        
        //Only print if the ADC value or time has changed since the last time 
        // around the loop and we haven't updated recently too recently.
        if(allowScreenUpdate == true)
        {
            if((RedADCResult != PrevRADCres) || (GreenADCResult != PrevGADCres) || (BlueADCResult != PrevBADCres) ||
                (memcmp(&time, &lastTime, sizeof(time)) != MEMCMP_VALUES_IDENTICAL) )
            {                  
                //Either ADC or time has changed, and the screen update refresh
                // limit has expired, update the screen.
                allowScreenUpdate = false;
                
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
}

static void ScreenUpdateEventHandler(void)
{
    allowScreenUpdate = true;
}

