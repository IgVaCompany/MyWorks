/*
 * File: EthernetMicro.c
 *
 * Code generated for Simulink model 'EthernetMicro'.
 *
 * Model version                  : 1.27
 * Simulink Coder version         : 8.9 (R2015b) 13-Aug-2015
 * C/C++ source code generated on : Wed Aug 08 18:31:17 2018
 *
 * Target selection: ert.tlc
 * Embedded hardware selection: Atmel->AVR
 * Code generation objectives: Unspecified
 * Validation result: Not run
 */

#include "EthernetMicro.h"
#include "EthernetMicro_private.h"

/* Named constants for Chart: '<Root>/Chart' */
#define EthernetMicr_IN_NO_ACTIVE_CHILD ((uint8_T)0U)
#define EthernetMicro_IN_Off           ((uint8_T)1U)
#define EthernetMicro_IN_On            ((uint8_T)2U)

/* Block signals (auto storage) */
B_EthernetMicro_T EthernetMicro_B;

/* Block states (auto storage) */
DW_EthernetMicro_T EthernetMicro_DW;

/* Real-time model */
RT_MODEL_EthernetMicro_T EthernetMicro_M_;
RT_MODEL_EthernetMicro_T *const EthernetMicro_M = &EthernetMicro_M_;
static void rate_monotonic_scheduler(void);

/*
 * Set which subrates need to run this base step (base rate always runs).
 * This function must be called prior to calling the model step function
 * in order to "remember" which rates need to run this base step.  The
 * buffering of events allows for overlapping preemption.
 */
void EthernetMicro_SetEventsForThisBaseStep(boolean_T *eventFlags)
{
  /* Task runs when its counter is zero, computed via rtmStepTask macro */
  eventFlags[1] = ((boolean_T)rtmStepTask(EthernetMicro_M, 1));
}

/*
 *   This function updates active task flag for each subrate
 * and rate transition flags for tasks that exchange data.
 * The function assumes rate-monotonic multitasking scheduler.
 * The function must be called at model base rate so that
 * the generated code self-manages all its subrates and rate
 * transition flags.
 */
static void rate_monotonic_scheduler(void)
{
  /* Compute which subrates run during the next base time step.  Subrates
   * are an integer multiple of the base rate counter.  Therefore, the subtask
   * counter is reset when it reaches its limit (zero means run).
   */
  (EthernetMicro_M->Timing.TaskCounters.TID[1])++;
  if ((EthernetMicro_M->Timing.TaskCounters.TID[1]) > 9) {/* Sample time: [1.0s, 0.0s] */
    EthernetMicro_M->Timing.TaskCounters.TID[1] = 0;
  }
}

/* Model step function for TID0 */
void EthernetMicro_step0(void)         /* Sample time: [0.1s, 0.0s] */
{
  {                                    /* Sample time: [0.1s, 0.0s] */
    rate_monotonic_scheduler();
  }
}

/* Model step function for TID1 */
void EthernetMicro_step1(void)         /* Sample time: [1.0s, 0.0s] */
{
  int32_T rtb_UDPReceive_o2;
  uint8_T tmp;

  /* S-Function (arduinoudpreceive_sfcn): '<Root>/UDP Receive' */
  MW_UDPFinalRead(EthernetMicro_P.UDPReceive_p1, &EthernetMicro_B.UDPReceive_o1,
                  &rtb_UDPReceive_o2);

  /* Byte Unpacking: <Root>/Byte Unpacking  */
  (void)memcpy((uint8_T*)&EthernetMicro_B.ByteUnpacking, (uint8_T*)
               &EthernetMicro_B.UDPReceive_o1 + 0, 1);

  /* Chart: '<Root>/Chart' */
  /* Gateway: Chart */
  /* During: Chart */
  if (EthernetMicro_DW.is_active_c3_EthernetMicro == 0U) {
    /* Entry: Chart */
    EthernetMicro_DW.is_active_c3_EthernetMicro = 1U;

    /* Entry Internal: Chart */
    /* Transition: '<S1>:5' */
    EthernetMicro_DW.is_c3_EthernetMicro = EthernetMicro_IN_On;

    /* Entry 'On': '<S1>:1' */
    EthernetMicro_B.y = 1.0;
  } else if (EthernetMicro_DW.is_c3_EthernetMicro == EthernetMicro_IN_Off) {
    /* During 'Off': '<S1>:2' */
    if (EthernetMicro_B.ByteUnpacking > 5) {
      /* Transition: '<S1>:4' */
      EthernetMicro_DW.is_c3_EthernetMicro = EthernetMicro_IN_On;

      /* Entry 'On': '<S1>:1' */
      EthernetMicro_B.y = 1.0;
    }
  } else {
    /* During 'On': '<S1>:1' */
    if (EthernetMicro_B.ByteUnpacking <= 5) {
      /* Transition: '<S1>:3' */
      EthernetMicro_DW.is_c3_EthernetMicro = EthernetMicro_IN_Off;

      /* Entry 'Off': '<S1>:2' */
      EthernetMicro_B.y = 0.0;
    }
  }

  /* End of Chart: '<Root>/Chart' */

  /* DataTypeConversion: '<S2>/Data Type Conversion' */
  if (EthernetMicro_B.y < 256.0) {
    if (EthernetMicro_B.y >= 0.0) {
      tmp = (uint8_T)EthernetMicro_B.y;
    } else {
      tmp = 0U;
    }
  } else {
    tmp = MAX_uint8_T;
  }

  /* End of DataTypeConversion: '<S2>/Data Type Conversion' */

  /* S-Function (arduinodigitaloutput_sfcn): '<S2>/Digital Output' */
  MW_digitalWrite(EthernetMicro_P.DigitalOutput_pinNumber, tmp);

  /* S-Function (arduinodigitaloutput_sfcn): '<S3>/Digital Output' */
  MW_digitalWrite(EthernetMicro_P.DigitalOutput_pinNumber_o,
                  EthernetMicro_B.ByteUnpacking);
}

/* Model step wrapper function for compatibility with a static main program */
void EthernetMicro_step(int_T tid)
{
  switch (tid) {
   case 0 :
    EthernetMicro_step0();
    break;

   case 1 :
    EthernetMicro_step1();
    break;

   default :
    break;
  }
}

/* Model initialize function */
void EthernetMicro_initialize(void)
{
  /* Registration code */

  /* initialize real-time model */
  (void) memset((void *)EthernetMicro_M, 0,
                sizeof(RT_MODEL_EthernetMicro_T));

  /* block I/O */
  (void) memset(((void *) &EthernetMicro_B), 0,
                sizeof(B_EthernetMicro_T));

  /* states (dwork) */
  (void) memset((void *)&EthernetMicro_DW, 0,
                sizeof(DW_EthernetMicro_T));

  /* Start for S-Function (arduinoudpreceive_sfcn): '<Root>/UDP Receive' */
  MW_EthernetAndUDPBegin(EthernetMicro_P.UDPReceive_p1,
    EthernetMicro_P.UDPReceive_p2);

  /* Start for S-Function (arduinodigitaloutput_sfcn): '<S2>/Digital Output' */
  MW_pinModeOutput(EthernetMicro_P.DigitalOutput_pinNumber);

  /* Start for S-Function (arduinodigitaloutput_sfcn): '<S3>/Digital Output' */
  MW_pinModeOutput(EthernetMicro_P.DigitalOutput_pinNumber_o);

  /* InitializeConditions for Chart: '<Root>/Chart' */
  EthernetMicro_DW.is_active_c3_EthernetMicro = 0U;
  EthernetMicro_DW.is_c3_EthernetMicro = EthernetMicr_IN_NO_ACTIVE_CHILD;
}

/* Model terminate function */
void EthernetMicro_terminate(void)
{
  /* (no terminate code required) */
}

/*
 * File trailer for generated code.
 *
 * [EOF]
 */
