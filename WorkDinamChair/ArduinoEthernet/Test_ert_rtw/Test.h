/*
 * File: Test.h
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

#ifndef RTW_HEADER_Test_h_
#define RTW_HEADER_Test_h_
#include <math.h>
#include <stddef.h>
#ifndef Test_COMMON_INCLUDES_
# define Test_COMMON_INCLUDES_
#include "rtwtypes.h"
#include "arduino_digitaloutput_lct.h"
#include "arduino_analogoutput_lct.h"
#endif                                 /* Test_COMMON_INCLUDES_ */

#include "MW_target_hardware_resources.h"

/* Macros for accessing real-time model data structure */
#ifndef rtmGetErrorStatus
# define rtmGetErrorStatus(rtm)        ((rtm)->errorStatus)
#endif

#ifndef rtmSetErrorStatus
# define rtmSetErrorStatus(rtm, val)   ((rtm)->errorStatus = (val))
#endif

#define Test_M                         (rtM)

/* Forward declaration for rtModel */
typedef struct tag_RTM RT_MODEL;

/* Block signals and states (auto storage) for system '<Root>' */
typedef struct {
  real_T y;                            /* '<Root>/Chart1' */
  real_T y_e;                          /* '<Root>/Chart' */
  real_T NextOutput;                   /* '<S1>/White Noise' */
  real_T NextOutput_n;                 /* '<S2>/White Noise' */
  uint32_T RandSeed;                   /* '<S1>/White Noise' */
  uint32_T RandSeed_k;                 /* '<S2>/White Noise' */
  uint8_T is_active_c1_Test;           /* '<Root>/Chart1' */
  uint8_T is_c1_Test;                  /* '<Root>/Chart1' */
  uint8_T is_active_c3_Test;           /* '<Root>/Chart' */
  uint8_T is_c3_Test;                  /* '<Root>/Chart' */
} DW;

/* Real-time Model Data Structure */
struct tag_RTM {
  const char_T *errorStatus;

  /*
   * Timing:
   * The following substructure contains information regarding
   * the timing information for the model.
   */
  struct {
    struct {
      uint8_T TID[2];
    } TaskCounters;
  } Timing;
};

/* Block signals and states (auto storage) */
extern DW rtDW;

/* Model entry point functions */
extern void Test_initialize(void);
extern void Test_step(void);

/* Real-time Model object */
extern RT_MODEL *const rtM;

/*-
 * These blocks were eliminated from the model due to optimizations:
 *
 * Block '<Root>/Scope' : Unused code path elimination
 * Block '<Root>/Scope1' : Unused code path elimination
 */

/*-
 * The generated code includes comments that allow you to trace directly
 * back to the appropriate location in the model.  The basic format
 * is <system>/block_name, where system is the system number (uniquely
 * assigned by Simulink) and block_name is the name of the block.
 *
 * Use the MATLAB hilite_system command to trace the generated code back
 * to the model.  For example,
 *
 * hilite_system('<S3>')    - opens system 3
 * hilite_system('<S3>/Kp') - opens and selects block Kp which resides in S3
 *
 * Here is the system hierarchy for this model
 *
 * '<Root>' : 'Test'
 * '<S1>'   : 'Test/Band-Limited White Noise'
 * '<S2>'   : 'Test/Band-Limited White Noise1'
 * '<S3>'   : 'Test/Chart'
 * '<S4>'   : 'Test/Chart1'
 * '<S5>'   : 'Test/Digital Output'
 * '<S6>'   : 'Test/PWM'
 */
#endif                                 /* RTW_HEADER_Test_h_ */

/*
 * File trailer for generated code.
 *
 * [EOF]
 */
