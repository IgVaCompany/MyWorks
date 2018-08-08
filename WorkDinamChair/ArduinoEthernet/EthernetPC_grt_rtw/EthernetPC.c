/*
 * EthernetPC.c
 *
 * Code generation for model "EthernetPC".
 *
 * Model version              : 1.3
 * Simulink Coder version : 8.9 (R2015b) 13-Aug-2015
 * C source code generated on : Wed Aug 08 09:26:25 2018
 *
 * Target selection: grt.tlc
 * Note: GRT includes extra infrastructure and instrumentation for prototyping
 * Embedded hardware selection: Intel->x86-64 (Windows64)
 * Code generation objectives: Unspecified
 * Validation result: Not run
 */

#include "EthernetPC.h"
#include "EthernetPC_private.h"

/* Block signals (auto storage) */
B_EthernetPC_T EthernetPC_B;

/* Block states (auto storage) */
DW_EthernetPC_T EthernetPC_DW;

/* Real-time model */
RT_MODEL_EthernetPC_T EthernetPC_M_;
RT_MODEL_EthernetPC_T *const EthernetPC_M = &EthernetPC_M_;

/* Model step function */
void EthernetPC_step(void)
{
  /* Byte Packing: <Root>/Byte Packing  */
  (void)memcpy((uint8_T*)&EthernetPC_B.BytePacking[0] + 0, (uint8_T*)
               &EthernetPC_P.Constant_Value, 8);

  /* Matfile logging */
  rt_UpdateTXYLogVars(EthernetPC_M->rtwLogInfo, (&EthernetPC_M->Timing.taskTime0));

  /* signal main to stop simulation */
  {                                    /* Sample time: [0.2s, 0.0s] */
    if ((rtmGetTFinal(EthernetPC_M)!=-1) &&
        !((rtmGetTFinal(EthernetPC_M)-EthernetPC_M->Timing.taskTime0) >
          EthernetPC_M->Timing.taskTime0 * (DBL_EPSILON))) {
      rtmSetErrorStatus(EthernetPC_M, "Simulation finished");
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
  if (!(++EthernetPC_M->Timing.clockTick0)) {
    ++EthernetPC_M->Timing.clockTickH0;
  }

  EthernetPC_M->Timing.taskTime0 = EthernetPC_M->Timing.clockTick0 *
    EthernetPC_M->Timing.stepSize0 + EthernetPC_M->Timing.clockTickH0 *
    EthernetPC_M->Timing.stepSize0 * 4294967296.0;
}

/* Model initialize function */
void EthernetPC_initialize(void)
{
  /* Registration code */

  /* initialize non-finites */
  rt_InitInfAndNaN(sizeof(real_T));

  /* initialize real-time model */
  (void) memset((void *)EthernetPC_M, 0,
                sizeof(RT_MODEL_EthernetPC_T));
  rtmSetTFinal(EthernetPC_M, -1);
  EthernetPC_M->Timing.stepSize0 = 0.2;

  /* Setup for data logging */
  {
    static RTWLogInfo rt_DataLoggingInfo;
    rt_DataLoggingInfo.loggingInterval = NULL;
    EthernetPC_M->rtwLogInfo = &rt_DataLoggingInfo;
  }

  /* Setup for data logging */
  {
    rtliSetLogXSignalInfo(EthernetPC_M->rtwLogInfo, (NULL));
    rtliSetLogXSignalPtrs(EthernetPC_M->rtwLogInfo, (NULL));
    rtliSetLogT(EthernetPC_M->rtwLogInfo, "tout");
    rtliSetLogX(EthernetPC_M->rtwLogInfo, "");
    rtliSetLogXFinal(EthernetPC_M->rtwLogInfo, "");
    rtliSetLogVarNameModifier(EthernetPC_M->rtwLogInfo, "rt_");
    rtliSetLogFormat(EthernetPC_M->rtwLogInfo, 4);
    rtliSetLogMaxRows(EthernetPC_M->rtwLogInfo, 1000);
    rtliSetLogDecimation(EthernetPC_M->rtwLogInfo, 1);
    rtliSetLogY(EthernetPC_M->rtwLogInfo, "");
    rtliSetLogYSignalInfo(EthernetPC_M->rtwLogInfo, (NULL));
    rtliSetLogYSignalPtrs(EthernetPC_M->rtwLogInfo, (NULL));
  }

  /* block I/O */
  (void) memset(((void *) &EthernetPC_B), 0,
                sizeof(B_EthernetPC_T));

  /* states (dwork) */
  (void) memset((void *)&EthernetPC_DW, 0,
                sizeof(DW_EthernetPC_T));

  /* Matfile logging */
  rt_StartDataLoggingWithStartTime(EthernetPC_M->rtwLogInfo, 0.0, rtmGetTFinal
    (EthernetPC_M), EthernetPC_M->Timing.stepSize0, (&rtmGetErrorStatus
    (EthernetPC_M)));
}

/* Model terminate function */
void EthernetPC_terminate(void)
{
  /* (no terminate code required) */
}
