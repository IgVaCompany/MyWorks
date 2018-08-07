/*
 * File: ert_main.c
 *
 * Code generated for Simulink model 'arduinorobot_linefollower'.
 *
 * Model version                  : 1.124
 * Simulink Coder version         : 8.9 (R2015b) 13-Aug-2015
 * C/C++ source code generated on : Mon Jul 16 11:29:23 2018
 *
 * Target selection: ert.tlc
 * Embedded hardware selection: Atmel->AVR
 * Code generation objectives: Unspecified
 * Validation result: Not run
 */

#include "arduinorobot_linefollower.h"
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

  arduinorobot_linefollower_step();

  /* Get model outputs here */
#ifndef _MW_ARDUINO_LOOP_

  cli();

#endif;

  OverrunFlag--;
}

int main(void)
{
  volatile boolean_T runModel = 1;
  float modelBaseRate = 0.002;
  float systemClock = 0;
  init();
  MW_Arduino_Init();
  rtmSetErrorStatus(arduinorobot_linefollower_M, 0);
  arduinorobot_linefollower_initialize();
  configureArduinoAVRTimer();
  runModel =
    rtmGetErrorStatus(arduinorobot_linefollower_M) == (NULL);

#ifndef _MW_ARDUINO_LOOP_

  sei();

#endif;

  sei();
  while (runModel) { 
    MW_Arduino_Loop();
    runModel =
      rtmGetErrorStatus(arduinorobot_linefollower_M) == (NULL);
  }

  /* Disable rt_OneStep() here */

  /* Terminate model */
  arduinorobot_linefollower_terminate();
  cli();
  return 0;
}

/*
 * File trailer for generated code.
 *
 * [EOF]
 */
