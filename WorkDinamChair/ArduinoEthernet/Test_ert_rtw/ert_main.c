/*
 * File: ert_main.c
 *
 * Code generated for Simulink model 'Test'.
 *
 * Model version                  : 1.17
 * Simulink Coder version         : 8.9 (R2015b) 13-Aug-2015
 * C/C++ source code generated on : Wed Aug 08 12:58:16 2018
 *
 * Target selection: ert.tlc
 * Embedded hardware selection: Atmel->AVR
 * Code generation objectives:
 *    1. Execution efficiency
 *    2. RAM efficiency
 * Validation result: Not run
 */

#include "Test.h"
#include "rtwtypes.h"

volatile int IsrOverrun = 0;
static boolean_T OverrunFlag = 0;
void rt_OneStep(void)
{
  /* Check for overrun. Protect OverrunFlag against preemption */
  if (OverrunFlag++) {
    IsrOverrun = 1;
    OverrunFlag--;
    return;
  }

#ifndef _MW_ARDUINO_LOOP_

  sei();

#endif;

  Test_step();

  /* Get model outputs here */
#ifndef _MW_ARDUINO_LOOP_

  cli();

#endif;

  OverrunFlag--;
}

int main(void)
{
  volatile boolean_T runModel = 1;
  float modelBaseRate = 0.1;
  float systemClock = 0;
  init();
  MW_Arduino_Init();
  rtmSetErrorStatus(rtM, 0);
  Test_initialize();
  configureArduinoAVRTimer();
  runModel =
    rtmGetErrorStatus(rtM) == (NULL);

#ifndef _MW_ARDUINO_LOOP_

  sei();

#endif;

  sei();
  while (runModel) { 
    MW_Arduino_Loop();
    runModel =
      rtmGetErrorStatus(rtM) == (NULL);
  }

  /* Disable rt_OneStep() here */
  cli();
  return 0;
}

/*
 * File trailer for generated code.
 *
 * [EOF]
 */
