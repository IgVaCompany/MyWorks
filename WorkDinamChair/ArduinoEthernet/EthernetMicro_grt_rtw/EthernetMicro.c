/*
 * EthernetMicro.c
 *
 * Code generation for model "EthernetMicro".
 *
 * Model version              : 1.1
 * Simulink Coder version : 8.9 (R2015b) 13-Aug-2015
 * C source code generated on : Tue Aug 07 23:03:47 2018
 *
 * Target selection: grt.tlc
 * Note: GRT includes extra infrastructure and instrumentation for prototyping
 * Embedded hardware selection: Intel->x86-64 (Windows64)
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

/* Model step function */
void EthernetMicro_step(void)
{
  int32_T rtb_TCPIPReceive_o2;
  uint8_T tmp;

  /* S-Function (arduinotcpreceive_sfcn): '<Root>/TCP//IP Receive' */
  MW_TCPFinalread(EthernetMicro_P.TCPIPReceive_p1,
                  &EthernetMicro_B.TCPIPReceive_o1,
                  EthernetMicro_P.TCPIPReceive_p2, &rtb_TCPIPReceive_o2);

  /* Byte Unpacking: <Root>/Byte Unpacking  */
  (void)memcpy((uint8_T*)&EthernetMicro_B.ByteUnpacking, (uint8_T*)
               &EthernetMicro_B.TCPIPReceive_o1 + 0, 1);

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
  } else if ((EthernetMicro_DW.is_c3_EthernetMicro == EthernetMicro_IN_Off) &&
             (EthernetMicro_B.ByteUnpacking > 0)) {
    /* During 'Off': '<S1>:2' */
    /* Transition: '<S1>:4' */
    EthernetMicro_DW.is_c3_EthernetMicro = EthernetMicro_IN_On;

    /* Entry 'On': '<S1>:1' */
    EthernetMicro_B.y = 1.0;
  } else {
    /* During 'On': '<S1>:1' */
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

  /* Matfile logging */
  rt_UpdateTXYLogVars(EthernetMicro_M->rtwLogInfo,
                      (&EthernetMicro_M->Timing.taskTime0));

  /* signal main to stop simulation */
  {                                    /* Sample time: [1.0s, 0.0s] */
    if ((rtmGetTFinal(EthernetMicro_M)!=-1) &&
        !((rtmGetTFinal(EthernetMicro_M)-EthernetMicro_M->Timing.taskTime0) >
          EthernetMicro_M->Timing.taskTime0 * (DBL_EPSILON))) {
      rtmSetErrorStatus(EthernetMicro_M, "Simulation finished");
    }
  }

  /* Update absolute time for base rate */
  /* The "clockTick0" counts the number of times the code of this task has
   * been executed. The absolute time is the multiplication of "clockTick0"
   * and "Timing.stepSize0". Size of "clockTick0" ensures timer will not
   * overflow during the application lifespan selected.
   * Timer of this task consists of two 32 bit unsigned integers.
   * The two integers represent the low bits Timing.clockTick0 and the high bits
   * Timing.clockTickH0. When the low bit overflows to 0, the high bits increment.
   */
  if (!(++EthernetMicro_M->Timing.clockTick0)) {
    ++EthernetMicro_M->Timing.clockTickH0;
  }

  EthernetMicro_M->Timing.taskTime0 = EthernetMicro_M->Timing.clockTick0 *
    EthernetMicro_M->Timing.stepSize0 + EthernetMicro_M->Timing.clockTickH0 *
    EthernetMicro_M->Timing.stepSize0 * 4294967296.0;
}

/* Model initialize function */
void EthernetMicro_initialize(void)
{
  /* Registration code */

  /* initialize non-finites */
  rt_InitInfAndNaN(sizeof(real_T));

  /* initialize real-time model */
  (void) memset((void *)EthernetMicro_M, 0,
                sizeof(RT_MODEL_EthernetMicro_T));
  rtmSetTFinal(EthernetMicro_M, 10.0);
  EthernetMicro_M->Timing.stepSize0 = 1.0;

  /* Setup for data logging */
  {
    static RTWLogInfo rt_DataLoggingInfo;
    rt_DataLoggingInfo.loggingInterval = NULL;
    EthernetMicro_M->rtwLogInfo = &rt_DataLoggingInfo;
  }

  /* Setup for data logging */
  {
    rtliSetLogXSignalInfo(EthernetMicro_M->rtwLogInfo, (NULL));
    rtliSetLogXSignalPtrs(EthernetMicro_M->rtwLogInfo, (NULL));
    rtliSetLogT(EthernetMicro_M->rtwLogInfo, "tout");
    rtliSetLogX(EthernetMicro_M->rtwLogInfo, "");
    rtliSetLogXFinal(EthernetMicro_M->rtwLogInfo, "");
    rtliSetLogVarNameModifier(EthernetMicro_M->rtwLogInfo, "rt_");
    rtliSetLogFormat(EthernetMicro_M->rtwLogInfo, 4);
    rtliSetLogMaxRows(EthernetMicro_M->rtwLogInfo, 1000);
    rtliSetLogDecimation(EthernetMicro_M->rtwLogInfo, 1);
    rtliSetLogY(EthernetMicro_M->rtwLogInfo, "");
    rtliSetLogYSignalInfo(EthernetMicro_M->rtwLogInfo, (NULL));
    rtliSetLogYSignalPtrs(EthernetMicro_M->rtwLogInfo, (NULL));
  }

  /* block I/O */
  (void) memset(((void *) &EthernetMicro_B), 0,
                sizeof(B_EthernetMicro_T));

  /* states (dwork) */
  (void) memset((void *)&EthernetMicro_DW, 0,
                sizeof(DW_EthernetMicro_T));

  /* Matfile logging */
  rt_StartDataLoggingWithStartTime(EthernetMicro_M->rtwLogInfo, 0.0,
    rtmGetTFinal(EthernetMicro_M), EthernetMicro_M->Timing.stepSize0,
    (&rtmGetErrorStatus(EthernetMicro_M)));

  /* Start for S-Function (arduinotcpreceive_sfcn): '<Root>/TCP//IP Receive' */
  MW_EthernetAndTCPServerBegin(EthernetMicro_P.TCPIPReceive_p1,
    EthernetMicro_P.TCPIPReceive_p2);

  /* Start for S-Function (arduinodigitaloutput_sfcn): '<S2>/Digital Output' */
  MW_pinModeOutput(EthernetMicro_P.DigitalOutput_pinNumber);

  /* InitializeConditions for Chart: '<Root>/Chart' */
  EthernetMicro_DW.is_active_c3_EthernetMicro = 0U;
  EthernetMicro_DW.is_c3_EthernetMicro = EthernetMicr_IN_NO_ACTIVE_CHILD;
}

/* Model terminate function */
void EthernetMicro_terminate(void)
{
  /* (no terminate code required) */
}
