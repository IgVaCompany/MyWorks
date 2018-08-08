/*
 * File: Test.c
 *
 * Code generated for Simulink model 'Test'.
 *
 * Model version                  : 1.16
 * Simulink Coder version         : 8.9 (R2015b) 13-Aug-2015
 * C/C++ source code generated on : Wed Aug 08 09:19:32 2018
 *
 * Target selection: ert.tlc
 * Embedded hardware selection: Atmel->AVR
 * Code generation objectives:
 *    1. Execution efficiency
 *    2. RAM efficiency
 * Validation result: Not run
 */

#include "Test.h"

/* Named constants for Chart: '<Root>/Chart' */
#define IN_Off                         ((uint8_T)1U)
#define IN_On                          ((uint8_T)2U)

/* Block signals and states (auto storage) */
DW rtDW;

/* Real-time model */
RT_MODEL rtM_;
RT_MODEL *const rtM = &rtM_;
extern real_T rt_urand_Upu32_Yd_f_pw(uint32_T *u);
extern real_T rt_nrand_Upu32_Yd_f_pw(uint32_T *u);
static void rate_scheduler(void);

/*
 *   This function updates active task flag for each subrate.
 * The function is called at model base rate, hence the
 * generated code self-manages all its subrates.
 */
static void rate_scheduler(void)
{
  /* Compute which subrates run during the next base time step.  Subrates
   * are an integer multiple of the base rate counter.  Therefore, the subtask
   * counter is reset when it reaches its limit (zero means run).
   */
  (rtM->Timing.TaskCounters.TID[1])++;
  if ((rtM->Timing.TaskCounters.TID[1]) > 4) {/* Sample time: [0.5s, 0.0s] */
    rtM->Timing.TaskCounters.TID[1] = 0;
  }
}

real_T rt_urand_Upu32_Yd_f_pw(uint32_T *u)
{
  uint32_T lo;
  uint32_T hi;

  /* Uniform random number generator (random number between 0 and 1)

     #define IA      16807                      magic multiplier = 7^5
     #define IM      2147483647                 modulus = 2^31-1
     #define IQ      127773                     IM div IA
     #define IR      2836                       IM modulo IA
     #define S       4.656612875245797e-10      reciprocal of 2^31-1
     test = IA * (seed % IQ) - IR * (seed/IQ)
     seed = test < 0 ? (test + IM) : test
     return (seed*S)
   */
  lo = *u % 127773UL * 16807UL;
  hi = *u / 127773UL * 2836UL;
  if (lo < hi) {
    *u = 2147483647UL - (hi - lo);
  } else {
    *u = lo - hi;
  }

  return (real_T)*u * 4.6566128752457969E-10;
}

real_T rt_nrand_Upu32_Yd_f_pw(uint32_T *u)
{
  real_T y;
  real_T sr;
  real_T si;

  /* Normal (Gaussian) random number generator */
  do {
    sr = 2.0 * rt_urand_Upu32_Yd_f_pw(u) - 1.0;
    si = 2.0 * rt_urand_Upu32_Yd_f_pw(u) - 1.0;
    si = sr * sr + si * si;
  } while (si > 1.0);

  y = sqrt(-2.0 * log(si) / si) * sr;
  return y;
}

/* Model step function */
void Test_step(void)
{
  real_T rtb_Output;
  uint8_T tmp;

  /* Gain: '<S1>/Output' incorporates:
   *  RandomNumber: '<S1>/White Noise'
   */
  rtb_Output = 3.1622776601683791 * rtDW.NextOutput;

  /* Chart: '<Root>/Chart' */
  /* Gateway: Chart */
  /* During: Chart */
  if (rtDW.is_active_c3_Test == 0U) {
    /* Entry: Chart */
    rtDW.is_active_c3_Test = 1U;

    /* Entry Internal: Chart */
    /* Transition: '<S3>:5' */
    rtDW.is_c3_Test = IN_On;

    /* Entry 'On': '<S3>:1' */
    rtDW.y_e = 1.0;
  } else if (rtDW.is_c3_Test == IN_Off) {
    /* During 'Off': '<S3>:2' */
    if (rtb_Output > 0.0) {
      /* Transition: '<S3>:4' */
      rtDW.is_c3_Test = IN_On;

      /* Entry 'On': '<S3>:1' */
      rtDW.y_e = 1.0;
    }
  } else {
    /* During 'On': '<S3>:1' */
    if (rtb_Output < 0.0) {
      /* Transition: '<S3>:3' */
      rtDW.is_c3_Test = IN_Off;

      /* Entry 'Off': '<S3>:2' */
      rtDW.y_e = 0.0;
    }
  }

  /* End of Chart: '<Root>/Chart' */

  /* DataTypeConversion: '<S5>/Data Type Conversion' */
  if (rtDW.y_e < 256.0) {
    if (rtDW.y_e >= 0.0) {
      tmp = (uint8_T)rtDW.y_e;
    } else {
      tmp = 0U;
    }
  } else {
    tmp = MAX_uint8_T;
  }

  /* End of DataTypeConversion: '<S5>/Data Type Conversion' */

  /* S-Function (arduinodigitaloutput_sfcn): '<S5>/Digital Output' */
  MW_digitalWrite(9UL, tmp);
  if (rtM->Timing.TaskCounters.TID[1] == 0) {
    /* Gain: '<Root>/Gain' incorporates:
     *  Gain: '<S2>/Output'
     *  RandomNumber: '<S2>/White Noise'
     */
    rtb_Output = 1.4142135623730949 * rtDW.NextOutput_n * 75.0;

    /* Chart: '<Root>/Chart1' */
    /* Gateway: Chart1 */
    /* During: Chart1 */
    if (rtDW.is_active_c1_Test == 0U) {
      /* Entry: Chart1 */
      rtDW.is_active_c1_Test = 1U;

      /* Entry Internal: Chart1 */
      /* Transition: '<S4>:5' */
      rtDW.is_c1_Test = IN_On;

      /* Entry 'On': '<S4>:1' */
      rtDW.y = rtb_Output;
    } else if (rtDW.is_c1_Test == IN_Off) {
      /* During 'Off': '<S4>:2' */
      if (rtb_Output > 0.0) {
        /* Transition: '<S4>:4' */
        rtDW.is_c1_Test = IN_On;

        /* Entry 'On': '<S4>:1' */
        rtDW.y = rtb_Output;
      } else {
        if (rtDW.y != rtb_Output) {
          /* Transition: '<S4>:9' */
          rtDW.is_c1_Test = IN_Off;

          /* Entry 'Off': '<S4>:2' */
          rtDW.y = -rtb_Output;
        }
      }
    } else {
      /* During 'On': '<S4>:1' */
      if (rtb_Output < 0.0) {
        /* Transition: '<S4>:3' */
        rtDW.is_c1_Test = IN_Off;

        /* Entry 'Off': '<S4>:2' */
        rtDW.y = -rtb_Output;
      } else {
        if (rtb_Output != rtDW.y) {
          /* Transition: '<S4>:8' */
          rtDW.is_c1_Test = IN_On;

          /* Entry 'On': '<S4>:1' */
          rtDW.y = rtb_Output;
        }
      }
    }

    /* End of Chart: '<Root>/Chart1' */

    /* DataTypeConversion: '<S6>/Data Type Conversion' */
    if (rtDW.y < 256.0) {
      if (rtDW.y >= 0.0) {
        tmp = (uint8_T)rtDW.y;
      } else {
        tmp = 0U;
      }
    } else {
      tmp = MAX_uint8_T;
    }

    /* End of DataTypeConversion: '<S6>/Data Type Conversion' */

    /* S-Function (arduinoanalogoutput_sfcn): '<S6>/PWM' */
    MW_analogWrite(5UL, tmp);

    /* Update for RandomNumber: '<S2>/White Noise' */
    rtDW.NextOutput_n = rt_nrand_Upu32_Yd_f_pw(&rtDW.RandSeed_k);
  }

  /* Update for RandomNumber: '<S1>/White Noise' */
  rtDW.NextOutput = rt_nrand_Upu32_Yd_f_pw(&rtDW.RandSeed);
  rate_scheduler();
}

/* Model initialize function */
void Test_initialize(void)
{
  /* Start for S-Function (arduinodigitaloutput_sfcn): '<S5>/Digital Output' */
  MW_pinModeOutput(9UL);

  /* Start for S-Function (arduinoanalogoutput_sfcn): '<S6>/PWM' */
  MW_pinModeOutput(5UL);

  /* InitializeConditions for RandomNumber: '<S1>/White Noise' */
  rtDW.RandSeed = 1529675776UL;
  rtDW.NextOutput = rt_nrand_Upu32_Yd_f_pw(&rtDW.RandSeed);

  /* InitializeConditions for RandomNumber: '<S2>/White Noise' */
  rtDW.RandSeed_k = 8060928UL;
  rtDW.NextOutput_n = rt_nrand_Upu32_Yd_f_pw(&rtDW.RandSeed_k);
}

/*
 * File trailer for generated code.
 *
 * [EOF]
 */
